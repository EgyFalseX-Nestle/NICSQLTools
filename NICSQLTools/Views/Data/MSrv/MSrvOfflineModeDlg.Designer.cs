namespace NICSQLTools.Views.Data.MSrv
{
    partial class MSrvOfflineModeDlg
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
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pbc
            // 
            this.pbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbc.Location = new System.Drawing.Point(0, 0);
            this.pbc.Name = "pbc";
            this.pbc.Properties.ShowTitle = true;
            this.pbc.Size = new System.Drawing.Size(449, 22);
            this.pbc.TabIndex = 0;
            // 
            // MSrvOfflineModeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 22);
            this.Controls.Add(this.pbc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSrvOfflineModeDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Data";
            this.Load += new System.EventHandler(this.MSrvOfflineModeDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl pbc;
    }
}