namespace NICSQLTools.Views.Data.TSrv.Code
{
    partial class TSrv_PlateEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TSrv_PlateEditorUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExLicenseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDistrict3Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSDN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSSalesDistrict3Id = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colConstructYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditf0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditRouteTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSRouteTypeId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUserIn = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRouteTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUserIn)).BeginInit();
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
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlate,
            this.colExLicenseDate,
            this.colModel,
            this.colSalesDistrict3Id,
            this.colConstructYear,
            this.gridColumn2,
            this.colUserIn,
            this.colDateIn});
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
            this.gridViewMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewMain_InitNewRow);
            // 
            // colPlate
            // 
            this.colPlate.FieldName = "Plate";
            this.colPlate.Name = "colPlate";
            this.colPlate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPlate.Visible = true;
            this.colPlate.VisibleIndex = 0;
            // 
            // colExLicenseDate
            // 
            this.colExLicenseDate.Caption = "Expire License Date";
            this.colExLicenseDate.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colExLicenseDate.FieldName = "ExLicenseDate";
            this.colExLicenseDate.Name = "colExLicenseDate";
            this.colExLicenseDate.Visible = true;
            this.colExLicenseDate.VisibleIndex = 1;
            this.colExLicenseDate.Width = 104;
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
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            // 
            // colSalesDistrict3Id
            // 
            this.colSalesDistrict3Id.Caption = "Sales District";
            this.colSalesDistrict3Id.ColumnEdit = this.repositoryItemLookUpEditSDN;
            this.colSalesDistrict3Id.FieldName = "SalesDistrict3Id!Key";
            this.colSalesDistrict3Id.Name = "colSalesDistrict3Id";
            this.colSalesDistrict3Id.Visible = true;
            this.colSalesDistrict3Id.VisibleIndex = 3;
            this.colSalesDistrict3Id.Width = 97;
            // 
            // repositoryItemLookUpEditSDN
            // 
            this.repositoryItemLookUpEditSDN.AutoHeight = false;
            this.repositoryItemLookUpEditSDN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSDN.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sales_District_2", "Sales_District_2", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditSDN.DataSource = this.LSMSSalesDistrict3Id;
            this.repositoryItemLookUpEditSDN.DisplayMember = "Sales_District_2";
            this.repositoryItemLookUpEditSDN.Name = "repositoryItemLookUpEditSDN";
            this.repositoryItemLookUpEditSDN.NullText = "";
            this.repositoryItemLookUpEditSDN.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditSDN.ValueMember = "SalesDistrict3Id";
            // 
            // LSMSSalesDistrict3Id
            // 
            this.LSMSSalesDistrict3Id.ElementType = typeof(NICSQLTools.Data.Linq.SalesDistrict3);
            this.LSMSSalesDistrict3Id.KeyExpression = "[SalesDistrict3Id]";
            // 
            // colConstructYear
            // 
            this.colConstructYear.Caption = "Construct Year";
            this.colConstructYear.ColumnEdit = this.repositoryItemTextEditf0;
            this.colConstructYear.FieldName = "ConstructYear";
            this.colConstructYear.Name = "colConstructYear";
            this.colConstructYear.Visible = true;
            this.colConstructYear.VisibleIndex = 4;
            this.colConstructYear.Width = 92;
            // 
            // repositoryItemTextEditf0
            // 
            this.repositoryItemTextEditf0.AutoHeight = false;
            this.repositoryItemTextEditf0.DisplayFormat.FormatString = "f0";
            this.repositoryItemTextEditf0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditf0.EditFormat.FormatString = "f0";
            this.repositoryItemTextEditf0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditf0.Mask.EditMask = "f0";
            this.repositoryItemTextEditf0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditf0.Name = "repositoryItemTextEditf0";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Route Type";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEditRouteTypeId;
            this.gridColumn2.FieldName = "RouteTypeId!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 83;
            // 
            // repositoryItemLookUpEditRouteTypeId
            // 
            this.repositoryItemLookUpEditRouteTypeId.AutoHeight = false;
            this.repositoryItemLookUpEditRouteTypeId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditRouteTypeId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RouteTypeName", "Route Type Name", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditRouteTypeId.DataSource = this.LSMSRouteTypeId;
            this.repositoryItemLookUpEditRouteTypeId.DisplayMember = "RouteTypeName";
            this.repositoryItemLookUpEditRouteTypeId.Name = "repositoryItemLookUpEditRouteTypeId";
            this.repositoryItemLookUpEditRouteTypeId.NullText = "";
            this.repositoryItemLookUpEditRouteTypeId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditRouteTypeId.ValueMember = "RouteTypeId";
            // 
            // LSMSRouteTypeId
            // 
            this.LSMSRouteTypeId.ElementType = typeof(NICSQLTools.Data.Linq.TSrv_RouteType);
            this.LSMSRouteTypeId.KeyExpression = "[RouteTypeId]";
            // 
            // colUserIn
            // 
            this.colUserIn.Caption = "Entry User";
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUserIn;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.OptionsColumn.AllowEdit = false;
            this.colUserIn.OptionsColumn.ReadOnly = true;
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUserIn.DataSource = this.LSMSUserIn;
            this.repositoryItemLookUpEditUserIn.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            this.repositoryItemLookUpEditUserIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
            // 
            // LSMSUserIn
            // 
            this.LSMSUserIn.ElementType = typeof(NICSQLTools.Data.Linq.AppUser);
            this.LSMSUserIn.KeyExpression = "[UserID]";
            // 
            // colDateIn
            // 
            this.colDateIn.Caption = "Entry Date";
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.OptionsColumn.AllowEdit = false;
            this.colDateIn.OptionsColumn.ReadOnly = true;
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 7;
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
            this.repositoryItemDateEditYMD,
            this.repositoryItemLookUpEditSDN,
            this.repositoryItemTextEditf0,
            this.repositoryItemLookUpEditRouteTypeId,
            this.repositoryItemLookUpEditUserIn});
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
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsTSrv.PlateDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // TSrv_PlateEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TSrv_PlateEditorUC";
            this.Size = new System.Drawing.Size(679, 391);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSalesDistrict3Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditf0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditRouteTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRouteTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colConstructYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict3Id;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colExLicenseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPlate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSalesDistrict3Id;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUserIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSDN;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSRouteTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditf0;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditRouteTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
    }
}
