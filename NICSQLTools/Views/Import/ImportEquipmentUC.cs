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
    public partial class ImportEquipmentUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportEquipmentUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Equipment
Serial Number
Material
Description
Functional Loc.
Valid From
Inventory no.
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportEquipmentUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(customerInfoTableAdapter, DataManager.ConnectionTimeout);
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

            //if (SSM.IsSplashFormVisible)
            //    SSM.CloseWaitForm();
            ShowHideProgress(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        ChangeProgressCaption(String.Format("Loading Excel File [{0}] Contains[1 of 1]", (i + 1)));
                        DataTable dtPart = DataManager.LoadExcelFile_VBA(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLog("File empty " + lbcFilePath.Items[i], false);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
            }));

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
                if (row["Functional Loc#"].ToString() == string.Empty)
                    continue;

                int Funloc = 0;
                if (Int32.TryParse(row["Functional Loc#"].ToString(), out Funloc))
                    row["Functional Loc#"] = Funloc;
                else
                {
                    AddLog("Unknown Functional Loc Format : " + row["Functional Loc#"], true);
                    AddLog(string.Format("Try To Convert ({0}) To ({1})", row["Functional Loc#"], FXFW.SqlDB.ConvertStringToInt(row["Functional Loc#"].ToString())).ToString(), true);
                    row["Functional Loc#"] = FXFW.SqlDB.ConvertStringToInt(row["Functional Loc#"].ToString()).ToString();
                }
                ////remove duplicated
                //if (dsData.CustomerInfo.FindByCustomerStart_date_of_validityEnd_date_of_validity(row["Customer"].ToString(), Convert.ToDateTime(row["Start date of validity"]), Convert.ToDateTime(row["End date of validity"])) != null)
                //    continue;

                NICSQLTools.Data.dsData.EquipmentRow SqlRow = dsData.Equipment.NewEquipmentRow();

                SqlRow.Equipment = row["Equipment"].ToString();
                SqlRow.Serial_Number = row["Serial Number"].ToString();
                SqlRow.Material = row["Material"].ToString();
                SqlRow.Description = row["Description"].ToString();
                SqlRow.Func_Loc = row["Functional Loc#"].ToString();
                SqlRow.Description = row["Description"].ToString();
                SqlRow.Valid_From = Convert.ToDateTime(row["Valid From"]);
                SqlRow.Inventory_number = row["Inventory no#"].ToString();
                if (row["ConstructYear"].ToString() == string.Empty)
                    SqlRow.ConstructYear = Convert.ToInt16(tbYear.EditValue);
                else
                    SqlRow.ConstructYear = Convert.ToInt16(row["ConstructYear"]);
                
                SqlRow.MonthNum = Convert.ToInt16(tbMonth.EditValue);
                SqlRow.YearNum = Convert.ToInt16(tbYear.EditValue);

                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;

                dsData.Equipment.AddEquipmentRow(SqlRow);
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
            ChangeProgressCaption("Updating Equipment ...");
            if (!Equipment.UpdateBulkEquipment(cmd, dsData.Equipment, Convert.ToInt16(tbYear.EditValue), Convert.ToInt16(tbMonth.EditValue)))
                MsgDlg.Show("Update Equipment Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Equipment Saved " + dsData.Equipment.Count, true);
                output = true;
            }
            dsData.Equipment.AcceptChanges();
            ShowHideProgress(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.Equipment.Clear(); dsData.Equipment.Dispose();
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
        private void ImportEquipmentUC_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    using (NICSQLTools.Data.dsQryTableAdapters.LastEditEquipmentTableAdapter lastEditEquipmentTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditEquipmentTableAdapter())
                    {
                        Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditEquipmentTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
                        NICSQLTools.Data.dsQry.LastEditEquipmentDataTable tbl = lastEditEquipmentTableAdapter.GetData();
                        if (tbl.Count > 0)
                        {
                            NICSQLTools.Data.dsQry.LastEditEquipmentRow row = tbl[0];
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
            {
                e.Result = dt;
            }
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
