namespace NICSQLTools.Views.Dashboard
{
    partial class DashboardViewerUC
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
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.dashboardViewerMain = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.dockManagerMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelDashboard = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControlParamter = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupParamters = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlDashboards = new DevExpress.XtraLayout.LayoutControl();
            this.ppWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnLoadDashboard = new DevExpress.XtraEditors.SimpleButton();
            this.lueDashboard = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSSchema = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDashboardSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshAll = new DevExpress.XtraEditors.SimpleButton();
            this.pbcRefresh = new DevExpress.XtraEditors.ProgressBarControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWait = new DevExpress.XtraLayout.LayoutControlItem();
            this.appDashboardDSTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDashboardDSTableAdapter();
            this.appDashboardDSPramTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDashboardDSPramTableAdapter();
            this.appDashboardSchemaTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.AppDashboardSchemaTableAdapter();
            this.get_sp_PramTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerMain)).BeginInit();
            this.dockPanelDashboard.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlParamter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupParamters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDashboards)).BeginInit();
            this.layoutControlDashboards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDashboard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWait)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "d/M/yyyy hh:mm:ss";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "d/M/yyyy hh:mm:ss";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "d/M/yyyy hh:mm:ss";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // dashboardViewerMain
            // 
            this.dashboardViewerMain.AllowPrintDashboardItems = true;
            this.dashboardViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewerMain.Location = new System.Drawing.Point(281, 0);
            this.dashboardViewerMain.Name = "dashboardViewerMain";
            this.dashboardViewerMain.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.SeparatePage;
            this.dashboardViewerMain.PrintingOptions.FontInfo.GdiCharSet = ((byte)(0));
            this.dashboardViewerMain.PrintingOptions.FontInfo.Name = null;
            this.dashboardViewerMain.Size = new System.Drawing.Size(476, 494);
            this.dashboardViewerMain.TabIndex = 0;
            // 
            // dockManagerMain
            // 
            this.dockManagerMain.Form = this;
            this.dockManagerMain.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelDashboard});
            this.dockManagerMain.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanelDashboard
            // 
            this.dockPanelDashboard.Controls.Add(this.dockPanel2_Container);
            this.dockPanelDashboard.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelDashboard.ID = new System.Guid("2fa5a753-1d56-4b04-8069-bd742a7da53c");
            this.dockPanelDashboard.Location = new System.Drawing.Point(0, 0);
            this.dockPanelDashboard.Name = "dockPanelDashboard";
            this.dockPanelDashboard.OriginalSize = new System.Drawing.Size(281, 200);
            this.dockPanelDashboard.Size = new System.Drawing.Size(281, 494);
            this.dockPanelDashboard.Text = "Dashborad";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.layoutControlParamter);
            this.dockPanel2_Container.Controls.Add(this.layoutControlDashboards);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(273, 467);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // layoutControlParamter
            // 
            this.layoutControlParamter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlParamter.Location = new System.Drawing.Point(0, 195);
            this.layoutControlParamter.Name = "layoutControlParamter";
            this.layoutControlParamter.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(726, 151, 434, 493);
            this.layoutControlParamter.Root = this.layoutControlGroup2;
            this.layoutControlParamter.Size = new System.Drawing.Size(273, 272);
            this.layoutControlParamter.TabIndex = 1;
            this.layoutControlParamter.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Root";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupParamters});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(273, 272);
            this.layoutControlGroup2.Text = "Root";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroupParamters
            // 
            this.layoutControlGroupParamters.CustomizationFormText = "Paramters";
            this.layoutControlGroupParamters.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupParamters.Name = "layoutControlGroupParamters";
            this.layoutControlGroupParamters.Size = new System.Drawing.Size(253, 252);
            this.layoutControlGroupParamters.Text = "Paramters";
            // 
            // layoutControlDashboards
            // 
            this.layoutControlDashboards.Controls.Add(this.ppWait);
            this.layoutControlDashboards.Controls.Add(this.btnLoadDashboard);
            this.layoutControlDashboards.Controls.Add(this.lueDashboard);
            this.layoutControlDashboards.Controls.Add(this.btnRefreshAll);
            this.layoutControlDashboards.Controls.Add(this.pbcRefresh);
            this.layoutControlDashboards.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControlDashboards.Location = new System.Drawing.Point(0, 0);
            this.layoutControlDashboards.Name = "layoutControlDashboards";
            this.layoutControlDashboards.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(567, 159, 328, 452);
            this.layoutControlDashboards.Root = this.layoutControlGroup1;
            this.layoutControlDashboards.Size = new System.Drawing.Size(273, 195);
            this.layoutControlDashboards.TabIndex = 0;
            this.layoutControlDashboards.Text = "layoutControl1";
            // 
            // ppWait
            // 
            this.ppWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppWait.Appearance.Options.UseBackColor = true;
            this.ppWait.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ppWait.AppearanceCaption.Options.UseFont = true;
            this.ppWait.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ppWait.AppearanceDescription.Options.UseFont = true;
            this.ppWait.Location = new System.Drawing.Point(12, 128);
            this.ppWait.Name = "ppWait";
            this.ppWait.Size = new System.Drawing.Size(249, 46);
            this.ppWait.StyleController = this.layoutControlDashboards;
            this.ppWait.TabIndex = 2;
            this.ppWait.Text = "Loading ...";
            // 
            // btnLoadDashboard
            // 
            this.btnLoadDashboard.Image = global::NICSQLTools.Properties.Resources.done;
            this.btnLoadDashboard.Location = new System.Drawing.Point(12, 36);
            this.btnLoadDashboard.Name = "btnLoadDashboard";
            this.btnLoadDashboard.Size = new System.Drawing.Size(249, 31);
            this.btnLoadDashboard.StyleController = this.layoutControlDashboards;
            this.btnLoadDashboard.TabIndex = 1;
            this.btnLoadDashboard.Text = "Load Dashboard";
            this.btnLoadDashboard.Click += new System.EventHandler(this.btnLoadDashboard_Click);
            // 
            // lueDashboard
            // 
            this.lueDashboard.EditValue = "";
            this.lueDashboard.Location = new System.Drawing.Point(67, 12);
            this.lueDashboard.Name = "lueDashboard";
            this.lueDashboard.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueDashboard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDashboard.Properties.DataSource = this.LSMSSchema;
            this.lueDashboard.Properties.DisplayMember = "DashboardSchemaName";
            this.lueDashboard.Properties.NullText = "";
            this.lueDashboard.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.lueDashboard.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUserIn});
            this.lueDashboard.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDashboard.Properties.ValueMember = "DashboardSchemaId";
            this.lueDashboard.Properties.View = this.gridLookUpEdit1View;
            this.lueDashboard.Size = new System.Drawing.Size(194, 20);
            this.lueDashboard.StyleController = this.layoutControlDashboards;
            this.lueDashboard.TabIndex = 0;
            // 
            // LSMSSchema
            // 
            this.LSMSSchema.ElementType = typeof(NICSQLTools.Data.Linq.AppDashboardSchema);
            this.LSMSSchema.KeyExpression = "[DashboardSchemaId]";
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.DataSource = this.LSMSUser;
            this.repositoryItemLookUpEditUserIn.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
            // 
            // LSMSUser
            // 
            this.LSMSUser.ElementType = typeof(NICSQLTools.Data.Linq.User);
            this.LSMSUser.KeyExpression = "[UserID]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDashboardSchemaName,
            this.colDateIn,
            this.colUserIn});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // colDashboardSchemaName
            // 
            this.colDashboardSchemaName.Caption = "Dashboard Schema Name";
            this.colDashboardSchemaName.FieldName = "DashboardSchemaName";
            this.colDashboardSchemaName.Name = "colDashboardSchemaName";
            this.colDashboardSchemaName.Visible = true;
            this.colDashboardSchemaName.VisibleIndex = 0;
            // 
            // colDateIn
            // 
            this.colDateIn.Caption = "Last Edit";
            this.colDateIn.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 1;
            // 
            // colUserIn
            // 
            this.colUserIn.Caption = "Owner";
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUserIn;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 2;
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Image = global::NICSQLTools.Properties.Resources.refresh2_32x32;
            this.btnRefreshAll.Location = new System.Drawing.Point(12, 71);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(249, 31);
            this.btnRefreshAll.StyleController = this.layoutControlDashboards;
            this.btnRefreshAll.TabIndex = 4;
            this.btnRefreshAll.Text = "Refresh All";
            // 
            // pbcRefresh
            // 
            this.pbcRefresh.Location = new System.Drawing.Point(12, 106);
            this.pbcRefresh.Name = "pbcRefresh";
            this.pbcRefresh.Size = new System.Drawing.Size(249, 18);
            this.pbcRefresh.StyleController = this.layoutControlDashboards;
            this.pbcRefresh.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.lciWait});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(273, 195);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueDashboard;
            this.layoutControlItem1.CustomizationFormText = "lueDashboard";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(253, 24);
            this.layoutControlItem1.Text = "Dashboard";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLoadDashboard;
            this.layoutControlItem2.CustomizationFormText = "btnLoad";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 35);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(128, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(253, 35);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRefreshAll;
            this.layoutControlItem3.CustomizationFormText = "btnRefeshAll";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 35);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(102, 35);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(253, 35);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.pbcRefresh;
            this.layoutControlItem4.CustomizationFormText = "pbProgressAll";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(253, 22);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // lciWait
            // 
            this.lciWait.Control = this.ppWait;
            this.lciWait.CustomizationFormText = "lciWait";
            this.lciWait.Location = new System.Drawing.Point(0, 116);
            this.lciWait.MaxSize = new System.Drawing.Size(0, 50);
            this.lciWait.MinSize = new System.Drawing.Size(54, 50);
            this.lciWait.Name = "lciWait";
            this.lciWait.Size = new System.Drawing.Size(253, 59);
            this.lciWait.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciWait.Text = "lciWait";
            this.lciWait.TextSize = new System.Drawing.Size(0, 0);
            this.lciWait.TextToControlDistance = 0;
            this.lciWait.TextVisible = false;
            this.lciWait.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // appDashboardDSTableAdapter
            // 
            this.appDashboardDSTableAdapter.ClearBeforeFill = true;
            // 
            // appDashboardDSPramTableAdapter
            // 
            this.appDashboardDSPramTableAdapter.ClearBeforeFill = true;
            // 
            // appDashboardSchemaTableAdapter
            // 
            this.appDashboardSchemaTableAdapter.ClearBeforeFill = true;
            // 
            // get_sp_PramTableAdapter
            // 
            this.get_sp_PramTableAdapter.ClearBeforeFill = true;
            // 
            // DashboardViewerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardViewerMain);
            this.Controls.Add(this.dockPanelDashboard);
            this.Name = "DashboardViewerUC";
            this.Size = new System.Drawing.Size(757, 494);
            this.Load += new System.EventHandler(this.DashboardViewerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManagerMain)).EndInit();
            this.dockPanelDashboard.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlParamter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupParamters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDashboards)).EndInit();
            this.layoutControlDashboards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueDashboard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewerMain;
        private DevExpress.XtraBars.Docking.DockManager dockManagerMain;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelDashboard;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControlDashboards;
        private DevExpress.XtraEditors.GridLookUpEdit lueDashboard;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLoadDashboard;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControlParamter;
        private DevExpress.XtraEditors.ProgressBarControl pbcRefresh;
        private DevExpress.XtraEditors.SimpleButton btnRefreshAll;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private NICSQLTools.Data.dsDataTableAdapters.AppDashboardDSTableAdapter appDashboardDSTableAdapter;
        private NICSQLTools.Data.dsDataTableAdapters.AppDashboardDSPramTableAdapter appDashboardDSPramTableAdapter;
        private NICSQLTools.Data.dsDataTableAdapters.AppDashboardSchemaTableAdapter appDashboardSchemaTableAdapter;
        private NICSQLTools.Data.dsQryTableAdapters.Get_sp_PramTableAdapter get_sp_PramTableAdapter;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSchema;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUser;
        private DevExpress.XtraWaitForm.ProgressPanel ppWait;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem lciWait;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupParamters;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
    }
}
