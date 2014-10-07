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
    public partial class ImportCustomerInfoUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportCustomerInfoUC));
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Distribution Channel
Customer
Start date of validity
End date of validity
City
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportCustomerInfoUC()
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(customerInfoTableAdapter, DataManager.ConnectionTimeout);
        }
        private bool ImportDaysFromExcel()
        {
            //return false;
            bool output = false;

            AddLog("Start importing ...");
            DataTable dtExcel = new DataTable();

            //if (SSM.IsSplashFormVisible)
            //    SSM.CloseWaitForm();
            SSM.ShowWaitForm();
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        SSM.SetWaitFormDescription(String.Format("Loading Excel File [{0}] Contains[1 of 1]", (i + 1)));
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
                if (SSM.IsSplashFormVisible)
                    SSM.CloseWaitForm();
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

            SSM.CloseWaitForm();
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

                row["Customer"] = Convert.ToInt32(row["Customer"].ToString());

                //remove duplicated
                if (dsData.CustomerInfo.FindByCustomerStart_date_of_validityEnd_date_of_validity(row["Customer"].ToString(), Convert.ToDateTime(row["Start date of validity"]), Convert.ToDateTime(row["End date of validity"])) != null)
                    continue;

                NICSQLTools.Data.dsData.CustomerInfoRow SqlRow = dsData.CustomerInfo.NewCustomerInfoRow();
                SqlRow.Distribution_Channel = row["Distribution Channel"].ToString();
                SqlRow.Customer = row["Customer"].ToString();
                SqlRow.Start_date_of_validity = Convert.ToDateTime(row["Start date of validity"]);
                SqlRow.End_date_of_validity = Convert.ToDateTime(row["End date of validity"]);
                SqlRow.City = row["City"].ToString();

                dsData.CustomerInfo.AddCustomerInfoRow(SqlRow);
                SqlRow.EndEdit();
            }

            SSM.ShowWaitForm(); Application.DoEvents();
            SSM.SetWaitFormDescription("Updating CustomerInfo ..."); Application.DoEvents();
            if (!CustomerInfo.UpdateBulkCustomerInfo(cmd, dsData.CustomerInfo))
                MsgDlg.Show("Update Customer Info Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Customer Info Saved " + dsData.CustomerInfo.Count);
                output = true;
            }
            dsData.CustomerInfo.AcceptChanges();
            SSM.CloseWaitForm();

            AddLog("New Data Saved " + dsData.CustomerInfo.Count);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.CustomerInfo.Clear(); dsData.CustomerInfo.Dispose();
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
