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
    public partial class ImportUpdateProductDetailsUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(ImportUpdateProductDetailsUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredFieldPP
        {
            get
            {
                return string.Format(@"Required field for import{0}
Material ->(Material Number)
Material ->(Material Name)
 Amount
UoM
Valid From
_______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportUpdateProductDetailsUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLogPP.Text = RequiredFieldPP;

            //DataManager.SetAllCommandTimeouts(customerInfoTableAdapter, DataManager.ConnectionTimeout);
            
            _elementRule = RuleElement;
        }
        public void ActivateRules()
        {
            btnImportPP.Visible = _elementRule.Inserting;
        }
        #region -   PP   -
        private void ShowHideProgressPP(bool ShowHide)
        {
            if (ShowHide)
                PnlProgPP.Invoke(new MethodInvoker(() => { PnlProgPP.Show(); layoutControlItemPnlProgPP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; }));
            else
                PnlProgPP.Invoke(new MethodInvoker(() => { PnlProgPP.Hide(); layoutControlItemPnlProgPP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; }));
            Application.DoEvents();
        }
        private void ChangeProgressCaptionPP(string Caption)
        {
            PnlProgPP.Invoke(new MethodInvoker(() => { PnlProgPP.Caption = Caption; }));
            Application.DoEvents();
        }
        private bool ImportFromExcelPP()
        {
            //return false;
            bool output = false;

            AddLogPP("Start importing ...");
            DataTable dtExcel = new DataTable();

            //if (SSM.IsSplashFormVisible)
            //    SSM.CloseWaitForm();
            ShowHideProgressPP(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePathPP.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePathPP.Items[i].ToString()))
                    {
                        ChangeProgressCaptionPP(String.Format("Loading Excel File [{0}] Contains[1 of 1]", (i + 1)));
                        DataTable dtPart = DataManager.LoadExcelFile_VBA(lbcFilePathPP.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLogPP("File empty " + lbcFilePathPP.Items[i]);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
            }));

            if (dtExcel.Rows.Count == 0)
            {
                ShowHideProgressPP(false);
                AddLogPP("Importing Aborted");
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
                ProgressBarMainPP.Properties.Maximum = ProcessedMax;
                ProgressBarMainPP.EditValue = ProcessedCounter;
            }));

            ShowHideProgressPP(false);
            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    //double DonePercent = ProcessedCounter / ProcessedMax;
                    Invoke(new MethodInvoker(() =>
                    {
                        lblEstTimePP.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMainPP.EditValue = ProcessedCounter;
                        lblCountPP.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }

                //remove duplicated
                if (dsData.TMP_UpdateProductPricePoint.FindByMaterial(Convert.ToInt32(row["Material"])) != null)
                    continue;

                NICSQLTools.Data.dsData.TMP_UpdateProductPricePointRow SqlRow = dsData.TMP_UpdateProductPricePoint.NewTMP_UpdateProductPricePointRow();
                SqlRow.Material = Convert.ToInt32(row["Material"].ToString());
                SqlRow.Amount = Convert.ToDouble(row[" Amount"].ToString());
                //SqlRow.UoM = row["UoM"].ToString();
                DateTime ValidFrom;
                //if (row["Valid From"].ToString().Contains("."))
                //    row["Valid From"] = row["Valid From"].ToString().Replace(".", "/");

                if (DateTime.TryParseExact(row["Valid From"].ToString(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ValidFrom))
                    SqlRow.Valid_From = ValidFrom;
                else
                {
                    MsgDlg.Show("Can't Extract Date From [Valid From] : " + row["Valid From"], MsgDlg.MessageType.Error);
                    return false;
                }
                dsData.TMP_UpdateProductPricePoint.AddTMP_UpdateProductPricePointRow(SqlRow);
                SqlRow.EndEdit();
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTimePP.Text = "0 sec";
                ProgressBarMainPP.EditValue = ProcessedMax;
                lblCountPP.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgressPP(true);
            ChangeProgressCaptionPP("Updating Product ...");
            if (!Product.UpdateProductPricePoint(cmd, dsData.TMP_UpdateProductPricePoint))
                MsgDlg.Show("Update Product Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLogPP("Product Price Point Saved " + dsData.TMP_UpdateProductPricePoint.Count);
                output = true;
            }
            dsData.CustomerInfo.AcceptChanges();
            ShowHideProgressPP(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.CustomerInfo.Clear(); dsData.CustomerInfo.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();

            return output;
        }
        private void AddLogPP(string strLog)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLogPP.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                Logger.Info(strLog);
            }));
        }
        #endregion
        #endregion
        #region -   Event Handlers   -

        #region -   PP   -
        private void btnGetFileNamePP_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePathPP.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePathPP.Items.Add(item);
            }
        }
        private void btnRemovePP_Click(object sender, EventArgs e)
        {
            for (int i = lbcFilePathPP.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePathPP.Items.Remove(lbcFilePathPP.SelectedItems[i]);
            }
        }
        private void btnImportPP_Click(object sender, EventArgs e)
        {
            if (lbcFilePathPP.ItemCount == 0)
            {
                MsgDlg.Show("Please add a file to import", MsgDlg.MessageType.Info, null);
                return;
            }
            layoutControlGroupCommandPP.Enabled = false;
            try
            {
                BackgroundWorker ImportWorker = new BackgroundWorker();
                ImportWorker.DoWork += ImportWorkerPP_DoWork;
                ImportWorker.RunWorkerCompleted += ImportWorkerPP_RunWorkerCompleted;
                ImportWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        void ImportWorkerPP_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (ImportFromExcelPP())
            {
                e.Result = dt;
            }
            else
                e.Result = null;
        }
        void ImportWorkerPP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (e.Result != null)
            {
                DateTime dt = (DateTime)e.Result;
                MsgDlg.Show(String.Format("Excel file imported {0} in {1} sec", Environment.NewLine, Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds)), MsgDlg.MessageType.Success);
            }
            ProgressBarMainPP.EditValue = 0;
            layoutControlGroupCommandPP.Enabled = true;
        }

        #endregion
        
        #endregion
        
    }
}
