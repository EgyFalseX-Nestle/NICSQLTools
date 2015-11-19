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
    public partial class ImportDst_MasterUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        #region -   Variables   -
        List<string> Dist = new List<string>();
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ImportDst_MasterUC));
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        private string RequiredField
        {
            get
            {
                return string.Format(@"Required field for import{0}
Invoicekey
BillingNumber
BillingType
Billingdateforbil
route
Salesman
BrandRoute
Supervisor
Region
Distributer
ProductRef
ProductName
brand
price_point_range
price_point
BaseProduct
PartnerRef
PartnerName
level3
subchannel
CustomerType
invoice_value
invoice_case
invoice_volume
SalesType
ProductSalesType
PatnerNameعربي
systemdate
______________________________________________
", Environment.NewLine);
            }
        }
     
        #endregion
        #region -   Functions   -
        public ImportDst_MasterUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            tbLog.Text = RequiredField;

            DataManager.SetAllCommandTimeouts(_0_4__Product_DetailsTableAdapter, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(dst_RouteTableAdapter, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(dst_CustomerTableAdapter, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(qryDst_MasterDocNumberTableAdapter, DataManager.ConnectionTimeout);
            
            _elementRule = RuleElement;
        }
        private static bool FindBillDoc(NICSQLTools.Data.dsData.QryDst_MasterDocNumberDataTable tbl, string BillDoc)
        {
            if (tbl.FindByBillingNumber(BillDoc) != null)
                return true;
            else
                return false;
        }
        private void LoadCustomerCodes(ref NICSQLTools.Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Customer FROM dbo.[Dst_Customer]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NICSQLTools.Data.dsData.Dst_CustomerRow row = ds.Dst_Customer.NewDst_CustomerRow();
                row.Customer = Convert.ToInt64(dr.GetValue(0));
                ds.Dst_Customer.AddDst_CustomerRow(row);
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
        }
        private void LoadRouteCodes(ref NICSQLTools.Data.dsData ds)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT [Route] FROM dbo.[Dst_Route]", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NICSQLTools.Data.dsData.Dst_RouteRow row = ds.Dst_Route.NewDst_RouteRow();
                row.Route = dr.GetValue(0).ToString();
                ds.Dst_Route.AddDst_RouteRow(row);
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

            int NewCustomerFounded = 0;
            int NewRouteFounded = 0;
            AddLog("Start importing ...", false);
            DataTable dtExcel = new DataTable();

            ShowHideProgress(true);
            this.Invoke(new MethodInvoker(() =>
            {
                for (int i = 0; i < lbcFilePath.ItemCount; i++)
                {
                    if (File.Exists(lbcFilePath.Items[i].ToString()))
                    {
                        ChangeProgressCaption("Loading Excel File [" + (i + 1) + "] Contains [1/4]");
                        DataTable dtPart = DataManager.LoadExcelFile_VBA(lbcFilePath.Items[i].ToString(), 0, "*");
                        if (dtPart.Rows.Count == 0)
                        {
                            AddLog("File empty " + lbcFilePath.Items[i], false);
                            continue;
                        }
                        dtExcel.Merge(dtPart);
                    }
                }
                ChangeProgressCaption("Loading Customers Informations [2/4]");
                LoadCustomerCodes(ref dsData);
                ChangeProgressCaption("Loading Routes Informations [3/4]");
                dst_RouteTableAdapter.Fill(dsData.Dst_Route);
                //LoadRouteCodes(ref dsData);
                ChangeProgressCaption("Loading Products Informations [4/4]");
                _0_4__Product_DetailsTableAdapter.Fill(dsData._0_4__Product_Details);
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
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandTimeout = 0;

            con.Open();

            int ProcessedCounter = 0;
            int ProcessedMax = dtExcel.Rows.Count;
            this.Invoke(new MethodInvoker(() =>
            {
                ProgressBarMain.Properties.Maximum = ProcessedMax;
                ProgressBarMain.EditValue = ProcessedCounter;
            }));

            //Load All Bill Docs
            NICSQLTools.Data.dsData.QryDst_MasterDocNumberDataTable TblMaster = new NICSQLTools.Data.dsData.QryDst_MasterDocNumberDataTable();
            
            //deleting data before saving new 1
            var result = from row in dtExcel.AsEnumerable()
                         where row["Billingdateforbil"] != null & row["Billingdateforbil"].ToString() != string.Empty
                         orderby row["Billingdateforbil"]
                         group row by row["Billingdateforbil"] into grp
                         select new { BillingDate = grp.Key };

            
            DateTime BillStartDate = (DateTime)result.ElementAt(0).BillingDate;
            DateTime BillEndDate = (DateTime)result.ElementAt(result.Count() - 1).BillingDate;

            qryDst_MasterDocNumberTableAdapter.Fill(TblMaster, BillStartDate, BillEndDate);

            ShowHideProgress(false);

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
                if (FindBillDoc(TblMaster, row["BillingNumber"].ToString()))// Check Bill Doc Exists
                    continue;
                if (row["Invoicekey"].ToString().Trim() == string.Empty)
                    continue;
                NICSQLTools.Data.dsData.Dst_MasterRow SqlRow = dsData.Dst_Master.NewDst_MasterRow();

                SqlRow.Invoicekey = Convert.ToInt32(row["Invoicekey"]);
                SqlRow.BillingNumber = row["BillingNumber"].ToString();
                SqlRow.BillingType = row["BillingType"].ToString();
                SqlRow.BillingDate = Convert.ToDateTime(row["Billingdateforbil"]);
                SqlRow.Route = row["RouteNumberSystem"].ToString();
                SqlRow.Distributer = row["Distributer"].ToString();
                SqlRow.Product = Convert.ToInt64(row["ProductRef"]);
                SqlRow.Customer = Convert.ToInt64(row["PartnerRef"]);
                SqlRow.Value = Convert.ToDouble(row["invoice_value"]);
                SqlRow.CS = Convert.ToDouble(row["invoice_case"]);
                SqlRow.Vol = Convert.ToDouble(row["invoice_volume"]);
                SqlRow.SalesType = row["SalesType"].ToString();
                SqlRow.ProductSalesType = row["ProductSalesType"].ToString();
                SqlRow.systemdate = Convert.ToDateTime(row["systemdate"]);
                
                if (SqlRow.Route == string.Empty)
                {
                    //try to get it from last route for this "Sold to-party"
                    cmd.CommandText = string.Format("SELECT top 1 Route FROM [Dst_Master] WHERE [Customer] = {0} AND [Dst_Master].[Route] <> '' order by [BillingDate] DESC", SqlRow.Customer);
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                        SqlRow.Route = obj.ToString();
                }
                //Customer Update
                NICSQLTools.Data.dsData.Dst_CustomerRow CustomerRow = Dst_Customer.GetCustomerRow(SqlRow.Customer, dsData.Dst_Customer);

                if (CustomerRow.RowState == DataRowState.Detached)
                {
                    CustomerRow.Customer = SqlRow.Customer;
                    CustomerRow.CustomerName = row["PartnerName"].ToString();
                    CustomerRow.CustomerName2 = row["PatnerNameعربي"].ToString();
                    CustomerRow.CustomerNameAr = row["PartnerName"].ToString();
                    CustomerRow.CustomerName2Ar = row["PatnerNameعربي"].ToString();
                    CustomerRow.Level3 = row["level3"].ToString();
                    CustomerRow.Subchannel = row["subchannel"].ToString();
                    CustomerRow.CustomerType = row["CustomerType"].ToString();

                    dsData.Dst_Customer.AddDst_CustomerRow(CustomerRow);
                    CustomerRow.EndEdit();
                    dst_CustomerTableAdapter.Insert(SqlRow.Customer, CustomerRow.CustomerName, CustomerRow.CustomerName2, CustomerRow.CustomerNameAr, CustomerRow.CustomerName2Ar, CustomerRow.Level3, CustomerRow.Subchannel, CustomerRow.CustomerType);
                    AddLog("[New Customer Found] : " + CustomerRow.Customer, true);
                    NewCustomerFounded++;
                }
                //Route Update
                if (row["Route"].ToString().Trim() != string.Empty)
                {
                    NICSQLTools.Data.dsData.Dst_RouteRow RouteRow = Dst_Route.GetRouteNumber(row["RouteNumberSystem"].ToString().Trim(), dsData.Dst_Route);
                    if (RouteRow == null)
                    {
                        RouteRow = dsData.Dst_Route.NewDst_RouteRow();
                        RouteRow.Route = SqlRow.Route;
                        RouteRow.Distributer = row["Distributer"].ToString();
                        RouteRow.RouteName = row["Route"].ToString();
                        RouteRow.SalesMan = row["Salesman"].ToString();
                        RouteRow.BrandRoute = row["BrandRoute"].ToString();
                        RouteRow.Supervisor = row["Supervisor"].ToString();
                        RouteRow.Region = row["Region"].ToString();
                        dsData.Dst_Route.AddDst_RouteRow(RouteRow);
                        RouteRow.EndEdit();
                        //dst_RouteTableAdapter.Insert(RouteRow.Route, RouteRow.RouteName, RouteRow.Distributer, RouteRow.SalesMan, RouteRow.BrandRoute, RouteRow.Supervisor, RouteRow.Region);
                        AddLog("[New Route Found] : " + RouteRow.Route, true);
                        NewRouteFounded++;
                    }
                }
                SqlRow.UserIn = UserManager.defaultInstance.User.UserId;
                dsData.Dst_Master.AddDst_MasterRow(SqlRow);
                SqlRow.EndEdit();
            }
            ShowHideProgress(true);
            ChangeProgressCaption("Updating Billing Details ...");
            if (!Dst_Master.UpdateBulkMaster(cmd, dsData.Dst_Master))
                MsgDlg.Show("Update Billing Details Failed", MsgDlg.MessageType.Error);
            else
            {
                AddLog("New Billing Details Saved " + dsData.Dst_Master.Count, true);
                output = true;
            }
            ChangeProgressCaption("Updating Routes ..."); Application.DoEvents();
            Dst_Route.UpdateBulkRoute(cmd, dsData.Dst_Route);
            dsData.Dst_Master.AcceptChanges();
            ShowHideProgress(false);

            AddLog("New Customers Saved " + NewCustomerFounded, true);
            AddLog("New Routes Saved " + NewRouteFounded, true);

            dtExcel.Rows.Clear(); dtExcel.Dispose(); dtExcel = null;
            dsData.Dst_Master.Clear(); dsData.Dst_Customer.Clear();
            dsData.Dst_Master.Dispose(); dsData.Dst_Customer.Dispose();
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
                    using (NICSQLTools.Data.dsQryTableAdapters.LastEditDstMasterTableAdapter lastEditDistMasterTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.LastEditDstMasterTableAdapter())
                    {
                        Classes.Managers.DataManager.SetAllCommandTimeouts(lastEditDistMasterTableAdapter, Classes.Managers.DataManager.ConnectionTimeout);
                        NICSQLTools.Data.dsQry.LastEditDstMasterDataTable tbl = lastEditDistMasterTableAdapter.GetData();
                        if (tbl.Count > 0)
                        {
                            NICSQLTools.Data.dsQry.LastEditDstMasterRow row = tbl[0];
                            string log = string.Format("Last Edit {0}Billing Date: {1}{0}Date : {2}{0}User : {3}", Environment.NewLine, row.BillingDate, row.DateIn, row.RealName);
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
                MsgDlg.Show("Faild to import bills from excel. - " + ex.Message, MsgDlg.MessageType.Error, ex);
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
                MsgDlg.Show("Bills imported " + Environment.NewLine + "in " + Convert.ToInt32(DateTime.Now.Subtract(dt).TotalSeconds) + " sec", MsgDlg.MessageType.Success);
            }
            ProgressBarMain.EditValue = 0;
            layoutControlGroupCommand.Enabled = true;
        }

        #endregion

    }
}
