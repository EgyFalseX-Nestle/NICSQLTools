namespace NICSQLTools
{
    partial class TestFrm
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
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSrvTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSrvType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.LSMSData;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(908, 480);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(NICSQLTools.Data.Linq.MSrv_Type);
            this.LSMSData.KeyExpression = "MSrvTypeId";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSrvTypeId,
            this.colMSrvType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMSrvTypeId
            // 
            this.colMSrvTypeId.FieldName = "MSrvTypeId";
            this.colMSrvTypeId.Name = "colMSrvTypeId";
            this.colMSrvTypeId.Visible = true;
            this.colMSrvTypeId.VisibleIndex = 0;
            // 
            // colMSrvType
            // 
            this.colMSrvType.FieldName = "MSrvType";
            this.colMSrvType.Name = "colMSrvType";
            this.colMSrvType.Visible = true;
            this.colMSrvType.VisibleIndex = 1;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn colMSrvTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colMSrvType;





    }
}