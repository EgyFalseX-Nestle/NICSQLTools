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

namespace NICSQLTools.Views.Import
{
    public partial class ImportCustomerSSInfoUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportCustomerSSInfoUC));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Customer
F2 (Empty)
Name 3
Region
Cust.Hier.:Level 6
F6 (Empty)
Cust.Hier.:Level 5
F8 (Empty)
Cust.Hier.:Level 4
F10 (Empty)
Cust.Hier.:Level 3
F12 (Empty)
Distribution
F14
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportCustomerSSInfoUC()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
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

            AddLog("Start importing ...");
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
                            AddLog("File empty " + lbcFilePath.Items[i]);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
            }));

            if (dtExcel.Rows.Count == 0)
            {
                ShowHideProgress(false);
                AddLog("Importing Aborted");
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

                row["F2"] = Convert.ToInt32(row["F2"].ToString());

                NICSQLTools.Data.dsData.CustomerSSInfoRow SqlRow = dsData.CustomerSSInfo.NewCustomerSSInfoRow();
                SqlRow.Customer = row["Customer"].ToString();
                SqlRow._Sold_to_party = row["F2"].ToString();
                SqlRow.Name_3 = row["Name 3"].ToString();
                SqlRow.Region = row["Region"].ToString();
                SqlRow.CustHier_Level_6 = row["Cust#Hier#:Level 6"].ToString();
                SqlRow.L6_Code = row["F6"].ToString();

                SqlRow.CustHier_Level_5 = row["Cust#Hier#:Level 5"].ToString();
                SqlRow.L5_Code = row["F8"].ToString();

                SqlRow.CustHier_Level_4 = row["Cust#Hier#:Level 4"].ToString();
                SqlRow.L4_Code = row["F10"].ToString();

                SqlRow.CustHier_Level_3 = row["Cust#Hier#:Level 3"].ToString();
                SqlRow.L3_Code = row["F12"].ToString();
                SqlRow.Distribution_channel = row["Distribution channel"].ToString();
                SqlRow.DC_Code = row["F14"].ToString();

                dsData.CustomerSSInfo.AddCustomerSSInfoRow(SqlRow);
                SqlRow.EndEdit();
            }
            ShowHideProgress(true);
            ChangeProgressCaption("Updating CustomerSSInfo ...");
            if (!CustomerSSInfo.UpdateBulkCustomerSSInfo(cmd, dsData.CustomerSSInfo))
                MsgDlg.Show("Update Customer SS Info Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Customer SS Info Saved " + dsData.CustomerSSInfo.Count);
                output = true;
            }
            dsData.CustomerSSInfo.AcceptChanges();
            ShowHideProgress(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.CustomerSSInfo.Clear(); dsData.CustomerSSInfo.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();

            return output;
        }
        private void AddLog(string strLog)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLog.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                Logger.Info(strLog);
            }));
        }
        
        #endregion
        #region -   Event Handlers   -
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
                MsgDlg.Show(String.Format("Excel file imported {0} in {1} sec", Environment.NewLine, Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds)), MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion
        
    }
}
