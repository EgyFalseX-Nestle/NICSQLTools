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
        NICSQLTools.Data.dsQry.vAppDatasourceForUserRow _selectedDatasource = null;
        UpdateInfo DynNotify = null;

        #endregion
        #region -   Functions   -
        public QryPivotUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;

            layoutControlItemLoadLayout.Control.Enabled = false;
            layoutControlItemSave.Control.Enabled = false;
            layoutControlItemSaveAs.Control.Enabled = false;
            layoutControlItemLoad.Control.Enabled = false;
            layoutControlItemDelete.Control.Enabled = false;
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
        private Task<bool> OpenDatasourceAsync()
        {
            return Task.Run(() =>
            {
                bool output = false;
                NICSQLTools.Views.Dashboard.DatasourceOpenDlg dlg = new NICSQLTools.Views.Dashboard.DatasourceOpenDlg(Uti.Types.AppDatasourceTypeIdEnum.SPQry);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedDatasource = dlg.DataSourceRow;
                    output = true;
                }
                return output;
            });
        }
        /// <summary>
        /// Create Datasource And Its Controls And Add it to ref Param 'ds'
        /// </summary>
        /// <param name="DatasourceID"> Database Datasource ID required to get its paramters</param>
        /// <param name="ds">DatasourceStrc needed to get its information</param>
        private Task CreateDatasourceAsync(int DatasourceID)
        {
            return Task.Run(() =>
            {
                NICSQLTools.Data.dsDataSource.AppDatasourceRow DashboardDSRow = appDashboardDSTableAdapter.GetDataByDatasourceID(DatasourceID)[0];// Get information About DatasourceID
                NICSQLTools.Data.dsDataSource.AppDatasourceParamDataTable dtParam = appDashboardDSPramTableAdapter.GetDataByDatasourceID(DatasourceID);// Get Paramters Information For DatasourceID

                DataSourceList.DashboadId = DatasourceID;
                DataSourceList.DatasourceName = DashboardDSRow.DatasourceName;
                DataSourceList.DatasourceSPName = DashboardDSRow.DatasourceSPName;

                //Create All Datasource Paramters
                foreach (NICSQLTools.Data.dsDataSource.AppDatasourceParamRow ParamRow in dtParam.Rows)
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
                    DataSourceList.Controls.Add(ParamRow.ParamName, item);
                }

                //Create Excel Dynamic Update Button For Datasource
                SimpleButton btnDyn = new SimpleButton();
                btnDyn.Image = global::NICSQLTools.Properties.Resources.refresh2_16x16;
                btnDyn.Name = String.Format("btnDyn{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
                btnDyn.Size = new Size(170, 22);
                btnDyn.Location = new Point(120, layoutControlParamter.Controls.Count * 23);
                btnDyn.Text = "Excel Dynamic Update " + DashboardDSRow.DatasourceName;
                btnDyn.StyleController = layoutControlParamter;
                btnDyn.Click += btnDyn_Click; btnDyn.Tag = DatasourceID;
                //Create Cancel Button For Dynamic Update
                SimpleButton btnDynCancel = new SimpleButton();
                btnDynCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
                btnDynCancel.Name = String.Format("btnDynCancel{0}{1}", DashboardDSRow.DatasourceSPName, DatasourceID);
                btnDynCancel.Size = new Size(170, 22);
                btnDynCancel.Location = new Point(120, btnDynCancel.Location.Y + 21);
                btnDynCancel.StyleController = layoutControlParamter;
                btnDynCancel.Text = "Cancel Excel Dynamic Update";
                btnDynCancel.Enabled = false;
                btnDynCancel.Click += btnDynCancel_Click; btnDynCancel.Tag = DatasourceID;

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
                DataSourceList.ExeButton = btnRefresh;
                DataSourceList.EDUCancelButton = btnDynCancel;
                DataSourceList.CancelButton = btnCancel;
                DataSourceList.EDUButton = btnDyn;
            });
            
        }
        private Control CreateDSElement(NICSQLTools.Data.dsDataSource.AppDatasourceParamRow ParamRow, string ParamType)
        {
            object ctr = null;
            if (!ParamRow.IsLookupIDNull())
            {
                ctr = CreateLookupedit(ParamRow.LookupID);
            }
            else
            {
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
                        de1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
                        de1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
                        de1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        de1.Properties.Mask.EditMask = "yyyy-MM-dd";
                        de1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                        ctr = de1;
                        break;
                    default:
                        break;
                }
            }


            ((TextEdit)ctr).Properties.NullValuePrompt = ParamRow.ParamDisplayName;
            return (Control)ctr;
        }
        private void CreateLayout(Classes.QueryLayout.DatasourceStrc ds)
        {
            layoutControlGroupParamters.Clear();
            for (int i = 0; i < LayoutControlList.Count; i++)
            {
                LayoutControlList[i].Dispose();
                LayoutControlList[i] = null;
            }
            LayoutControlList.Clear();

            LayoutControlGroup LayGroup = layoutControlGroupParamters.AddGroup();
            LayGroup.Text = ds.DatasourceName;
            foreach (KeyValuePair<string, Control> item in ds.Controls)
            {
                layoutControlParamter.Controls.Add(item.Value);

                LayoutControlItem layItem = LayGroup.AddItem();
                layItem.Text = ((TextEdit)item.Value).Properties.NullValuePrompt;
                layItem.Control = item.Value;
            }
            //Add Excel Dynamic Update button
            LayoutControlItem layItemBtnDyn = LayGroup.AddItem(string.Empty, ds.EDUButton);
            layItemBtnDyn.TextVisible = false;
            //Add Excel Dynamic Update Cancel button
            LayoutControlItem layItemBtnDynCancel = LayGroup.AddItem(string.Empty, ds.EDUCancelButton);
            layItemBtnDynCancel.TextVisible = false;
            //Add Refresh button
            LayoutControlItem layItemBtnRefresh = LayGroup.AddItem(string.Empty, ds.ExeButton);
            layItemBtnRefresh.TextVisible = false;
            //Add Cancel button
            LayoutControlItem layItemBtnCancel = LayGroup.AddItem(string.Empty, ds.CancelButton);
            layItemBtnCancel.TextVisible = false;
        }
        private Task LoadLayoutDatasourceAsync(int DatasourceId)
        {
            Task tsk = Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(() => 
                {
                    LSMSLayout.QueryableSource = from q in dsLinq.vAppDatasourceLayout_LUEs where q.DatasourceID == DatasourceId select q;
                }));
            });
            return tsk;
        }
        private bool LoadLayout(int DatasourceLayoutId)
        {
            try
            {
                byte[] data = Classes.QueryLayout.LoadDatasourceLayoutData(DatasourceLayoutId);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(data);
                pivotGridControlMain.Fields.Clear();
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
        private CheckedComboBoxEdit CreateLookupedit(int LookupID)
        {
            List<object> data = DataManager.ExeDSLookup(LookupID);
            CheckedComboBoxEdit ccbe = new CheckedComboBoxEdit();
            ccbe.Properties.AllowMultiSelect = true;
            ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            ccbe.Properties.DataSource = Classes.Managers.UserManager.defaultInstance.LookupUserValue((DataTable)data[0], data[2].ToString(), LookupID);
            ccbe.Properties.DisplayMember = data[1].ToString();
            ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ccbe.Properties.ValueMember = data[2].ToString();
            ccbe.EditValueChanged += new EventHandler((e, o) =>
            { ((CheckedComboBoxEdit)e).RefreshEditValue(); });//validate edit value to do not select out of list items
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
            //LoadDefaultData();
            ActivateRules();

        }
        private async void btnLoadDatasource_Click(object sender, EventArgs e)
        {
            try
            {
                btnLoadDashboard.Enabled = false;
                if (await OpenDatasourceAsync() == false)
                {
                    btnLoadDashboard.Enabled = true;
                    return;
                }
                btnLoadDashboard.Enabled = true;

                if (_selectedDatasource == null)
                    return;
                layoutControlGroupDatasource.Enabled = false;//Stop User Activity

                int DatasourceID = _selectedDatasource.DatasourceID;
                DataSourceList = new Classes.QueryLayout.DatasourceStrc(); DataSourceList.Controls = new Dictionary<string, Control>(); //Inti Datasource
                await CreateDatasourceAsync(DatasourceID);
                //Add Controls To Form
                CreateLayout(DataSourceList);
                //Load Datasource Layout
                await LoadLayoutDatasourceAsync(DatasourceID);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }

            layoutControlGroupDatasource.Enabled = true;//Start User Activity

            layoutControlItemLoadLayout.Control.Enabled = true;
            layoutControlItemSave.Control.Enabled = true;
            layoutControlItemSaveAs.Control.Enabled = true;
            layoutControlItemLoad.Control.Enabled = true;
            layoutControlItemDelete.Control.Enabled = true;
        }
        private async void btnDyn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            if (Classes.QueryLayout.ChekForEmptyPram(DataSourceList))
            {
                MsgDlg.Show("Please Fill All Paramters For Data Source: " + DataSourceList.DatasourceName, MsgDlg.MessageType.Info);
                return;
            }
            //Creating Excel Updatable Sheet
            Dictionary<string, object> Paramters = new Dictionary<string, object>();
            foreach (KeyValuePair<string, Control> ctrItem in DataSourceList.Controls)
            {
                if (ctrItem.Value.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).EditValue);
                else
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).Text);
            }

            DataSourceList.EDUButton.Enabled = false;
            DataSourceList.EDUCancelButton.Enabled = true;
            layoutControlGroupDatasource.Enabled = false;//Stop User Activity
            Application.DoEvents();
            try
            {
                DynNotify = new UpdateInfo(); DynNotify.AddItem(null);//Add Item To Kill Excel App
                Classes.msExcel.DynamicRefresh.xlDRJobManager DynJobManager = new Classes.msExcel.DynamicRefresh.xlDRJobManager();
                await DynJobManager.CreateDynamicWorkbookAsync(DataSourceList, Paramters, DynNotify);
            }
            catch { }

            RemoveProgressList(dsID.ToString());// Remove From Working List
            DataSourceList.EDUButton.Enabled = true;
            DataSourceList.EDUCancelButton.Enabled = false;
            layoutControlGroupDatasource.Enabled = true;//Stop User Activity
        }
        void btnDynCancel_Click(object sender, EventArgs e)
        {
            //Kill Excel Application
            DynNotify.SetValue(0, null);
        }
        async void btnRefresh_Click(object sender, EventArgs e)
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
            {
                if (ctrItem.Value.GetType() == typeof(DevExpress.XtraEditors.CheckedComboBoxEdit))
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).EditValue);
                else
                    Paramters.Add(ctrItem.Key, ((TextEdit)ctrItem.Value).Text);
            }

            DataSourceList.EDUButton.Enabled = false;
            DataSourceList.ExeButton.Enabled = false;
            DataSourceList.CancelButton.Enabled = true;
            layoutControlGroupDatasource.Enabled = false;//Stop User Activity
            Application.DoEvents();
            try
            {
                pivotGridControlMain.Fields.Clear();
                pivotGridControlMain.ForceInitialize();
                pivotGridControlMain.DataSource = await DataManager.ExeDataSourceAsync(DataSourceList.DatasourceSPName, Paramters, DataSourceList.Execommand, StoredProcedure_InfoMessage, SelectCommand_StatementCompleted);
                pivotGridControlMain.RetrieveFields();
            }
            catch { }

            RemoveProgressList(dsID.ToString());// Remove From Working List
            DataSourceList.EDUButton.Enabled = true;
            DataSourceList.ExeButton.Enabled = true;
            DataSourceList.CancelButton.Enabled = false;
            layoutControlGroupDatasource.Enabled = true;//Stop User Activity
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            int dsID = Convert.ToInt32(btn.Tag);
            try
            {
                DataSourceList.ExeButton.Enabled = true;
                DataSourceList.CancelButton.Enabled = false;
                layoutControlGroupDatasource.Enabled = true;//Stop User Activity
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
            MessageBox.Show(String.Format("Select Command Complete Flag Fired: {0}Recored Count: {1}", Environment.NewLine, e.RecordCount));
        }
        private void lueLayout_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (_selectedDatasource != null && e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
                LSMSLayout.Reload();
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            if (_selectedDatasource == null)//|| FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue)
                return;
            int Datasource = _selectedDatasource.DatasourceID;

            Views.Main.ChooseSaveNameDlg dlg = null;
            if (FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))// Save As New
            {
                dlg = new Main.ChooseSaveNameDlg();
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                int NewLayoutId = (int)Classes.QueryLayout.InsertLayout(Datasource, dlg.SavingName, ms.ToArray());
                LSMSLayout.Reload(); lueLayout.EditValue = NewLayoutId;
            }
            else// Update
            {
                NICSQLTools.Data.Linq.vAppDatasourceLayout_LUE row = (NICSQLTools.Data.Linq.vAppDatasourceLayout_LUE)lueLayout.GetSelectedDataRow();
                if (!Classes.Managers.UserManager.defaultInstance.User.IsAdmin && row.UserIn != Classes.Managers.UserManager.defaultInstance.User.UserId)
                {
                    MsgDlg.Show("Can't Edit Item you do not owen", MsgDlg.MessageType.Error);
                    return;
                }

                dlg = new Main.ChooseSaveNameDlg(row.DatasourceLayoutName);
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                Classes.QueryLayout.UpdateDatasourceLayout(row.DatasourceLayoutId, Datasource, dlg.SavingName, ms.ToArray());
                LSMSLayout.Reload();
            }
            
        }
        private void btnSaveAsLayout_Click(object sender, EventArgs e)
        {
            if (_selectedDatasource == null)
                return;

            Views.Main.ChooseSaveNameDlg dlg = new Main.ChooseSaveNameDlg();

            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pivotGridControlMain.SaveLayoutToStream(ms, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                int NewId = (int)Classes.QueryLayout.InsertLayout(_selectedDatasource.DatasourceID, dlg.SavingName, ms.ToArray());
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
            if (_selectedDatasource == null || FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))
                return;
            if (MsgDlg.Show("Are You Sure You Wanna Load ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            int DatasourceLayoutId = Convert.ToInt32(lueLayout.EditValue);
            LoadLayout(DatasourceLayoutId);
        }
        private void btnDeleteLayout_Click(object sender, EventArgs e)
        {
            if (_selectedDatasource == null || FXFW.SqlDB.IsNullOrEmpty(lueLayout.EditValue))
                return;

            if (MsgDlg.Show("Are You Sure You Wanna Delete ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            int DatasourceLayoutId = Convert.ToInt32(lueLayout.EditValue);
            if (Classes.QueryLayout.DeleteDatasourceLayout(DatasourceLayoutId))
            {
                MsgDlg.Show("Layout Deleted ...", MsgDlg.MessageType.Success);
                //Load Datasource Layout
                if (_selectedDatasource != null)
                    LoadLayoutDatasourceAsync(_selectedDatasource.DatasourceID);
                lueLayout.EditValue = null;
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

            // Add Field property Menu Item
            DevExpress.Utils.Menu.DXMenuItem FieldPropertyItem = Classes.QueryLayout.CreateMenuItem("Field Property", Properties.Resources.new_16x16, MenuItemFieldProperty_Click);
            FieldPropertyItem.Tag = field;
            e.Menu.Items.Add(FieldPropertyItem);

            // Add Delete Field Menu Item
            DevExpress.Utils.Menu.DXMenuItem DeleteFieldItem = Classes.QueryLayout.CreateMenuItem("Delete Field", Properties.Resources.cancel_16x16, MenuItemDeleteField_Click);
            DeleteFieldItem.Tag = field;
            e.Menu.Items.Add(DeleteFieldItem);


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
        private void MenuItemDeleteField_Click(object sender, EventArgs e)
        {
            DevExpress.Utils.Menu.DXMenuItem item = (DevExpress.Utils.Menu.DXMenuItem)sender;
            pivotGridControlMain.Fields.Remove((PivotGridField)item.Tag);
        }
        private void bbiExcelPivot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pivotGridControlMain.DataSource == null || _selectedDatasource == null)
                return;
            sfd.FileName = _selectedDatasource.DatasourceName;
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;
            if (((DataTable)pivotGridControlMain.DataSource).Rows.Count <= 1000000)
                Classes.msExcel.PivotCreator.CreatePivotByRecordSet(pivotGridControlMain, _selectedDatasource.DatasourceName, sfd.FileName);
            else
                Classes.msExcel.PivotCreator.CreatePivotByRecordSet(pivotGridControlMain, Application.ProductName, sfd.FileName);
            
        }
        private void bbiExportRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControl grid = new GridControl();
            GridView view = new GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view; grid.Parent = this;
            grid.DataSource = pivotGridControlMain.DataSource;
            grid.ShowRibbonPrintPreview();
            this.Controls.Remove(grid); grid.Parent = null;
        }
        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        #endregion

    }
}
