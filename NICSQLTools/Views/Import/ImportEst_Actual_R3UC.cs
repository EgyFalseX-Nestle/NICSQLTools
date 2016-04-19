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
    public partial class ImportEst_Actual_R3UC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportEst_Actual_R3UC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsQryTableAdapters.QryBillDocEST_actual_R3TableAdapter _adpBillDoc = new NICSQLTools.Data.dsQryTableAdapters.QryBillDocEST_actual_R3TableAdapter();
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Payer
Billing Document
Agreement (various c
Sales Organization
Distribution Channel
Billing Type
Sold-to party
Name of Person who C
Sales district
Assignment number
Accounting Document
Cancelled billing do
Reference Document N
Billing date for bil
Net Value in Documen
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportEst_Actual_R3UC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;
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

            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();

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

            DateTime UserIn = DataManager.defaultInstance.ServerDateTime;

            //Load All Bill Docs
            NICSQLTools.Data.dsQry.QryBillDocEST_actual_R3DataTable TblMaster = new NICSQLTools.Data.dsQry.QryBillDocEST_actual_R3DataTable();

            //deleting data before saving new 1
            var result = from q in dtExcel.AsEnumerable()
                         orderby q["Billing date for bil"]
                         group q by q["Billing date for bil"] into grp
                         select new { BillingDate = grp.Key };
            DateTime BillStartDate = (DateTime)result.ElementAt(0).BillingDate;
            DateTime BillEndDate = (DateTime)result.ElementAt(result.Count() - 1).BillingDate;
            _adpBillDoc.Fill(TblMaster, BillStartDate, BillEndDate);

            ShowHideProgress(false);
            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        lblEstTime.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMain.EditValue = ProcessedCounter;
                        lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }

                if (TblMaster.FindByBilling_Document(row["Billing Document"].ToString()) != null)// Already in DB
                    continue;
                if (dsData.EST_actual_R3.FindByBilling_Document(row["Billing Document"].ToString()) != null)// Already Added
                    continue;

                NICSQLTools.Data.dsData.EST_actual_R3Row SqlRow = dsData.EST_actual_R3.NewEST_actual_R3Row();

                SqlRow.Payer = row["Payer"].ToString();
                SqlRow.Billing_Document = row["Billing Document"].ToString();
                if (row["Agreement (various c"].ToString() != string.Empty)
                    SqlRow._Agreement__various_c = Convert.ToInt64(row["Agreement (various c"]).ToString();
                SqlRow.Distribution_Channel = row["Distribution Channel"].ToString();
                SqlRow.Billing_Type = row["Billing Type"].ToString();
                SqlRow._Sold_to_party = Convert.ToInt32(row["Sold-to party"]).ToString();
                SqlRow.Name_of_Person_who_C = row["Name of Person who C"].ToString();
                SqlRow.Assignment_number = row["Assignment number"].ToString();
                SqlRow.Reference_Document_N = row["Reference Document N"].ToString();
                SqlRow.Billing_date_for_bil = Convert.ToDateTime(row["Billing date for bil"]);
                SqlRow.Net_Value_in_Documen = Convert.ToDouble(row["Net Value in Documen"]);

                dsData.EST_actual_R3.AddEST_actual_R3Row(SqlRow);
                SqlRow.EndEdit();
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTime.Text = "0 sec";
                ProgressBarMain.EditValue = ProcessedMax;
                lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgress(true); ChangeProgressCaption("Updating EST_actual_R3 ...");

            if (!EST_actual_R3.UpdateBulkEST_actual_R3(cmd, dsData.EST_actual_R3))
                MsgDlg.Show("Update EST_actual_R3 Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New EST_actual_R3 Saved " + dsData.EST_actual_R3.Count);
                output = true;
            }
            dsData.EST_actual_R3.AcceptChanges();
            ShowHideProgress(false);
            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.EST_actual_R3.Clear(); dsData.EST_actual_R3.Dispose();
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
        public void ActivateRules()
        {
            btnImport.Visible = _elementRule.Inserting;
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
