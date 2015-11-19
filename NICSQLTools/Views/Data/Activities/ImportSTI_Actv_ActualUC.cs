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

namespace NICSQLTools.Views.Data.Activities
{
    public partial class ImportSTI_Actv_ActualUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportSTI_Actv_ActualUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
[Billing Document]
[Billing date for bil]
[Sold-to party]
[Condition type]
[Condition value]
[Actual Invoiced Quan]
[Distribution Channel]
[Reference Document N]
[Agreement (various c]
[Billing Type]
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportSTI_Actv_ActualUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
            NICSQLTools.Data.dsQry.QryBillDocSTI_Actv_ActualDataTable TblMaster = new NICSQLTools.Data.dsQry.QryBillDocSTI_Actv_ActualDataTable();

            //deleting data before saving new 1
            var result = from q in dtExcel.AsEnumerable()
                         orderby q["Billing date for bil"]
                         group q by q["Billing date for bil"] into grp
                         select new { BillingDate = grp.Key };
            DateTime BillStartDate = (DateTime)result.ElementAt(0).BillingDate;
            DateTime BillEndDate = (DateTime)result.ElementAt(result.Count() - 1).BillingDate;
            qryBillDocSTI_Actv_ActualTableAdapter.Fill(TblMaster, BillStartDate, BillEndDate);
            

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

                if (TblMaster.FindByBillingDocument(row["Billing Document"].ToString()) != null)
                    continue;
                if (Convert.ToDouble(row["Condition value"]) < 0)
                    continue;

                NICSQLTools.Data.dsData.STI_Actv_ActualRow SqlRow = dsData.STI_Actv_Actual.NewSTI_Actv_ActualRow();

                SqlRow.BillingDocument = row["Billing Document"].ToString();
                SqlRow.ReferenceDocumentN = row["Reference Document N"].ToString();
                SqlRow.DistributionChannel = row["Distribution Channel"].ToString();
                if (row["Billing date for bil"].ToString() != string.Empty)
                    SqlRow.BillingDateForBil = Convert.ToDateTime(row["Billing date for bil"]);
                SqlRow.SoldToParty = Convert.ToInt32(row["Sold-to party"]).ToString();
                if (row["Agreement (various c"].ToString() != string.Empty)
                    SqlRow.AgreementVariousC = Convert.ToInt32(row["Agreement (various c"]).ToString();

                SqlRow.ConditionType = row["Condition type"].ToString();
                SqlRow.BillingType = row["Billing Type"].ToString();

                if (row["Actual Invoiced Quan"].ToString() != string.Empty)
                    SqlRow.ActualInvoicedQuan = Convert.ToDouble(row["Actual Invoiced Quan"]);
                if (row["Condition value"].ToString() != string.Empty)
                    SqlRow.ConditionValue = Convert.ToDouble(row["Condition value"]);
                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;
                SqlRow.DateIn = UserIn;

                dsData.STI_Actv_Actual.AddSTI_Actv_ActualRow(SqlRow);
                SqlRow.EndEdit();
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTime.Text = "0 sec";
                ProgressBarMain.EditValue = ProcessedMax;
                lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgress(true); ChangeProgressCaption("Updating Activities Actual ...");

            if (!STI_Actv_Actual.UpdateBulkSTI_Actv_Actual(cmd, dsData.STI_Actv_Actual))
                MsgDlg.Show("Update Activities Actual Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Activities Actual Saved " + dsData.STI_Actv_Actual.Count);
                output = true;
            }
            dsData.STI_Actv_Actual.AcceptChanges();
            ShowHideProgress(false);
            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.STI_Actv_Actual.Clear(); dsData.STI_Actv_Actual.Dispose();
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
