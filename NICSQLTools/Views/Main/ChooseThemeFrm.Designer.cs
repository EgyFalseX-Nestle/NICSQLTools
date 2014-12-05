namespace NICSQLTools.Views.Main
{
    partial class ChooseThemeFrm
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
            this.galleryControlMain = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlMain)).BeginInit();
            this.galleryControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryControlMain
            // 
            this.galleryControlMain.Controls.Add(this.galleryControlClient1);
            this.galleryControlMain.DesignGalleryGroupIndex = 0;
            this.galleryControlMain.DesignGalleryItemIndex = 0;
            this.galleryControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryControlMain.Location = new System.Drawing.Point(0, 0);
            this.galleryControlMain.Name = "galleryControlMain";
            this.galleryControlMain.Size = new System.Drawing.Size(684, 361);
            this.galleryControlMain.TabIndex = 0;
            this.galleryControlMain.Text = "Themes";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControlMain;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(663, 357);
            // 
            // ChooseThemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.galleryControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseThemeFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Theme";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlMain)).EndInit();
            this.galleryControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControlMain;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}