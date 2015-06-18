namespace NICSQLTools.Views.Data
{
    partial class AppDatasourceUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDatasourceUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDSCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTreeListLookUpEditDSCategoryId = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.LSMSAppDSCategory = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colDSCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDSCategoryDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollectionCategoryNodes = new DevExpress.Utils.ImageCollection(this.components);
            this.colDatasourceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasourceSPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppDatasourceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAppDatasourceTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSAppDatasourceType = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditDesc = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemMemoExEditMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditDSCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDSCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCategoryNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAppDatasourceTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDSCategoryId,
            this.colDatasourceName,
            this.colDatasourceSPName,
            this.colAppDatasourceTypeId,
            this.colDesc});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colDSCategoryId
            // 
            this.colDSCategoryId.Caption = "Category";
            this.colDSCategoryId.ColumnEdit = this.repositoryItemTreeListLookUpEditDSCategoryId;
            this.colDSCategoryId.FieldName = "DSCategoryId";
            this.colDSCategoryId.Name = "colDSCategoryId";
            this.colDSCategoryId.Visible = true;
            this.colDSCategoryId.VisibleIndex = 0;
            this.colDSCategoryId.Width = 94;
            // 
            // repositoryItemTreeListLookUpEditDSCategoryId
            // 
            this.repositoryItemTreeListLookUpEditDSCategoryId.AutoHeight = false;
            this.repositoryItemTreeListLookUpEditDSCategoryId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEditDSCategoryId.DataSource = this.LSMSAppDSCategory;
            this.repositoryItemTreeListLookUpEditDSCategoryId.DisplayMember = "DSCategoryName";
            this.repositoryItemTreeListLookUpEditDSCategoryId.Name = "repositoryItemTreeListLookUpEditDSCategoryId";
            this.repositoryItemTreeListLookUpEditDSCategoryId.NullText = "";
            this.repositoryItemTreeListLookUpEditDSCategoryId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemTreeListLookUpEditDSCategoryId.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            this.repositoryItemTreeListLookUpEditDSCategoryId.ValueMember = "DSCategoryId";
            // 
            // LSMSAppDSCategory
            // 
            this.LSMSAppDSCategory.ElementType = typeof(NICSQLTools.Data.Linq.vAppDSCategory);
            this.LSMSAppDSCategory.KeyExpression = "[DSCategoryId]";
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDSCategoryName,
            this.colDSCategoryDesc});
            this.repositoryItemTreeListLookUpEdit1TreeList.DataSource = this.LSMSAppDSCategory;
            this.repositoryItemTreeListLookUpEdit1TreeList.KeyFieldName = "DSCategoryId";
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.ParentFieldName = "DSCategoryParent";
            this.repositoryItemTreeListLookUpEdit1TreeList.SelectImageList = this.imageCollectionCategoryNodes;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colDSCategoryName
            // 
            this.colDSCategoryName.Caption = "Category Name";
            this.colDSCategoryName.FieldName = "DSCategoryName";
            this.colDSCategoryName.MinWidth = 33;
            this.colDSCategoryName.Name = "colDSCategoryName";
            this.colDSCategoryName.Visible = true;
            this.colDSCategoryName.VisibleIndex = 0;
            // 
            // colDSCategoryDesc
            // 
            this.colDSCategoryDesc.Caption = "Category Description";
            this.colDSCategoryDesc.FieldName = "DSCategoryDesc";
            this.colDSCategoryDesc.Name = "colDSCategoryDesc";
            this.colDSCategoryDesc.Visible = true;
            this.colDSCategoryDesc.VisibleIndex = 1;
            // 
            // imageCollectionCategoryNodes
            // 
            this.imageCollectionCategoryNodes.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCategoryNodes.ImageStream")));
            this.imageCollectionCategoryNodes.InsertImage(global::NICSQLTools.Properties.Resources.open_16x16, "open_16x16", typeof(global::NICSQLTools.Properties.Resources), 0);
            this.imageCollectionCategoryNodes.Images.SetKeyName(0, "open_16x16");
            // 
            // colDatasourceName
            // 
            this.colDatasourceName.Caption = "Datasource Name";
            this.colDatasourceName.FieldName = "DatasourceName";
            this.colDatasourceName.Name = "colDatasourceName";
            this.colDatasourceName.Visible = true;
            this.colDatasourceName.VisibleIndex = 1;
            this.colDatasourceName.Width = 208;
            // 
            // colDatasourceSPName
            // 
            this.colDatasourceSPName.Caption = "Datasource Stored Procedure Name";
            this.colDatasourceSPName.FieldName = "DatasourceSPName";
            this.colDatasourceSPName.Name = "colDatasourceSPName";
            this.colDatasourceSPName.Visible = true;
            this.colDatasourceSPName.VisibleIndex = 2;
            this.colDatasourceSPName.Width = 231;
            // 
            // colAppDatasourceTypeId
            // 
            this.colAppDatasourceTypeId.Caption = "Datasource Type";
            this.colAppDatasourceTypeId.ColumnEdit = this.repositoryItemLookUpEditAppDatasourceTypeId;
            this.colAppDatasourceTypeId.FieldName = "AppDatasourceTypeId";
            this.colAppDatasourceTypeId.Name = "colAppDatasourceTypeId";
            this.colAppDatasourceTypeId.Visible = true;
            this.colAppDatasourceTypeId.VisibleIndex = 3;
            this.colAppDatasourceTypeId.Width = 114;
            // 
            // repositoryItemLookUpEditAppDatasourceTypeId
            // 
            this.repositoryItemLookUpEditAppDatasourceTypeId.AutoHeight = false;
            this.repositoryItemLookUpEditAppDatasourceTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAppDatasourceTypeId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AppDatasourceTypeName", "Datasource Type", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAppDatasourceTypeId.DataSource = this.LSMSAppDatasourceType;
            this.repositoryItemLookUpEditAppDatasourceTypeId.DisplayMember = "AppDatasourceTypeName";
            this.repositoryItemLookUpEditAppDatasourceTypeId.Name = "repositoryItemLookUpEditAppDatasourceTypeId";
            this.repositoryItemLookUpEditAppDatasourceTypeId.NullText = "";
            this.repositoryItemLookUpEditAppDatasourceTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAppDatasourceTypeId.ValueMember = "AppDatasourceTypeId";
            // 
            // LSMSAppDatasourceType
            // 
            this.LSMSAppDatasourceType.ElementType = typeof(NICSQLTools.Data.Linq.AppDatasourceType_LUE);
            this.LSMSAppDatasourceType.KeyExpression = "[AppDatasourceTypeId]";
            // 
            // colDesc
            // 
            this.colDesc.Caption = "Description";
            this.colDesc.ColumnEdit = this.repositoryItemMemoExEditDesc;
            this.colDesc.FieldName = "Desc";
            this.colDesc.Name = "colDesc";
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 4;
            // 
            // repositoryItemMemoExEditDesc
            // 
            this.repositoryItemMemoExEditDesc.AutoHeight = false;
            this.repositoryItemMemoExEditDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditDesc.Name = "repositoryItemMemoExEditDesc";
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEditMemo,
            this.repositoryItemMemoExEditDesc,
            this.repositoryItemLookUpEditAppDatasourceTypeId,
            this.repositoryItemTreeListLookUpEditDSCategoryId});
            this.gridControlMain.Size = new System.Drawing.Size(766, 360);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
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
            this.barDockControlTop.Size = new System.Drawing.Size(766, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(766, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 360);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(766, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
            // 
            // repositoryItemMemoExEditMemo
            // 
            this.repositoryItemMemoExEditMemo.AutoHeight = false;
            this.repositoryItemMemoExEditMemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditMemo.Name = "repositoryItemMemoExEditMemo";
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsDataSource.AppDatasourceDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // AppDatasourceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AppDatasourceUC";
            this.Size = new System.Drawing.Size(766, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditDSCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDSCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCategoryNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAppDatasourceTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceSPName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colAppDatasourceTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAppDatasourceTypeId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAppDatasourceType;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAppDSCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colDSCategoryId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEditDSCategoryId;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryDesc;
        private DevExpress.Utils.ImageCollection imageCollectionCategoryNodes;
    }
}
