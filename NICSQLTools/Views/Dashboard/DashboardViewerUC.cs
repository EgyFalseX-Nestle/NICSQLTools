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
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Dashboard
{
    public partial class DashboardViewerUC : XtraUserControl
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardViewerUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
        List<Classes.Dashboard.DatasourceStrc> DataSourceList = new List<Classes.Dashboard.DatasourceStrc>();
        List<Control> LayoutControlList = new List<Control>();
        List<string> ProgressList = new List<string>();
        #endregion
        #region -   Functions   -
        public DashboardViewerUC()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSSchema.QueryableSource = from q in dsLinq.vAppDashboardSchema_LUEs select q;
                }));
                SplashScreenManager.CloseForm();
            });
        }
        /// <summary>
        /// Create Datasource And Its Controls And Add it to ref Param 'ds'
        /// </summary>
        /// <param name="DatasourceID"> Database Datasource ID required to get its paramters</param>
        /// <param name="ds">DatasourceStrc needed to get its information</param>
        private void CreateDatasource(int DatasourceID, ref Classes.Dashboard.DatasourceStrc ds)
        {
            NICSQLTools.Data.dsDataSource.AppDatasourceRow DashboardDSRow = appDashboardDSTableAdapter.GetDataByDatasourceID(DatasourceID)[0];// Get information About DatasourceID
            NICSQLTools.Data.dsDataSource.AppDatasourceParamDataTable dtParam = appDashboardDSPramTableAdapter.GetDataByDatasourceID(DatasourceID);// Get Paramters Information For DatasourceID

            ds.DashboadId = DatasourceID;
            ds.DatasourceName = DashboardDSRow.DatasourceName;
            ds.DatasourceSPName = DashboardDSRow.DatasourceSPName;

            //Create All Datasource Paramters
            foreach (NICSQLTools.Data.dsDataSource.AppDatasourceParamRow ParamRow in dtParam.Rows)
            {
                NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = get_sp_PramTableAdapter.GetDataByParamName(ParamRow.ParamName, DashboardDSRow.DatasourceSPName);//Get Paramter Information
                string ParamType = string.Empty;
                if (tblPramType.Rows.Count == 0)
                {
                    ParamType = "NVARCHAR";
                }
                else
                {
                    ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type;
                }
                //Create Control For Parameter
                Control item = CreateDSElement(ParamRow, ParamType);
                //Add Control to Datasource Controls List
                ds.Controls.Add(ParamRow.ParamName, item);
            }
            //Create Refresh Button For Datasource
            SimpleButton btnRefresh = new SimpleButton();
            btnRefresh.Image = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            btnRefresh.Name = String.Format("btnRefresh{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
            btnRefresh.Size = new Size(170, 22);
            btnRefresh.Location = new Point(120, layoutControlParamter.Controls.Count * 23);
            btnRefresh.Text = "Refresh " + DashboardDSRow.DatasourceName;
            btnRefresh.StyleController = layoutControlParamter;
            btnRefresh.Click += btnRefresh_Click; btnRefresh.Tag = DatasourceID;
            //Create Cancel Button For Datasource
            SimpleButton btnCancel = new SimpleButton();
            btnCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
            btnCancel.Name = String.Format("btnCancel{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
            btnCancel.Size = new Size(170, 22);
            btnCancel.Location = new Point(120, btnRefresh.Location.Y + 21);
            btnCancel.StyleController = layoutControlParamter;
            btnCancel.Text = "Cancel";
            btnCancel.Enabled = false;
            btnCancel.Click += btnCancel_Click; btnCancel.Tag = DatasourceID;

            //Add Buttons to Datasource Controls List
            ds.ExeButton = btnRefresh;
            ds.CancelButton = btnCancel;
        }
        private Control CreateDSElement(NICSQLTools.Data.dsDataSource.AppDatasourceParamRow ParamRow, string ParamType)
        {
            object ctr = null;
            switch (ParamRow.ParamName)
            {
                case "@SalesDistrict2":
                    ctr = CreateLookupeditForSalesDistrict2();
                    break;
                case "@Materials":
                    ctr = CreateLookupeditForMaterial();
                    break;
                case "@Base_Product":
                    ctr = CreateLookupeditForBaseProduct();
                    break;
                case "@Base_Group":
                    ctr = CreateLookupeditForBaseGroup();
                    break;
                default:// if param have not datasource
                    switch (ParamType.ToLower())
                    {
                        case "nvarchar":
                            TextEdit txt1 = new TextEdit();
                            txt1.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                            ctr = txt1;
                            break;
                        case "int":
                        case "smallint":
                        case "bigint":
                            TextEdit txt2 = new TextEdit();
                            txt2.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                            txt2.Properties.DisplayFormat.FormatString = "n0";
                            txt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            txt2.Properties.EditFormat.FormatString = "n0";
                            txt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            txt2.Properties.Mask.EditMask = "n0";
                            txt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            ctr = txt2;
                            break;
                        case "float":
                            TextEdit txt3 = new TextEdit();
                            txt3.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                            txt3.Properties.DisplayFormat.FormatString = "f2";
                            txt3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            txt3.Properties.EditFormat.FormatString = "f2";
                            txt3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            txt3.Properties.Mask.EditMask = "f2";
                            txt3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                            ctr = txt3;
                            break;
                        case "datetime":
                            DateEdit de1 = new DateEdit();
                            de1.EditValue = null;
                            de1.Name = String.Format("ctr{0}{1}{2}", ParamRow.ParamName, ParamRow.AppDatasourceParamID, ParamRow.DatasourceID);
                            de1.Properties.DisplayFormat.FormatString = "d/M/yyyy";
                            de1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                            de1.Properties.EditFormat.FormatString = "d/M/yyyy";
                            de1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                            de1.Properties.Mask.EditMask = "d/M/yyyy";
                            de1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                            ctr = de1;
                            break;
                        default:
                            break;
                    }
                    break;
            }


            ((TextEdit)ctr).Properties.NullValuePrompt = ParamRow.ParamDisplayName;
            return (Control)ctr;
        }
        private void DeleteLayoutConrols(ref List<Control> lst)
        {
            layoutControlGroupParamters.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].Dispose();
                lst[i] = null;
            }
            lst.Clear();

        }
        private void CreateLayout(List<Classes.Dashboard.DatasourceStrc> DSs, ref List<Control> LayControls)
        {
            DeleteLayoutConrols(ref LayControls);

            foreach (Classes.Dashboard.DatasourceStrc ds in DSs)
            {
                DevExpress.XtraLayout.LayoutControlGroup LayGroup = layoutControlGroupParamters.AddGroup();
                LayGroup.Text = ds.DatasourceName;
                foreach (KeyValuePair<string, Control> item in ds.Controls)
                {
                    layoutControlParamter.Controls.Add(item.Value);

                    DevExpress.XtraLayout.LayoutControlItem layItem = LayGroup.AddItem();
                    layItem.Text = ((TextEdit)item.Value).Properties.NullValuePrompt;
                    layItem.Control = item.Value;
                }
                //Add Refresh button
                DevExpress.XtraLayout.LayoutControlItem layItemBtnRefresh = LayGroup.AddItem();
                layItemBtnRefresh.Control = ds.ExeButton;
                layItemBtnRefresh.TextVisible = false; layItemBtnRefresh.Text = string.Empty;
                
                //Add Cancel button
                DevExpress.XtraLayout.LayoutControlItem layItemBtnCancel = LayGroup.AddItem();
                layItemBtnCancel.Control = ds.CancelButton;
                layItemBtnCancel.TextVisible = false; layItemBtnCancel.Text = string.Empty;
            }
        }
        private CheckedComboBoxEdit CreateLookupeditForSalesDistrict2()
        {
            NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter adp = new NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter();
            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Name = "ccbe";
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = Classes.Managers.UserManager.defaultInstance.UserRuleSalesDistrictTable;
            ccbe.Properties.DisplayMember = "Sales District 2";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "Sales District 2";
            //ccbe.Size = new Size(100, 20);
            //ccbe.TabIndex = 2;

            return ccbe;
        }
        private CheckedComboBoxEdit CreateLookupeditForMaterial()
        {
            NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
            DevExpress.Data.Linq.LinqServerModeSource lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail); lsms.KeyExpression = "[Material_Number]";
            lsms.QueryableSource = from q in ds.vAppProductDetails select q;

            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = lsms;
            ccbe.Properties.DisplayMember = "Material_Number";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "Material_Number";

            return ccbe;
        }
        private CheckedComboBoxEdit CreateLookupeditForBaseProduct()
        {
            NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
            DevExpress.Data.Linq.LinqServerModeSource lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail); lsms.KeyExpression = "[BaseProduct]";
            lsms.QueryableSource = from q in ds.vAppProductDetails where q.BaseProduct != null group q by q.BaseProduct into g select new { BaseProduct = g.Key };

            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = lsms;
            ccbe.Properties.DisplayMember = "BaseProduct";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "BaseProduct";

            return ccbe;
        }
        private CheckedComboBoxEdit CreateLookupeditForBaseGroup()
        {
            NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
            DevExpress.Data.Linq.LinqServerModeSource lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail); lsms.KeyExpression = "[BaseGroup]";
            lsms.QueryableSource = from q in ds.vAppProductDetails where q.BaseGroup != null group q by q.BaseGroup into g select new { BaseGroup = g.Key };

            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = lsms;
            ccbe.Properties.DisplayMember = "BaseGroup";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "BaseGroup";

            return ccbe;
        }
        private void AddToProgreeList(string WorkName)
        {
            lock (ProgressList)
            {
                ProgressList.Add(WorkName);
                if (ProgressList.Count > 0)
                    lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        private void RemoveProgressList(string WorkName)
        {
            lock (ProgressList)
            {
                ProgressList.Remove(WorkName);
                if (ProgressList.Count == 0)
                {
                    lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //pbcRefresh.Text = "Loading ...";
                }
            }
        }
        #endregion
        #region -   EventWhnd   -
        private void DashboardViewerUC_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void btnLoadDashboard_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDashboard.EditValue))
                return;

            try
            {
                NICSQLTools.Data.dsData.AppDashboardSchemaRow SchemaRow = appDashboardSchemaTableAdapter.GetDataByDashboardSchemaId(Convert.ToInt32(lueDashboard.EditValue))[0];//Load Selected Schema Data From Database
                dashboardViewerMain.LoadDashboard(new System.IO.MemoryStream(SchemaRow.DashboardSchemaData));//Load Schema Into Viewer

                DataSourceList.Clear();//Clear Datasource List To Load Another Dashboard Datasource
                for (int i = 0; i < dashboardViewerMain.Dashboard.DataSources.Count; i++)// Refresh Dashboard's Datasource Schema
                {
                    Classes.Dashboard.DatasourceStrc ds = new Classes.Dashboard.DatasourceStrc();//New Struc for Datasource Controls
                    ds.Controls = new Dictionary<string, Control>();//Init Struc Controls List

                    int DatasourceID = Convert.ToInt32(dashboardViewerMain.Dashboard.DataSources[i].ComponentName.Replace(Classes.Dashboard.ComponentNamePerfix, string.Empty));//Extract Datasource ID
                    CreateDatasource(DatasourceID, ref ds);

                    DataSourceList.Add(ds);
                }

                //Add Controls To Form
                CreateLayout(DataSourceList, ref LayoutControlList);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            
        }
        private void btnEditDashboard_Click(object sender, EventArgs e)
        {
            if (dashboardViewerMain.Dashboard == null)
                return;
            DashboardViewerEditorFrm frm = new DashboardViewerEditorFrm(dashboardViewerMain.Dashboard);
            frm.ShowDialog();

            dashboardViewerMain.Dashboard.LayoutRoot = frm.dashboardDesignerMain.Dashboard.LayoutRoot;
            dashboardViewerMain.Dashboard = frm.dashboardDesignerMain.Dashboard;

            dashboardViewerMain.ResumeLayout(true);
            dashboardViewerMain.Refresh();
            dashboardViewerMain.Update();
            dashboardViewerMain.ReloadData(true);


            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //frm.dashboardDesignerMain.Dashboard.SaveToXml(ms);
            //dashboardViewerMain.Dashboard.LoadFromXml(ms);
            
            //dashboardViewerMain.LoadDashboard(ms);//Load Schema Into Viewer

            

            
        }
        void btnRefresh_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            int inx = -1;
            for (int i = 0; i < DataSourceList.Count; i++)
            {
                if (DataSourceList[i].DashboadId == dsID)
                {
                    inx = i;
                    break;
                }
            }
            if (Classes.Dashboard.ChekForEmptyPram(DataSourceList[inx]))
            {
                MsgDlg.Show("Please Fill All Paramters For Data Source: " + DataSourceList[inx].DatasourceName, MsgDlg.MessageType.Info);
                return;
            }
            AddToProgreeList(dsID.ToString());//Add To Working List
            //Executing SP
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            foreach (KeyValuePair<string, Control> ctrItem in DataSourceList[inx].Controls)
            {
                if (ctrItem.Value.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).EditValue);
                else
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).Text);
            }

            DataSourceList[inx].ExeButton.Enabled = false;
            DataSourceList[inx].CancelButton.Enabled = true;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                var data = DataManager.ExeDataSourceAsync(DataSourceList[inx].DatasourceSPName, Paramters, DataSourceList[inx].Execommand, StoredProcedure_InfoMessage, SelectCommand_StatementCompleted);
                Invoke(new MethodInvoker(() => { dashboardViewerMain.Dashboard.DataSources[inx].Data = data; }));
                //dashboardViewerMain.ReloadData(true);
                Invoke(new MethodInvoker(() =>
                {
                    RemoveProgressList(dsID.ToString());// Remove From Working List
                    DataSourceList[inx].ExeButton.Enabled = true;
                    DataSourceList[inx].CancelButton.Enabled = false;
                }));
            });

        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            int inx = -1;
            for (int i = 0; i < DataSourceList.Count; i++)
            {
                if (DataSourceList[i].DashboadId == dsID)
                {
                    inx = i;
                    break;
                }
            }
            if (inx != -1)
            {
                try
                {
                    DataSourceList[inx].ExeButton.Enabled = true;
                    DataSourceList[inx].CancelButton.Enabled = false;
                    RemoveProgressList(dsID.ToString());//Remove Working From List

                    if (DataSourceList[inx].Execommand != null)
                    {
                        DataSourceList[inx].Execommand.Cancel();
                    }
                }
                catch (SqlException ex)
                {
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }

            }
        }
        void StoredProcedure_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            foreach (SqlError error in e.Errors)
            {
                Logger.Error(String.Format("Error While Execute StoredProcedure: {0} - {1}", error.Procedure, error.Message));
            }
            ppWait.Invoke(new MethodInvoker(() =>
            {
                ppWait.Description = e.Message;
                //ppWait.Refresh();
                //Application.DoEvents();

            }));
        }
        void SelectCommand_StatementCompleted(object sender, StatementCompletedEventArgs e)
        {
            MessageBox.Show("Select Command Complete Flag Fired: " + Environment.NewLine + "Recored Count: " + e.RecordCount);
        }
        private void lueDashboard_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                LoadDefaultData();
        }
        #endregion

    }
}
