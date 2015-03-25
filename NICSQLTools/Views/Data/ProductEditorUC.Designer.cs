namespace NICSQLTools.Views.Data
{
    partial class ProductEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditorUC));
            this.colValidMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.colValidYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePointrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colBaseProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditBaseProductId = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.LSMSBaseProduct = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsubBaseProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolumPice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewQu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceIncreas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPallet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSplit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlavor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandRang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colConsumerSegment = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBaseProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSBaseProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // colValidMonth
            // 
            this.colValidMonth.FieldName = "Valid Month";
            this.colValidMonth.Name = "colValidMonth";
            this.colValidMonth.Visible = true;
            this.colValidMonth.VisibleIndex = 25;
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // colValidYear
            // 
            this.colValidYear.FieldName = "Valid Year";
            this.colValidYear.Name = "colValidYear";
            this.colValidYear.Visible = true;
            this.colValidYear.VisibleIndex = 24;
            // 
            // colPricePointrang
            // 
            this.colPricePointrang.FieldName = "Price Point rang";
            this.colPricePointrang.Name = "colPricePointrang";
            this.colPricePointrang.Visible = true;
            this.colPricePointrang.VisibleIndex = 6;
            this.colPricePointrang.Width = 95;
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 3;
            // 
            // colMaterialName
            // 
            this.colMaterialName.FieldName = "Material Name";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            this.colMaterialName.Width = 88;
            // 
            // colMaterialNumber
            // 
            this.colMaterialNumber.FieldName = "Material Number";
            this.colMaterialNumber.Name = "colMaterialNumber";
            this.colMaterialNumber.Visible = true;
            this.colMaterialNumber.VisibleIndex = 0;
            this.colMaterialNumber.Width = 98;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialNumber,
            this.colMaterialName,
            this.colBrand,
            this.colBaseProductId,
            this.colPricePointrang,
            this.colPricePoint,
            this.colMarketrang,
            this.colQuin,
            this.colVolumPice,
            this.colVolum,
            this.colVol,
            this.colNewQu,
            this.colPriceIncreas,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colPallet,
            this.colSplit,
            this.colMaterialType,
            this.colFlavor,
            this.colNPDS,
            this.colValidYear,
            this.colValidMonth,
            this.colMaterialName2,
            this.colMaterialStatus,
            this.colBrandRang,
            this.gridColumn1,
            this.colConsumerSegment});
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
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // colBaseProductId
            // 
            this.colBaseProductId.Caption = "Base Product";
            this.colBaseProductId.ColumnEdit = this.repositoryItemGridLookUpEditBaseProductId;
            this.colBaseProductId.FieldName = "BaseProductId";
            this.colBaseProductId.Name = "colBaseProductId";
            this.colBaseProductId.Visible = true;
            this.colBaseProductId.VisibleIndex = 4;
            this.colBaseProductId.Width = 83;
            // 
            // repositoryItemGridLookUpEditBaseProductId
            // 
            this.repositoryItemGridLookUpEditBaseProductId.AutoHeight = false;
            this.repositoryItemGridLookUpEditBaseProductId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditBaseProductId.DataSource = this.LSMSBaseProduct;
            this.repositoryItemGridLookUpEditBaseProductId.DisplayMember = "BaseProduct";
            this.repositoryItemGridLookUpEditBaseProductId.Name = "repositoryItemGridLookUpEditBaseProductId";
            this.repositoryItemGridLookUpEditBaseProductId.NullText = "";
            this.repositoryItemGridLookUpEditBaseProductId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditBaseProductId.ValueMember = "BaseProductId";
            this.repositoryItemGridLookUpEditBaseProductId.View = this.gridView6;
            // 
            // LSMSBaseProduct
            // 
            this.LSMSBaseProduct.ElementType = typeof(NICSQLTools.Data.Linq.PRD_BaseProduct);
            this.LSMSBaseProduct.KeyExpression = "[BaseProductId]";
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsubBaseProductId,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colsubBaseProductId
            // 
            this.colsubBaseProductId.AppearanceCell.Options.UseTextOptions = true;
            this.colsubBaseProductId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsubBaseProductId.AppearanceHeader.Options.UseTextOptions = true;
            this.colsubBaseProductId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsubBaseProductId.Caption = "Id";
            this.colsubBaseProductId.FieldName = "BaseProductId";
            this.colsubBaseProductId.Name = "colsubBaseProductId";
            this.colsubBaseProductId.Visible = true;
            this.colsubBaseProductId.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Base Product";
            this.gridColumn6.FieldName = "BaseProduct";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Group1";
            this.gridColumn7.FieldName = "Group1";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Group2";
            this.gridColumn8.FieldName = "Group2";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Group3";
            this.gridColumn9.FieldName = "Group3";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // colPricePoint
            // 
            this.colPricePoint.FieldName = "Price Point";
            this.colPricePoint.Name = "colPricePoint";
            this.colPricePoint.Visible = true;
            this.colPricePoint.VisibleIndex = 7;
            // 
            // colMarketrang
            // 
            this.colMarketrang.FieldName = "Market range";
            this.colMarketrang.Name = "colMarketrang";
            this.colMarketrang.Visible = true;
            this.colMarketrang.VisibleIndex = 8;
            this.colMarketrang.Width = 84;
            // 
            // colQuin
            // 
            this.colQuin.FieldName = "Quin";
            this.colQuin.Name = "colQuin";
            this.colQuin.Visible = true;
            this.colQuin.VisibleIndex = 9;
            // 
            // colVolumPice
            // 
            this.colVolumPice.FieldName = "Volum Pice";
            this.colVolumPice.Name = "colVolumPice";
            this.colVolumPice.Visible = true;
            this.colVolumPice.VisibleIndex = 10;
            // 
            // colVolum
            // 
            this.colVolum.FieldName = "Volum";
            this.colVolum.Name = "colVolum";
            this.colVolum.Visible = true;
            this.colVolum.VisibleIndex = 11;
            // 
            // colVol
            // 
            this.colVol.FieldName = "Vol";
            this.colVol.Name = "colVol";
            this.colVol.Visible = true;
            this.colVol.VisibleIndex = 12;
            // 
            // colNewQu
            // 
            this.colNewQu.FieldName = "New Qu";
            this.colNewQu.Name = "colNewQu";
            this.colNewQu.Visible = true;
            this.colNewQu.VisibleIndex = 13;
            // 
            // colPriceIncreas
            // 
            this.colPriceIncreas.FieldName = "Price Increas";
            this.colPriceIncreas.Name = "colPriceIncreas";
            this.colPriceIncreas.Visible = true;
            this.colPriceIncreas.VisibleIndex = 14;
            this.colPriceIncreas.Width = 82;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Trade Price/Carton";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 15;
            this.gridColumn2.Width = 111;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Trade Price/Piece";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 16;
            this.gridColumn3.Width = 103;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Consumer price /Carton";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 17;
            this.gridColumn4.Width = 134;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Consumer price /Piece";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 18;
            this.gridColumn5.Width = 126;
            // 
            // colPallet
            // 
            this.colPallet.FieldName = "Pallet";
            this.colPallet.Name = "colPallet";
            this.colPallet.Visible = true;
            this.colPallet.VisibleIndex = 19;
            // 
            // colSplit
            // 
            this.colSplit.FieldName = "Split";
            this.colSplit.Name = "colSplit";
            this.colSplit.Visible = true;
            this.colSplit.VisibleIndex = 20;
            // 
            // colMaterialType
            // 
            this.colMaterialType.FieldName = "Material Type";
            this.colMaterialType.Name = "colMaterialType";
            this.colMaterialType.Visible = true;
            this.colMaterialType.VisibleIndex = 21;
            this.colMaterialType.Width = 85;
            // 
            // colFlavor
            // 
            this.colFlavor.FieldName = "Flavor";
            this.colFlavor.Name = "colFlavor";
            this.colFlavor.Visible = true;
            this.colFlavor.VisibleIndex = 22;
            // 
            // colNPDS
            // 
            this.colNPDS.FieldName = "NPDS";
            this.colNPDS.Name = "colNPDS";
            this.colNPDS.Visible = true;
            this.colNPDS.VisibleIndex = 23;
            // 
            // colMaterialName2
            // 
            this.colMaterialName2.FieldName = "Material Name 2";
            this.colMaterialName2.Name = "colMaterialName2";
            this.colMaterialName2.Visible = true;
            this.colMaterialName2.VisibleIndex = 2;
            this.colMaterialName2.Width = 97;
            // 
            // colMaterialStatus
            // 
            this.colMaterialStatus.FieldName = "MaterialStatus";
            this.colMaterialStatus.Name = "colMaterialStatus";
            this.colMaterialStatus.Visible = true;
            this.colMaterialStatus.VisibleIndex = 26;
            this.colMaterialStatus.Width = 92;
            // 
            // colBrandRang
            // 
            this.colBrandRang.FieldName = "Brand Rang";
            this.colBrandRang.Name = "colBrandRang";
            this.colBrandRang.Visible = true;
            this.colBrandRang.VisibleIndex = 27;
            this.colBrandRang.Width = 76;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Product/ Active- Cancel";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 28;
            this.gridColumn1.Width = 133;
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlMain_EmbeddedNavigator_ButtonClick);
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditBaseProductId,
            this.repositoryItemButtonEditDel});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh)});
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
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData._0_4__Product_DetailsDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // colConsumerSegment
            // 
            this.colConsumerSegment.FieldName = "Consumer Segment";
            this.colConsumerSegment.Name = "colConsumerSegment";
            this.colConsumerSegment.Visible = true;
            this.colConsumerSegment.VisibleIndex = 5;
            this.colConsumerSegment.Width = 119;
            // 
            // ProductEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProductEditorUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBaseProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSBaseProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colValidMonth;
        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraGrid.Columns.GridColumn colValidYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePointrang;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePoint;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketrang;
        private DevExpress.XtraGrid.Columns.GridColumn colQuin;
        private DevExpress.XtraGrid.Columns.GridColumn colVolumPice;
        private DevExpress.XtraGrid.Columns.GridColumn colVolum;
        private DevExpress.XtraGrid.Columns.GridColumn colVol;
        private DevExpress.XtraGrid.Columns.GridColumn colNewQu;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceIncreas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colPallet;
        private DevExpress.XtraGrid.Columns.GridColumn colSplit;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialType;
        private DevExpress.XtraGrid.Columns.GridColumn colFlavor;
        private DevExpress.XtraGrid.Columns.GridColumn colNPDS;
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
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialStatus;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandRang;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseProductId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSBaseProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditBaseProductId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colsubBaseProductId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumerSegment;
    }
}
