namespace NICSQLTools.Views.Qry.MSrv
{
    partial class MSrv_04
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.qry04BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMSrc = new NICSQLTools.Data.dsMSrc();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechnicianId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechnicianName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechnicianCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colActualPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiStartDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bbiEndDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bbiExecute = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qry04TableAdapter = new NICSQLTools.Data.dsMSrcTableAdapters.Qry04TableAdapter();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry04BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gridControlMain.DataSource = this.qry04BindingSource;
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditn0,
            this.repositoryItemTextEditn2});
            this.gridControlMain.ShowOnlyPredefinedDetails = true;
            this.gridControlMain.Size = new System.Drawing.Size(876, 380);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // qry04BindingSource
            // 
            this.qry04BindingSource.DataMember = "Qry04";
            this.qry04BindingSource.DataSource = this.dsMSrc;
            // 
            // dsMSrc
            // 
            this.dsMSrc.DataSetName = "dsMSrc";
            this.dsMSrc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewMain.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTechnicianId,
            this.colTechnicianName1,
            this.colTechnicianCompany,
            this.colPartId,
            this.colPartName1,
            this.colQuantity1,
            this.colActualPrice2});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewMain.OptionsDetail.SmartDetailHeight = true;
            this.gridViewMain.OptionsPrint.AllowMultilineHeaders = true;
            this.gridViewMain.OptionsPrint.AutoWidth = false;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colTechnicianId
            // 
            this.colTechnicianId.Caption = "Technician Id";
            this.colTechnicianId.FieldName = "TechnicianId";
            this.colTechnicianId.Name = "colTechnicianId";
            this.colTechnicianId.Visible = true;
            this.colTechnicianId.VisibleIndex = 0;
            // 
            // colTechnicianName1
            // 
            this.colTechnicianName1.Caption = "Technician Name";
            this.colTechnicianName1.FieldName = "TechnicianName";
            this.colTechnicianName1.Name = "colTechnicianName1";
            this.colTechnicianName1.Visible = true;
            this.colTechnicianName1.VisibleIndex = 1;
            // 
            // colTechnicianCompany
            // 
            this.colTechnicianCompany.Caption = "Technician Company";
            this.colTechnicianCompany.FieldName = "TechnicianCompany";
            this.colTechnicianCompany.Name = "colTechnicianCompany";
            this.colTechnicianCompany.Visible = true;
            this.colTechnicianCompany.VisibleIndex = 2;
            // 
            // colPartId
            // 
            this.colPartId.Caption = "Part Id";
            this.colPartId.FieldName = "PartId";
            this.colPartId.Name = "colPartId";
            this.colPartId.Visible = true;
            this.colPartId.VisibleIndex = 3;
            // 
            // colPartName1
            // 
            this.colPartName1.Caption = "Part Name";
            this.colPartName1.FieldName = "PartName";
            this.colPartName1.Name = "colPartName1";
            this.colPartName1.Visible = true;
            this.colPartName1.VisibleIndex = 4;
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Quantity";
            this.colQuantity1.ColumnEdit = this.repositoryItemTextEditn0;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 5;
            // 
            // repositoryItemTextEditn0
            // 
            this.repositoryItemTextEditn0.AutoHeight = false;
            this.repositoryItemTextEditn0.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEditn0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn0.EditFormat.FormatString = "n0";
            this.repositoryItemTextEditn0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn0.Mask.EditMask = "n0";
            this.repositoryItemTextEditn0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn0.Name = "repositoryItemTextEditn0";
            // 
            // colActualPrice2
            // 
            this.colActualPrice2.Caption = "Value";
            this.colActualPrice2.ColumnEdit = this.repositoryItemTextEditn2;
            this.colActualPrice2.FieldName = "ActualPrice";
            this.colActualPrice2.Name = "colActualPrice2";
            this.colActualPrice2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ActualPrice", "{0:0.##}")});
            this.colActualPrice2.Visible = true;
            this.colActualPrice2.VisibleIndex = 6;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(900, 404);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(900, 404);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(880, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            this.bbiExecute,
            this.bbiStartDate,
            this.bbiEndDate});
            this.barManagerMain.MaxItemId = 6;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(1691, 777);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.bbiStartDate, "", false, true, true, 141),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.bbiEndDate, "", false, true, true, 127),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExecute),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiStartDate
            // 
            this.bbiStartDate.Caption = "Start Date";
            this.bbiStartDate.Edit = this.repositoryItemDateEdit1;
            this.bbiStartDate.Id = 4;
            this.bbiStartDate.Name = "bbiStartDate";
            this.bbiStartDate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // bbiEndDate
            // 
            this.bbiEndDate.Caption = "End Date";
            this.bbiEndDate.Edit = this.repositoryItemDateEdit2;
            this.bbiEndDate.Id = 5;
            this.bbiEndDate.Name = "bbiEndDate";
            this.bbiEndDate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // bbiExecute
            // 
            this.bbiExecute.Caption = "Run";
            this.bbiExecute.Glyph = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.bbiExecute.Id = 3;
            this.bbiExecute.Name = "bbiExecute";
            this.bbiExecute.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiExecute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExecute_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(900, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Size = new System.Drawing.Size(900, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(900, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // qry04TableAdapter
            // 
            this.qry04TableAdapter.ClearBeforeFill = true;
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
            // MSrv_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MSrv_04";
            this.Size = new System.Drawing.Size(900, 435);
            this.Load += new System.EventHandler(this.MSrv_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry04BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private NICSQLTools.Data.dsMSrc dsMSrc;
        private DevExpress.XtraBars.BarEditItem bbiStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem bbiEndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem bbiExecute;
        private System.Windows.Forms.BindingSource qry04BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnicianId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn0;
        private DevExpress.XtraGrid.Columns.GridColumn colActualPrice2;
        private NICSQLTools.Data.dsMSrcTableAdapters.Qry04TableAdapter qry04TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnicianCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnicianName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
    }
}
