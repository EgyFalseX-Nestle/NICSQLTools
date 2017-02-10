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
    public partial class ImportGPS_DataUC : DevExpress.XtraEditors.XtraUserControl
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
Start Time
End Time
Stop Time
Idle Time
Stop Address
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportGPS_DataUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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

            //DateTime UserIn = DataManager.defaultInstance.ServerDateTime;
            
            ShowHideProgress(false);
            bool CatchPlate = false;
            string Plate = string.Empty;
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
                if (row[0].ToString() == string.Empty)
                    continue;
                if (row[0].ToString() == "Plate")
                {
                    CatchPlate = true;
                    continue;
                }
                if (CatchPlate)
                {
                    Plate = row[0].ToString();
                    CatchPlate = false;
                    continue;
                }
                DateTime checkRow = DateTime.Now;
                if (!DateTime.TryParse(row[0].ToString(), out checkRow))
                    continue;

                NICSQLTools.Data.dsData.GPS_DataRow SqlRow = dsData.GPS_Data.NewGPS_DataRow();
                SqlRow.Plate = Plate;
                SqlRow.StartTime = Convert.ToDateTime(row[0]);
                SqlRow.EndTime = Convert.ToDateTime(row[1]);
                if (row[2].ToString() != string.Empty)
                    SqlRow.Stop_Idle = "Stop";
                else if (row[3].ToString() != string.Empty)
                    SqlRow.Stop_Idle = "Idle";
                string[] customerSplit = row[4].ToString().Split('/');
                int Customer;
                foreach (string item in customerSplit)
                {
                    if (int.TryParse(item, out Customer))
                    {
                        if (Customer > 0)
                        {
                            switch (Customer.ToString())
                            {
                                case "898":
                                    SqlRow.Customer = "0898";
                                    break;
                                case "899":
                                    SqlRow.Customer = "0899";
                                    break;
                                case "902":
                                    SqlRow.Customer = "0902";
                                    break;
                                default:
                                    SqlRow.Customer = Customer.ToString();
                                    break;
                            }
                            
                            break;
                        }
                    }
                    else if (item.Contains("1020M"))
                    {
                        SqlRow.Customer = "1020M";
                        break;
                    }
                    else if (item.Contains("1020S"))
                    {
                        SqlRow.Customer = "1020S";
                        break;
                    }
                    else if (item.Contains("0898N"))
                    {
                        SqlRow.Customer = "0898N";
                        break;
                    }}
                if (dsData.GPS_Data.FindByStartTimeEndTimePlate(SqlRow.StartTime, SqlRow.EndTime, SqlRow.Plate) == null)
                {
                    dsData.GPS_Data.AddGPS_DataRow(SqlRow);
                    SqlRow.EndEdit();
                }
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTime.Text = "0 sec";
                ProgressBarMain.EditValue = ProcessedMax;
                lblCount.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgress(true); ChangeProgressCaption("Updating GPS Data ...");

            if (!GPS_Data.UpdateBulkGPS_Data(cmd, dsData.GPS_Data))
                MsgDlg.Show("Update GPS_Data Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New GPS_Data Saved " + dsData.GPS_Data.Count);
                output = true;
            }
            dsData.GPS_Data.AcceptChanges();
            ShowHideProgress(false);
            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.GPS_Data.Clear(); dsData.GPS_Data.Dispose();
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
