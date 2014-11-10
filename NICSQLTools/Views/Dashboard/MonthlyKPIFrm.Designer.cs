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
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItemMain = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItemMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItemMain
            // 
            this.chartDashboardItemMain.AxisX.TitleVisible = false;
            this.chartDashboardItemMain.ComponentName = "chartDashboardItemMain";
            this.chartDashboardItemMain.DataItemRepository.Clear();
            this.chartDashboardItemMain.IgnoreMasterFilters = false;
            this.chartDashboardItemMain.Name = "Sales Vs Target";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            this.chartDashboardItemMain.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItemMain.ShowCaption = true;
            // 
            // ChartControlFrm
            // 
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItemMain});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItemMain;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItemMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItemMain;

    }
}
