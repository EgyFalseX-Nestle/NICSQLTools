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
    public partial class QryPivotOLapUC : XtraUserControl
    {

        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(QryPivotOLapUC));
        NICSQLTools.Data.Linq.dsLinqDataDataContext dsLinq = new NICSQLTools.Data.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        Classes.QueryLayout.DatasourceStrc DataSourceList = new Classes.QueryLayout.DatasourceStrc();
        List<Control> LayoutControlList = new List<Control>();
        List<string> ProgressList = new List<string>();
        NICSQLTools.Data.dsData.AppRuleDetailRow _elementRule = null;
        NICSQLTools.Data.dsQry.vAppDatasourceForUserRow _selectedDatasource = null;
        UpdateInfo DynNotify = null;

        #endregion
        #region -   Functions   -
        public QryPivotOLapUC(NICSQLTools.Data.dsData.AppRuleDetailRow RuleElement)
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
            return;
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
                //await CreateDatasourceAsync(DatasourceID);
                //Add Controls To Form
                //CreateLayout(DataSourceList);
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
