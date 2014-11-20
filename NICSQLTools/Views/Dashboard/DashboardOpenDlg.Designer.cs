namespace NICSQLTools.Views.Dashboard
{
    partial class DashboardOpenDlg
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDashboardSchemaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDashboardSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDateIn = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.LSMSDS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.Location = new System.Drawing.Point(12, 12);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUserIn,
            this.repositoryItemDateEditDateIn,
            this.repositoryItemButtonEditSelect});
            this.gridControlMain.Size = new System.Drawing.Size(560, 297);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDashboardSchemaId,
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
            // colDashboardSchemaId
            // 
            this.colDashboardSchemaId.Caption = "Select";
            this.colDashboardSchemaId.ColumnEdit = this.repositoryItemButtonEditSelect;
            this.colDashboardSchemaId.FieldName = "DashboardSchemaId";
            this.colDashboardSchemaId.Name = "colDashboardSchemaId";
            this.colDashboardSchemaId.Visible = true;
            this.colDashboardSchemaId.VisibleIndex = 0;
            // 
            // repositoryItemButtonEditSelect
            // 
            this.repositoryItemButtonEditSelect.AutoHeight = false;
            this.repositoryItemButtonEditSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditSelect.Name = "repositoryItemButtonEditSelect";
            this.repositoryItemButtonEditSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSelect.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSelect_ButtonClick);
            // 
            // colDashboardSchemaName
            // 
            this.colDashboardSchemaName.FieldName = "DashboardSchemaName";
            this.colDashboardSchemaName.Name = "colDashboardSchemaName";
            this.colDashboardSchemaName.Visible = true;
            this.colDashboardSchemaName.VisibleIndex = 1;
            this.colDashboardSchemaName.Width = 141;
            // 
            // colUserIn
            // 
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUserIn;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 2;
            this.colUserIn.Width = 120;
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            // 
            // colDateIn
            // 
            this.colDateIn.ColumnEdit = this.repositoryItemDateEditDateIn;
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 3;
            this.colDateIn.Width = 115;
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
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(NICSQLTools.Data.dsData.AppDashboardSchemaDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 315);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(584, 66);
            this.groupControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::NICSQLTools.Properties.Resources.Stop;
            this.btnClose.Location = new System.Drawing.Point(467, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LSMSDS
            // 
            this.LSMSDS.ElementType = typeof(NICSQLTools.Data.Linq.AppDashboardD);
            this.LSMSDS.KeyExpression = "[DatasourceID]";
            // 
            // LSMSUser
            // 
            this.LSMSUser.ElementType = typeof(NICSQLTools.Data.Linq.User);
            this.LSMSUser.KeyExpression = "[UserID]";
            // 
            // DashboardOpenDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DashboardOpenDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Dashboard";
            this.Load += new System.EventHandler(this.DashboardOpenDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDateIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDS;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDateIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSelect;
    }
}