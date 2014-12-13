namespace NICSQLTools.Views.Dashboard
{
    partial class DashboardViewerEditorFrm
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
            this.dashboardDesignerMain = new DevExpress.DashboardWin.DashboardDesigner();
            this.SuspendLayout();
            // 
            // dashboardDesignerMain
            // 
            this.dashboardDesignerMain.ActionOnClose = DevExpress.DashboardWin.DashboardActionOnClose.Discard;
            this.dashboardDesignerMain.CustomDBSchemaProvider = null;
            this.dashboardDesignerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesignerMain.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesignerMain.Name = "dashboardDesignerMain";
            this.dashboardDesignerMain.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.SeparatePage;
            this.dashboardDesignerMain.PrintingOptions.FontInfo.GdiCharSet = ((byte)(0));
            this.dashboardDesignerMain.PrintingOptions.FontInfo.Name = null;
            this.dashboardDesignerMain.Size = new System.Drawing.Size(657, 385);
            this.dashboardDesignerMain.TabIndex = 1;
            // 
            // DashboardViewerEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 385);
            this.Controls.Add(this.dashboardDesignerMain);
            this.Name = "DashboardViewerEditorFrm";
            this.Text = "Dashboard Editor";
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.DashboardWin.DashboardDesigner dashboardDesignerMain;



    }
}