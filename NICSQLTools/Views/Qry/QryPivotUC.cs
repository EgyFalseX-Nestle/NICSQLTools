﻿using System;
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
using DevExpress.XtraLayout;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Qry
{
    public partial class QryPivotUC : XtraUserControl
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(QryPivotUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        Classes.QueryLayout.DatasourceStrc DataSourceList = new Classes.QueryLayout.DatasourceStrc();
        List<Control> LayoutControlList = new List<Control>();
        List<string> ProgressList = new List<string>();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        #endregion
        #region -   Functions   -
        public QryPivotUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        public void ActivateRules()
        {
            btnSaveAsLayout.Visible = _elementRule.Inserting;
            btnSaveLayout.Visible = _elementRule.Updateing;
            btnDeleteLayout.Visible = _elementRule.Deleting;

        }
        private void LoadDefaultData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSDatasource.QueryableSource = from q in dsLinq.vAppDatasource_LUEs where q.AppDatasourceTypeId == (int)Uti.Types.AppDatasourceTypeIdEnum.SPQry select q;
                }));
                SplashScreenManager.CloseForm();
            });
        }
        /// <summary>
        /// Create Datasource And Its Controls And Add it to ref Param 'ds'
        /// </summary>
        /// <param name="DatasourceID"> Database Datasource ID required to get its paramters</param>
        /// <param name="ds">DatasourceStrc needed to get its information</param>
        private void CreateDatasource(int DatasourceID, ref Classes.QueryLayout.DatasourceStrc Datasource)
        {
            NICSQLTools.Data.dsData.AppDatasourceRow DashboardDSRow = appDashboardDSTableAdapter.GetDataByDatasourceID(DatasourceID)[0];// Get information About DatasourceID
            NICSQLTools.Data.dsData.AppDatasourceParamDataTable dtParam = appDashboardDSPramTableAdapter.GetDataByDatasourceID(DatasourceID);// Get Paramters Information For DatasourceID

            Datasource.DashboadId = DatasourceID;
            Datasource.DatasourceName = DashboardDSRow.DatasourceName;
            Datasource.DatasourceSPName = DashboardDSRow.DatasourceSPName;

            //Create All Datasource Paramters
            foreach (NICSQLTools.Data.dsData.AppDatasourceParamRow ParamRow in dtParam.Rows)
            {
                NICSQLTools.Data.dsQry.Get_sp_PramDataTable tblPramType = get_sp_PramTableAdapter.GetDataByParamName(ParamRow.ParamName, DashboardDSRow.DatasourceSPName);//Get Paramter Information
                string ParamType = string.Empty;
                if (tblPramType.Rows.Count == 0)
                    ParamType = "NVARCHAR";
                else
                    ParamType = ((NICSQLTools.Data.dsQry.Get_sp_PramRow)tblPramType.Rows[0]).type;
                //Create Control For Parameter
                Control item = CreateDSElement(ParamRow, ParamType);
                //Add Control to Datasource Controls List
                Datasource.Controls.Add(ParamRow.ParamName, item);
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
            Datasource.ExeButton = btnRefresh;
            Datasource.CancelButton = btnCancel;
        }
        private Control CreateDSElement(NICSQLTools.Data.dsData.AppDatasourceParamRow ParamRow, string ParamType)
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
        private void CreateLayout(Classes.QueryLayout.DatasourceStrc ds, ref List<Control> LayControls)
        {
            DeleteLayoutConrols(ref LayControls);

            LayoutControlGroup LayGroup = layoutControlGroupParamters.AddGroup();
            LayGroup.Text = ds.DatasourceName;
            foreach (KeyValuePair<string, Control> item in ds.Controls)
            {
                layoutControlParamter.Controls.Add(item.Value);

                LayoutControlItem layItem = LayGroup.AddItem();
                layItem.Text = ((TextEdit)item.Value).Properties.NullValuePrompt;
                layItem.Control = item.Value;
            }
            //Add Refresh button
            LayoutControlItem layItemBtnRefresh = LayGroup.AddItem(string.Empty, ds.ExeButton);
            layItemBtnRefresh.TextVisible = false;
            //Add Cancel button
            LayoutControlItem layItemBtnCancel = LayGroup.AddItem(string.Empty, ds.CancelButton);
            layItemBtnCancel.TextVisible = false;
        }
        private void LoadLayoutDatasource(int DatasourceId)
        {
            LSMSLayout.QueryableSource = from q in dsLinq.vAppDatasourceLayout_LUEs where q.DatasourceID == DatasourceId select q;

        }
        private bool LoadLayout(int DatasourceLayoutId)
        {
            try
            {
                byte[] data = Classes.QueryLayout.LoadDatasourceLayoutData(DatasourceLayoutId);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(data);
                pivotGridControlMain.RestoreLayoutFromStream(ms);
                //MsgDlg.Show("Layout Loaded ...", MsgDlg.MessageType.Success);
                return true;
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            return false;
        }
        private CheckedComboBoxEdit CreateLookupeditForSalesDistrict2()
        {
            NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter adp = new NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter();
            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            //ccbe.Name = "ccbe";
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
            lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail); lsms.KeyExpression = "[Base_Base_Product]";
            lsms.QueryableSource = from q in ds.vAppProductDetails group q by q.Base_Base_Product into g select new { Base_Base_Product = g.Key };

            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = lsms;
            ccbe.Properties.DisplayMember = "Base_Base_Product";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "Base_Base_Product";

            return ccbe;
        }
        private CheckedComboBoxEdit CreateLookupeditForBaseGroup()
        {
            NICSQLTools.Data.Linq.dsLinqDataDataContext ds = new NICSQLTools.Data.Linq.dsLinqDataDataContext();
            DevExpress.Data.Linq.LinqServerModeSource lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail); lsms.KeyExpression = "[Base_Group]";
            lsms.QueryableSource = from q in ds.vAppProductDetails group q by q.Base_Group into g select new { Base_Group = g.Key };

            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = lsms;
            ccbe.Properties.DisplayMember = "Base_Group";
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = "Base_Group";

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
                    lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
        #endregion
        #region -   EventWhnd   -

        private void QryPivotUC_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            ActivateRules();
        }
        private void btnLoadDatasource_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue))
                return;

            try
            {
                int DatasourceID = Convert.ToInt32(lueDatasource.EditValue);
                DataSourceList = new Classes.QueryLayout.DatasourceStrc(); DataSourceList.Controls = new Dictionary<string, Control>(); //Inti Datasource
                CreateDatasource(DatasourceID, ref DataSourceList);
                //Add Controls To Form
                CreateLayout(DataSourceList, ref LayoutControlList);
                //Load Datasource Layout
                LoadLayoutDatasource(Convert.ToInt32(lueDatasource.EditValue));
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            

        }
        void btnRefresh_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            if (Classes.QueryLayout.ChekForEmptyPram(DataSourceList))
            {
                MsgDlg.Show("Please Fill All Paramters For Data Source: " + DataSourceList.DatasourceName, MsgDlg.MessageType.Info);
                return;
            }
            AddToProgreeList(dsID.ToString());//Add To Working List
            //Executing SP
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            foreach (KeyValuePair<string, Control> ctrItem in DataSourceList.Controls)
                Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).EditValue);

            DataSourceList.ExeButton.Enabled = false;
            DataSourceList.CancelButton.Enabled = true;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                
                //pivotGridControlMain.ForceInitialize();
                pivotGridControlMain.DataSource = DataManager.ExeDataSource(DataSourceList.DatasourceSPName, Paramters, DataSourceList.Execommand, StoredProcedure_InfoMessage, SelectCommand_StatementCompleted);
                pivotGridControlMain.RetrieveFields();
                if (!FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))
                    LoadLayout(Convert.ToInt32(lueLayout.EditValue));
               
                Invoke(new MethodInvoker(() =>
                {
                    RemoveProgressList(dsID.ToString());// Remove From Working List
                    DataSourceList.ExeButton.Enabled = true;
                    DataSourceList.CancelButton.Enabled = false;
                }));
            });
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            try
            {
                DataSourceList.ExeButton.Enabled = true;
                DataSourceList.CancelButton.Enabled = false;
                RemoveProgressList(dsID.ToString());//Remove Working From List
                if (DataSourceList.Execommand != null)
                    DataSourceList.Execommand.Cancel();
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
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
        private void lueDatasource_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                LoadDefaultData();
        }
        private void lueLayout_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue))
                LSMSLayout.Reload();
            
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue))//|| FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue)
                return;
            int Datasource = Convert.ToInt32(lueDatasource.EditValue);

            //if (MsgDlg.Show("Are You Sure You Wanna Save Layout ?", MsgDlg.MessageType.Question) == DialogResult.No)
            //    return;
            Views.Main.ChooseSaveNameDlg dlg = null;
            if (FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))// Save As New
            {
                dlg = new Main.ChooseSaveNameDlg();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                Classes.QueryLayout.InsertLayout(Datasource, dlg.SavingName, ms.ToArray());
            }
            else// Update
            {
                NICSQLTools.Data.Linq.vAppDatasourceLayout_LUE row = (NICSQLTools.Data.Linq.vAppDatasourceLayout_LUE)lueLayout.GetSelectedDataRow();
                dlg = new Main.ChooseSaveNameDlg(row.DatasourceLayoutName);
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                Classes.QueryLayout.UpdateDatasourceLayout(row.DatasourceLayoutId, Datasource, dlg.SavingName, ms.ToArray());
            }
            
        }
        private void btnSaveAsLayout_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue))
                return;

            Views.Main.ChooseSaveNameDlg dlg = new Main.ChooseSaveNameDlg();

            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                int NewId = (int)Classes.QueryLayout.InsertLayout(Convert.ToInt32(lueDatasource.EditValue), dlg.SavingName, ms.ToArray());
                lueLayout.EditValue = NewId;
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            
        }
        private void btnLoadLayout_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue) || FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))
                return;
            if (MsgDlg.Show("Are You Sure You Wanna Load ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            int DatasourceLayoutId = Convert.ToInt32(lueLayout.EditValue);
            LoadLayout(DatasourceLayoutId);
        }
        private void btnDeleteLayout_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue) || FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))
                return;
            if (MsgDlg.Show("Are You Sure You Wanna Delete ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            int DatasourceLayoutId = Convert.ToInt32(lueDatasource.EditValue);
            if (Classes.QueryLayout.DeleteDatasourceLayout(DatasourceLayoutId))
            {
                MsgDlg.Show("Layout Deleted ...", MsgDlg.MessageType.Success);
                //Load Datasource Layout
                if (!FXFW.SqlDB.IsNullOrEmpty(lueDatasource.EditValue))
                    LoadLayoutDatasource(Convert.ToInt32(lueDatasource.EditValue));
            }
            else
                MsgDlg.Show("Can not Delete Layout ...", MsgDlg.MessageType.Error);
        }

        private void pivotGridControlMain_PopupMenuShowing(object sender, DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs e)
        {
            //add custom item
            DevExpress.Utils.Menu.DXMenuItem AddFieldItem = Classes.QueryLayout.CreateMenuItem("Add New Field", Properties.Resources.additem_16x16, MenuItemAddNewField_Click);
            AddFieldItem.Tag = pivotGridControlMain;
            e.Menu.Items.Add(AddFieldItem);

            DevExpress.Utils.Menu.DXMenuItem PivotPropertyItem = Classes.QueryLayout.CreateMenuItem("Pivot Property", Properties.Resources.pivot_16x16, MenuItemPivotProperty_Click);
            PivotPropertyItem.Tag = pivotGridControlMain;
            e.Menu.Items.Add(PivotPropertyItem);

            if (e.Field == null)
                return;
            PivotGridField field = e.Field;
            if (field == null)
                return; //this is Grand Total cell

            DevExpress.Utils.Menu.DXMenuItem FieldPropertyItem = Classes.QueryLayout.CreateMenuItem("Field Property", Properties.Resources.new_16x16, MenuItemFieldProperty_Click);
            FieldPropertyItem.Tag = field;
            e.Menu.Items.Add(FieldPropertyItem);

        }
        private void MenuItemAddNewField_Click(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = (DevExpress.Utils.Menu.DXMenuItem)sender;
            PivotGridControl pivot = (PivotGridControl)item.Tag;
            PivotGridField field = new PivotGridField("New Claculated Field", PivotArea.FilterArea);
            field.UnboundType = DevExpress.Data.UnboundColumnType.Decimal; field.UnboundExpression = "0";
            pivot.Fields.Add(field);
            pgcProperties.SelectedObject = field;

            dockPanelProperties.ParentPanel.ActiveChild = dockPanelProperties;
            dockPanelProperties.ParentPanel.ActiveControl = dockPanelProperties;
            dockPanelProperties.ParentPanel.Show();
            dockPanelProperties.ParentPanel.ShowSliding();
        }
        private void MenuItemFieldProperty_Click(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = (DevExpress.Utils.Menu.DXMenuItem)sender;
            pgcProperties.SelectedObject = item.Tag;

            dockPanelProperties.ParentPanel.ActiveChild = dockPanelProperties;
            dockPanelProperties.ParentPanel.ActiveControl = dockPanelProperties;
            dockPanelProperties.ParentPanel.Show();
            dockPanelProperties.ParentPanel.ShowSliding();
        }
        private void MenuItemPivotProperty_Click(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = (DevExpress.Utils.Menu.DXMenuItem)sender;
            pgcProperties.SelectedObject = item.Tag;

            dockPanelProperties.ParentPanel.ActiveChild = dockPanelProperties;
            dockPanelProperties.ParentPanel.ActiveControl = dockPanelProperties;
            dockPanelProperties.ParentPanel.Show();
            dockPanelProperties.ParentPanel.ShowSliding();
        }
        private void btnExportPivot_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pivotGridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            pivotGridControlMain.ShowRibbonPrintPreview();
        }
        private void btnExportDatasource_Click(object sender, EventArgs e)
        {
            GridControl grid = new GridControl();
            GridView view = new GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view; grid.Parent = this;
            grid.DataSource = pivotGridControlMain.DataSource;
            grid.ShowRibbonPrintPreview();
            this.Controls.Remove(grid); grid.Parent = null;
        }
        #endregion

    }
}
