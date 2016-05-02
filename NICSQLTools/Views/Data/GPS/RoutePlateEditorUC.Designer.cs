namespace NICSQLTools.Views.Data.GPS
{
    partial class RoutePlateEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutePlateEditorUC));
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
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.repositoryItemLookUpEditPlate = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dsGPS = new NICSQLTools.Data.dsGPS();
            this.plateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plateTableAdapter = new NICSQLTools.Data.dsGPSTableAdapters.PlateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(936, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(936, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(936, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditPlate});
            this.gridControlMain.Size = new System.Drawing.Size(936, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRouteNumber,
            this.colRouteName,
            this.colPlate});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            // 
            // colRouteNumber
            // 
            this.colRouteNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.FieldName = "Route Number";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.OptionsColumn.ReadOnly = true;
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 0;
            this.colRouteNumber.Width = 98;
            // 
            // colRouteName
            // 
            this.colRouteName.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.FieldName = "Route Name";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.OptionsColumn.ReadOnly = true;
            this.colRouteName.Visible = true;
            this.colRouteName.VisibleIndex = 1;
            this.colRouteName.Width = 164;
            // 
            // colPlate
            // 
            this.colPlate.AppearanceCell.Options.UseTextOptions = true;
            this.colPlate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlate.Caption = "Plate";
            this.colPlate.ColumnEdit = this.repositoryItemLookUpEditPlate;
            this.colPlate.FieldName = "Plate";
            this.colPlate.Name = "colPlate";
            this.colPlate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPlate.Visible = true;
            this.colPlate.VisibleIndex = 2;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData._0_3__Route_DetailsDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // repositoryItemLookUpEditPlate
            // 
            this.repositoryItemLookUpEditPlate.AutoHeight = false;
            this.repositoryItemLookUpEditPlate.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEditPlate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPlate.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Plate", "Plate", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditPlate.DataSource = this.plateBindingSource;
            this.repositoryItemLookUpEditPlate.DisplayMember = "Plate";
            this.repositoryItemLookUpEditPlate.DropDownRows = 10;
            this.repositoryItemLookUpEditPlate.Name = "repositoryItemLookUpEditPlate";
            this.repositoryItemLookUpEditPlate.NullText = "";
            this.repositoryItemLookUpEditPlate.ShowHeader = false;
            this.repositoryItemLookUpEditPlate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditPlate.ValueMember = "Plate";
            // 
            // dsGPS
            // 
            this.dsGPS.DataSetName = "dsGPS";
            this.dsGPS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plateBindingSource
            // 
            this.plateBindingSource.DataMember = "Plate";
            this.plateBindingSource.DataSource = this.dsGPS;
            // 
            // plateTableAdapter
            // 
            this.plateTableAdapter.ClearBeforeFill = true;
            // 
            // RoutePlateEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RoutePlateEditorUC";
            this.Size = new System.Drawing.Size(936, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteName;
        private DevExpress.XtraGrid.Columns.GridColumn colPlate;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPlate;
        private System.Windows.Forms.BindingSource plateBindingSource;
        private NICSQLTools.Data.dsGPS dsGPS;
        private NICSQLTools.Data.dsGPSTableAdapters.PlateTableAdapter plateTableAdapter;
    }
}
