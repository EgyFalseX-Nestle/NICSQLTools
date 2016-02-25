namespace NICSQLTools.Views.Data.RDM
{
    partial class RDM_ReceiptEditorUC
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRDM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRDM_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colRouteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMDHM = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colRDM_Promo_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupervisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand_Route = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSales_District_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRDM_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditDesc = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMDHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMDHM.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).BeginInit();
            this.SuspendLayout();
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
            this.bbiAddNew,
            this.bbiExport,
            this.bbiRefresh});
            this.barManagerMain.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiAddNew
            // 
            this.bbiAddNew.Caption = "Add Receipt";
            this.bbiAddNew.Glyph = global::NICSQLTools.Properties.Resources.add_16x16;
            this.bbiAddNew.Id = 0;
            this.bbiAddNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiAddNew.LargeGlyph = global::NICSQLTools.Properties.Resources.add_32x32;
            this.bbiAddNew.Name = "bbiAddNew";
            this.bbiAddNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNew_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::NICSQLTools.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(988, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(988, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(988, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.LSMSData;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditn2,
            this.repositoryItemDateEditYMDHM,
            this.repositoryItemDateEditYMD,
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDelete,
            this.repositoryItemMemoExEditDesc});
            this.gridControlMain.Size = new System.Drawing.Size(988, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(NICSQLTools.Data.Linq.vRDM_Receipt_ByUser);
            this.LSMSData.KeyExpression = "[RDM_ID], [VisibleToUserId]";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewMain.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewMain.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewMain.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRDM_ID,
            this.colReceiptNo,
            this.colRDM_Date,
            this.colRouteNumber,
            this.colQun,
            this.colDateIn,
            this.colRDM_Promo_Type,
            this.colYearNum,
            this.colBaseProduct,
            this.colBaseGroup,
            this.colGroup1,
            this.colGroup2,
            this.colGroup3,
            this.colRoute_Name,
            this.colPlant,
            this.colASM,
            this.colSupervisor,
            this.colBrand_Route,
            this.colSales_District_2,
            this.colSales_District_Name,
            this.colRealName,
            this.gridColumn1,
            this.gridColumn2,
            this.colRDM_Description});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridViewMain.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.SegmentedFade;
            this.gridViewMain.OptionsImageLoad.AsyncLoad = true;
            this.gridViewMain.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewMain.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewMain_CustomRowCellEdit);
            this.gridViewMain.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridViewMain_CustomRowCellEditForEditing);
            // 
            // colRDM_ID
            // 
            this.colRDM_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colRDM_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRDM_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_ID.Caption = "ID";
            this.colRDM_ID.FieldName = "RDM_ID";
            this.colRDM_ID.Name = "colRDM_ID";
            this.colRDM_ID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RDM_ID", "{0}")});
            this.colRDM_ID.Visible = true;
            this.colRDM_ID.VisibleIndex = 0;
            this.colRDM_ID.Width = 44;
            // 
            // colReceiptNo
            // 
            this.colReceiptNo.AppearanceCell.Options.UseTextOptions = true;
            this.colReceiptNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colReceiptNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptNo.Caption = "Receipt No";
            this.colReceiptNo.FieldName = "ReceiptNo";
            this.colReceiptNo.Name = "colReceiptNo";
            this.colReceiptNo.Visible = true;
            this.colReceiptNo.VisibleIndex = 1;
            // 
            // colRDM_Date
            // 
            this.colRDM_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colRDM_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colRDM_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Date.Caption = "Receipt Date";
            this.colRDM_Date.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colRDM_Date.FieldName = "RDM_Date";
            this.colRDM_Date.Name = "colRDM_Date";
            this.colRDM_Date.Visible = true;
            this.colRDM_Date.VisibleIndex = 2;
            this.colRDM_Date.Width = 110;
            // 
            // repositoryItemDateEditYMD
            // 
            this.repositoryItemDateEditYMD.AutoHeight = false;
            this.repositoryItemDateEditYMD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.Name = "repositoryItemDateEditYMD";
            // 
            // colRouteNumber
            // 
            this.colRouteNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteNumber.Caption = "Route";
            this.colRouteNumber.FieldName = "RouteNumber";
            this.colRouteNumber.Name = "colRouteNumber";
            this.colRouteNumber.Visible = true;
            this.colRouteNumber.VisibleIndex = 5;
            // 
            // colQun
            // 
            this.colQun.AppearanceCell.Options.UseTextOptions = true;
            this.colQun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQun.AppearanceHeader.Options.UseTextOptions = true;
            this.colQun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQun.Caption = "Quantity";
            this.colQun.ColumnEdit = this.repositoryItemTextEditn2;
            this.colQun.FieldName = "Qun";
            this.colQun.Name = "colQun";
            this.colQun.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qun", "{0:0.##}")});
            this.colQun.Visible = true;
            this.colQun.VisibleIndex = 4;
            this.colQun.Width = 63;
            // 
            // repositoryItemTextEditn2
            // 
            this.repositoryItemTextEditn2.AutoHeight = false;
            this.repositoryItemTextEditn2.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.EditFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.Mask.EditMask = "n2";
            this.repositoryItemTextEditn2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn2.Name = "repositoryItemTextEditn2";
            // 
            // colDateIn
            // 
            this.colDateIn.AppearanceCell.Options.UseTextOptions = true;
            this.colDateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.Caption = "Entry Date";
            this.colDateIn.ColumnEdit = this.repositoryItemDateEditYMDHM;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            // 
            // repositoryItemDateEditYMDHM
            // 
            this.repositoryItemDateEditYMDHM.AutoHeight = false;
            this.repositoryItemDateEditYMDHM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMDHM.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMDHM.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEditYMDHM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMDHM.EditFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEditYMDHM.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMDHM.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEditYMDHM.Name = "repositoryItemDateEditYMDHM";
            // 
            // colRDM_Promo_Type
            // 
            this.colRDM_Promo_Type.AppearanceCell.Options.UseTextOptions = true;
            this.colRDM_Promo_Type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Promo_Type.AppearanceHeader.Options.UseTextOptions = true;
            this.colRDM_Promo_Type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Promo_Type.Caption = "Promotion Type";
            this.colRDM_Promo_Type.FieldName = "RDM_Promo_Type";
            this.colRDM_Promo_Type.Name = "colRDM_Promo_Type";
            this.colRDM_Promo_Type.Visible = true;
            this.colRDM_Promo_Type.VisibleIndex = 8;
            this.colRDM_Promo_Type.Width = 95;
            // 
            // colYearNum
            // 
            this.colYearNum.AppearanceCell.Options.UseTextOptions = true;
            this.colYearNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearNum.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearNum.Caption = "Promotion Year";
            this.colYearNum.FieldName = "YearNum";
            this.colYearNum.Name = "colYearNum";
            this.colYearNum.Visible = true;
            this.colYearNum.VisibleIndex = 9;
            this.colYearNum.Width = 91;
            // 
            // colBaseProduct
            // 
            this.colBaseProduct.AppearanceCell.Options.UseTextOptions = true;
            this.colBaseProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaseProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.colBaseProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaseProduct.Caption = "Base Product";
            this.colBaseProduct.FieldName = "BaseProduct";
            this.colBaseProduct.Name = "colBaseProduct";
            this.colBaseProduct.Visible = true;
            this.colBaseProduct.VisibleIndex = 3;
            this.colBaseProduct.Width = 83;
            // 
            // colBaseGroup
            // 
            this.colBaseGroup.AppearanceCell.Options.UseTextOptions = true;
            this.colBaseGroup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaseGroup.AppearanceHeader.Options.UseTextOptions = true;
            this.colBaseGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBaseGroup.Caption = "Base Group";
            this.colBaseGroup.FieldName = "BaseGroup";
            this.colBaseGroup.Name = "colBaseGroup";
            // 
            // colGroup1
            // 
            this.colGroup1.AppearanceCell.Options.UseTextOptions = true;
            this.colGroup1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup1.Caption = "Group 1";
            this.colGroup1.FieldName = "Group1";
            this.colGroup1.Name = "colGroup1";
            // 
            // colGroup2
            // 
            this.colGroup2.AppearanceCell.Options.UseTextOptions = true;
            this.colGroup2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup2.Caption = "Group 2";
            this.colGroup2.FieldName = "Group2";
            this.colGroup2.Name = "colGroup2";
            // 
            // colGroup3
            // 
            this.colGroup3.AppearanceCell.Options.UseTextOptions = true;
            this.colGroup3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup3.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup3.Caption = "Group 3";
            this.colGroup3.FieldName = "Group3";
            this.colGroup3.Name = "colGroup3";
            // 
            // colRoute_Name
            // 
            this.colRoute_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colRoute_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoute_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoute_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoute_Name.Caption = "Route Name";
            this.colRoute_Name.FieldName = "Route_Name";
            this.colRoute_Name.Name = "colRoute_Name";
            this.colRoute_Name.Visible = true;
            this.colRoute_Name.VisibleIndex = 6;
            this.colRoute_Name.Width = 79;
            // 
            // colPlant
            // 
            this.colPlant.AppearanceCell.Options.UseTextOptions = true;
            this.colPlant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlant.Caption = "Plant";
            this.colPlant.FieldName = "Plant";
            this.colPlant.Name = "colPlant";
            // 
            // colASM
            // 
            this.colASM.AppearanceCell.Options.UseTextOptions = true;
            this.colASM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colASM.AppearanceHeader.Options.UseTextOptions = true;
            this.colASM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colASM.Caption = "ASM";
            this.colASM.FieldName = "ASM";
            this.colASM.Name = "colASM";
            // 
            // colSupervisor
            // 
            this.colSupervisor.AppearanceCell.Options.UseTextOptions = true;
            this.colSupervisor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupervisor.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupervisor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupervisor.Caption = "Supervisor";
            this.colSupervisor.FieldName = "Supervisor";
            this.colSupervisor.Name = "colSupervisor";
            // 
            // colBrand_Route
            // 
            this.colBrand_Route.AppearanceCell.Options.UseTextOptions = true;
            this.colBrand_Route.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrand_Route.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrand_Route.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrand_Route.Caption = "Brand Route";
            this.colBrand_Route.FieldName = "Brand_Route";
            this.colBrand_Route.Name = "colBrand_Route";
            this.colBrand_Route.Width = 80;
            // 
            // colSales_District_2
            // 
            this.colSales_District_2.AppearanceCell.Options.UseTextOptions = true;
            this.colSales_District_2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_District_2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSales_District_2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_District_2.Caption = "Sales District 2";
            this.colSales_District_2.FieldName = "Sales_District_2";
            this.colSales_District_2.Name = "colSales_District_2";
            this.colSales_District_2.Visible = true;
            this.colSales_District_2.VisibleIndex = 7;
            this.colSales_District_2.Width = 90;
            // 
            // colSales_District_Name
            // 
            this.colSales_District_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colSales_District_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_District_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colSales_District_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSales_District_Name.Caption = "Sales District Name";
            this.colSales_District_Name.FieldName = "Sales_District_Name";
            this.colSales_District_Name.Name = "colSales_District_Name";
            this.colSales_District_Name.Width = 111;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "Entry User";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Edit";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            this.gridColumn1.Width = 83;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Edit", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, global::NICSQLTools.Properties.Resources.pictureshapeoutlinecolor_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Delete";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 12;
            this.gridColumn2.Width = 48;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, global::NICSQLTools.Properties.Resources.delete_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // colRDM_Description
            // 
            this.colRDM_Description.AppearanceCell.Options.UseTextOptions = true;
            this.colRDM_Description.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Description.AppearanceHeader.Options.UseTextOptions = true;
            this.colRDM_Description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRDM_Description.Caption = "Description";
            this.colRDM_Description.ColumnEdit = this.repositoryItemMemoExEditDesc;
            this.colRDM_Description.FieldName = "RDM_Description";
            this.colRDM_Description.Name = "colRDM_Description";
            this.colRDM_Description.Visible = true;
            this.colRDM_Description.VisibleIndex = 10;
            // 
            // repositoryItemMemoExEditDesc
            // 
            this.repositoryItemMemoExEditDesc.AutoHeight = false;
            this.repositoryItemMemoExEditDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditDesc.Name = "repositoryItemMemoExEditDesc";
            // 
            // RDM_ReceiptEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RDM_ReceiptEditorUC";
            this.Size = new System.Drawing.Size(988, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMDHM.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMDHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiAddNew;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMDHM;
        private DevExpress.XtraGrid.Columns.GridColumn colRDM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRDM_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colQun;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraGrid.Columns.GridColumn colRDM_Promo_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colYearNum;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPlant;
        private DevExpress.XtraGrid.Columns.GridColumn colASM;
        private DevExpress.XtraGrid.Columns.GridColumn colSupervisor;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand_Route;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_2;
        private DevExpress.XtraGrid.Columns.GridColumn colSales_District_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colRDM_Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditDesc;
    }
}
