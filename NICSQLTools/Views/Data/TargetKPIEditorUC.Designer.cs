namespace NICSQLTools.Views.Data
{
    partial class TargetKPIEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetKPIEditorUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesDistrict2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditSalesDistrict2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.salesDistrict2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesDistrict21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEditBrandRoute = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPSTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicesTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPOSTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDropSizeTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrucks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTPPBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.salesDistrict2TableAdapter = new NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter();
            this.brandRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandRouteTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.BrandRouteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrict2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBrandRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandRouteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
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
            this.bbiExport});
            this.barManagerMain.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.Glyph")));
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(652, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(652, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(652, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEditSalesDistrict2,
            this.repositoryItemGridLookUpEditBrandRoute});
            this.gridControlMain.Size = new System.Drawing.Size(652, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesDistrict2,
            this.colBrandRoute,
            this.colMonthNum,
            this.colYearNum,
            this.colNPSTarget,
            this.colInvoicesTarget,
            this.colAPOSTarget,
            this.colDropSizeTarget,
            this.colTrucks,
            this.colTPPBudget});
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
            // colSalesDistrict2
            // 
            this.colSalesDistrict2.Caption = "Sales District 2";
            this.colSalesDistrict2.ColumnEdit = this.repositoryItemGridLookUpEditSalesDistrict2;
            this.colSalesDistrict2.FieldName = "Sales District 2";
            this.colSalesDistrict2.Name = "colSalesDistrict2";
            this.colSalesDistrict2.Visible = true;
            this.colSalesDistrict2.VisibleIndex = 0;
            this.colSalesDistrict2.Width = 79;
            // 
            // repositoryItemGridLookUpEditSalesDistrict2
            // 
            this.repositoryItemGridLookUpEditSalesDistrict2.AutoHeight = false;
            this.repositoryItemGridLookUpEditSalesDistrict2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditSalesDistrict2.DataSource = this.salesDistrict2BindingSource;
            this.repositoryItemGridLookUpEditSalesDistrict2.DisplayMember = "Sales District 2";
            this.repositoryItemGridLookUpEditSalesDistrict2.Name = "repositoryItemGridLookUpEditSalesDistrict2";
            this.repositoryItemGridLookUpEditSalesDistrict2.NullText = "";
            this.repositoryItemGridLookUpEditSalesDistrict2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemGridLookUpEditSalesDistrict2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditSalesDistrict2.ValueMember = "Sales District 2";
            this.repositoryItemGridLookUpEditSalesDistrict2.View = this.gridView6;
            // 
            // salesDistrict2BindingSource
            // 
            this.salesDistrict2BindingSource.DataMember = "SalesDistrict2";
            this.salesDistrict2BindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesDistrict21});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colSalesDistrict21
            // 
            this.colSalesDistrict21.FieldName = "Sales District 2";
            this.colSalesDistrict21.Name = "colSalesDistrict21";
            this.colSalesDistrict21.Visible = true;
            this.colSalesDistrict21.VisibleIndex = 0;
            // 
            // colBrandRoute
            // 
            this.colBrandRoute.Caption = "Brand Route";
            this.colBrandRoute.ColumnEdit = this.repositoryItemGridLookUpEditBrandRoute;
            this.colBrandRoute.FieldName = "Brand Route";
            this.colBrandRoute.Name = "colBrandRoute";
            this.colBrandRoute.Visible = true;
            this.colBrandRoute.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEditBrandRoute
            // 
            this.repositoryItemGridLookUpEditBrandRoute.AutoHeight = false;
            this.repositoryItemGridLookUpEditBrandRoute.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEditBrandRoute.DataSource = this.brandRouteBindingSource;
            this.repositoryItemGridLookUpEditBrandRoute.DisplayMember = "Brand Route";
            this.repositoryItemGridLookUpEditBrandRoute.Name = "repositoryItemGridLookUpEditBrandRoute";
            this.repositoryItemGridLookUpEditBrandRoute.NullText = "";
            this.repositoryItemGridLookUpEditBrandRoute.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemGridLookUpEditBrandRoute.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEditBrandRoute.ValueMember = "Brand Route";
            this.repositoryItemGridLookUpEditBrandRoute.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMonthNum
            // 
            this.colMonthNum.Caption = "Month Number";
            this.colMonthNum.FieldName = "MonthNum";
            this.colMonthNum.Name = "colMonthNum";
            this.colMonthNum.Visible = true;
            this.colMonthNum.VisibleIndex = 2;
            this.colMonthNum.Width = 79;
            // 
            // colYearNum
            // 
            this.colYearNum.Caption = "Year Number";
            this.colYearNum.FieldName = "YearNum";
            this.colYearNum.Name = "colYearNum";
            this.colYearNum.Visible = true;
            this.colYearNum.VisibleIndex = 3;
            // 
            // colNPSTarget
            // 
            this.colNPSTarget.Caption = "NPS Target";
            this.colNPSTarget.FieldName = "NPS Target";
            this.colNPSTarget.Name = "colNPSTarget";
            this.colNPSTarget.Visible = true;
            this.colNPSTarget.VisibleIndex = 4;
            // 
            // colInvoicesTarget
            // 
            this.colInvoicesTarget.Caption = "Invoices Target";
            this.colInvoicesTarget.FieldName = "Invoices Target";
            this.colInvoicesTarget.Name = "colInvoicesTarget";
            this.colInvoicesTarget.Visible = true;
            this.colInvoicesTarget.VisibleIndex = 5;
            this.colInvoicesTarget.Width = 84;
            // 
            // colAPOSTarget
            // 
            this.colAPOSTarget.Caption = "APOS Target";
            this.colAPOSTarget.FieldName = "APOS Target";
            this.colAPOSTarget.Name = "colAPOSTarget";
            this.colAPOSTarget.Visible = true;
            this.colAPOSTarget.VisibleIndex = 6;
            // 
            // colDropSizeTarget
            // 
            this.colDropSizeTarget.Caption = "Drop Size Target";
            this.colDropSizeTarget.FieldName = "Drop Size Target";
            this.colDropSizeTarget.Name = "colDropSizeTarget";
            this.colDropSizeTarget.Visible = true;
            this.colDropSizeTarget.VisibleIndex = 7;
            this.colDropSizeTarget.Width = 89;
            // 
            // colTrucks
            // 
            this.colTrucks.Caption = "Trucks";
            this.colTrucks.FieldName = "Trucks";
            this.colTrucks.Name = "colTrucks";
            this.colTrucks.Visible = true;
            this.colTrucks.VisibleIndex = 8;
            // 
            // colTPPBudget
            // 
            this.colTPPBudget.Caption = "TPP Budget";
            this.colTPPBudget.FieldName = "TPP Budget";
            this.colTPPBudget.Name = "colTPPBudget";
            this.colTPPBudget.Visible = true;
            this.colTPPBudget.VisibleIndex = 9;
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData.TargetKPIDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // salesDistrict2TableAdapter
            // 
            this.salesDistrict2TableAdapter.ClearBeforeFill = true;
            // 
            // brandRouteBindingSource
            // 
            this.brandRouteBindingSource.DataMember = "BrandRoute";
            this.brandRouteBindingSource.DataSource = this.dsQry;
            // 
            // brandRouteTableAdapter
            // 
            this.brandRouteTableAdapter.ClearBeforeFill = true;
            // 
            // TargetKPIEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TargetKPIEditorUC";
            this.Size = new System.Drawing.Size(652, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditSalesDistrict2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrict2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEditBrandRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandRouteBindingSource)).EndInit();
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
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict2;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthNum;
        private DevExpress.XtraGrid.Columns.GridColumn colYearNum;
        private DevExpress.XtraGrid.Columns.GridColumn colNPSTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicesTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colAPOSTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colDropSizeTarget;
        private DevExpress.XtraGrid.Columns.GridColumn colTrucks;
        private DevExpress.XtraGrid.Columns.GridColumn colTPPBudget;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditSalesDistrict2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.BindingSource salesDistrict2BindingSource;
        private NICSQLTools.Data.dsQry dsQry;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDistrict21;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEditBrandRoute;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter salesDistrict2TableAdapter;
        private System.Windows.Forms.BindingSource brandRouteBindingSource;
        private NICSQLTools.Data.dsQryTableAdapters.BrandRouteTableAdapter brandRouteTableAdapter;
    }
}
