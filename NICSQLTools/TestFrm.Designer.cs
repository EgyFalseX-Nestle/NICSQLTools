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
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.mSrvPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMSrc = new NICSQLTools.Data.dsMSrc();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LSMSRoute = new DevExpress.Data.Linq.LinqServerModeSource();
            this.mSrv_PartTableAdapter = new NICSQLTools.Data.dsMSrcTableAdapters.MSrv_PartTableAdapter();
            this.colPartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(115, 192);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(264, 20);
            this.searchLookUpEdit1.TabIndex = 0;
            // 
            // mSrvPartBindingSource
            // 
            this.mSrvPartBindingSource.DataMember = "MSrv_Part";
            this.mSrvPartBindingSource.DataSource = this.dsMSrc;
            // 
            // dsMSrc
            // 
            this.dsMSrc.DataSetName = "dsMSrc";
            this.dsMSrc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartId,
            this.colPartName,
            this.colPartPrice,
            this.colUserIn,
            this.colDateIn});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LSMSRoute
            // 
            this.LSMSRoute.ElementType = typeof(NICSQLTools.Data.Linq.vRDM_Receipt);
            this.LSMSRoute.KeyExpression = "[RDM_ID]";
            // 
            // mSrv_PartTableAdapter
            // 
            this.mSrv_PartTableAdapter.ClearBeforeFill = true;
            // 
            // colPartId
            // 
            this.colPartId.FieldName = "PartId";
            this.colPartId.Name = "colPartId";
            this.colPartId.Visible = true;
            this.colPartId.VisibleIndex = 0;
            // 
            // colPartName
            // 
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 1;
            // 
            // colPartPrice
            // 
            this.colPartPrice.FieldName = "PartPrice";
            this.colPartPrice.Name = "colPartPrice";
            this.colPartPrice.Visible = true;
            this.colPartPrice.VisibleIndex = 2;
            // 
            // colUserIn
            // 
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            this.colUserIn.Visible = true;
            this.colUserIn.VisibleIndex = 3;
            // 
            // colDateIn
            // 
            this.colDateIn.FieldName = "DateIn";
            this.colDateIn.Name = "colDateIn";
            this.colDateIn.Visible = true;
            this.colDateIn.VisibleIndex = 4;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSrvPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSRoute)).EndInit();
            this.ResumeLayout(false);

        }






        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSRoute;
        private Data.dsMSrc dsMSrc;
        private System.Windows.Forms.BindingSource mSrvPartBindingSource;
        private Data.dsMSrcTableAdapters.MSrv_PartTableAdapter mSrv_PartTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPartId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colDateIn;
    }
}