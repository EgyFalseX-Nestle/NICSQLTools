namespace NICSQLTools.Views.Qry
{
    partial class CustomerMapUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMapUC));
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider1 = new DevExpress.XtraMap.BingSearchDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer2 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingRouteDataProvider bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            DevExpress.XtraMap.MapItemVisiblePropertyMapping mapItemVisiblePropertyMapping1 = new DevExpress.XtraMap.MapItemVisiblePropertyMapping();
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.mapRouteCustomerBindingSource = new System.Windows.Forms.BindingSource();
            this.barManagerMain = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.beiRoute = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.LSMSRoute = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beiCustomer = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubchannel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName3Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bbiFind = new DevExpress.XtraBars.BarButtonItem();
            this.bsiMapKind = new DevExpress.XtraBars.BarSubItem();
            this.bbiMakKindRoad = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMakKindArea = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMakKindHybrid = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiExcelDynamicUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.mapControlMain = new DevExpress.XtraMap.MapControl();
            this.LSMSCustomer = new DevExpress.Data.Linq.LinqServerModeSource();
            this.mapRouteCustomerTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.MapRouteCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapRouteCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mapRouteCustomerBindingSource
            // 
            this.mapRouteCustomerBindingSource.DataMember = "MapRouteCustomer";
            this.mapRouteCustomerBindingSource.DataSource = this.dsQry;
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrint,
            this.bbiExcelDynamicUpdate,
            this.beiRoute,
            this.beiCustomer,
            this.bbiFind,
            this.bsiMapKind,
            this.bbiMakKindRoad,
            this.bbiMakKindArea,
            this.bbiMakKindHybrid});
            this.barManagerMain.MainMenu = this.bar2;
            this.barManagerMain.MaxItemId = 15;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemSearchLookUpEdit2});
            this.barManagerMain.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.beiRoute, "", false, true, true, 208),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.beiCustomer, "", false, true, true, 200),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiMapKind),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // beiRoute
            // 
            this.beiRoute.Caption = "Route";
            this.beiRoute.Edit = this.repositoryItemSearchLookUpEdit1;
            this.beiRoute.Id = 8;
            this.beiRoute.Name = "beiRoute";
            this.beiRoute.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.beiRoute.EditValueChanged += new System.EventHandler(this.beiRoute_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.LSMSRoute;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "Route_Name";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "Route_Number";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // LSMSRoute
            // 
            this.LSMSRoute.ElementType = typeof(NICSQLTools.Data.Linq.vRouteDetail);
            this.LSMSRoute.KeyExpression = "[Route_Number]";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Route Number";
            this.gridColumn1.FieldName = "Route_Number";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Route Name";
            this.gridColumn2.FieldName = "Route_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Brand Route";
            this.gridColumn3.FieldName = "Brand_Route";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Sales District 2";
            this.gridColumn4.FieldName = "Sales_District_2";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Supervisor";
            this.gridColumn5.FieldName = "Supervisor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // beiCustomer
            // 
            this.beiCustomer.Caption = "Customer";
            this.beiCustomer.Edit = this.repositoryItemSearchLookUpEdit2;
            this.beiCustomer.Id = 9;
            this.beiCustomer.Name = "beiCustomer";
            this.beiCustomer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.beiCustomer.EditValueChanged += new System.EventHandler(this.beiCustomer_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DataSource = this.mapRouteCustomerBindingSource;
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "Name 3 Ar";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.NullText = "";
            this.repositoryItemSearchLookUpEdit2.ValueMember = "Customer";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colCustomerType,
            this.colSubchannel,
            this.colName1Ar,
            this.colName3Ar});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomer
            // 
            this.colCustomer.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.Caption = "Code";
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 0;
            // 
            // colCustomerType
            // 
            this.colCustomerType.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerType.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerType.Caption = "Customer Type";
            this.colCustomerType.FieldName = "Customer Type";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.Visible = true;
            this.colCustomerType.VisibleIndex = 1;
            // 
            // colSubchannel
            // 
            this.colSubchannel.AppearanceCell.Options.UseTextOptions = true;
            this.colSubchannel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubchannel.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubchannel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubchannel.Caption = "Subchannel";
            this.colSubchannel.FieldName = "Subchannel";
            this.colSubchannel.Name = "colSubchannel";
            this.colSubchannel.Visible = true;
            this.colSubchannel.VisibleIndex = 2;
            // 
            // colName1Ar
            // 
            this.colName1Ar.AppearanceCell.Options.UseTextOptions = true;
            this.colName1Ar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName1Ar.AppearanceHeader.Options.UseTextOptions = true;
            this.colName1Ar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName1Ar.Caption = "Name 1 Ar";
            this.colName1Ar.FieldName = "Name 1 Ar";
            this.colName1Ar.Name = "colName1Ar";
            this.colName1Ar.Visible = true;
            this.colName1Ar.VisibleIndex = 3;
            // 
            // colName3Ar
            // 
            this.colName3Ar.AppearanceCell.Options.UseTextOptions = true;
            this.colName3Ar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName3Ar.AppearanceHeader.Options.UseTextOptions = true;
            this.colName3Ar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName3Ar.Caption = "Name 3 Ar";
            this.colName3Ar.FieldName = "Name 3 Ar";
            this.colName3Ar.Name = "colName3Ar";
            this.colName3Ar.Visible = true;
            this.colName3Ar.VisibleIndex = 4;
            // 
            // bbiFind
            // 
            this.bbiFind.Caption = "Find";
            this.bbiFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiFind.Glyph")));
            this.bbiFind.Id = 10;
            this.bbiFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiFind.LargeGlyph")));
            this.bbiFind.Name = "bbiFind";
            this.bbiFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFind_ItemClick);
            // 
            // bsiMapKind
            // 
            this.bsiMapKind.Caption = "Map Kind";
            this.bsiMapKind.Glyph = ((System.Drawing.Image)(resources.GetObject("bsiMapKind.Glyph")));
            this.bsiMapKind.Id = 11;
            this.bsiMapKind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bsiMapKind.LargeGlyph")));
            this.bsiMapKind.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMakKindRoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMakKindArea),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMakKindHybrid)});
            this.bsiMapKind.Name = "bsiMapKind";
            this.bsiMapKind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiMakKindRoad
            // 
            this.bbiMakKindRoad.Caption = "Roud";
            this.bbiMakKindRoad.Id = 12;
            this.bbiMakKindRoad.Name = "bbiMakKindRoad";
            this.bbiMakKindRoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMakKindRoad_ItemClick);
            // 
            // bbiMakKindArea
            // 
            this.bbiMakKindArea.Caption = "Area";
            this.bbiMakKindArea.Id = 13;
            this.bbiMakKindArea.Name = "bbiMakKindArea";
            this.bbiMakKindArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMakKindArea_ItemClick);
            // 
            // bbiMakKindHybrid
            // 
            this.bbiMakKindHybrid.Caption = "Hybrid";
            this.bbiMakKindHybrid.Id = 14;
            this.bbiMakKindHybrid.Name = "bbiMakKindHybrid";
            this.bbiMakKindHybrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMakKindHybrid_ItemClick);
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "Print";
            this.bbiPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiPrint.Glyph")));
            this.bbiPrint.Id = 4;
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(800, 44);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 44);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
            // 
            // bbiExcelDynamicUpdate
            // 
            this.bbiExcelDynamicUpdate.Caption = "Excel Dynamic Update";
            this.bbiExcelDynamicUpdate.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExcelDynamicUpdate.Glyph")));
            this.bbiExcelDynamicUpdate.Id = 7;
            this.bbiExcelDynamicUpdate.Name = "bbiExcelDynamicUpdate";
            this.bbiExcelDynamicUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // mapControlMain
            // 
            this.mapControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            bingMapDataProvider1.BingKey = "AkVwp2-taePfVbizWMg4sw7euGQgm0V10-LPDl7SogRzhje2RsGfbp-YxDjK97_M";
            bingMapDataProvider1.CacheOptions.DiskFolder = "MapDiskFolder";
            bingMapDataProvider1.CacheOptions.MemoryLimit = 128;
            bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            bingMapDataProvider1.TileSource = null;
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            imageTilesLayer1.Name = "BingDataLayer";
            bingSearchDataProvider1.BingKey = "AkVwp2-taePfVbizWMg4sw7euGQgm0V10-LPDl7SogRzhje2RsGfbp-YxDjK97_M";
            informationLayer1.DataProvider = bingSearchDataProvider1;
            informationLayer1.Name = "SearchLayer";
            bingRouteDataProvider1.BingKey = "AkVwp2-taePfVbizWMg4sw7euGQgm0V10-LPDl7SogRzhje2RsGfbp-YxDjK97_M";
            informationLayer2.DataProvider = bingRouteDataProvider1;
            informationLayer2.Name = "RouteLayer";
            listSourceDataAdapter1.DataMember = "MapRouteCustomer";
            listSourceDataAdapter1.DataSource = this.dsQry;
            listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Callout;
            listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            listSourceDataAdapter1.Mappings.Text = "Name 3 Ar";
            listSourceDataAdapter1.Mappings.Type = "Customer Type";
            mapItemVisiblePropertyMapping1.DefaultValue = true;
            mapItemVisiblePropertyMapping1.Member = "Subchannel";
            listSourceDataAdapter1.PropertyMappings.Add(mapItemVisiblePropertyMapping1);
            vectorItemsLayer1.Data = listSourceDataAdapter1;
            vectorItemsLayer1.Name = "CustomerLayer";
            this.mapControlMain.Layers.Add(imageTilesLayer1);
            this.mapControlMain.Layers.Add(informationLayer1);
            this.mapControlMain.Layers.Add(informationLayer2);
            this.mapControlMain.Layers.Add(vectorItemsLayer1);
            this.mapControlMain.Location = new System.Drawing.Point(0, 44);
            this.mapControlMain.Name = "mapControlMain";
            this.mapControlMain.Size = new System.Drawing.Size(800, 533);
            this.mapControlMain.TabIndex = 4;
            // 
            // LSMSCustomer
            // 
            this.LSMSCustomer.ElementType = typeof(NICSQLTools.Data.Linq.vRouteDetail);
            this.LSMSCustomer.KeyExpression = "Route_Number";
            // 
            // mapRouteCustomerTableAdapter
            // 
            this.mapRouteCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerMapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CustomerMapUC";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapRouteCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiExcelDynamicUpdate;
        private DevExpress.XtraBars.BarEditItem beiRoute;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem beiCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraBars.BarButtonItem bbiFind;
        private DevExpress.XtraMap.MapControl mapControlMain;
        private DevExpress.XtraBars.BarSubItem bsiMapKind;
        private DevExpress.XtraBars.BarButtonItem bbiMakKindRoad;
        private DevExpress.XtraBars.BarButtonItem bbiMakKindArea;
        private DevExpress.XtraBars.BarButtonItem bbiMakKindHybrid;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSRoute;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCustomer;
        private System.Windows.Forms.BindingSource mapRouteCustomerBindingSource;
        private NICSQLTools.Data.dsQry dsQry;
        private NICSQLTools.Data.dsQryTableAdapters.MapRouteCustomerTableAdapter mapRouteCustomerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn colSubchannel;
        private DevExpress.XtraGrid.Columns.GridColumn colName1Ar;
        private DevExpress.XtraGrid.Columns.GridColumn colName3Ar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
