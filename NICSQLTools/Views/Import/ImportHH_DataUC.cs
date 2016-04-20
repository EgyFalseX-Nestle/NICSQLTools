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
using NICSQLTools.Classes.Managers;


namespace NICSQLTools.Views.Import
{
    public partial class ImportHH_DataUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        #region -   Variables   -
        //private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportDaysFrm));
        List<string> Dist = new List<string>();
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ImportHH_DataUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Code
Invoice No.
Customer Name
Time
Cash Sales
Credit Sales	
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportHH_DataUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(qryBillDocHH_DataTableAdapter, DataManager.ConnectionTimeout);
            
            _elementRule = RuleElement;
        }
        private void LoadCustomerCodes(ref NICSQLTools.Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Customer_T FROM [0-6 Customer HN]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NICSQLTools.Data.dsData._0_6_Customer_HNRow row = ds._0_6_Customer_HN.New_0_6_Customer_HNRow();
                row.Customer_T = dr.GetValue(0).ToString();
                ds._0_6_Customer_HN.Add_0_6_Customer_HNRow(row);
            }
            dr.Close();
            cmd.Dispose();
            con.Close(); con.Dispose();
        }
        private void LoadProductCodes(ref NICSQLTools.Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT [Material Number], Quin FROM [0-4  Product Details]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NICSQLTools.Data.dsData._0_4__Product_DetailsRow row = ds._0_4__Product_Details.New_0_4__Product_DetailsRow();
                row.Material_Number = dr.GetDouble(0);
                row.Quin = dr.GetDouble(1);
                ds._0_4__Product_Details.Add_0_4__Product_DetailsRow(row);
            }
            dr.Close();
            cmd.Dispose();
            con.Close(); con.Dispose();
        }private void LoadRouteCodes(ref NICSQLTools.Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT [Route Number] FROM [0-3  Route Details]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NICSQLTools.Data.dsData._0_3__Route_DetailsRow row = ds._0_3__Route_Details.New_0_3__Route_DetailsRow();
                row.Route_Number = dr.GetValue(0).ToString();
                ds._0_3__Route_Details.Add_0_3__Route_DetailsRow(row);
            }
            dr.Close();
            cmd.Dispose();
            con.Close(); con.Dispose();
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
        private bool ImportDaysFromExcel()
        {
            //return false;
            bool output = false;

            AddLog("Start importing ...", false);DataTable dtExcel = new DataTable();

            ShowHideProgress(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        ChangeProgressCaption("Loading Excel File [" + (i + 1) + "] Contains [1/6]");
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
            DateTime userIn = DataManager.defaultInstance.ServerDateTime;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("", con) {CommandTimeout = 0};

            con.Open();

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {
                if (dtExcel.Rows[i][7].ToString().Contains("to"))
                {
                    dtExcel.Rows[i][7] = dtExcel.Rows[i][7].ToString().Substring(0, 10);
                }
                else
                {
                    dtExcel.Rows[i][7] = string.Empty;
                }
            }

            //Load All Bill Docs
            NICSQLTools.Data.dsQry.QryBillDocHH_DataDataTable TblMaster = new NICSQLTools.Data.dsQry.QryBillDocHH_DataDataTable();
            
            //deleting data before saving new 1
            var result = from row in dtExcel.AsEnumerable()
                         where row[7] != null & row[7].ToString() != string.Empty
                         orderby row[7]
                         group row by row[7] into grp
                         select new { BillingDate = grp.Key };
            
            DateTime BillStartDate = Convert.ToDateTime(result.ElementAt(0).BillingDate);
            DateTime BillEndDate = Convert.ToDateTime(result.ElementAt(result.Count() - 1).BillingDate).AddDays(1);
            
            qryBillDocHH_DataTableAdapter.Fill(TblMaster, BillStartDate, BillEndDate);

            ShowHideProgress(false);

            string RouteNumber = string.Empty;
            DateTime billdate = DateTime.Now;

            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    //double DonePercent = ProcessedCounter / ProcessedMax;
                    this.Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }
                if (row[1] != null && row[1].ToString().Contains("Route"))// Get RowNumber
                    RouteNumber = row[2].ToString().Substring(0, row[2].ToString().IndexOf(" -"));
                if (row[7] != null && row[7].ToString() != String.Empty)// Get Date
                    billdate = Convert.ToDateTime(row[7]);

                if (row[2] == null || row[2].ToString().Trim() == string.Empty || row[2].ToString().StartsWith("CS") == false)// Row is empty or a header
                    continue;

                if (TblMaster.FindByInvoiceNo(row[2].ToString()) != null)// Check Bill Doc Exists
                    continue;
                

                NICSQLTools.Data.dsData.HH_DataRow SqlRow = dsData.HH_Data.NewHH_DataRow();
                SqlRow.InvoiceNo = row[2].ToString();

                //Get Date and Time
                string[] time = row[5].ToString().Split(':');
                SqlRow.BillDate = new DateTime(billdate.Year, billdate.Month, billdate.Day, Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));

                SqlRow.Customer = Convert.ToInt32(row[3].ToString().Substring(0, row[3].ToString().IndexOf(" -"))).ToString();
                SqlRow.RouteNumber = RouteNumber;
                SqlRow.CashSales = Convert.ToDouble(row[8]);
                SqlRow.CreditSales = Convert.ToDouble(row[9]);
                SqlRow.Code = row[1].ToString();

                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;
                SqlRow.DateIn = userIn;

                dsData.HH_Data.AddHH_DataRow(SqlRow);
                SqlRow.EndEdit();

            }
            ShowHideProgress(true);
            ChangeProgressCaption("Updating HH Data ...");
            if (!HH_Data.UpdateBulk(cmd, dsData.HH_Data))
                MsgDlg.Show("Update HH Data Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New HH Data Saved " + dsData.HH_Data.Count, true);
                output = true;
            }
            
            dsData.HH_Data.AcceptChanges();
            ShowHideProgress(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.HH_Data.Clear();
            dsData.HH_Data.Dispose(); dsData.HH_Data.Dispose();
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
        private void ImportDaysUC_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    using (NICSQLTools.Data.dsQryTableAdapters.LastEditHH_DataTableAdapter lastEditHH_DataTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditHH_DataTableAdapter())
                    {
                        Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditHH_DataTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
                        NICSQLTools.Data.dsQry.LastEditHH_DataDataTable tbl = lastEditHH_DataTableAdapter.GetData();
                        if (tbl.Count > 0)
                        {
                            NICSQLTools.Data.dsQry.LastEditHH_DataRow row = tbl[0];
                            string log = string.Format("Last Edit {0}Invoice Date: {1}{0}Date : {2}{0}User : {3}", Environment.NewLine, row.BillDate.ToShortDateString(), row.DateIn, row.RealName);
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
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
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
            //if (lbcFilePath.SelectedIndex == -1)
            //    return;
            
            for (int i = lbcFilePath.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePath.Items.Remove(lbcFilePath.SelectedItems[i]);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbcFilePath.ItemCount == 0)
            {
                //MsgDlg.Show("Please add a file to import", Types.MessageType.Warn);
                MessageBox.Show("Please add a file to import");
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
                MsgDlg.Show("Faild to import data from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        void ImportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportDaysFromExcel())
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
                MsgDlg.Show("Data imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
