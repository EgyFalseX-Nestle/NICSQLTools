namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    partial class MSrv_TicketTypeDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSrv_TicketTypeDlg));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.ticketTypeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMSrc = new NICSQLTools.Data.dsMSrc();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSrvType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ticketTypeInfoTableAdapter = new NICSQLTools.Data.dsMSrcTableAdapters.TicketTypeInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTypeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.ticketTypeInfoBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(284, 261);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // ticketTypeInfoBindingSource
            // 
            this.ticketTypeInfoBindingSource.DataMember = "TicketTypeInfo";
            this.ticketTypeInfoBindingSource.DataSource = this.dsMSrc;
            // 
            // dsMSrc
            // 
            this.dsMSrc.DataSetName = "dsMSrc";
            this.dsMSrc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSrvType});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsView.ShowColumnHeaders = false;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.ShowIndicator = false;
            // 
            // colMSrvType
            // 
            this.colMSrvType.AppearanceCell.Options.UseTextOptions = true;
            this.colMSrvType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMSrvType.AppearanceHeader.Options.UseTextOptions = true;
            this.colMSrvType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMSrvType.Caption = "Reason";
            this.colMSrvType.FieldName = "MSrvType";
            this.colMSrvType.Name = "colMSrvType";
            this.colMSrvType.Visible = true;
            this.colMSrvType.VisibleIndex = 0;
            // 
            // ticketTypeInfoTableAdapter
            // 
            this.ticketTypeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // MSrv_TicketTypeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSrv_TicketTypeDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Reasons";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTypeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.BindingSource ticketTypeInfoBindingSource;
        private NICSQLTools.Data.dsMSrc dsMSrc;
        private DevExpress.XtraGrid.Columns.GridColumn colMSrvType;
        private NICSQLTools.Data.dsMSrcTableAdapters.TicketTypeInfoTableAdapter ticketTypeInfoTableAdapter;
    }
}