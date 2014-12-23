namespace NICSQLTools.Views.Dashboard
{
    partial class DatasourceOpenDlg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasourceOpenDlg));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.LSMSDatasource = new DevExpress.Data.Linq.LinqServerModeSource();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDSCategoryDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LSMSCategory = new DevExpress.Data.Linq.LinqServerModeSource();
            this.imageCollectionNormal = new DevExpress.Utils.ImageCollection(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDatasourceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDashboardSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDateIn = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDatasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // LSMSDatasource
            // 
            this.LSMSDatasource.ElementType = typeof(NICSQLTools.Data.Linq.vAppDatasource_LUE);
            this.LSMSDatasource.KeyExpression = "[DatasourceID]";
            // 
            // groupControlMain
            // 
            this.groupControlMain.Controls.Add(this.btnClose);
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlMain.Location = new System.Drawing.Point(0, 315);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(867, 66);
            this.groupControlMain.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::NICSQLTools.Properties.Resources.Stop;
            this.btnClose.Location = new System.Drawing.Point(750, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.colDSCategoryDesc});
            this.treeListMain.DataSource = this.LSMSCategory;
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.KeyFieldName = "DSCategoryId";
            this.treeListMain.Location = new System.Drawing.Point(0, 0);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.AutoMoveRowFocus = true;
            this.treeListMain.OptionsBehavior.Editable = false;
            this.treeListMain.OptionsBehavior.EnableFiltering = true;
            this.treeListMain.OptionsBehavior.EnterMovesNextColumn = true;
            this.treeListMain.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListMain.OptionsLayout.LayoutVersion = "1";
            this.treeListMain.OptionsView.AutoWidth = false;
            this.treeListMain.OptionsView.ShowAutoFilterRow = true;
            this.treeListMain.ParentFieldName = "DSCategoryParent";
            this.treeListMain.SelectImageList = this.imageCollectionNormal;
            this.treeListMain.Size = new System.Drawing.Size(347, 315);
            this.treeListMain.TabIndex = 11;
            this.treeListMain.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMain_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "DSCategoryName";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 98;
            // 
            // colDSCategoryDesc
            // 
            this.colDSCategoryDesc.Caption = "Description";
            this.colDSCategoryDesc.FieldName = "DSCategoryDesc";
            this.colDSCategoryDesc.Name = "colDSCategoryDesc";
            this.colDSCategoryDesc.Visible = true;
            this.colDSCategoryDesc.VisibleIndex = 1;
            this.colDSCategoryDesc.Width = 98;
            // 
            // LSMSCategory
            // 
            this.LSMSCategory.ElementType = typeof(NICSQLTools.Data.Linq.vAppDSCategory);
            this.LSMSCategory.KeyExpression = "[DSCategoryId]";
            // 
            // imageCollectionNormal
            // 
            this.imageCollectionNormal.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNormal.ImageStream")));
            this.imageCollectionNormal.InsertImage(global::NICSQLTools.Properties.Resources.open_16x16, "open_16x16", typeof(global::NICSQLTools.Properties.Resources), 0);
            this.imageCollectionNormal.Images.SetKeyName(0, "open_16x16");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(867, 315);
            this.splitContainerControl1.SplitterPosition = 347;
            this.splitContainerControl1.TabIndex = 12;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlMain
            // 
            this.gridControlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMain.DataSource = this.LSMSDatasource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDateIn,
            this.repositoryItemButtonEditSelect,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.Size = new System.Drawing.Size(515, 315);
            this.gridControlMain.TabIndex = 1;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDatasourceID,
            this.colDashboardSchemaName,
            this.colUserIn,
            this.colDateIn});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.ShowIndicator = false;
            // 
            // colDatasourceID
            // 
            this.colDatasourceID.AppearanceCell.Options.UseTextOptions = true;
            this.colDatasourceID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDatasourceID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDatasourceID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDatasourceID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDatasourceID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDatasourceID.Caption = "Select";
            this.colDatasourceID.ColumnEdit = this.repositoryItemButtonEditSelect;
            this.colDatasourceID.FieldName = "DatasourceID";
            this.colDatasourceID.Name = "colDatasourceID";
            this.colDatasourceID.Visible = true;
            this.colDatasourceID.VisibleIndex = 0;
            this.colDatasourceID.Width = 67;
            // 
            // repositoryItemButtonEditSelect
            // 
            this.repositoryItemButtonEditSelect.AutoHeight = false;
            this.repositoryItemButtonEditSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, global::NICSQLTools.Properties.Resources.apply_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditSelect.Name = "repositoryItemButtonEditSelect";
            this.repositoryItemButtonEditSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSelect.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSelect_ButtonClick);
            // 
            // colDashboardSchemaName
            // 
            this.colDashboardSchemaName.AppearanceCell.Options.UseTextOptions = true;
            this.colDashboardSchemaName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDashboardSchemaName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDashboardSchemaName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDashboardSchemaName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDashboardSchemaName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDashboardSchemaName.Caption = "Data Source";
            this.colDashboardSchemaName.FieldName = "DatasourceName";
            this.colDashboardSchemaName.Name = "colDashboardSchemaName";
            this.colDashboardSchemaName.Visible = true;
            this.colDashboardSchemaName.VisibleIndex = 1;
            this.colDashboardSchemaName.Width = 156;
            // 
            // colUserIn
            // 
            this.colUserIn.AppearanceCell.Options.UseTextOptions = true;
            this.colUserIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUserIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUserIn.Caption = "Last Edit User";
            this.colUserIn.FieldName = "RealName";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 2;
            this.colUserIn.Width = 132;
            // 
            // colDateIn
            // 
            this.colDateIn.AppearanceCell.Options.UseTextOptions = true;
            this.colDateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDateIn.Caption = "Edit Date";
            this.colDateIn.ColumnEdit = this.repositoryItemDateEditDateIn;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 3;
            this.colDateIn.Width = 135;
            // 
            // repositoryItemDateEditDateIn
            // 
            this.repositoryItemDateEditDateIn.AutoHeight = false;
            this.repositoryItemDateEditDateIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateIn.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDateIn.DisplayFormat.FormatString = "f";
            this.repositoryItemDateEditDateIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateIn.EditFormat.FormatString = "f";
            this.repositoryItemDateEditDateIn.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDateIn.Mask.EditMask = "d/M/yyyy HH:mm:ss";
            this.repositoryItemDateEditDateIn.Name = "repositoryItemDateEditDateIn";
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // DatasourceOpenDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(867, 381);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControlMain);
            this.Name = "DatasourceOpenDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Data Sources";
            this.Load += new System.EventHandler(this.DashboardOpenDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDatasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlMain;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDatasource;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDSCategoryDesc;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCategory;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasourceID;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDateIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.Utils.ImageCollection imageCollectionNormal;
    }
}