namespace NICSQLTools
{
    partial class Form1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LSMSGeneral = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSSub = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colDashboardSchemaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDashboardSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.LSMSGeneral;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(738, 337);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDashboardSchemaId,
            this.colDashboardSchemaName,
            this.colUserIn,
            this.colDateIn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // LSMSGeneral
            // 
            this.LSMSGeneral.ElementType = typeof(NICSQLTools.Data.Linq.AppDashboardSchema);
            this.LSMSGeneral.KeyExpression = "[DashboardSchemaId]";
            // 
            // LSMSSub
            // 
            this.LSMSSub.ElementType = typeof(NICSQLTools.Data.Linq.User);
            this.LSMSSub.KeyExpression = "[UserID]";
            // 
            // colDashboardSchemaId
            // 
            this.colDashboardSchemaId.FieldName = "DashboardSchemaId";
            this.colDashboardSchemaId.Name = "colDashboardSchemaId";
            this.colDashboardSchemaId.Visible = true;
            this.colDashboardSchemaId.VisibleIndex = 0;
            // 
            // colDashboardSchemaName
            // 
            this.colDashboardSchemaName.FieldName = "DashboardSchemaName";
            this.colDashboardSchemaName.Name = "colDashboardSchemaName";
            this.colDashboardSchemaName.Visible = true;
            this.colDashboardSchemaName.VisibleIndex = 1;
            // 
            // colUserIn
            // 
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 2;
            // 
            // colDateIn
            // 
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 59, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.LSMSSub;
            this.repositoryItemLookUpEdit1.DisplayMember = "UserName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "UserID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 337);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSGeneral;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSub;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaId;
        private DevExpress.XtraGrid.Columns.GridColumn colDashboardSchemaName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;








    }
}