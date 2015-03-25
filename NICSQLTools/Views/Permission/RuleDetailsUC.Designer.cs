namespace NICSQLTools.Views.Permission
{
    partial class RuleDetailsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleDetailsUC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.rulesLUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.dsData = new NICSQLTools.Data.dsData();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiRule = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.rules_LUETableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter();
            this.TLItems = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcSelect = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tlcInsert = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcUpdate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ruleDetailTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppRuleDetailTableAdapter();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageUI = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageDatasource = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDSCategoryDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LSMSCategory = new DevExpress.Data.Linq.LinqServerModeSource();
            this.imageCollectionNormal = new DevExpress.Utils.ImageCollection(this.components);
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnableRule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHelp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDSInfo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDashboardSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDateIn = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemButtonEditSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEditEnable = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.XPSCSDS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.UOWDS = new DevExpress.Xpo.UnitOfWork(this.components);
            this.appRuleDatasourceForRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appRuleDatasourceTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppRuleDatasourceTableAdapter();
            this.appRuleDatasourceForRuleTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppRuleDatasourceForRuleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageUI.SuspendLayout();
            this.xtraTabPageDatasource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDSInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRuleDatasourceForRuleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rulesLUEBindingSource
            // 
            this.rulesLUEBindingSource.AllowNew = true;
            this.rulesLUEBindingSource.DataMember = "Rules_LUE";
            this.rulesLUEBindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bbiRefresh,
            this.bbiRule});
            this.barManagerMain.MaxItemId = 4;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRule),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiRule
            // 
            this.bbiRule.Caption = "Rules";
            this.bbiRule.Edit = this.repositoryItemLookUpEdit1;
            this.bbiRule.Id = 3;
            this.bbiRule.Name = "bbiRule";
            this.bbiRule.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.bbiRule.Width = 200;
            this.bbiRule.EditValueChanged += new System.EventHandler(this.bbiRule_EditValueChanged);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RuleName", "Rule Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RuleDesc", "Rule Description", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.rulesLUEBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "RuleName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.NullValuePrompt = "Select A Rule To Edit";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "RuleID";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = global::NICSQLTools.Properties.Resources.saveall_16x16;
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = global::NICSQLTools.Properties.Resources.saveall_32x32;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::NICSQLTools.Properties.Resources.refresh2_32x32;
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
            this.barDockControlTop.Size = new System.Drawing.Size(700, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 332);
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 301);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 301);
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // rules_LUETableAdapter
            // 
            this.rules_LUETableAdapter.ClearBeforeFill = true;
            // 
            // TLItems
            // 
            this.TLItems.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName,
            this.tlcSelect,
            this.tlcInsert,
            this.tlcUpdate,
            this.tlcDelete,
            this.tlcID});
            this.TLItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLItems.KeyFieldName = "Name";
            this.TLItems.Location = new System.Drawing.Point(0, 0);
            this.TLItems.Name = "TLItems";
            this.TLItems.OptionsBehavior.PopulateServiceColumns = true;
            this.TLItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.TLItems.Size = new System.Drawing.Size(694, 273);
            this.TLItems.TabIndex = 10;
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Item Name";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.OptionsColumn.AllowEdit = false;
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 0;
            this.tlcName.Width = 136;
            // 
            // tlcSelect
            // 
            this.tlcSelect.Caption = "View";
            this.tlcSelect.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcSelect.FieldName = "Select";
            this.tlcSelect.Name = "tlcSelect";
            this.tlcSelect.Visible = true;
            this.tlcSelect.VisibleIndex = 1;
            this.tlcSelect.Width = 137;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // tlcInsert
            // 
            this.tlcInsert.Caption = "Insert";
            this.tlcInsert.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcInsert.FieldName = "Insert";
            this.tlcInsert.Name = "tlcInsert";
            this.tlcInsert.Visible = true;
            this.tlcInsert.VisibleIndex = 2;
            this.tlcInsert.Width = 137;
            // 
            // tlcUpdate
            // 
            this.tlcUpdate.Caption = "Update";
            this.tlcUpdate.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcUpdate.FieldName = "Update";
            this.tlcUpdate.Name = "tlcUpdate";
            this.tlcUpdate.Visible = true;
            this.tlcUpdate.VisibleIndex = 3;
            this.tlcUpdate.Width = 136;
            // 
            // tlcDelete
            // 
            this.tlcDelete.Caption = "Delete";
            this.tlcDelete.ColumnEdit = this.repositoryItemCheckEdit1;
            this.tlcDelete.FieldName = "Delete";
            this.tlcDelete.Name = "tlcDelete";
            this.tlcDelete.Visible = true;
            this.tlcDelete.VisibleIndex = 4;
            this.tlcDelete.Width = 136;
            // 
            // tlcID
            // 
            this.tlcID.Caption = "ID";
            this.tlcID.FieldName = "ID";
            this.tlcID.Name = "tlcID";
            this.tlcID.OptionsColumn.AllowEdit = false;
            // 
            // ruleDetailTableAdapter
            // 
            this.ruleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 31);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageUI;
            this.xtraTabControlMain.Size = new System.Drawing.Size(700, 301);
            this.xtraTabControlMain.TabIndex = 15;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageUI,
            this.xtraTabPageDatasource});
            // 
            // xtraTabPageUI
            // 
            this.xtraTabPageUI.Controls.Add(this.TLItems);
            this.xtraTabPageUI.Name = "xtraTabPageUI";
            this.xtraTabPageUI.Size = new System.Drawing.Size(694, 273);
            this.xtraTabPageUI.Text = "UI";
            // 
            // xtraTabPageDatasource
            // 
            this.xtraTabPageDatasource.Controls.Add(this.splitContainerControl1);
            this.xtraTabPageDatasource.Name = "xtraTabPageDatasource";
            this.xtraTabPageDatasource.Size = new System.Drawing.Size(694, 273);
            this.xtraTabPageDatasource.Text = "Data Source";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(694, 273);
            this.splitContainerControl1.SplitterPosition = 347;
            this.splitContainerControl1.TabIndex = 13;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.colDSCategoryDesc});
            this.treeListMain.DataSource = this.LSMSCategory;
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.KeyFieldName = "DSCategoryId";
            this.treeListMain.Location = new System.Drawing.Point(0, 0);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.Editable = false;
            this.treeListMain.OptionsBehavior.EnableFiltering = true;
            this.treeListMain.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMain.OptionsLayout.LayoutVersion = "1";
            this.treeListMain.OptionsNavigation.AutoMoveRowFocus = true;
            this.treeListMain.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeListMain.OptionsView.AutoWidth = false;
            this.treeListMain.OptionsView.ShowAutoFilterRow = true;
            this.treeListMain.ParentFieldName = "DSCategoryParent";
            this.treeListMain.SelectImageList = this.imageCollectionNormal;
            this.treeListMain.Size = new System.Drawing.Size(347, 273);
            this.treeListMain.TabIndex = 11;
            this.treeListMain.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListMain_AfterExpand);
            this.treeListMain.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMain_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "DSCategoryName";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 98;
            // 
            // colDSCategoryDesc
            // 
            this.colDSCategoryDesc.Caption = "Description";
            this.colDSCategoryDesc.FieldName = "DSCategoryDesc";
            this.colDSCategoryDesc.Name = "colDSCategoryDesc";
            this.colDSCategoryDesc.Visible = true;
            this.colDSCategoryDesc.VisibleIndex = 1;
            this.colDSCategoryDesc.Width = 98;
            // 
            // LSMSCategory
            // 
            this.LSMSCategory.ElementType = typeof(NICSQLTools.Data.Linq.vAppDSCategory);
            this.LSMSCategory.KeyExpression = "[DSCategoryId]";
            // 
            // imageCollectionNormal
            // 
            this.imageCollectionNormal.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNormal.ImageStream")));
            this.imageCollectionNormal.InsertImage(global::NICSQLTools.Properties.Resources.open_16x16, "open_16x16", typeof(global::NICSQLTools.Properties.Resources), 0);
            this.imageCollectionNormal.Images.SetKeyName(0, "open_16x16");
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDateIn,
            this.repositoryItemButtonEditSelect,
            this.repositoryItemButtonEditDSInfo,
            this.repositoryItemCheckEditEnable});
            this.gridControlMain.Size = new System.Drawing.Size(342, 273);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnableRule,
            this.gridColumnHelp,
            this.colDashboardSchemaName,
            this.colUserIn,
            this.colDateIn});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.ShowIndicator = false;
            this.gridViewMain.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewMain_RowUpdated);
            // 
            // colEnableRule
            // 
            this.colEnableRule.FieldName = "EnableRule";
            this.colEnableRule.Name = "colEnableRule";
            this.colEnableRule.Visible = true;
            this.colEnableRule.VisibleIndex = 0;
            // 
            // gridColumnHelp
            // 
            this.gridColumnHelp.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnHelp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnHelp.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnHelp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnHelp.Caption = "Help";
            this.gridColumnHelp.ColumnEdit = this.repositoryItemButtonEditDSInfo;
            this.gridColumnHelp.Name = "gridColumnHelp";
            this.gridColumnHelp.Visible = true;
            this.gridColumnHelp.VisibleIndex = 1;
            // 
            // repositoryItemButtonEditDSInfo
            // 
            this.repositoryItemButtonEditDSInfo.AutoHeight = false;
            this.repositoryItemButtonEditDSInfo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Help", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, global::NICSQLTools.Properties.Resources.info_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Show Information About This Object", null, null, true)});
            this.repositoryItemButtonEditDSInfo.Name = "repositoryItemButtonEditDSInfo";
            this.repositoryItemButtonEditDSInfo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDSInfo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDSInfo_ButtonClick);
            // 
            // colDashboardSchemaName
            // 
            this.colDashboardSchemaName.AppearanceCell.Options.UseTextOptions = true;
            this.colDashboardSchemaName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDashboardSchemaName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDashboardSchemaName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDashboardSchemaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDashboardSchemaName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDashboardSchemaName.Caption = "Name";
            this.colDashboardSchemaName.FieldName = "DatasourceName";
            this.colDashboardSchemaName.Name = "colDashboardSchemaName";
            this.colDashboardSchemaName.Visible = true;
            this.colDashboardSchemaName.VisibleIndex = 2;
            this.colDashboardSchemaName.Width = 156;
            // 
            // colUserIn
            // 
            this.colUserIn.AppearanceCell.Options.UseTextOptions = true;
            this.colUserIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUserIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUserIn.Caption = "Last Edit User";
            this.colUserIn.FieldName = "RealName";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 3;
            this.colUserIn.Width = 132;
            // 
            // colDateIn
            // 
            this.colDateIn.AppearanceCell.Options.UseTextOptions = true;
            this.colDateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDateIn.Caption = "Edit Date";
            this.colDateIn.ColumnEdit = this.repositoryItemDateEditDateIn;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 4;
            this.colDateIn.Width = 135;
            // 
            // repositoryItemDateEditDateIn
            // 
            this.repositoryItemDateEditDateIn.AutoHeight = false;
            this.repositoryItemDateEditDateIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateIn.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateIn.DisplayFormat.FormatString = "f";
            this.repositoryItemDateEditDateIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateIn.EditFormat.FormatString = "f";
            this.repositoryItemDateEditDateIn.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateIn.Mask.EditMask = "d/M/yyyy HH:mm:ss";
            this.repositoryItemDateEditDateIn.Name = "repositoryItemDateEditDateIn";
            // 
            // repositoryItemButtonEditSelect
            // 
            this.repositoryItemButtonEditSelect.AutoHeight = false;
            this.repositoryItemButtonEditSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, global::NICSQLTools.Properties.Resources.apply_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEditSelect.Name = "repositoryItemButtonEditSelect";
            this.repositoryItemButtonEditSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemCheckEditEnable
            // 
            this.repositoryItemCheckEditEnable.AutoHeight = false;
            this.repositoryItemCheckEditEnable.Name = "repositoryItemCheckEditEnable";
            // 
            // XPSCSDS
            // 
            this.XPSCSDS.AllowEdit = true;
            this.XPSCSDS.Session = this.UOWDS;
            this.XPSCSDS.TrackChanges = true;
            // 
            // UOWDS
            // 
            this.UOWDS.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOWDS.TrackPropertiesModifications = false;
            // 
            // appRuleDatasourceForRuleBindingSource
            // 
            this.appRuleDatasourceForRuleBindingSource.DataMember = "AppRuleDatasourceForRule";
            this.appRuleDatasourceForRuleBindingSource.DataSource = this.dsData;
            // 
            // appRuleDatasourceTableAdapter
            // 
            this.appRuleDatasourceTableAdapter.ClearBeforeFill = true;
            // 
            // appRuleDatasourceForRuleTableAdapter
            // 
            this.appRuleDatasourceForRuleTableAdapter.ClearBeforeFill = true;
            // 
            // RuleDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RuleDetailsUC";
            this.Size = new System.Drawing.Size(700, 332);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesLUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageUI.ResumeLayout(false);
            this.xtraTabPageDatasource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDSInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appRuleDatasourceForRuleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private NICSQLTools.Data.dsData dsData;
        private NICSQLTools.Data.dsQry dsQry;
        private System.Windows.Forms.BindingSource rulesLUEBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.Rules_LUETableAdapter rules_LUETableAdapter;
        private DevExpress.XtraTreeList.TreeList TLItems;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcSelect;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcInsert;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcUpdate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private NICSQLTools.Data.dsDataTableAdapters.AppRuleDetailTableAdapter ruleDetailTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraBars.BarEditItem bbiRule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUI;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDatasource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryDesc;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHelp;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDSInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDateIn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCategory;
        private DevExpress.Utils.ImageCollection imageCollectionNormal;
        private NICSQLTools.Data.dsDataTableAdapters.AppRuleDatasourceTableAdapter appRuleDatasourceTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditEnable;
        private System.Windows.Forms.BindingSource appRuleDatasourceForRuleBindingSource;
        private NICSQLTools.Data.dsDataTableAdapters.AppRuleDatasourceForRuleTableAdapter appRuleDatasourceForRuleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEnableRule;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSDS;
        private DevExpress.Xpo.UnitOfWork UOWDS;
    }
}
