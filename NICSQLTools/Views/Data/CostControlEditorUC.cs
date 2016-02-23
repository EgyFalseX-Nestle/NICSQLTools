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
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo.Metadata;
using NICSQLTools.Data.xpo;

namespace NICSQLTools.Views.Data
{
    public partial class CostControlEditorUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(CostControlEditorUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsDataTableAdapters.CostCostcenterTableAdapter adpCostCenter = new NICSQLTools.Data.dsDataTableAdapters.CostCostcenterTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.CostAccountNatureTableAdapter adpAccountNature = new NICSQLTools.Data.dsDataTableAdapters.CostAccountNatureTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.QryCostCostActualDocNumberTableAdapter adpBillDoc = new NICSQLTools.Data.dsDataTableAdapters.QryCostCostActualDocNumberTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.CostDynamicForecastTableAdapter adpDF = new NICSQLTools.Data.dsDataTableAdapters.CostDynamicForecastTableAdapter();
        private string RequiredFieldDF
        {
            get
            {
                return string.Format(@"Required field for import{0}
New CC NO
Acc No
Business Unit
DF
Type
_______________________________________________
", Environment.NewLine);
            }
        }
        private string RequiredFieldActual
        {
            get
            {
                return string.Format(@"Required field for import{0}
Cost Element
Cost Center
Offsetting acct no.
Name of offsetting account
Name
Document Header Text
Document type
Ref Document Number
Document Number
Period
User Name
Value TranCurr
Transaction Currency
Vbl. value/Obj. curr
Object Currency
Document Date
Posting Date
Fiscal Year
From Period
_______________________________________________
", Environment.NewLine);
            }
        }
      
        #endregion
        #region -   Functions   -
        public CostControlEditorUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;

            tbLogDF.Text = RequiredFieldDF;
            tbLogActual.Text = RequiredFieldActual;
            
            tbPeriodDF.EditValue = (DataManager.defaultInstance.ServerDateTime.Month - 1) / 3 + 1;
            tbYearDF.EditValue = DataManager.defaultInstance.ServerDateTime.Year;

            ActivateRules();
        }
        private void ShowHideProgressDF(bool ShowHide)
        {
            if (ShowHide)
                PnlProgDF.Invoke(new MethodInvoker(() => { PnlProgDF.Show(); layoutControlItemPnlProgDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; }));
            else
                PnlProgDF.Invoke(new MethodInvoker(() => { PnlProgDF.Hide(); layoutControlItemPnlProgDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; }));
            Application.DoEvents();
        }
        private void ChangeProgressCaptionDF(string Caption)
        {
            PnlProgDF.Invoke(new MethodInvoker(() => { PnlProgDF.Caption = Caption; }));
            Application.DoEvents();
        }
        private void ShowHideProgressActual(bool ShowHide)
        {
            if (ShowHide)
                PnlProgActual.Invoke(new MethodInvoker(() => { PnlProgActual.Show(); layoutControlItemPnlProgActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always; }));
            else
                PnlProgActual.Invoke(new MethodInvoker(() => { PnlProgActual.Hide(); layoutControlItemPnlProgActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never; }));
            Application.DoEvents();
        }
        private void ChangeProgressCaptionActual(string Caption)
        {
            PnlProgActual.Invoke(new MethodInvoker(() => { PnlProgActual.Caption = Caption; }));
            Application.DoEvents();
        }
        private bool ImportFromExcelDF()
        {
            //return false;
            bool output = false;

            AddLogDF("Start importing ...", false);
            DataTable dtExcel = new DataTable();

            ShowHideProgressDF(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePathDF.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePathDF.Items[i].ToString()))
                    {
                        ChangeProgressCaptionDF(String.Format("Loading Excel File [{0}] Contains[1 of 3]", (i + 1)));
                        DataTable dtPart = DataManager.LoadExcelFile_VBA(lbcFilePathDF.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLogDF("File empty " + lbcFilePathDF.Items[i], false);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
                ChangeProgressCaptionDF("Loading Cost Center [2 of 3]");
                adpCostCenter.Fill(dsData.CostCostcenter);
                ChangeProgressCaptionDF("Loading AccountNature [3 of 3]");
                adpAccountNature.Fill(dsData.CostAccountNature);
            }));

            if (dtExcel.Rows.Count == 0)
            {
                ShowHideProgressDF(false);
                AddLogDF("Importing Aborted", false);
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
                ProgressBarMainDF.Properties.Maximum = ProcessedMax;
                ProgressBarMainDF.EditValue = ProcessedCounter;
            }));

            DateTime ServerDatetime = DataManager.defaultInstance.ServerDateTime;

            ShowHideProgressDF(false);
            foreach (DataRow row in dtExcel.Rows)
            {
                //Update UI
                ProcessedCounter++;
                if (ProcessedCounter % 500 == 1)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        lblEstTimeDF.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                        ProgressBarMainDF.EditValue = ProcessedCounter;
                        lblCountDF.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                        Application.DoEvents();
                    }));
                }
                if (row[Cost._colCostcenter].ToString() == string.Empty || row[Cost._colGLAccount].ToString() == string.Empty )
                    continue;
                NICSQLTools.Data.dsData.CostDynamicForecastRow SqlRow = dsData.CostDynamicForecast.NewCostDynamicForecastRow();
                SqlRow.Costcenter = row[Cost._colCostcenter].ToString();
                SqlRow.GLAccount = row[Cost._colGLAccount].ToString();
                SqlRow.DF = Convert.ToDouble(row[Cost._colDF]);
                SqlRow.Type = row[Cost._colType].ToString();
                //if (row[Cost._colType].ToString().Contains(Cost._FC))
                //    SqlRow.BusinessUnit = Cost._FC;
                //else
                //    SqlRow.BusinessUnit = Cost._IC_BU;
                SqlRow.BusinessUnit = row[Cost._colBusinessUnit].ToString().Trim();

                SqlRow.Period = Convert.ToInt32(tbPeriodDF.EditValue);
                SqlRow.Year = Convert.ToInt32(tbYearDF.EditValue);

                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;
                SqlRow.DateIn = ServerDatetime;

                //check duplicated
                NICSQLTools.Data.dsData.CostDynamicForecastRow resultRow = dsData.CostDynamicForecast.FindByCostcenterGLAccountYearBusinessUnitPeriod(SqlRow.Costcenter, SqlRow.GLAccount, SqlRow.Year, SqlRow.BusinessUnit, SqlRow.Period);
                if (resultRow != null)
                {
                    resultRow.DF += SqlRow.DF;
                    resultRow.EndEdit();
                    continue;
                }
                //check if new cost center
                if (dsData.CostCostcenter.FindByCostCenter(row[Cost._colCostcenter].ToString()) == null)
                {
                    adpCostCenter.InsertNewCostCenter(row[Cost._colCostcenter].ToString(), "Auto Generate Cost Center");
                    NICSQLTools.Data.dsData.CostCostcenterRow NewCC = dsData.CostCostcenter.NewCostCostcenterRow();
                    NewCC.CostCenter = row[Cost._colCostcenter].ToString(); dsData.CostCostcenter.AddCostCostcenterRow(NewCC);

                    AddLogDF("New Cost Center Found : " + row[Cost._colCostcenter], true);
                }
                //check if new Account Nature
                if (dsData.CostAccountNature.FindByGLAccount(row[Cost._colGLAccount].ToString()) == null)
                {
                    adpAccountNature.InsertNewAccountNature(row[Cost._colGLAccount].ToString(), "Auto Generate Account Nature");
                    NICSQLTools.Data.dsData.CostAccountNatureRow NewGL = dsData.CostAccountNature.NewCostAccountNatureRow();
                    NewGL.GLAccount = row[Cost._colGLAccount].ToString(); dsData.CostAccountNature.AddCostAccountNatureRow(NewGL);

                     AddLogDF("New Account Nature Found : " + row[Cost._colGLAccount], true);
                }

                dsData.CostDynamicForecast.AddCostDynamicForecastRow(SqlRow);
                SqlRow.EndEdit();
            }
            Invoke(new MethodInvoker(() =>//100 %
            {
                lblEstTimeDF.Text = "0 sec";
                ProgressBarMainDF.EditValue = ProcessedMax;
                lblCountDF.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedMax);

                Application.DoEvents();
            }));
            ShowHideProgressDF(true);
            ChangeProgressCaptionDF("Updating Cost Dynamic Forecast ...");
            if (!Cost.UpdateBulkCostDynamicForecast(cmd, dsData.CostDynamicForecast, Convert.ToInt16(tbYearDF.EditValue), Convert.ToInt16(tbPeriodDF.EditValue)))
                MsgDlg.Show("Update Cost Dynamic Forecast Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLogDF("New Cost Dynamic Forecast Saved " + dsData.CostDynamicForecast.Count, true);
                output = true;
            }
            dsData.CostDynamicForecast.AcceptChanges();
            ShowHideProgressDF(false);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.CostDynamicForecast.Clear(); dsData.CostDynamicForecast.Dispose();
            cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
            GC.Collect(); GC.WaitForPendingFinalizers();

            return output;
        }
        private void AddLogDF(string strLog, bool LogtoFile)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLogDF.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                if (LogtoFile)
                    Logger.Info(strLog);
            }));
        }
        private void AddLogActual(string strLog, bool LogtoFile)
        {
            Invoke(new MethodInvoker(() =>
            {
                tbLogActual.EditValue += string.Format("{0}{1}", strLog, Environment.NewLine);
                if (LogtoFile)
                    Logger.Info(strLog);
            }));
        }
        public void ActivateRules()
        {
            //Selecting 
            gridControlDFEditor.Visible = _elementRule.Selecting;
            btnExportDFEditor.Visible = _elementRule.Selecting;
            btnRefreshDFEditor.Visible = _elementRule.Selecting;
            gridControlCostcenter.Visible = _elementRule.Selecting;
            btnRefreshCostCent.Visible = _elementRule.Selecting;
            btnExportCostCenter.Visible = _elementRule.Selecting;
            gridControlAccountNature.Visible = _elementRule.Selecting;
            btnRefreshAccountNature.Visible = _elementRule.Selecting;
            btnExportAccountNature.Visible = _elementRule.Selecting;

            //Inserting
            XPSCSCostcenter.AllowNew = _elementRule.Inserting;
            XPSCSAccountNature.AllowNew = _elementRule.Inserting;
            XPSCSDFEditor.AllowNew = _elementRule.Inserting;
            if (_elementRule.Updateing)
            {
                layoutControlItemImportDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemImportActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItemImportDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemImportActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            btnAddDFEditor.Visible = _elementRule.Inserting;
            btnSaveCostcenter.Visible = _elementRule.Inserting;
            btnSaveAccountNature.Visible = _elementRule.Inserting;

            //Updating
            XPSCSCostcenter.AllowEdit = _elementRule.Updateing;
            XPSCSAccountNature.AllowEdit = _elementRule.Updateing;
            XPSCSDFEditor.AllowEdit = _elementRule.Updateing;
            if (_elementRule.Updateing)
            {
                layoutControlItemImportDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemImportActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItemImportDF.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemImportActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            btnEditDFEditor.Visible = _elementRule.Updateing;
            btnSaveCostcenter.Visible = _elementRule.Updateing;
            btnSaveAccountNature.Visible = _elementRule.Updateing;

            //Deleting
            XPSCSCostcenter.AllowRemove = _elementRule.Deleting;
            XPSCSAccountNature.AllowRemove = _elementRule.Deleting;
            XPSCSDFEditor.AllowRemove = _elementRule.Deleting;
            btnDeleteDFEditor.Visible = _elementRule.Deleting;
            btnSaveCostcenter.Visible = _elementRule.Deleting;
            btnSaveAccountNature.Visible = _elementRule.Deleting;
        }
        private Task<bool> ImportActual()
        {
            return Task<bool>.Run(() => 
            {
                bool output = false;
                AddLogActual("Start importing ...", false);
                DataTable dtExcel = new DataTable();
                NICSQLTools.Data.dsData ds = new NICSQLTools.Data.dsData();

                ShowHideProgressActual(true);
                this.Invoke(new MethodInvoker(() =>
                {
                    for (int i = 0; i < lbcFilePathActual.ItemCount; i++)
                    {
                        if (File.Exists(lbcFilePathActual.Items[i].ToString()))
                        {
                            ChangeProgressCaptionActual("Loading Excel File [" + (i + 1) + "] Contains. [1 of 3]");
                            DataTable dtPart = DataManager.LoadExcelFile_VBA(lbcFilePathActual.Items[i].ToString(), 0, "*");
                            if (dtPart.Rows.Count == 0)
                            {
                                AddLogActual("File empty " + lbcFilePathActual.Items[i], false);
                                continue;
                            }
                            dtExcel.Merge(dtPart);
                        }
                    }

                    ChangeProgressCaptionActual("Loading Cost Center [2 of 3]");
                    adpCostCenter.Fill(ds.CostCostcenter);
                    ChangeProgressCaptionActual("Loading AccountNature [3 of 3]");
                    adpAccountNature.Fill(ds.CostAccountNature);
                }));

                if (dtExcel.Rows.Count == 0)
                {
                    ShowHideProgressActual(false);
                    AddLogActual("Importing Aborted", false);
                    MsgDlg.Show("No Data Found", MsgDlg.MessageType.Error);
                    return false;
                }

                DateTime dtStart = DateTime.Now;

                SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandTimeout = 0;

                con.Open();

                int ProcessedCounter = 0;
                int ProcessedMax = dtExcel.Rows.Count;
                this.Invoke(new MethodInvoker(() =>
                {
                    ProgressBarMainActual.Properties.Maximum = ProcessedMax;
                    ProgressBarMainActual.EditValue = ProcessedCounter;
                }));

                DateTime ServerDatetime = DataManager.defaultInstance.ServerDateTime;

                //Load All Bill Docs
                NICSQLTools.Data.dsData.QryCostCostActualDocNumberDataTable TblMaster = new NICSQLTools.Data.dsData.QryCostCostActualDocNumberDataTable();
                //deleting data before saving new 1
                var result = from row in dtExcel.AsEnumerable()
                             where row[Cost._colAct_PostingDate] != null & row[Cost._colAct_PostingDate].ToString() != string.Empty
                             orderby row[Cost._colAct_PostingDate]
                             group row by row[Cost._colAct_PostingDate] into grp
                             select new { BillingDate = grp.Key };
                DateTime BillStartDate = (DateTime)result.ElementAt(0).BillingDate;
                DateTime BillEndDate = (DateTime)result.ElementAt(result.Count() - 1).BillingDate;
                adpBillDoc.Fill(TblMaster, BillStartDate, BillEndDate);

                ShowHideProgressActual(false);

                foreach (DataRow row in dtExcel.Rows)
                {
                    //Update UI
                    ProcessedCounter++;
                    if (ProcessedCounter % 500 == 1)
                    {
                        //double DonePercent = ProcessedCounter / ProcessedMax;
                        this.Invoke(new MethodInvoker(() =>
                        {
                            lblEstTimeActual.Text = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds / ProcessedCounter * ProcessedMax) + " sec";
                            ProgressBarMainActual.EditValue = ProcessedCounter;
                            lblCountActual.Text = string.Format("{0}/{1}", ProcessedMax, ProcessedCounter);

                            Application.DoEvents();
                        }));
                    }

                    if (TblMaster.FindByDocumentNumber(row[Cost._colAct_DocumentNumber].ToString()) != null)// Check Bill Doc Exists
                        continue;

                    NICSQLTools.Data.dsData.CostCostActualRow SqlRow = ds.CostCostActual.NewCostCostActualRow();

                    SqlRow.PostingDate = Convert.ToDateTime(row[Cost._colAct_PostingDate]);
                    SqlRow.GLAccount = row[Cost._colAct_GLAccount].ToString();
                    SqlRow.Costcenter = row[Cost._colAct_Costcenter].ToString();
                    SqlRow.OffsettingAccount = row[Cost._colAct_OffsettingAccount].ToString();
                    SqlRow.OffsettingAccountName = row[Cost._colAct_OffsettingAccountName].ToString();
                    SqlRow.Desc = row[Cost._colAct_Desc].ToString();
                    SqlRow.DocumentHeaderText = row[Cost._colAct_DocumentHeaderText].ToString();
                    SqlRow.DocumentType = row[Cost._colAct_DocumentType].ToString();
                    SqlRow.RefDocumentNumber = row[Cost._colAct_RefDocumentNumber].ToString();
                    SqlRow.DocumentNumber = row[Cost._colAct_DocumentNumber].ToString();
                    SqlRow.Period = row[Cost._colAct_Period].ToString();
                    SqlRow.UserName = row[Cost._colAct_UserName].ToString();
                    SqlRow.ValueTranCurr = Convert.ToDouble(row[Cost._colAct_ValueTranCurr]);
                    SqlRow.TransactionCurrency = row[Cost._colAct_TransactionCurrency].ToString();
                    SqlRow.VblValue_ObjCurr = Convert.ToDouble(row[Cost._colAct_VblValue_ObjCurr]);
                    SqlRow.ObjectCurrency = row[Cost._colAct_ObjectCurrency].ToString();
                    SqlRow.DocumentDate = Convert.ToDateTime(row[Cost._colAct_DocumentDate]);
                    SqlRow.FiscalYear = row[Cost._colAct_FiscalYear].ToString();
                    SqlRow.FromPeriod = row[Cost._colAct_FromPeriod].ToString();

                    SqlRow.UserIn = UserManager.defaultInstance.User.UserId;
                    SqlRow.DateIn = ServerDatetime;

                    //check if new cost center
                    if (ds.CostCostcenter.FindByCostCenter(row[Cost._colAct_Costcenter].ToString()) == null)
                    {
                        adpCostCenter.InsertNewCostCenter(row[Cost._colAct_Costcenter].ToString(), "Auto Generate Cost Center");
                        AddLogActual("New Cost Center Found : " + row[Cost._colAct_Costcenter], true);
                    }
                    //check if new Account Nature
                    if (ds.CostAccountNature.FindByGLAccount(row[Cost._colAct_GLAccount].ToString()) == null)
                    {
                        adpAccountNature.InsertNewAccountNature(row[Cost._colAct_GLAccount].ToString(), "Auto Generate Account Nature");
                        AddLogActual("New Account Nature Found : " + row[Cost._colAct_GLAccount], true);
                    }

                    ds.CostCostActual.AddCostCostActualRow(SqlRow);
                    SqlRow.EndEdit();

                }
                ShowHideProgressActual(true);
                ChangeProgressCaptionActual("Updating Cost Actual ...");
                if (!Cost.UpdateBulkCostActual(cmd, ds.CostCostActual))
                    MsgDlg.Show("Update Cost Actual Failed", MsgDlg.MessageType.Error);

                else
                {
                    AddLogActual("New Cost Actual Saved " + ds.CostCostActual.Count, true);
                    output = true;
                }
                ds.CostCostActual.AcceptChanges();
                ShowHideProgressActual(false);


                dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
                ds.CostCostActual.Clear(); ds.CostCostActual.Clear();
                ds.CostCostActual.Dispose(); ds.CostCostActual.Dispose();
                cmd.Dispose(); cmd = null; con.Close(); con.Dispose(); con = null;
                GC.Collect(); GC.WaitForPendingFinalizers();

                return output;
            });
        }
        private Task LoadCostcenterGridAsync()
        {
            return Task.Run(() => 
            {
                XPSCSCostcenter.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                gridControlCostcenter.DataSource = XPSCSCostcenter;
                gridViewCostcenter.BestFitColumns();
            });
        }
        private Task LoadAccountNatureGridAsync()
        {
            return Task.Run(() =>
            {
                XPSCSAccountNature.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                gridControlAccountNature.DataSource = XPSCSAccountNature;
                gridViewAccountNature.BestFitColumns();
                
            });
        }
        private Task LoadDFEditorGridAsync()
        {
            return Task.Run(() =>
            {
                XPSCSDFEditor.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
                gridControlDFEditor.DataSource = XPSCSDFEditor;
                gridViewDFEditor.BestFitColumns();
            });
        }
        #endregion
        #region -   Event Handlers   -
        private async void ImportCustomerRouteUC_Load(object sender, EventArgs e)
        {
            //System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            //{
            //    try
            //    {
            //        using (NICSQLTools.Data.dsQryTableAdapters.LastEditCustomerRouteTableAdapter lastEditCustomerRouteTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditCustomerRouteTableAdapter())
            //        {
            //            Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditCustomerRouteTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
            //            NICSQLTools.Data.dsQry.LastEditCustomerRouteDataTable tbl = lastEditCustomerRouteTableAdapter.GetData();
            //            if (tbl.Count > 0)
            //            {
            //                NICSQLTools.Data.dsQry.LastEditCustomerRouteRow row = tbl[0];
            //                string log = string.Format("Last Edit {0}Year : {1}{0}Month : {2}{0}Date : {3}{0}User : {4}", Environment.NewLine, row.YearNum, row.MonthNum, row.DateIn, row.RealName);
            //                AddLog(log, false);
            //            }
            //        }
            //    }
            //    catch (SqlException ex)
            //    { Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId); }
            //});
            LoadCostcenterGridAsync();
            LoadAccountNatureGridAsync();
            LoadDFEditorGridAsync();
        }
        #region -   DF   -
        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePathDF.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePathDF.Items.Add(item);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lbcFilePathDF.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbcFilePathDF.Items.Remove(lbcFilePathDF.SelectedItems[i]);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lbcFilePathDF.ItemCount == 0)
            {
                MsgDlg.Show("Please add a file to import", MsgDlg.MessageType.Info, null);
                return;
            }
            layoutControlGroupCommandDF.Enabled = false;
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
            if (ImportFromExcelDF())
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
            ProgressBarMainDF.EditValue = 0;
            layoutControlGroupCommandDF.Enabled = true;
        }
        private void btnRefreshDFEditor_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            UOWDFEditor.DropIdentityMap();
            UOWDFEditor.DropChanges();
            XPSCSDFEditor.Reload();
            gridViewDFEditor.RefreshData();
        }
        private void btnAddDFEditor_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicForecastEditorDlg frm = new DynamicForecastEditorDlg(true, string.Empty, string.Empty, null, string.Empty, null);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewDFEditor.ShowLoadingPanel();
                    UOWDFEditor.DropIdentityMap();
                    UOWDFEditor.DropChanges();
                    XPSCSDFEditor.Reload();
                    gridViewDFEditor.RefreshData();
                    gridViewDFEditor.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditDFEditor_Click(object sender, EventArgs e)
        {
            try
            {
                CostDynamicForecast row = (CostDynamicForecast)gridViewDFEditor.GetRow(gridViewDFEditor.FocusedRowHandle);
                if (row == null)
                    return;


                DynamicForecastEditorDlg frm = new DynamicForecastEditorDlg(false, row.ID.Costcenter,
                    row.ID.GLAccount, row.ID.Year, row.ID.BusinessUnit, row.ID.Period);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewDFEditor.ShowLoadingPanel();
                    UOWDFEditor.DropIdentityMap();
                    UOWDFEditor.DropChanges();
                    XPSCSDFEditor.Reload();
                    gridViewDFEditor.RefreshData();
                    gridViewDFEditor.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteDFEditor_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                else
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            };
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            gridViewDFEditor.ShowLoadingPanel();
            gridViewDFEditor.DeleteSelectedRows();
            gridViewDFEditor.RefreshData();
            gridViewDFEditor.HideLoadingPanel();
            UOWDFEditor.CommitTransactionAsync(CommitCallBack);
        }
        private void btnExportDFEditor_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlDFEditor.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridViewDFEditor.ShowRibbonPrintPreview();
        }
        #endregion
        #region -   Import Actual   -
        private void btnGetFileNameActual_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string item in ofd.FileNames)
            {
                int found = lbcFilePathActual.FindString(item);
                if (found != -1)
                    continue;
                lbcFilePathActual.Items.Add(item);
            }
        }
        private void btnRemoveActual_Click(object sender, EventArgs e)
        {
            for (int i = lbcFilePathActual.SelectedItems.Count - 1; i >= 0; i--)
                lbcFilePathActual.Items.Remove(lbcFilePathActual.SelectedItems[i]);
        }
        private async void btnImportActual_Click(object sender, EventArgs e)
        {
            if (lbcFilePathActual.ItemCount == 0)
            {
                MsgDlg.Show("Please add a file to import", MsgDlg.MessageType.Info, null);
                return;
            }
            layoutControlGroupCommandActual.Enabled = false;
            try
            {
                DateTime dt = DateTime.Now;
                if (await ImportActual())
                {
                    MsgDlg.Show(String.Format("Excel file imported {0} in {1} sec", Environment.NewLine, Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds)), MsgDlg.MessageType.Success);
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Faild to import from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
            }
            ProgressBarMainActual.EditValue = 0;
            layoutControlGroupCommandActual.Enabled = true;
        }
        #endregion
        #region -   CostCenter   -
        private void btnRefreshCostCent_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            UOWCostcenter.DropIdentityMap();
            UOWCostcenter.DropChanges();
            XPSCSCostcenter.Reload();
            gridViewCostcenter.RefreshData();
        }
        private void btnSaveCostcenter_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                else
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            };
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOWCostcenter.CommitTransactionAsync(CommitCallBack);
        }
        private void btnExportCostCenter_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlCostcenter.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlCostcenter.ShowRibbonPrintPreview();
        }
        #endregion
        #region -   GLAccount   -
        private void btnRefreshAccountNature_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            UOWAccountNature.DropIdentityMap();
            UOWAccountNature.DropChanges();
            XPSCSAccountNature.Reload();
            gridViewAccountNature.RefreshData();
        }
        private void btnSaveAccountNature_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = (o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                {
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                else
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, o.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, o.InnerException, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
            };
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOWAccountNature.CommitTransactionAsync(CommitCallBack);
        }
        private void btnExportAccountNature_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlAccountNature.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlAccountNature.ShowRibbonPrintPreview();
        }
        #endregion

        #endregion

    }
}
