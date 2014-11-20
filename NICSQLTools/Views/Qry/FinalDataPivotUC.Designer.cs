namespace NICSQLTools.Views.Qry
{
    partial class FinalDataPivotUC
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
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldBillingDocument1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVolume141 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldVolume131 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue141 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValue131 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCases141 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCases131 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMaterialName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBaseBaseProduct1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBrand1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName3Ar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomerType21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomerType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldName3En1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBrandRoute1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSupervisor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldASM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesDistrictName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRouteName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDayMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldyeard1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRouteSold1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMaterialNumber1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBillingdateforbil1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoldtoparty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDistributionChannel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBaseNew = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLevelCCSD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFRZbrand1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesDistrict21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.calcCases = new DevExpress.XtraPivotGrid.PivotGridField();
            this.calcValue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.calcVol = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(NICSQLTools.Data.Linq._0_0_Final_Data_All);
            this.LSMS.KeyExpression = "AutoKey";
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
            this.bbiExport});
            this.barManagerMain.MaxItemId = 3;
            this.barManagerMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::NICSQLTools.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(874, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 428);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 428);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // pivotGridControlMain
            // 
            this.pivotGridControlMain.DataSource = this.LSMS;
            this.pivotGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldBillingDocument1,
            this.fieldVolume141,
            this.fieldVolume131,
            this.fieldValue141,
            this.fieldValue131,
            this.fieldCases141,
            this.fieldCases131,
            this.fieldType1,
            this.fieldMaterialName1,
            this.fieldBaseBaseProduct1,
            this.fieldBrand1,
            this.fieldName3Ar,
            this.fieldCustomerType21,
            this.fieldCustomerType1,
            this.fieldName3En1,
            this.fieldBrandRoute1,
            this.fieldSupervisor1,
            this.fieldASM1,
            this.fieldSalesDistrictName1,
            this.fieldRouteName1,
            this.fieldDayMonth,
            this.fieldMonth1,
            this.fieldyeard1,
            this.fieldRouteSold1,
            this.fieldMaterialNumber1,
            this.fieldBillingdateforbil1,
            this.fieldSoldtoparty1,
            this.fieldDistributionChannel1,
            this.fieldBaseNew,
            this.fieldLevelCCSD1,
            this.fieldFRZbrand1,
            this.fieldSalesDistrict21,
            this.calcCases,
            this.calcValue,
            this.calcVol});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 31);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.OptionsBehavior.UseAsyncMode = true;
            this.pivotGridControlMain.OptionsData.FilterByVisibleFieldsOnly = true;
            this.pivotGridControlMain.OptionsFilterPopup.ShowOnlyAvailableItems = true;
            this.pivotGridControlMain.Size = new System.Drawing.Size(874, 428);
            this.pivotGridControlMain.TabIndex = 10;
            // 
            // fieldBillingDocument1
            // 
            this.fieldBillingDocument1.AreaIndex = 2;
            this.fieldBillingDocument1.Caption = "Billing Document";
            this.fieldBillingDocument1.FieldName = "Billing_Document";
            this.fieldBillingDocument1.Name = "fieldBillingDocument1";
            // 
            // fieldVolume141
            // 
            this.fieldVolume141.AreaIndex = 32;
            this.fieldVolume141.Caption = "Volume 14";
            this.fieldVolume141.FieldName = "Volume_14";
            this.fieldVolume141.Name = "fieldVolume141";
            // 
            // fieldVolume131
            // 
            this.fieldVolume131.AreaIndex = 33;
            this.fieldVolume131.Caption = "Volume 13";
            this.fieldVolume131.FieldName = "Volume_13";
            this.fieldVolume131.Name = "fieldVolume131";
            // 
            // fieldValue141
            // 
            this.fieldValue141.AreaIndex = 29;
            this.fieldValue141.Caption = "Value 14";
            this.fieldValue141.FieldName = "Value_14";
            this.fieldValue141.Name = "fieldValue141";
            // 
            // fieldValue131
            // 
            this.fieldValue131.AreaIndex = 30;
            this.fieldValue131.Caption = "Value 13";
            this.fieldValue131.FieldName = "Value_13";
            this.fieldValue131.Name = "fieldValue131";
            // 
            // fieldCases141
            // 
            this.fieldCases141.AreaIndex = 26;
            this.fieldCases141.Caption = "Cases 14";
            this.fieldCases141.FieldName = "Cases_14";
            this.fieldCases141.Name = "fieldCases141";
            // 
            // fieldCases131
            // 
            this.fieldCases131.AreaIndex = 27;
            this.fieldCases131.Caption = "Cases 13";
            this.fieldCases131.FieldName = "Cases_13";
            this.fieldCases131.Name = "fieldCases131";
            // 
            // fieldType1
            // 
            this.fieldType1.AreaIndex = 1;
            this.fieldType1.Caption = "Type";
            this.fieldType1.FieldName = "Type";
            this.fieldType1.Name = "fieldType1";
            // 
            // fieldMaterialName1
            // 
            this.fieldMaterialName1.AreaIndex = 3;
            this.fieldMaterialName1.Caption = "Material Name";
            this.fieldMaterialName1.FieldName = "Material_Name";
            this.fieldMaterialName1.Name = "fieldMaterialName1";
            // 
            // fieldBaseBaseProduct1
            // 
            this.fieldBaseBaseProduct1.AreaIndex = 4;
            this.fieldBaseBaseProduct1.Caption = "Base Base Product";
            this.fieldBaseBaseProduct1.FieldName = "Base_Base_Product";
            this.fieldBaseBaseProduct1.Name = "fieldBaseBaseProduct1";
            // 
            // fieldBrand1
            // 
            this.fieldBrand1.AreaIndex = 20;
            this.fieldBrand1.Caption = "Brand";
            this.fieldBrand1.FieldName = "Brand";
            this.fieldBrand1.Name = "fieldBrand1";
            // 
            // fieldName3Ar
            // 
            this.fieldName3Ar.AreaIndex = 5;
            this.fieldName3Ar.Caption = "Name 3 Ar";
            this.fieldName3Ar.FieldName = "Name_3_Ar";
            this.fieldName3Ar.Name = "fieldName3Ar";
            // 
            // fieldCustomerType21
            // 
            this.fieldCustomerType21.AreaIndex = 6;
            this.fieldCustomerType21.Caption = "Customer Type 2";
            this.fieldCustomerType21.FieldName = "Customer_Type_2";
            this.fieldCustomerType21.Name = "fieldCustomerType21";
            // 
            // fieldCustomerType1
            // 
            this.fieldCustomerType1.AreaIndex = 7;
            this.fieldCustomerType1.Caption = "Customer Type";
            this.fieldCustomerType1.FieldName = "Customer_Type";
            this.fieldCustomerType1.Name = "fieldCustomerType1";
            // 
            // fieldName3En1
            // 
            this.fieldName3En1.AreaIndex = 8;
            this.fieldName3En1.Caption = "Name 3 En";
            this.fieldName3En1.FieldName = "Name_3_En";
            this.fieldName3En1.Name = "fieldName3En1";
            // 
            // fieldBrandRoute1
            // 
            this.fieldBrandRoute1.AreaIndex = 9;
            this.fieldBrandRoute1.Caption = "Brand Route";
            this.fieldBrandRoute1.FieldName = "Brand_Route";
            this.fieldBrandRoute1.Name = "fieldBrandRoute1";
            // 
            // fieldSupervisor1
            // 
            this.fieldSupervisor1.AreaIndex = 25;
            this.fieldSupervisor1.Caption = "Supervisor";
            this.fieldSupervisor1.FieldName = "Supervisor";
            this.fieldSupervisor1.Name = "fieldSupervisor1";
            // 
            // fieldASM1
            // 
            this.fieldASM1.AreaIndex = 24;
            this.fieldASM1.Caption = "ASM";
            this.fieldASM1.FieldName = "ASM";
            this.fieldASM1.Name = "fieldASM1";
            // 
            // fieldSalesDistrictName1
            // 
            this.fieldSalesDistrictName1.AreaIndex = 22;
            this.fieldSalesDistrictName1.Caption = "Sales District Name";
            this.fieldSalesDistrictName1.FieldName = "Sales_District_Name";
            this.fieldSalesDistrictName1.Name = "fieldSalesDistrictName1";
            // 
            // fieldRouteName1
            // 
            this.fieldRouteName1.AreaIndex = 10;
            this.fieldRouteName1.Caption = "Route Name";
            this.fieldRouteName1.FieldName = "Route_Name";
            this.fieldRouteName1.Name = "fieldRouteName1";
            // 
            // fieldDayMonth
            // 
            this.fieldDayMonth.AreaIndex = 11;
            this.fieldDayMonth.Caption = "Day Month";
            this.fieldDayMonth.FieldName = "Day_Month";
            this.fieldDayMonth.Name = "fieldDayMonth";
            // 
            // fieldMonth1
            // 
            this.fieldMonth1.AreaIndex = 12;
            this.fieldMonth1.Caption = "Month";
            this.fieldMonth1.FieldName = "Month";
            this.fieldMonth1.Name = "fieldMonth1";
            // 
            // fieldyeard1
            // 
            this.fieldyeard1.AreaIndex = 13;
            this.fieldyeard1.Caption = "yeard";
            this.fieldyeard1.FieldName = "yeard";
            this.fieldyeard1.Name = "fieldyeard1";
            // 
            // fieldRouteSold1
            // 
            this.fieldRouteSold1.AreaIndex = 14;
            this.fieldRouteSold1.Caption = "Route & Sold";
            this.fieldRouteSold1.FieldName = "Route___Sold";
            this.fieldRouteSold1.Name = "fieldRouteSold1";
            // 
            // fieldMaterialNumber1
            // 
            this.fieldMaterialNumber1.AreaIndex = 15;
            this.fieldMaterialNumber1.Caption = "Material Number";
            this.fieldMaterialNumber1.FieldName = "Material_Number";
            this.fieldMaterialNumber1.Name = "fieldMaterialNumber1";
            // 
            // fieldBillingdateforbil1
            // 
            this.fieldBillingdateforbil1.AreaIndex = 0;
            this.fieldBillingdateforbil1.Caption = "Billing date for bil";
            this.fieldBillingdateforbil1.FieldName = "Billing_date_for_bil";
            this.fieldBillingdateforbil1.Name = "fieldBillingdateforbil1";
            this.fieldBillingdateforbil1.Options.ShowValues = false;
            // 
            // fieldSoldtoparty1
            // 
            this.fieldSoldtoparty1.AreaIndex = 16;
            this.fieldSoldtoparty1.Caption = "Sold to party";
            this.fieldSoldtoparty1.FieldName = "Sold_to_party";
            this.fieldSoldtoparty1.Name = "fieldSoldtoparty1";
            // 
            // fieldDistributionChannel1
            // 
            this.fieldDistributionChannel1.AreaIndex = 21;
            this.fieldDistributionChannel1.Caption = "Distribution Channel";
            this.fieldDistributionChannel1.FieldName = "Distribution_Channel";
            this.fieldDistributionChannel1.Name = "fieldDistributionChannel1";
            // 
            // fieldBaseNew
            // 
            this.fieldBaseNew.AreaIndex = 17;
            this.fieldBaseNew.Caption = "Base New";
            this.fieldBaseNew.FieldName = "Base_New";
            this.fieldBaseNew.Name = "fieldBaseNew";
            // 
            // fieldLevelCCSD1
            // 
            this.fieldLevelCCSD1.AreaIndex = 18;
            this.fieldLevelCCSD1.Caption = "Level CCSD";
            this.fieldLevelCCSD1.FieldName = "Level_CCSD";
            this.fieldLevelCCSD1.Name = "fieldLevelCCSD1";
            // 
            // fieldFRZbrand1
            // 
            this.fieldFRZbrand1.AreaIndex = 19;
            this.fieldFRZbrand1.Caption = "FRZ brand";
            this.fieldFRZbrand1.FieldName = "FRZ_brand";
            this.fieldFRZbrand1.Name = "fieldFRZbrand1";
            // 
            // fieldSalesDistrict21
            // 
            this.fieldSalesDistrict21.AreaIndex = 23;
            this.fieldSalesDistrict21.Caption = "Sales District 2";
            this.fieldSalesDistrict21.FieldName = "Sales_District_2";
            this.fieldSalesDistrict21.Name = "fieldSalesDistrict21";
            // 
            // calcCases
            // 
            this.calcCases.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.calcCases.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.calcCases.AreaIndex = 28;
            this.calcCases.Caption = "% Cases";
            this.calcCases.EmptyCellText = "0";
            this.calcCases.EmptyValueText = "0";
            this.calcCases.GrandTotalCellFormat.FormatString = "p";
            this.calcCases.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcCases.Name = "calcCases";
            this.calcCases.Options.AllowRunTimeSummaryChange = true;
            this.calcCases.Options.ShowUnboundExpressionMenu = true;
            this.calcCases.UnboundExpression = "[Cases_14] / [Cases_13]";
            this.calcCases.UnboundFieldName = "calcCases";
            this.calcCases.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // calcValue
            // 
            this.calcValue.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.calcValue.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.calcValue.AreaIndex = 31;
            this.calcValue.Caption = "% Value";
            this.calcValue.EmptyCellText = "0";
            this.calcValue.EmptyValueText = "0";
            this.calcValue.GrandTotalCellFormat.FormatString = "p";
            this.calcValue.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcValue.Name = "calcValue";
            this.calcValue.Options.AllowRunTimeSummaryChange = true;
            this.calcValue.Options.ShowUnboundExpressionMenu = true;
            this.calcValue.UnboundExpression = "[Value_14] / [Value_13]";
            this.calcValue.UnboundFieldName = "calcValue";
            this.calcValue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // calcVol
            // 
            this.calcVol.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.calcVol.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.calcVol.AreaIndex = 34;
            this.calcVol.Caption = "% Volume";
            this.calcVol.EmptyCellText = "0";
            this.calcVol.EmptyValueText = "0";
            this.calcVol.GrandTotalCellFormat.FormatString = "p";
            this.calcVol.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcVol.Name = "calcVol";
            this.calcVol.Options.AllowRunTimeSummaryChange = true;
            this.calcVol.Options.ShowUnboundExpressionMenu = true;
            this.calcVol.UnboundExpression = "[Volume_14] / [Volume_13]";
            this.calcVol.UnboundFieldName = "calcVol";
            this.calcVol.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // FinalDataPivotUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FinalDataPivotUC";
            this.Size = new System.Drawing.Size(874, 459);
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBillingDocument1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVolume141;
        private DevExpress.XtraPivotGrid.PivotGridField fieldVolume131;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue141;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValue131;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCases141;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCases131;
        private DevExpress.XtraPivotGrid.PivotGridField fieldType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMaterialName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBaseBaseProduct1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBrand1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName3Ar;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomerType21;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomerType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName3En1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBrandRoute1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSupervisor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldASM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesDistrictName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRouteName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDayMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldyeard1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRouteSold1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMaterialNumber1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBillingdateforbil1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoldtoparty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDistributionChannel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBaseNew;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLevelCCSD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFRZbrand1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesDistrict21;
        private DevExpress.XtraPivotGrid.PivotGridField calcCases;
        private DevExpress.XtraPivotGrid.PivotGridField calcValue;
        private DevExpress.XtraPivotGrid.PivotGridField calcVol;
    }
}
