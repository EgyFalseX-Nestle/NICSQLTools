namespace NICSQLTools.Views.Dashboard
{
    partial class ChartControlFrm
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
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardParameter dashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
            DevExpress.DashboardCommon.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.DashboardCommon.DynamicListLookUpSettings();
            this.chartDashboardItemMain = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dataSourceMain = new DevExpress.DashboardCommon.DataSource();
            this.dsSP1 = new NICSQLTools.Data.dsSP();
            this.dataSourceSDN = new DevExpress.DashboardCommon.DataSource();
            this.dsQry1 = new NICSQLTools.Data.dsQry();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItemMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceSDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItemMain
            // 
            dimension1.DataMember = "Month";
            this.chartDashboardItemMain.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.chartDashboardItemMain.AxisX.TitleVisible = false;
            this.chartDashboardItemMain.ComponentName = "chartDashboardItemMain";
            measure1.DataMember = "Percentage";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure1.NumericFormat.Precision = 1;
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            this.chartDashboardItemMain.DataItemRepository.Clear();
            this.chartDashboardItemMain.DataItemRepository.Add(dimension1, "DataItem0");
            this.chartDashboardItemMain.DataItemRepository.Add(measure1, "DataItem1");
            this.chartDashboardItemMain.DataSource = this.dataSourceMain;
            this.chartDashboardItemMain.IgnoreMasterFilters = false;
            this.chartDashboardItemMain.Name = "Sales Vs Target";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Percentage (Sum)";
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItemMain.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItemMain.ShowCaption = true;
            // 
            // dataSourceMain
            // 
            this.dataSourceMain.ComponentName = "dataSourceMain";
            this.dataSourceMain.Data = this.dsSP1;
            this.dataSourceMain.DataMember = "sp_DashboardV01";
            this.dataSourceMain.Name = "Data Source Main";
            // 
            // dsSP1
            // 
            this.dsSP1.DataSetName = "dsSP";
            this.dsSP1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSourceSDN
            // 
            this.dataSourceSDN.ComponentName = "dataSourceSDN";
            this.dataSourceSDN.Data = this.dsQry1;
            this.dataSourceSDN.DataMember = "SalesDistrict2";
            this.dataSourceSDN.Name = "Data Source SDN";
            // 
            // dsQry1
            // 
            this.dsQry1.DataSetName = "dsQry";
            this.dsQry1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChartControlFrm
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSourceMain,
            this.dataSourceSDN});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItemMain});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItemMain;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            dynamicListLookUpSettings1.DataSourceName = "dataSourceSDN";
            dynamicListLookUpSettings1.DisplayMember = "Sales District 2";
            dynamicListLookUpSettings1.ValueMember = "Sales District 2";
            dashboardParameter1.LookUpSettings = dynamicListLookUpSettings1;
            dashboardParameter1.Name = "PramSDN2";
            dashboardParameter1.Type = typeof(string);
            dashboardParameter1.Value = "";
            this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {
            dashboardParameter1});
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItemMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceSDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItemMain;
        private DevExpress.DashboardCommon.DataSource dataSourceMain;
        private NICSQLTools.Data.dsSP dsSP1;
        private DevExpress.DashboardCommon.DataSource dataSourceSDN;
        private NICSQLTools.Data.dsQry dsQry1;

    }
}
