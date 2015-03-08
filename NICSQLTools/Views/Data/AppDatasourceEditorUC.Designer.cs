namespace NICSQLTools.Views.Data
{
    partial class AppDatasourceEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDatasourceEditorUC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAddNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.XPSCSCat = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionCat = new DevExpress.Xpo.Session(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.colDSCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDSCategoryDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollectionNormal = new DevExpress.Utils.ImageCollection(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlDS = new DevExpress.XtraGrid.GridControl();
            this.XPSCSDS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionDS = new DevExpress.Xpo.Session(this.components);
            this.gridViewDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatasourceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasourceSPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppDatasourceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAppDatasourceTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSAppDatasourceType = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditDesc = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridControlParam = new DevExpress.XtraGrid.GridControl();
            this.XPSCSParam = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionParam = new DevExpress.Xpo.Session(this.components);
            this.gridViewParam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPramName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPramDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcParamDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditParamDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAppDatasourceTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParamDel)).BeginInit();
            this.SuspendLayout();
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
            this.bbiExport,
            this.bbiRefresh,
            this.bbiAddNode,
            this.bbiDeleteNode});
            this.barManagerMain.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiAddNode
            // 
            this.bbiAddNode.Caption = "Add Node";
            this.bbiAddNode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.Glyph")));
            this.bbiAddNode.Id = 3;
            this.bbiAddNode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.LargeGlyph")));
            this.bbiAddNode.Name = "bbiAddNode";
            this.bbiAddNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAddNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNode_ItemClick);
            // 
            // bbiDeleteNode
            // 
            this.bbiDeleteNode.Caption = "Delete Node";
            this.bbiDeleteNode.Glyph = global::NICSQLTools.Properties.Resources.cancel_16x16;
            this.bbiDeleteNode.Id = 4;
            this.bbiDeleteNode.Name = "bbiDeleteNode";
            this.bbiDeleteNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDeleteNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteNode_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::NICSQLTools.Properties.Resources.up_32x32;
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
            this.barDockControlTop.Size = new System.Drawing.Size(927, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Size = new System.Drawing.Size(927, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(927, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // XPSCSCat
            // 
            this.XPSCSCat.AllowEdit = true;
            this.XPSCSCat.AllowNew = true;
            this.XPSCSCat.AllowRemove = true;
            this.XPSCSCat.DeleteObjectOnRemove = true;
            this.XPSCSCat.ObjectType = typeof(NICSQLTools.Data.dsData.AppDSCategoryDataTable);
            this.XPSCSCat.Session = this.sessionCat;
            // 
            // sessionCat
            // 
            this.sessionCat.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionCat.TrackPropertiesModifications = false;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDSCategoryName,
            this.colDSCategoryDesc});
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced;
            this.treeListMain.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;
            this.treeListMain.KeyFieldName = "DSCategoryId";
            this.treeListMain.Location = new System.Drawing.Point(0, 0);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.treeListMain.OptionsBehavior.DragNodes = true;
            this.treeListMain.OptionsBehavior.EnableFiltering = true;
            this.treeListMain.OptionsBehavior.ImmediateEditor = false;
            this.treeListMain.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.treeListMain.OptionsLayout.LayoutVersion = "1";
            this.treeListMain.OptionsNavigation.AutoFocusNewNode = true;
            this.treeListMain.OptionsNavigation.AutoMoveRowFocus = true;
            this.treeListMain.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeListMain.OptionsView.AutoWidth = false;
            this.treeListMain.OptionsView.ShowAutoFilterRow = true;
            this.treeListMain.ParentFieldName = "DSCategoryParent";
            this.treeListMain.SelectImageList = this.imageCollectionNormal;
            this.treeListMain.Size = new System.Drawing.Size(450, 419);
            this.treeListMain.TabIndex = 10;
            this.treeListMain.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMain_FocusedNodeChanged);
            // 
            // colDSCategoryName
            // 
            this.colDSCategoryName.Caption = "Category Name";
            this.colDSCategoryName.FieldName = "DSCategoryName";
            this.colDSCategoryName.MinWidth = 34;
            this.colDSCategoryName.Name = "colDSCategoryName";
            this.colDSCategoryName.Visible = true;
            this.colDSCategoryName.VisibleIndex = 0;
            this.colDSCategoryName.Width = 133;
            // 
            // colDSCategoryDesc
            // 
            this.colDSCategoryDesc.Caption = "Category Description";
            this.colDSCategoryDesc.FieldName = "DSCategoryDesc";
            this.colDSCategoryDesc.Name = "colDSCategoryDesc";
            this.colDSCategoryDesc.Visible = true;
            this.colDSCategoryDesc.VisibleIndex = 1;
            this.colDSCategoryDesc.Width = 132;
            // 
            // imageCollectionNormal
            // 
            this.imageCollectionNormal.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNormal.ImageStream")));
            this.imageCollectionNormal.InsertImage(global::NICSQLTools.Properties.Resources.open_16x16, "open_16x16", typeof(global::NICSQLTools.Properties.Resources), 0);
            this.imageCollectionNormal.Images.SetKeyName(0, "open_16x16");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(927, 419);
            this.splitContainerControl1.SplitterPosition = 450;
            this.splitContainerControl1.TabIndex = 15;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControlDS);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlParam);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(472, 419);
            this.splitContainerControl2.SplitterPosition = 199;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControlDS
            // 
            this.gridControlDS.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDS.DataSource = this.XPSCSDS;
            this.gridControlDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDS.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlDS_EmbeddedNavigator_ButtonClick);
            this.gridControlDS.Location = new System.Drawing.Point(0, 0);
            this.gridControlDS.MainView = this.gridViewDS;
            this.gridControlDS.MenuManager = this.barManagerMain;
            this.gridControlDS.Name = "gridControlDS";
            this.gridControlDS.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEditDesc,
            this.repositoryItemLookUpEditAppDatasourceTypeId});
            this.gridControlDS.Size = new System.Drawing.Size(472, 199);
            this.gridControlDS.TabIndex = 6;
            this.gridControlDS.UseEmbeddedNavigator = true;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // XPSCSDS
            // 
            this.XPSCSDS.AllowEdit = true;
            this.XPSCSDS.AllowNew = true;
            this.XPSCSDS.AllowRemove = true;
            this.XPSCSDS.DeleteObjectOnRemove = true;
            this.XPSCSDS.FixedFilterString = "[DSCategoryId] = -1";
            this.XPSCSDS.ObjectType = typeof(NICSQLTools.Data.dsData.AppDatasourceDataTable);
            this.XPSCSDS.Session = this.sessionDS;
            // 
            // sessionDS
            // 
            this.sessionDS.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionDS.TrackPropertiesModifications = false;
            this.sessionDS.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionDS_BeforeCommitTransaction);
            // 
            // gridViewDS
            // 
            this.gridViewDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatasourceName,
            this.colDatasourceSPName,
            this.colAppDatasourceTypeId,
            this.colDesc});
            this.gridViewDS.GridControl = this.gridControlDS;
            this.gridViewDS.Name = "gridViewDS";
            this.gridViewDS.NewItemRowText = "Click here to add a new";
            this.gridViewDS.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewDS.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewDS.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewDS.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewDS.OptionsImageLoad.AsyncLoad = true;
            this.gridViewDS.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewDS.OptionsSelection.InvertSelection = true;
            this.gridViewDS.OptionsSelection.MultiSelect = true;
            this.gridViewDS.OptionsView.ColumnAutoWidth = false;
            this.gridViewDS.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewDS.OptionsView.ShowDetailButtons = false;
            this.gridViewDS.OptionsView.ShowGroupPanel = false;
            this.gridViewDS.OptionsView.ShowViewCaption = true;
            this.gridViewDS.ViewCaption = "DataSource View";
            this.gridViewDS.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDS_RowCellClick);
            this.gridViewDS.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewDS_InitNewRow);
            // 
            // colDatasourceName
            // 
            this.colDatasourceName.Caption = "Datasource Name";
            this.colDatasourceName.FieldName = "DatasourceName";
            this.colDatasourceName.Name = "colDatasourceName";
            this.colDatasourceName.Visible = true;
            this.colDatasourceName.VisibleIndex = 0;
            this.colDatasourceName.Width = 208;
            // 
            // colDatasourceSPName
            // 
            this.colDatasourceSPName.Caption = "Datasource Stored Procedure Name";
            this.colDatasourceSPName.FieldName = "DatasourceSPName";
            this.colDatasourceSPName.Name = "colDatasourceSPName";
            this.colDatasourceSPName.Visible = true;
            this.colDatasourceSPName.VisibleIndex = 1;
            this.colDatasourceSPName.Width = 231;
            // 
            // colAppDatasourceTypeId
            // 
            this.colAppDatasourceTypeId.Caption = "Datasource Type";
            this.colAppDatasourceTypeId.ColumnEdit = this.repositoryItemLookUpEditAppDatasourceTypeId;
            this.colAppDatasourceTypeId.FieldName = "AppDatasourceTypeId";
            this.colAppDatasourceTypeId.Name = "colAppDatasourceTypeId";
            this.colAppDatasourceTypeId.Visible = true;
            this.colAppDatasourceTypeId.VisibleIndex = 2;
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
            this.colDesc.VisibleIndex = 3;
            // 
            // repositoryItemMemoExEditDesc
            // 
            this.repositoryItemMemoExEditDesc.AutoHeight = false;
            this.repositoryItemMemoExEditDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditDesc.Name = "repositoryItemMemoExEditDesc";
            // 
            // gridControlParam
            // 
            this.gridControlParam.DataSource = this.XPSCSParam;
            this.gridControlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParam.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlParam_EmbeddedNavigator_ButtonClick);
            this.gridControlParam.Location = new System.Drawing.Point(0, 0);
            this.gridControlParam.MainView = this.gridViewParam;
            this.gridControlParam.MenuManager = this.barManagerMain;
            this.gridControlParam.Name = "gridControlParam";
            this.gridControlParam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditParamDel});
            this.gridControlParam.Size = new System.Drawing.Size(472, 215);
            this.gridControlParam.TabIndex = 6;
            this.gridControlParam.UseEmbeddedNavigator = true;
            this.gridControlParam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParam});
            // 
            // XPSCSParam
            // 
            this.XPSCSParam.AllowEdit = true;
            this.XPSCSParam.AllowNew = true;
            this.XPSCSParam.AllowRemove = true;
            this.XPSCSParam.DeleteObjectOnRemove = true;
            this.XPSCSParam.FixedFilterString = "[AppDatasourceParamID] = -1";
            this.XPSCSParam.ObjectType = typeof(NICSQLTools.Data.dsData.AppDatasourceParamDataTable);
            this.XPSCSParam.Session = this.sessionParam;
            // 
            // sessionParam
            // 
            this.sessionParam.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionParam.TrackPropertiesModifications = false;
            this.sessionParam.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionParam_BeforeCommitTransaction);
            // 
            // gridViewParam
            // 
            this.gridViewParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcParamDel,
            this.colPramName,
            this.colPramDisplayName});
            this.gridViewParam.GridControl = this.gridControlParam;
            this.gridViewParam.Name = "gridViewParam";
            this.gridViewParam.NewItemRowText = "Click here to add a new";
            this.gridViewParam.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewParam.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewParam.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewParam.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewParam.OptionsImageLoad.AsyncLoad = true;
            this.gridViewParam.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewParam.OptionsSelection.InvertSelection = true;
            this.gridViewParam.OptionsSelection.MultiSelect = true;
            this.gridViewParam.OptionsView.ColumnAutoWidth = false;
            this.gridViewParam.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewParam.OptionsView.ShowDetailButtons = false;
            this.gridViewParam.OptionsView.ShowGroupPanel = false;
            this.gridViewParam.OptionsView.ShowViewCaption = true;
            this.gridViewParam.ViewCaption = "Paramters View";
            this.gridViewParam.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewParam_InitNewRow);
            // 
            // colPramName
            // 
            this.colPramName.Caption = "Parameter Name";
            this.colPramName.FieldName = "ParamName";
            this.colPramName.Name = "colPramName";
            this.colPramName.Visible = true;
            this.colPramName.VisibleIndex = 0;
            this.colPramName.Width = 94;
            // 
            // colPramDisplayName
            // 
            this.colPramDisplayName.Caption = "Parameter Display Name";
            this.colPramDisplayName.FieldName = "ParamDisplayName";
            this.colPramDisplayName.Name = "colPramDisplayName";
            this.colPramDisplayName.Visible = true;
            this.colPramDisplayName.VisibleIndex = 1;
            this.colPramDisplayName.Width = 136;
            // 
            // gcParamDel
            // 
            this.gcParamDel.AppearanceCell.Options.UseTextOptions = true;
            this.gcParamDel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcParamDel.AppearanceHeader.Options.UseTextOptions = true;
            this.gcParamDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcParamDel.Caption = "Delete";
            this.gcParamDel.ColumnEdit = this.repositoryItemButtonEditParamDel;
            this.gcParamDel.Name = "gcParamDel";
            this.gcParamDel.OptionsColumn.TabStop = false;
            this.gcParamDel.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gcParamDel.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // repositoryItemButtonEditParamDel
            // 
            this.repositoryItemButtonEditParamDel.AutoHeight = false;
            this.repositoryItemButtonEditParamDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditParamDel.Name = "repositoryItemButtonEditParamDel";
            this.repositoryItemButtonEditParamDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditParamDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditParamDel_ButtonClick);
            // 
            // AppDatasourceEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AppDatasourceEditorUC";
            this.Size = new System.Drawing.Size(927, 450);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAppDatasourceTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParamDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSCat;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryDesc;
        private DevExpress.XtraBars.BarButtonItem bbiAddNode;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteNode;
        private DevExpress.Xpo.Session sessionCat;
        private DevExpress.Utils.ImageCollection imageCollectionNormal;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControlDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDS;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceSPName;
        private DevExpress.XtraGrid.Columns.GridColumn colAppDatasourceTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAppDatasourceTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditDesc;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSDS;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAppDatasourceType;
        private DevExpress.XtraGrid.GridControl gridControlParam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParam;
        private DevExpress.XtraGrid.Columns.GridColumn colPramName;
        private DevExpress.XtraGrid.Columns.GridColumn colPramDisplayName;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSParam;
        private DevExpress.Xpo.Session sessionDS;
        private DevExpress.Xpo.Session sessionParam;
        private DevExpress.XtraGrid.Columns.GridColumn gcParamDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditParamDel;
    }
}
