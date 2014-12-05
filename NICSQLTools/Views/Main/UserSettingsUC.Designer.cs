namespace NICSQLTools.Views.Main
{
    partial class UserSettingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSaveLayout = new DevExpress.XtraEditors.SimpleButton();
            this.btnResertLayout = new DevExpress.XtraEditors.SimpleButton();
            this.galleryControlMain = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.layoutControlGroupSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroupSettings = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupThemes = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupLayoutSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlMain)).BeginInit();
            this.galleryControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLayoutSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSaveLayout);
            this.layoutControl1.Controls.Add(this.btnResertLayout);
            this.layoutControl1.Controls.Add(this.galleryControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(874, 231, 645, 680);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroupSettings;
            this.layoutControl1.ShowTemplates = true;
            this.layoutControl1.Size = new System.Drawing.Size(751, 526);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Image = global::NICSQLTools.Properties.Resources.save_16x16;
            this.btnSaveLayout.Location = new System.Drawing.Point(36, 77);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(489, 22);
            this.btnSaveLayout.StyleController = this.layoutControl1;
            this.btnSaveLayout.TabIndex = 5;
            this.btnSaveLayout.Text = "Save Layout";
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // btnResertLayout
            // 
            this.btnResertLayout.Image = global::NICSQLTools.Properties.Resources.delete_16x16;
            this.btnResertLayout.Location = new System.Drawing.Point(529, 77);
            this.btnResertLayout.Name = "btnResertLayout";
            this.btnResertLayout.Size = new System.Drawing.Size(186, 22);
            this.btnResertLayout.StyleController = this.layoutControl1;
            this.btnResertLayout.TabIndex = 4;
            this.btnResertLayout.Text = "Reset Layout";
            this.btnResertLayout.Click += new System.EventHandler(this.btnResertLayout_Click);
            // 
            // galleryControlMain
            // 
            this.galleryControlMain.Controls.Add(this.galleryControlClient1);
            this.galleryControlMain.DesignGalleryGroupIndex = 0;
            this.galleryControlMain.DesignGalleryItemIndex = 0;
            // 
            // galleryControlGallery1
            // 
            this.galleryControlMain.Gallery.ShowItemText = true;
            this.galleryControlMain.Location = new System.Drawing.Point(24, 46);
            this.galleryControlMain.Name = "galleryControlMain";
            this.galleryControlMain.Size = new System.Drawing.Size(703, 456);
            this.galleryControlMain.StyleController = this.layoutControl1;
            this.galleryControlMain.TabIndex = 1;
            this.galleryControlMain.Text = "Themes";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControlMain;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(682, 452);
            // 
            // layoutControlGroupSettings
            // 
            this.layoutControlGroupSettings.CustomizationFormText = "layoutControlGroupSettings";
            this.layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupSettings.GroupBordersVisible = false;
            this.layoutControlGroupSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroupSettings});
            this.layoutControlGroupSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupSettings.Name = "layoutControlGroupSettings";
            this.layoutControlGroupSettings.Size = new System.Drawing.Size(751, 526);
            this.layoutControlGroupSettings.Text = "layoutControlGroupSettings";
            this.layoutControlGroupSettings.TextVisible = false;
            // 
            // tabbedControlGroupSettings
            // 
            this.tabbedControlGroupSettings.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroupSettings.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroupSettings.Name = "tabbedControlGroupSettings";
            this.tabbedControlGroupSettings.SelectedTabPage = this.layoutControlGroupGeneral;
            this.tabbedControlGroupSettings.SelectedTabPageIndex = 0;
            this.tabbedControlGroupSettings.Size = new System.Drawing.Size(731, 506);
            this.tabbedControlGroupSettings.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupGeneral,
            this.layoutControlGroupThemes});
            this.tabbedControlGroupSettings.Text = "tabbedControlGroup1";
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.CustomizationFormText = "General Settings";
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupLayoutSettings});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(707, 460);
            this.layoutControlGroupGeneral.Text = "General Settings";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnResertLayout;
            this.layoutControlItem2.CustomizationFormText = "Reset Layout";
            this.layoutControlItem2.Location = new System.Drawing.Point(493, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(190, 417);
            this.layoutControlItem2.Text = "Reset Layout";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSaveLayout;
            this.layoutControlItem3.CustomizationFormText = "Save Layout";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(493, 417);
            this.layoutControlItem3.Text = "Save Layout";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroupThemes
            // 
            this.layoutControlGroupThemes.CustomizationFormText = "Themes";
            this.layoutControlGroupThemes.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupThemes.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupThemes.Name = "layoutControlGroupThemes";
            this.layoutControlGroupThemes.Size = new System.Drawing.Size(707, 460);
            this.layoutControlGroupThemes.Text = "Themes";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.galleryControlMain;
            this.layoutControlItem1.CustomizationFormText = "Themes Gallary";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(54, 108);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(707, 460);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Themes Gallary";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroupLayoutSettings
            // 
            this.layoutControlGroupLayoutSettings.CustomizationFormText = "Layout Group";
            this.layoutControlGroupLayoutSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroupLayoutSettings.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupLayoutSettings.Name = "layoutControlGroupLayoutSettings";
            this.layoutControlGroupLayoutSettings.Size = new System.Drawing.Size(707, 460);
            this.layoutControlGroupLayoutSettings.Text = "Layout Group";
            // 
            // UserSettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserSettingsUC";
            this.Size = new System.Drawing.Size(751, 526);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlMain)).EndInit();
            this.galleryControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroupSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupLayoutSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupSettings;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroupSettings;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupThemes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControlMain;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSaveLayout;
        private DevExpress.XtraEditors.SimpleButton btnResertLayout;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupLayoutSettings;
    }
}
