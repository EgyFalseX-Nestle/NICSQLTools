namespace NICSQLTools.Views.Data
{
    partial class TargetNCEEditorUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetNCEEditorUC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditRouteNumber = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.routeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAposTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPSTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAposDayTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvDayTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPSDayTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSDayTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAposWeekTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvWeekTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPSWeekTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSWeekTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.routeInfoTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.RouteInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiExport,
            this.bbiRefresh});
            this.barManagerMain.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = global::NICSQLTools.Properties.Resources.saveall_16x16;
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(652, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(652, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(652, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditRouteNumber,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.Size = new System.Drawing.Size(652, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDel,
            this.colRouteNumber,
            this.colAposTarget,
            this.colInvTarget,
            this.colDSTarget,
            this.colNPSTarget,
            this.colAposDayTarget,
            this.colInvDayTarget,
            this.colNPSDayTarget,
            this.colDSDayTarget,
            this.colAposWeekTarget,
            this.colInvWeekTarget,
            this.colNPSWeekTarget,
            this.colDSWeekTarget,
            this.colYearNum,
            this.colMonthNum});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            // 
            // gcDel
            // 
            this.gcDel.AppearanceCell.Options.UseTextOptions = true;
            this.gcDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDel.AppearanceHeader.Options.UseTextOptions = true;
            this.gcDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDel.Caption = "Delete";
            this.gcDel.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gcDel.Name = "gcDel";
            this.gcDel.OptionsColumn.TabStop = false;
            this.gcDel.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // colRouteNumber
            // 
            this.colRouteNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.Caption = "Route Number";
            this.colRouteNumber.ColumnEdit = this.repositoryItemGridLookUpEditRouteNumber;
            this.colRouteNumber.FieldName = "Route Number";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 0;
            this.colRouteNumber.Width = 79;
            // 
            // repositoryItemGridLookUpEditRouteNumber
            // 
            this.repositoryItemGridLookUpEditRouteNumber.AutoHeight = false;
            this.repositoryItemGridLookUpEditRouteNumber.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditRouteNumber.DataSource = this.routeInfoBindingSource;
            this.repositoryItemGridLookUpEditRouteNumber.DisplayMember = "Route Number";
            this.repositoryItemGridLookUpEditRouteNumber.Name = "repositoryItemGridLookUpEditRouteNumber";
            this.repositoryItemGridLookUpEditRouteNumber.NullText = "";
            this.repositoryItemGridLookUpEditRouteNumber.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemGridLookUpEditRouteNumber.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditRouteNumber.ValueMember = "Route Number";
            this.repositoryItemGridLookUpEditRouteNumber.View = this.gridView6;
            // 
            // routeInfoBindingSource
            // 
            this.routeInfoBindingSource.DataMember = "RouteInfo";
            this.routeInfoBindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colAposTarget
            // 
            this.colAposTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colAposTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colAposTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposTarget.Caption = "Apos Target";
            this.colAposTarget.FieldName = "AposTarget";
            this.colAposTarget.Name = "colAposTarget";
            this.colAposTarget.Visible = true;
            this.colAposTarget.VisibleIndex = 1;
            // 
            // colInvTarget
            // 
            this.colInvTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colInvTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvTarget.Caption = "Inv Target";
            this.colInvTarget.FieldName = "InvTarget";
            this.colInvTarget.Name = "colInvTarget";
            this.colInvTarget.Visible = true;
            this.colInvTarget.VisibleIndex = 2;
            // 
            // colDSTarget
            // 
            this.colDSTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colDSTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colDSTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSTarget.Caption = "DS Target";
            this.colDSTarget.FieldName = "DSTarget";
            this.colDSTarget.Name = "colDSTarget";
            this.colDSTarget.Visible = true;
            this.colDSTarget.VisibleIndex = 3;
            // 
            // colNPSTarget
            // 
            this.colNPSTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colNPSTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colNPSTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSTarget.Caption = "NPS Target";
            this.colNPSTarget.FieldName = "NPSTarget";
            this.colNPSTarget.Name = "colNPSTarget";
            this.colNPSTarget.Visible = true;
            this.colNPSTarget.VisibleIndex = 4;
            // 
            // colAposDayTarget
            // 
            this.colAposDayTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colAposDayTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposDayTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colAposDayTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposDayTarget.Caption = "Apos Day Target";
            this.colAposDayTarget.FieldName = "AposDayTarget";
            this.colAposDayTarget.Name = "colAposDayTarget";
            this.colAposDayTarget.Visible = true;
            this.colAposDayTarget.VisibleIndex = 5;
            this.colAposDayTarget.Width = 91;
            // 
            // colInvDayTarget
            // 
            this.colInvDayTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colInvDayTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvDayTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvDayTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvDayTarget.Caption = "Inv Day Target";
            this.colInvDayTarget.FieldName = "InvDayTarget";
            this.colInvDayTarget.Name = "colInvDayTarget";
            this.colInvDayTarget.Visible = true;
            this.colInvDayTarget.VisibleIndex = 6;
            this.colInvDayTarget.Width = 83;
            // 
            // colNPSDayTarget
            // 
            this.colNPSDayTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colNPSDayTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSDayTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colNPSDayTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSDayTarget.Caption = "NPS Day Target";
            this.colNPSDayTarget.FieldName = "NPSDayTarget";
            this.colNPSDayTarget.Name = "colNPSDayTarget";
            this.colNPSDayTarget.Visible = true;
            this.colNPSDayTarget.VisibleIndex = 7;
            this.colNPSDayTarget.Width = 86;
            // 
            // colDSDayTarget
            // 
            this.colDSDayTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colDSDayTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSDayTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colDSDayTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSDayTarget.Caption = "DS Day Target";
            this.colDSDayTarget.FieldName = "DSDayTarget";
            this.colDSDayTarget.Name = "colDSDayTarget";
            this.colDSDayTarget.Visible = true;
            this.colDSDayTarget.VisibleIndex = 8;
            this.colDSDayTarget.Width = 80;
            // 
            // colAposWeekTarget
            // 
            this.colAposWeekTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colAposWeekTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposWeekTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colAposWeekTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAposWeekTarget.Caption = "Apos Week Target";
            this.colAposWeekTarget.FieldName = "AposWeekTarget";
            this.colAposWeekTarget.Name = "colAposWeekTarget";
            this.colAposWeekTarget.Visible = true;
            this.colAposWeekTarget.VisibleIndex = 9;
            this.colAposWeekTarget.Width = 99;
            // 
            // colInvWeekTarget
            // 
            this.colInvWeekTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colInvWeekTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvWeekTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvWeekTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvWeekTarget.Caption = "Inv Week Target";
            this.colInvWeekTarget.FieldName = "InvWeekTarget";
            this.colInvWeekTarget.Name = "colInvWeekTarget";
            this.colInvWeekTarget.Visible = true;
            this.colInvWeekTarget.VisibleIndex = 10;
            this.colInvWeekTarget.Width = 91;
            // 
            // colNPSWeekTarget
            // 
            this.colNPSWeekTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colNPSWeekTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSWeekTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colNPSWeekTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNPSWeekTarget.Caption = "NPS Week Target";
            this.colNPSWeekTarget.FieldName = "NPSWeekTarget";
            this.colNPSWeekTarget.Name = "colNPSWeekTarget";
            this.colNPSWeekTarget.Visible = true;
            this.colNPSWeekTarget.VisibleIndex = 11;
            this.colNPSWeekTarget.Width = 94;
            // 
            // colDSWeekTarget
            // 
            this.colDSWeekTarget.AppearanceCell.Options.UseTextOptions = true;
            this.colDSWeekTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSWeekTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.colDSWeekTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSWeekTarget.Caption = "DS Week Target";
            this.colDSWeekTarget.FieldName = "DSWeekTarget";
            this.colDSWeekTarget.Name = "colDSWeekTarget";
            this.colDSWeekTarget.Visible = true;
            this.colDSWeekTarget.VisibleIndex = 12;
            this.colDSWeekTarget.Width = 88;
            // 
            // colYearNum
            // 
            this.colYearNum.AppearanceCell.Options.UseTextOptions = true;
            this.colYearNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearNum.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearNum.Caption = "Year Number";
            this.colYearNum.FieldName = "YearNum";
            this.colYearNum.Name = "colYearNum";
            this.colYearNum.Visible = true;
            this.colYearNum.VisibleIndex = 13;
            // 
            // colMonthNum
            // 
            this.colMonthNum.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthNum.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthNum.Caption = "Month Number";
            this.colMonthNum.FieldName = "MonthNum";
            this.colMonthNum.Name = "colMonthNum";
            this.colMonthNum.Visible = true;
            this.colMonthNum.VisibleIndex = 14;
            this.colMonthNum.Width = 80;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData.TargetNCEDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // routeInfoTableAdapter
            // 
            this.routeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // TargetNCEEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TargetNCEEditorUC";
            this.Size = new System.Drawing.Size(652, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditRouteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAposTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colInvTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colNPSTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colAposDayTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colInvDayTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colNPSDayTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colDSDayTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colAposWeekTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colInvWeekTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colNPSWeekTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colDSWeekTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colYearNum;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthNum;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditRouteNumber;
        private System.Windows.Forms.BindingSource routeInfoBindingSource;
        private NICSQLTools.Data.dsQry dsQry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private NICSQLTools.Data.dsQryTableAdapters.RouteInfoTableAdapter routeInfoTableAdapter;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gcDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
    }
}
