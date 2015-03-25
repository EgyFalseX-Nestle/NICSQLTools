namespace NICSQLTools.Views.Import
{
    partial class ImportUpdateProductDetailsUC
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
            this.components = new System.ComponentModel.Container();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.emptySpaceItemSpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemImportPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnImportPP = new DevExpress.XtraEditors.SimpleButton();
            this.ImportBillingDetailsFrmConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.PnlProgPP = new DevExpress.XtraWaitForm.ProgressPanel();
            this.ProgressBarMainPP = new DevExpress.XtraEditors.ProgressBarControl();
            this.tbLogPP = new DevExpress.XtraEditors.MemoEdit();
            this.lblCountPP = new DevExpress.XtraEditors.LabelControl();
            this.lblEstTimePP = new DevExpress.XtraEditors.LabelControl();
            this.btnRemovePP = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetFileNamePP = new DevExpress.XtraEditors.SimpleButton();
            this.lbcFilePathPP = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFilesPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLogPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTimePP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCountPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemProgressPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommandPP = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRemovePP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAddPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPnlProgPP = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPagePricePoint = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dsData = new NICSQLTools.Data.dsData();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImportPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).BeginInit();
            this.ImportBillingDetailsFrmConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMainPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogPP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePathPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFilesPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTimePP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgressPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommandPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemovePP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPnlProgPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPagePricePoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files(xlsx)|*.xlsx";
            this.ofd.Multiselect = true;
            // 
            // emptySpaceItemSpace
            // 
            this.emptySpaceItemSpace.AllowHotTrack = false;
            this.emptySpaceItemSpace.CustomizationFormText = "Space";
            this.emptySpaceItemSpace.Location = new System.Drawing.Point(0, 192);
            this.emptySpaceItemSpace.Name = "emptySpaceItemSpace";
            this.emptySpaceItemSpace.Size = new System.Drawing.Size(281, 138);
            this.emptySpaceItemSpace.Text = "Space";
            this.emptySpaceItemSpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemImportPP
            // 
            this.layoutControlItemImportPP.Control = this.btnImportPP;
            this.layoutControlItemImportPP.CustomizationFormText = "Import";
            this.layoutControlItemImportPP.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItemImportPP.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControlItemImportPP.MinSize = new System.Drawing.Size(257, 42);
            this.layoutControlItemImportPP.Name = "layoutControlItemImportPP";
            this.layoutControlItemImportPP.Size = new System.Drawing.Size(257, 42);
            this.layoutControlItemImportPP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemImportPP.Text = "Import";
            this.layoutControlItemImportPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemImportPP.TextVisible = false;
            // 
            // btnImportPP
            // 
            this.btnImportPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportPP.Image = global::NICSQLTools.Properties.Resources.importtodatabase_32x32;
            this.btnImportPP.Location = new System.Drawing.Point(24, 396);
            this.btnImportPP.Name = "btnImportPP";
            this.btnImportPP.Size = new System.Drawing.Size(253, 38);
            this.btnImportPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnImportPP.TabIndex = 3;
            this.btnImportPP.Text = "Start Importing";
            this.btnImportPP.Click += new System.EventHandler(this.btnImportPP_Click);
            // 
            // ImportBillingDetailsFrmConvertedLayout
            // 
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.PnlProgPP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.ProgressBarMainPP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.tbLogPP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblCountPP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnImportPP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblEstTimePP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnRemovePP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnGetFileNamePP);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lbcFilePathPP);
            this.ImportBillingDetailsFrmConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBillingDetailsFrmConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ImportBillingDetailsFrmConvertedLayout.Name = "ImportBillingDetailsFrmConvertedLayout";
            this.ImportBillingDetailsFrmConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(469, 81, 315, 551);
            this.ImportBillingDetailsFrmConvertedLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.ImportBillingDetailsFrmConvertedLayout.Root = this.layoutControlGroup1;
            this.ImportBillingDetailsFrmConvertedLayout.Size = new System.Drawing.Size(897, 497);
            this.ImportBillingDetailsFrmConvertedLayout.TabIndex = 7;
            // 
            // PnlProgPP
            // 
            this.PnlProgPP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PnlProgPP.Appearance.Options.UseBackColor = true;
            this.PnlProgPP.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PnlProgPP.AppearanceCaption.Options.UseFont = true;
            this.PnlProgPP.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PnlProgPP.AppearanceDescription.Options.UseFont = true;
            this.PnlProgPP.Location = new System.Drawing.Point(12, 154);
            this.PnlProgPP.Name = "PnlProgPP";
            this.PnlProgPP.Size = new System.Drawing.Size(873, 46);
            this.PnlProgPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.PnlProgPP.TabIndex = 9;
            this.PnlProgPP.Text = "Progress Status";
            // 
            // ProgressBarMainPP
            // 
            this.ProgressBarMainPP.Location = new System.Drawing.Point(57, 467);
            this.ProgressBarMainPP.Name = "ProgressBarMainPP";
            this.ProgressBarMainPP.Size = new System.Drawing.Size(828, 18);
            this.ProgressBarMainPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.ProgressBarMainPP.TabIndex = 8;
            // 
            // tbLogPP
            // 
            this.tbLogPP.Location = new System.Drawing.Point(293, 204);
            this.tbLogPP.Name = "tbLogPP";
            this.tbLogPP.Properties.ReadOnly = true;
            this.tbLogPP.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLogPP.Size = new System.Drawing.Size(592, 242);
            this.tbLogPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.tbLogPP.TabIndex = 6;
            // 
            // lblCountPP
            // 
            this.lblCountPP.Location = new System.Drawing.Point(869, 450);
            this.lblCountPP.Name = "lblCountPP";
            this.lblCountPP.Size = new System.Drawing.Size(16, 13);
            this.lblCountPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblCountPP.TabIndex = 4;
            this.lblCountPP.Text = "0/0";
            // 
            // lblEstTimePP
            // 
            this.lblEstTimePP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTimePP.Location = new System.Drawing.Point(57, 450);
            this.lblEstTimePP.Name = "lblEstTimePP";
            this.lblEstTimePP.Size = new System.Drawing.Size(808, 13);
            this.lblEstTimePP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblEstTimePP.TabIndex = 4;
            this.lblEstTimePP.Text = "00:00";
            // 
            // btnRemovePP
            // 
            this.btnRemovePP.Location = new System.Drawing.Point(140, 354);
            this.btnRemovePP.Name = "btnRemovePP";
            this.btnRemovePP.Size = new System.Drawing.Size(85, 38);
            this.btnRemovePP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnRemovePP.TabIndex = 1;
            this.btnRemovePP.Text = "Remove";
            this.btnRemovePP.Click += new System.EventHandler(this.btnRemovePP_Click);
            // 
            // btnGetFileNamePP
            // 
            this.btnGetFileNamePP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileNamePP.Location = new System.Drawing.Point(24, 354);
            this.btnGetFileNamePP.Name = "btnGetFileNamePP";
            this.btnGetFileNamePP.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileNamePP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnGetFileNamePP.TabIndex = 0;
            this.btnGetFileNamePP.Text = "Add Excel File";
            this.btnGetFileNamePP.Click += new System.EventHandler(this.btnGetFileNamePP_Click);
            // 
            // lbcFilePathPP
            // 
            this.lbcFilePathPP.HorizontalScrollbar = true;
            this.lbcFilePathPP.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePathPP.Name = "lbcFilePathPP";
            this.lbcFilePathPP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcFilePathPP.Size = new System.Drawing.Size(873, 138);
            this.lbcFilePathPP.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lbcFilePathPP.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFilesPP,
            this.layoutControlItemLogPP,
            this.layoutControlItemTimePP,
            this.layoutControlItemCountPP,
            this.layoutControlItemProgressPP,
            this.layoutControlGroupCommandPP,
            this.emptySpaceItemSpace,
            this.layoutControlItemPnlProgPP});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(897, 497);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemFilesPP
            // 
            this.layoutControlItemFilesPP.Control = this.lbcFilePathPP;
            this.layoutControlItemFilesPP.CustomizationFormText = "Files";
            this.layoutControlItemFilesPP.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFilesPP.MaxSize = new System.Drawing.Size(0, 142);
            this.layoutControlItemFilesPP.MinSize = new System.Drawing.Size(54, 142);
            this.layoutControlItemFilesPP.Name = "layoutControlItemFilesPP";
            this.layoutControlItemFilesPP.Size = new System.Drawing.Size(877, 142);
            this.layoutControlItemFilesPP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemFilesPP.Text = "Files";
            this.layoutControlItemFilesPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFilesPP.TextVisible = false;
            // 
            // layoutControlItemLogPP
            // 
            this.layoutControlItemLogPP.Control = this.tbLogPP;
            this.layoutControlItemLogPP.CustomizationFormText = "Log";
            this.layoutControlItemLogPP.Location = new System.Drawing.Point(281, 192);
            this.layoutControlItemLogPP.Name = "layoutControlItemLogPP";
            this.layoutControlItemLogPP.Size = new System.Drawing.Size(596, 246);
            this.layoutControlItemLogPP.Text = "Log";
            this.layoutControlItemLogPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLogPP.TextVisible = false;
            // 
            // layoutControlItemTimePP
            // 
            this.layoutControlItemTimePP.Control = this.lblEstTimePP;
            this.layoutControlItemTimePP.CustomizationFormText = "Time";
            this.layoutControlItemTimePP.Location = new System.Drawing.Point(0, 438);
            this.layoutControlItemTimePP.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItemTimePP.MinSize = new System.Drawing.Size(77, 17);
            this.layoutControlItemTimePP.Name = "layoutControlItemTimePP";
            this.layoutControlItemTimePP.Size = new System.Drawing.Size(857, 17);
            this.layoutControlItemTimePP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemTimePP.Text = "Time";
            this.layoutControlItemTimePP.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemCountPP
            // 
            this.layoutControlItemCountPP.Control = this.lblCountPP;
            this.layoutControlItemCountPP.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItemCountPP.CustomizationFormText = "Count";
            this.layoutControlItemCountPP.Location = new System.Drawing.Point(857, 438);
            this.layoutControlItemCountPP.Name = "layoutControlItemCountPP";
            this.layoutControlItemCountPP.Size = new System.Drawing.Size(20, 17);
            this.layoutControlItemCountPP.Text = "Count";
            this.layoutControlItemCountPP.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItemCountPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCountPP.TextVisible = false;
            // 
            // layoutControlItemProgressPP
            // 
            this.layoutControlItemProgressPP.Control = this.ProgressBarMainPP;
            this.layoutControlItemProgressPP.CustomizationFormText = "Progress";
            this.layoutControlItemProgressPP.Location = new System.Drawing.Point(0, 455);
            this.layoutControlItemProgressPP.MaxSize = new System.Drawing.Size(0, 22);
            this.layoutControlItemProgressPP.MinSize = new System.Drawing.Size(99, 22);
            this.layoutControlItemProgressPP.Name = "layoutControlItemProgressPP";
            this.layoutControlItemProgressPP.Size = new System.Drawing.Size(877, 22);
            this.layoutControlItemProgressPP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemProgressPP.Text = "Progress";
            this.layoutControlItemProgressPP.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlGroupCommandPP
            // 
            this.layoutControlGroupCommandPP.CustomizationFormText = "Command";
            this.layoutControlGroupCommandPP.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRemovePP,
            this.layoutControlItemAddPP,
            this.layoutControlItemImportPP});
            this.layoutControlGroupCommandPP.Location = new System.Drawing.Point(0, 330);
            this.layoutControlGroupCommandPP.Name = "layoutControlGroupCommandPP";
            this.layoutControlGroupCommandPP.Size = new System.Drawing.Size(281, 108);
            this.layoutControlGroupCommandPP.Text = "Command";
            this.layoutControlGroupCommandPP.TextVisible = false;
            // 
            // layoutControlItemRemovePP
            // 
            this.layoutControlItemRemovePP.Control = this.btnRemovePP;
            this.layoutControlItemRemovePP.CustomizationFormText = "Remove";
            this.layoutControlItemRemovePP.Location = new System.Drawing.Point(116, 0);
            this.layoutControlItemRemovePP.MaxSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemovePP.MinSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemovePP.Name = "layoutControlItemRemovePP";
            this.layoutControlItemRemovePP.Size = new System.Drawing.Size(141, 42);
            this.layoutControlItemRemovePP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemRemovePP.Text = "Remove";
            this.layoutControlItemRemovePP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemRemovePP.TextVisible = false;
            // 
            // layoutControlItemAddPP
            // 
            this.layoutControlItemAddPP.Control = this.btnGetFileNamePP;
            this.layoutControlItemAddPP.CustomizationFormText = "Add";
            this.layoutControlItemAddPP.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAddPP.MaxSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAddPP.MinSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAddPP.Name = "layoutControlItemAddPP";
            this.layoutControlItemAddPP.Size = new System.Drawing.Size(116, 42);
            this.layoutControlItemAddPP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemAddPP.Text = "Add";
            this.layoutControlItemAddPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAddPP.TextVisible = false;
            // 
            // layoutControlItemPnlProgPP
            // 
            this.layoutControlItemPnlProgPP.Control = this.PnlProgPP;
            this.layoutControlItemPnlProgPP.CustomizationFormText = "Progress Panal";
            this.layoutControlItemPnlProgPP.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItemPnlProgPP.MaxSize = new System.Drawing.Size(0, 50);
            this.layoutControlItemPnlProgPP.MinSize = new System.Drawing.Size(54, 50);
            this.layoutControlItemPnlProgPP.Name = "layoutControlItemPnlProgPP";
            this.layoutControlItemPnlProgPP.Size = new System.Drawing.Size(877, 50);
            this.layoutControlItemPnlProgPP.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemPnlProgPP.Text = "Progress Panal";
            this.layoutControlItemPnlProgPP.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemPnlProgPP.TextVisible = false;
            this.layoutControlItemPnlProgPP.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPagePricePoint;
            this.xtraTabControl1.Size = new System.Drawing.Size(903, 525);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPagePricePoint,
            this.xtraTabPage2});
            // 
            // xtraTabPagePricePoint
            // 
            this.xtraTabPagePricePoint.Controls.Add(this.ImportBillingDetailsFrmConvertedLayout);
            this.xtraTabPagePricePoint.Name = "xtraTabPagePricePoint";
            this.xtraTabPagePricePoint.Size = new System.Drawing.Size(897, 497);
            this.xtraTabPagePricePoint.Text = "Update Product Price Point";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(897, 497);
            this.xtraTabPage2.Text = "Update Product ....";
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImportUpdateProductDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ImportUpdateProductDetailsUC";
            this.Size = new System.Drawing.Size(903, 525);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImportPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).EndInit();
            this.ImportBillingDetailsFrmConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMainPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogPP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePathPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFilesPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTimePP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgressPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommandPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemovePP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPnlProgPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPagePricePoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSpace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImportPP;
        private DevExpress.XtraEditors.SimpleButton btnImportPP;
        private DevExpress.XtraLayout.LayoutControl ImportBillingDetailsFrmConvertedLayout;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMainPP;
        private DevExpress.XtraEditors.MemoEdit tbLogPP;
        private DevExpress.XtraEditors.LabelControl lblCountPP;
        private DevExpress.XtraEditors.LabelControl lblEstTimePP;
        private DevExpress.XtraEditors.SimpleButton btnRemovePP;
        private DevExpress.XtraEditors.SimpleButton btnGetFileNamePP;
        private DevExpress.XtraEditors.ListBoxControl lbcFilePathPP;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFilesPP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLogPP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTimePP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCountPP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgressPP;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommandPP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemovePP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAddPP;
        private DevExpress.XtraWaitForm.ProgressPanel PnlProgPP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPnlProgPP;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePricePoint;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private NICSQLTools.Data.dsData dsData;
    }
}
