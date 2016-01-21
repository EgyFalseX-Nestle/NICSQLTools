namespace NICSQLTools.Views.Data.MSrv
{
    partial class MSrv_TechnicianSalesDistrictUC
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRuleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditTechnicianId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.mSrvTechnicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMSrc = new NICSQLTools.Data.dsMSrc();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechnicianName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDistrict3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSalesDistrict3Id = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.salesDistrictInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesDistrict2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.mSrvTechnicianSalesDistrictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dsData = new NICSQLTools.Data.dsData();
            this.LSMSSalesDistrict3 = new DevExpress.Data.Linq.LinqServerModeSource();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.salesDistrictInfoTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.SalesDistrictInfoTableAdapter();
            this.mSrv_TechnicianSalesDistrictTableAdapter = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TechnicianSalesDistrictTableAdapter();
            this.mSrv_TechnicianTableAdapter = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TechnicianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTechnicianId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvTechnicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrictInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvTechnicianSalesDistrictBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDel,
            this.colRuleId,
            this.colSalesDistrict3Id});
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
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
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
            // colRuleId
            // 
            this.colRuleId.AppearanceCell.Options.UseTextOptions = true;
            this.colRuleId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRuleId.AppearanceHeader.Options.UseTextOptions = true;
            this.colRuleId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRuleId.Caption = "Technician";
            this.colRuleId.ColumnEdit = this.repositoryItemGridLookUpEditTechnicianId;
            this.colRuleId.FieldName = "TechnicianId";
            this.colRuleId.Name = "colRuleId";
            this.colRuleId.Visible = true;
            this.colRuleId.VisibleIndex = 0;
            this.colRuleId.Width = 95;
            // 
            // repositoryItemGridLookUpEditTechnicianId
            // 
            this.repositoryItemGridLookUpEditTechnicianId.AutoHeight = false;
            this.repositoryItemGridLookUpEditTechnicianId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditTechnicianId.DataSource = this.mSrvTechnicianBindingSource;
            this.repositoryItemGridLookUpEditTechnicianId.DisplayMember = "TechnicianName";
            this.repositoryItemGridLookUpEditTechnicianId.Name = "repositoryItemGridLookUpEditTechnicianId";
            this.repositoryItemGridLookUpEditTechnicianId.NullText = "";
            this.repositoryItemGridLookUpEditTechnicianId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditTechnicianId.ValueMember = "TechnicianId";
            this.repositoryItemGridLookUpEditTechnicianId.View = this.gridView1;
            // 
            // mSrvTechnicianBindingSource
            // 
            this.mSrvTechnicianBindingSource.DataMember = "MSrv_Technician";
            this.mSrvTechnicianBindingSource.DataSource = this.dsMSrc;
            // 
            // dsMSrc
            // 
            this.dsMSrc.DataSetName = "dsMSrc";
            this.dsMSrc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTechnicianName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTechnicianName
            // 
            this.colTechnicianName.Caption = "Name";
            this.colTechnicianName.FieldName = "TechnicianName";
            this.colTechnicianName.Name = "colTechnicianName";
            this.colTechnicianName.Visible = true;
            this.colTechnicianName.VisibleIndex = 0;
            // 
            // colSalesDistrict3Id
            // 
            this.colSalesDistrict3Id.AppearanceCell.Options.UseTextOptions = true;
            this.colSalesDistrict3Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesDistrict3Id.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesDistrict3Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesDistrict3Id.Caption = "Sales District 2";
            this.colSalesDistrict3Id.ColumnEdit = this.repositoryItemGridLookUpEditSalesDistrict3Id;
            this.colSalesDistrict3Id.FieldName = "SalesDistrict3Id";
            this.colSalesDistrict3Id.Name = "colSalesDistrict3Id";
            this.colSalesDistrict3Id.Visible = true;
            this.colSalesDistrict3Id.VisibleIndex = 1;
            this.colSalesDistrict3Id.Width = 132;
            // 
            // repositoryItemGridLookUpEditSalesDistrict3Id
            // 
            this.repositoryItemGridLookUpEditSalesDistrict3Id.AutoHeight = false;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DataSource = this.salesDistrictInfoBindingSource;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DisplayMember = "Sales District 2";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Name = "repositoryItemGridLookUpEditSalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.NullText = "";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.ValueMember = "SalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // salesDistrictInfoBindingSource
            // 
            this.salesDistrictInfoBindingSource.DataMember = "SalesDistrictInfo";
            this.salesDistrictInfoBindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesDistrict2});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSalesDistrict2
            // 
            this.colSalesDistrict2.FieldName = "Sales District 2";
            this.colSalesDistrict2.Name = "colSalesDistrict2";
            this.colSalesDistrict2.Visible = true;
            this.colSalesDistrict2.VisibleIndex = 0;
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMain.DataSource = this.mSrvTechnicianSalesDistrictBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditSalesDistrict3Id,
            this.repositoryItemGridLookUpEditTechnicianId,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.Size = new System.Drawing.Size(679, 360);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // mSrvTechnicianSalesDistrictBindingSource
            // 
            this.mSrvTechnicianSalesDistrictBindingSource.DataMember = "MSrv_TechnicianSalesDistrict";
            this.mSrvTechnicianSalesDistrictBindingSource.DataSource = this.dsMSrc;
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
            this.bar1.FloatLocation = new System.Drawing.Point(233, 125);
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
            this.bbiSave.LargeGlyph = global::NICSQLTools.Properties.Resources.saveall_32x32;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::NICSQLTools.Properties.Resources.refresh2_32x32;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LSMSSalesDistrict3
            // 
            this.LSMSSalesDistrict3.ElementType = typeof(NICSQLTools.Data.Linq.vRouteDetail);
            this.LSMSSalesDistrict3.KeyExpression = "[SalesDistrict3Id]";
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // salesDistrictInfoTableAdapter
            // 
            this.salesDistrictInfoTableAdapter.ClearBeforeFill = true;
            // 
            // mSrv_TechnicianSalesDistrictTableAdapter
            // 
            this.mSrv_TechnicianSalesDistrictTableAdapter.ClearBeforeFill = true;
            // 
            // mSrv_TechnicianTableAdapter
            // 
            this.mSrv_TechnicianTableAdapter.ClearBeforeFill = true;
            // 
            // MSrv_TechnicianSalesDistrictUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MSrv_TechnicianSalesDistrictUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditTechnicianId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvTechnicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrictInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvTechnicianSalesDistrictBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSalesDistrict3Id;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colRuleId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditTechnicianId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private NICSQLTools.Data.dsData dsData;
        private NICSQLTools.Data.dsQry dsQry;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict3Id;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSalesDistrict3;
        private DevExpress.XtraGrid.Columns.GridColumn gcDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private System.Windows.Forms.BindingSource salesDistrictInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict2;
        private NICSQLTools.Data.dsQryTableAdapters.SalesDistrictInfoTableAdapter salesDistrictInfoTableAdapter;
        private System.Windows.Forms.BindingSource mSrvTechnicianSalesDistrictBindingSource;
        private NICSQLTools.Data.dsMSrc dsMSrc;
        private NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TechnicianSalesDistrictTableAdapter mSrv_TechnicianSalesDistrictTableAdapter;
        private System.Windows.Forms.BindingSource mSrvTechnicianBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnicianName;
        private NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TechnicianTableAdapter mSrv_TechnicianTableAdapter;
    }
}
