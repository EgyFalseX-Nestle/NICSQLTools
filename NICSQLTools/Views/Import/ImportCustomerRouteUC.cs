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
    public partial class ImportCustomerRouteUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportCustomerRouteUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Customer
Route
Delivery Day
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportCustomerRouteUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(customerRouteTableAdapter, DataManager.ConnectionTimeout);
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
            //DataTable distinctTable = dtExcel.DefaultView.ToTable(true, new string[3] { "Route", "Customer", "Delivery Day" });
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

                //Remove @0A Or @09
                if (row[0].ToString() != CustomerRoute.Status08)
                    continue;
                //remove duplicated
                if (dsData.CustomerRoute.FindByRouteCustomerDeliveryDayMonthNumYearNum(row["Route"].ToString(), row["Customer"].ToString(), Convert.ToInt16(row["Delivery Day"]), Convert.ToInt16(tbMonth.EditValue), Convert.ToInt16(tbYear.EditValue)) != null)
                    continue;

                NICSQLTools.Data.dsData.CustomerRouteRow SqlRow = dsData.CustomerRoute.NewCustomerRouteRow();
                SqlRow.Route = row["Route"].ToString();
                SqlRow.Customer = row["Customer"].ToString();
                SqlRow.DeliveryDay = Convert.ToInt16(row["Delivery Day"]);
                SqlRow.ValidFrom = Convert.ToDateTime(row["Valid From"]);
                SqlRow.MonthNum = Convert.ToInt16(tbMonth.EditValue);
                SqlRow.YearNum = Convert.ToInt16(tbYear.EditValue);

                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;

                dsData.CustomerRoute.AddCustomerRouteRow(SqlRow);
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
            ChangeProgressCaption("Updating Customer Route ...");
            if (!CustomerRoute.UpdateBulkCustomerRoute(cmd, dsData.CustomerRoute, Convert.ToInt16(tbYear.EditValue), Convert.ToInt16(tbMonth.EditValue)))
                MsgDlg.Show("Update Customer Route Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Customer Route Saved " + dsData.CustomerRoute.Count, true);
                output = true;
            }
            //Adding New Customers Found In CustomerRoute Into HN
            ChangeProgressCaption("Adding New Customer ...");
            int CustomerAdded = DataManager.adpQry.InsertNewCustomerFromCustomerRoute(Convert.ToInt16(tbYear.EditValue), Convert.ToInt16(tbMonth.EditValue));
            AddLog("New Customer Added : " + CustomerAdded, true);

            dsData.CustomerRoute.AcceptChanges();
            ShowHideProgress(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.CustomerRoute.Clear(); dsData.CustomerRoute.Dispose();
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
        private void ImportCustomerRouteUC_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    using (NICSQLTools.Data.dsQryTableAdapters.LastEditCustomerRouteTableAdapter lastEditCustomerRouteTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditCustomerRouteTableAdapter())
                    {
                        Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditCustomerRouteTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
                        NICSQLTools.Data.dsQry.LastEditCustomerRouteDataTable tbl = lastEditCustomerRouteTableAdapter.GetData();
                        if (tbl.Count > 0)
                        {
                            NICSQLTools.Data.dsQry.LastEditCustomerRouteRow row = tbl[0];
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
