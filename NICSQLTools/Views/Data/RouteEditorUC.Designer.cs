namespace NICSQLTools.Views.Data
{
    partial class RouteEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteEditorUC));
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
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributionChannel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteNumbersystem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRSM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDistrict3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSalesDistrict3Id = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSSalesDistrict2 = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCE_Project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
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
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditSalesDistrict3Id,
            this.repositoryItemButtonEditDelete});
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
            this.colDistributionChannel1,
            this.colRouteNumbersystem,
            this.colRouteName,
            this.colRegion,
            this.colPlant,
            this.colRSM,
            this.colASM,
            this.colSupervisor,
            this.colBrandRoute,
            this.colSalesDistrict3Id,
            this.colWarehouse,
            this.colNCE_Project});
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
            this.colRouteNumber.FieldName = "Route Number";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 0;
            this.colRouteNumber.Width = 89;
            // 
            // colDistributionChannel1
            // 
            this.colDistributionChannel1.AppearanceCell.Options.UseTextOptions = true;
            this.colDistributionChannel1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDistributionChannel1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDistributionChannel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDistributionChannel1.FieldName = "Distribution Channel";
            this.colDistributionChannel1.Name = "colDistributionChannel1";
            this.colDistributionChannel1.Visible = true;
            this.colDistributionChannel1.VisibleIndex = 9;
            this.colDistributionChannel1.Width = 116;
            // 
            // colRouteNumbersystem
            // 
            this.colRouteNumbersystem.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteNumbersystem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumbersystem.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteNumbersystem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumbersystem.FieldName = "Route Number  system";
            this.colRouteNumbersystem.Name = "colRouteNumbersystem";
            this.colRouteNumbersystem.Visible = true;
            this.colRouteNumbersystem.VisibleIndex = 1;
            this.colRouteNumbersystem.Width = 129;
            // 
            // colRouteName
            // 
            this.colRouteName.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.FieldName = "Route Name";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.Visible = true;
            this.colRouteName.VisibleIndex = 2;
            this.colRouteName.Width = 79;
            // 
            // colRegion
            // 
            this.colRegion.AppearanceCell.Options.UseTextOptions = true;
            this.colRegion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegion.AppearanceHeader.Options.UseTextOptions = true;
            this.colRegion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 3;
            // 
            // colPlant
            // 
            this.colPlant.AppearanceCell.Options.UseTextOptions = true;
            this.colPlant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.FieldName = "Plant";
            this.colPlant.Name = "colPlant";
            this.colPlant.Visible = true;
            this.colPlant.VisibleIndex = 4;
            // 
            // colRSM
            // 
            this.colRSM.AppearanceCell.Options.UseTextOptions = true;
            this.colRSM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRSM.AppearanceHeader.Options.UseTextOptions = true;
            this.colRSM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRSM.FieldName = "RSM";
            this.colRSM.Name = "colRSM";
            this.colRSM.Visible = true;
            this.colRSM.VisibleIndex = 5;
            // 
            // colASM
            // 
            this.colASM.AppearanceCell.Options.UseTextOptions = true;
            this.colASM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colASM.AppearanceHeader.Options.UseTextOptions = true;
            this.colASM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colASM.FieldName = "ASM";
            this.colASM.Name = "colASM";
            this.colASM.Visible = true;
            this.colASM.VisibleIndex = 6;
            // 
            // colSupervisor
            // 
            this.colSupervisor.AppearanceCell.Options.UseTextOptions = true;
            this.colSupervisor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupervisor.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupervisor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupervisor.FieldName = "Supervisor";
            this.colSupervisor.Name = "colSupervisor";
            this.colSupervisor.Visible = true;
            this.colSupervisor.VisibleIndex = 7;
            // 
            // colBrandRoute
            // 
            this.colBrandRoute.AppearanceCell.Options.UseTextOptions = true;
            this.colBrandRoute.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandRoute.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrandRoute.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrandRoute.FieldName = "Brand Route";
            this.colBrandRoute.Name = "colBrandRoute";
            this.colBrandRoute.Visible = true;
            this.colBrandRoute.VisibleIndex = 8;
            this.colBrandRoute.Width = 80;
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
            this.colSalesDistrict3Id.VisibleIndex = 10;
            this.colSalesDistrict3Id.Width = 90;
            // 
            // repositoryItemGridLookUpEditSalesDistrict3Id
            // 
            this.repositoryItemGridLookUpEditSalesDistrict3Id.AutoHeight = false;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DataSource = this.LSMSSalesDistrict2;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.DisplayMember = "Sales_District_2";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.Name = "repositoryItemGridLookUpEditSalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.NullText = "";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSalesDistrict3Id.ValueMember = "SalesDistrict3Id";
            this.repositoryItemGridLookUpEditSalesDistrict3Id.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // LSMSSalesDistrict2
            // 
            this.LSMSSalesDistrict2.ElementType = typeof(NICSQLTools.Data.Linq.SalesDistrict3);
            this.LSMSSalesDistrict2.KeyExpression = "[SalesDistrict3Id]";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sales District 2";
            this.gridColumn1.FieldName = "Sales_District_2";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colWarehouse
            // 
            this.colWarehouse.AppearanceCell.Options.UseTextOptions = true;
            this.colWarehouse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouse.AppearanceHeader.Options.UseTextOptions = true;
            this.colWarehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 11;
            // 
            // colNCE_Project
            // 
            this.colNCE_Project.AppearanceCell.Options.UseTextOptions = true;
            this.colNCE_Project.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNCE_Project.AppearanceHeader.Options.UseTextOptions = true;
            this.colNCE_Project.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNCE_Project.Caption = "NCE Project";
            this.colNCE_Project.FieldName = "NCE_Project";
            this.colNCE_Project.Name = "colNCE_Project";
            this.colNCE_Project.Visible = true;
            this.colNCE_Project.VisibleIndex = 12;
            this.colNCE_Project.Width = 77;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData._0_3__Route_DetailsDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // RouteEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RouteEditorUC";
            this.Size = new System.Drawing.Size(936, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict3Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributionChannel1;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumbersystem;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteName;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colPlant;
        private DevExpress.XtraGrid.Columns.GridColumn colRSM;
        private DevExpress.XtraGrid.Columns.GridColumn colASM;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandRoute;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colNCE_Project;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSalesDistrict2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSalesDistrict3Id;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
    }
}
