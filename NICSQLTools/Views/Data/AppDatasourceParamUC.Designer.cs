namespace NICSQLTools.Views.Data
{
    partial class AppDatasourceParamUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDatasourceParamUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatasourceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditDatasourceID = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSDatasource = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatasourceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppDatasourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasourceSPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPramName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPramDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDatasourceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDatasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatasourceID,
            this.colPramName,
            this.colPramDisplayName});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "Click here to add a new customer";
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
            // colDatasourceID
            // 
            this.colDatasourceID.Caption = "Data Source";
            this.colDatasourceID.ColumnEdit = this.repositoryItemGridLookUpEditDatasourceID;
            this.colDatasourceID.FieldName = "DatasourceID";
            this.colDatasourceID.Name = "colDatasourceID";
            this.colDatasourceID.Visible = true;
            this.colDatasourceID.VisibleIndex = 0;
            this.colDatasourceID.Width = 109;
            // 
            // repositoryItemGridLookUpEditDatasourceID
            // 
            this.repositoryItemGridLookUpEditDatasourceID.AutoHeight = false;
            this.repositoryItemGridLookUpEditDatasourceID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditDatasourceID.DataSource = this.LSMSDatasource;
            this.repositoryItemGridLookUpEditDatasourceID.DisplayMember = "DatasourceName";
            this.repositoryItemGridLookUpEditDatasourceID.Name = "repositoryItemGridLookUpEditDatasourceID";
            this.repositoryItemGridLookUpEditDatasourceID.NullText = "";
            this.repositoryItemGridLookUpEditDatasourceID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditDatasourceID.ValueMember = "DatasourceID";
            this.repositoryItemGridLookUpEditDatasourceID.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSDatasource
            // 
            this.LSMSDatasource.ElementType = typeof(NICSQLTools.Data.Linq.vAppDatasource_LUE);
            this.LSMSDatasource.KeyExpression = "[DatasourceID]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatasourceName,
            this.colAppDatasourceType,
            this.colDatasourceSPName});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDatasourceName
            // 
            this.colDatasourceName.Caption = "Data Source Display Name";
            this.colDatasourceName.FieldName = "DatasourceName";
            this.colDatasourceName.Name = "colDatasourceName";
            this.colDatasourceName.Visible = true;
            this.colDatasourceName.VisibleIndex = 0;
            // 
            // colAppDatasourceType
            // 
            this.colAppDatasourceType.Caption = "Datasource Type";
            this.colAppDatasourceType.FieldName = "AppDatasourceTypeName";
            this.colAppDatasourceType.Name = "colAppDatasourceType";
            this.colAppDatasourceType.Visible = true;
            this.colAppDatasourceType.VisibleIndex = 2;
            // 
            // colDatasourceSPName
            // 
            this.colDatasourceSPName.Caption = "Data Source SQL Name";
            this.colDatasourceSPName.FieldName = "DatasourceSPName";
            this.colDatasourceSPName.Name = "colDatasourceSPName";
            this.colDatasourceSPName.Visible = true;
            this.colDatasourceSPName.VisibleIndex = 1;
            // 
            // colPramName
            // 
            this.colPramName.Caption = "Parameter Name";
            this.colPramName.FieldName = "ParamName";
            this.colPramName.Name = "colPramName";
            this.colPramName.Visible = true;
            this.colPramName.VisibleIndex = 1;
            this.colPramName.Width = 94;
            // 
            // colPramDisplayName
            // 
            this.colPramDisplayName.Caption = "Parameter Display Name";
            this.colPramDisplayName.FieldName = "ParamDisplayName";
            this.colPramDisplayName.Name = "colPramDisplayName";
            this.colPramDisplayName.Visible = true;
            this.colPramDisplayName.VisibleIndex = 2;
            this.colPramDisplayName.Width = 136;
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
            this.repositoryItemGridLookUpEditDatasourceID});
            this.gridControlMain.Size = new System.Drawing.Size(679, 360);
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
            this.barDockControlTop.Size = new System.Drawing.Size(679, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(679, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(679, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData.AppDatasourceParamDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // AppDatasourceParamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AppDatasourceParamUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditDatasourceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDatasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceID;
        private DevExpress.XtraGrid.Columns.GridColumn colPramName;
        private DevExpress.XtraGrid.Columns.GridColumn colPramDisplayName;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditDatasourceID;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceSPName;
        private DevExpress.XtraGrid.Columns.GridColumn colAppDatasourceType;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDatasource;
    }
}
