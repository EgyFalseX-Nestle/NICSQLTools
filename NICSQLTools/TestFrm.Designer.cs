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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpTaskId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dsTask = new NICSQLTools.Data.dsTask();
            this.tskEmpEmpTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tskEmp_EmpTaskTableAdapter = new NICSQLTools.Data.dsTaskTableAdapters.TskEmp_EmpTaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tskEmpEmpTaskBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 369);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.DisplayableProperties = "This;EmpTaskId;EmpId;TaskId;TaskStartDate;TaskEndDate;UserIn;DateIn";
            this.xpServerCollectionSource1.ObjectType = typeof(NICSQLTools.Data.dsTask.TskEmp_EmpTaskDataTable);
            this.xpServerCollectionSource1.Session = this.unitOfWork1;
            // 
            // unitOfWork1
            // 
            this.unitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork1.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpTaskId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colEmpTaskId
            // 
            this.colEmpTaskId.FieldName = "EmpTaskId";
            this.colEmpTaskId.Name = "colEmpTaskId";
            this.colEmpTaskId.Visible = true;
            this.colEmpTaskId.VisibleIndex = 0;
            // 
            // dsTask
            // 
            this.dsTask.DataSetName = "dsTask";
            this.dsTask.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tskEmpEmpTaskBindingSource
            // 
            this.tskEmpEmpTaskBindingSource.DataMember = "TskEmp_EmpTask";
            this.tskEmpEmpTaskBindingSource.DataSource = this.dsTask;
            // 
            // tskEmp_EmpTaskTableAdapter
            // 
            this.tskEmp_EmpTaskTableAdapter.ClearBeforeFill = true;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tskEmpEmpTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpTaskId;
        private Data.dsTask dsTask;
        private System.Windows.Forms.BindingSource tskEmpEmpTaskBindingSource;
        private Data.dsTaskTableAdapters.TskEmp_EmpTaskTableAdapter tskEmp_EmpTaskTableAdapter;




    }
}