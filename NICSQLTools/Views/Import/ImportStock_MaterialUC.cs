using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data.SqlClient;
using log4net;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Import
{
    public partial class ImportStock_MaterialUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportStock_MaterialUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Material
Material Description
Batch
Batch Status
Plant
Storage Location
Display Unit/Measure
Unrestricted
In Quality Insp.
Restricted-Use Stock
Blocked
Returns
Stock in Transit
Transit CC
Op. Delive
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportStock_MaterialUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(stock_MaterialTableAdapter, DataManager.ConnectionTimeout);
            tbMonth.EditValue = DataManager.defaultInstance.ServerDateTime.Month;
            tbYear.EditValue = DataManager.defaultInstance.ServerDateTime.Year;
            _elementRule = RuleElement;
        }
        private void ShowHideProgress(bool ShowHide)
        {
            if (ShowHide)
                PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Show(); layoutControlItemPnlProg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; }));
            else
                PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Hide(); layoutControlItemPnlProg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; }));
            Application.DoEvents();
        }
        private void ChangeProgressCaption(string Caption)
        {
            PnlProg.Invoke(new MethodInvoker(() => { PnlProg.Caption = Caption; }));
            Application.DoEvents();
        }
        private bool ImportFromExcel()
        {
            //return false;
            bool output = false;

            AddLog("Start importing ...", false);
            DataTable dtExcel = new DataTable();

            ShowHideProgress(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        ChangeProgressCaption(String.Format("Loading Excel File [{0}] Contains[1/3]", (i + 1)));
                        DataTable dtPart = DataManager.LoadExcelFile(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLog("File empty " + lbcFilePath.Items[i], false);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
            }));
            ChangeProgressCaption("Loading Products Informations [2/3]");
            _0_4__Product_DetailsTableAdapter.FillByKeyOnly(dsData._0_4__Product_Details);
            ChangeProgressCaption("Loading Plants Informations [3/3]");
            plantsTableAdapter.Fill(dsQry.Plants);

            if (dtExcel.Rows.Count == 0)
            {
                ShowHideProgress(false);
                AddLog("Importing Aborted", false);
                MsgDlg.Show("No Data Found", MsgDlg.MessageType.Error);
                return false;
            }

            DateTime dtStart = DateTime.Now;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("", con) { CommandTimeout = 0 };

            con.Open();

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

            ShowHideProgress(false);
       
            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    //double DonePercent = ProcessedCounter / ProcessedMax;
                    Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }
                if (dsQry.Plants.FindByPlantId(row["Plant"].ToString()) == null)// Check if its Unknown Plants
                    continue;

                NICSQLTools.Data.dsData.Stock_MaterialRow SqlRow = dsData.Stock_Material.NewStock_MaterialRow();
                SqlRow.Material = Convert.ToDouble(row["Material"]);
                SqlRow.Batch = row["Batch"].ToString();
                SqlRow.Batch = row["Plant"].ToString();
                SqlRow.BatchStatus = row["Batch Status"].ToString();
                SqlRow.DisplayUnitMeasure = row["Display Unit/Measure"].ToString();
                SqlRow.Unrestricted = Convert.ToDouble(row["Unrestricted"]);
                SqlRow.InQualityInsp = Convert.ToDouble(row["In Quality Insp#"]);
                SqlRow.RestrictedUseStock = Convert.ToDouble(row["Restricted-Use Stock"]);
                SqlRow.Blocked = Convert.ToDouble(row["Blocked"]);
                SqlRow.Returns = Convert.ToDouble(row["Returns"]);
                SqlRow.StockInTransit = Convert.ToDouble(row["Stock in Transit"]);
                SqlRow.TransitCC = Convert.ToDouble(row["Transit CC"]);
                SqlRow.OpDelive = Convert.ToDouble(row["Op# Delive"]);
                
                SqlRow.MonthNum = Convert.ToInt16(tbMonth.EditValue);
                SqlRow.YearNum = Convert.ToInt16(tbYear.EditValue);
                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;

                //Product Update
                NICSQLTools.Data.dsData._0_4__Product_DetailsRow ProductRow = Product.GetProductRow(SqlRow.Material, dsData._0_4__Product_Details);
                if (ProductRow.RowState == DataRowState.Detached)
                {
                    ProductRow.Material_Number = SqlRow.Material;
                    dsData._0_4__Product_Details.Add_0_4__Product_DetailsRow(ProductRow);
                    ProductRow.EndEdit();
                    _0_4__Product_DetailsTableAdapter.Update(ProductRow);
                    AddLog("[New Product Found] : " + ProductRow.Material_Number, true);
                }

                dsData.Stock_Material.AddStock_MaterialRow(SqlRow);
                SqlRow.EndEdit();
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTime.Text = "0 sec";
                ProgressBarMain.EditValue = ProcessedMax;
                lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgress(true);
            ChangeProgressCaption("Updating Stock Material ...");
            if (!Stock_Material.UpdateBulkStock_Material(cmd, dsData.Stock_Material, Convert.ToInt16(tbYear.EditValue), Convert.ToInt16(tbMonth.EditValue)))
                MsgDlg.Show("Update Stock Material Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Stock Material Saved " + dsData.Stock_Material.Count, true);
                output = true;
            }

            dsData.Stock_Material.AcceptChanges();
            ShowHideProgress(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.Stock_Material.Clear(); dsData.Stock_Material.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();

            return output;
        }
        private void AddLog(string strLog, bool LogtoFile)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                if (LogtoFile)
                    Logger.Info(strLog);
            }));
        }
        public void ActivateRules()
        {
            btnImport.Visible = _elementRule.Inserting;
        }
        
        #endregion
        #region -   Event Handlers   -
        private void ImportStock_ListUC_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    using (NICSQLTools.Data.dsQryTableAdapters.LastEditStock_MaterialTableAdapter lastEditStock_MaterialTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditStock_MaterialTableAdapter())
                    {
                        Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditStock_MaterialTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
                        NICSQLTools.Data.dsQry.LastEditStock_MaterialDataTable tbl = lastEditStock_MaterialTableAdapter.GetData();
                        if (tbl.Count > 0)
                        {
                            NICSQLTools.Data.dsQry.LastEditStock_MaterialRow row = tbl[0];
                            string log = string.Format("Last Edit {0}Year : {1}{0}Month : {2}{0}Date : {3}{0}User : {4}", Environment.NewLine, row.YearNum, row.MonthNum, row.DateIn, row.RealName);
                            AddLog(log, false);
                        }
                    }
                }
                catch (SqlException ex)
                { Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId); }
            });
        }
        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePath.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePath.Items.Add(item);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lbcFilePath.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePath.Items.Remove(lbcFilePath.SelectedItems[i]);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbcFilePath.ItemCount == 0)
            {
                MsgDlg.Show("Please add a file to import", MsgDlg.MessageType.Info, null);
                return;
            }
            layoutControlGroupCommand.Enabled = false;
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorker_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorker_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportFromExcel())
                e.Result = dt;
            else
                e.Result = null;
        }
        void ImportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                DateTime dt = (DateTime)e.Result;
                MsgDlg.Show(String.Format("Excel file imported {0} in {1} sec", Environment.NewLine, Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds)), MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
