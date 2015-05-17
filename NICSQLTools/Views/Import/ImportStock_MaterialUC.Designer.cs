namespace NICSQLTools.Views.Import
{
    partial class ImportStock_MaterialUC
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
            this.layoutControlItemImport = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.ImportBillingDetailsFrmConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.PnlProg = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tbMonth = new DevExpress.XtraEditors.SpinEdit();
            this.tbYear = new DevExpress.XtraEditors.SpinEdit();
            this.ProgressBarMain = new DevExpress.XtraEditors.ProgressBarControl();
            this.tbLog = new DevExpress.XtraEditors.MemoEdit();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.lblEstTime = new DevExpress.XtraEditors.LabelControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetFileName = new DevExpress.XtraEditors.SimpleButton();
            this.lbcFilePath = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFiles = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLog = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupCommand = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPnlProg = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.dsData = new NICSQLTools.Data.dsData();
            this._0_4__Product_DetailsTableAdapter = new NICSQLTools.Data.dsDataTableAdapters._0_4__Product_DetailsTableAdapter();
            this.plantsTableAdapter = new NICSQLTools.Data.dsQryTableAdapters.PlantsTableAdapter();
            this.stock_MaterialTableAdapter = new NICSQLTools.Data.dsDataTableAdapters.Stock_MaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).BeginInit();
            this.ImportBillingDetailsFrmConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPnlProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
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
            this.emptySpaceItemSpace.Size = new System.Drawing.Size(269, 98);
            this.emptySpaceItemSpace.Text = "Space";
            this.emptySpaceItemSpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemImport
            // 
            this.layoutControlItemImport.Control = this.btnImport;
            this.layoutControlItemImport.CustomizationFormText = "Import";
            this.layoutControlItemImport.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItemImport.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControlItemImport.MinSize = new System.Drawing.Size(245, 42);
            this.layoutControlItemImport.Name = "layoutControlItemImport";
            this.layoutControlItemImport.Size = new System.Drawing.Size(245, 42);
            this.layoutControlItemImport.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemImport.Text = "Import";
            this.layoutControlItemImport.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemImport.TextVisible = false;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::NICSQLTools.Properties.Resources.importtodatabase_32x32;
            this.btnImport.Location = new System.Drawing.Point(24, 424);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(241, 38);
            this.btnImport.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Start Importing";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportBillingDetailsFrmConvertedLayout
            // 
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.PnlProg);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.tbMonth);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.tbYear);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.ProgressBarMain);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.tbLog);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblCount);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnImport);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lblEstTime);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnRemove);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.btnGetFileName);
            this.ImportBillingDetailsFrmConvertedLayout.Controls.Add(this.lbcFilePath);
            this.ImportBillingDetailsFrmConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportBillingDetailsFrmConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ImportBillingDetailsFrmConvertedLayout.Name = "ImportBillingDetailsFrmConvertedLayout";
            this.ImportBillingDetailsFrmConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(474, 217, 315, 464);
            this.ImportBillingDetailsFrmConvertedLayout.OptionsView.UseDefaultDragAndDropRendering = false;
            this.ImportBillingDetailsFrmConvertedLayout.Root = this.layoutControlGroup1;
            this.ImportBillingDetailsFrmConvertedLayout.Size = new System.Drawing.Size(903, 525);
            this.ImportBillingDetailsFrmConvertedLayout.TabIndex = 7;
            // 
            // PnlProg
            // 
            this.PnlProg.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PnlProg.Appearance.Options.UseBackColor = true;
            this.PnlProg.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PnlProg.AppearanceCaption.Options.UseFont = true;
            this.PnlProg.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PnlProg.AppearanceDescription.Options.UseFont = true;
            this.PnlProg.Location = new System.Drawing.Point(12, 154);
            this.PnlProg.Name = "PnlProg";
            this.PnlProg.Size = new System.Drawing.Size(879, 46);
            this.PnlProg.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.PnlProg.TabIndex = 9;
            this.PnlProg.Text = "Progress Status";
            // 
            // tbMonth
            // 
            this.tbMonth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMonth.Location = new System.Drawing.Point(62, 307);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbMonth.Size = new System.Drawing.Size(210, 20);
            this.tbMonth.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.tbMonth.TabIndex = 0;
            // 
            // tbYear
            // 
            this.tbYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbYear.Location = new System.Drawing.Point(62, 341);
            this.tbYear.Name = "tbYear";
            this.tbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbYear.Size = new System.Drawing.Size(210, 20);
            this.tbYear.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.tbYear.TabIndex = 1;
            // 
            // ProgressBarMain
            // 
            this.ProgressBarMain.Location = new System.Drawing.Point(57, 495);
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new System.Drawing.Size(834, 18);
            this.ProgressBarMain.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.ProgressBarMain.TabIndex = 8;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(281, 204);
            this.tbLog.Name = "tbLog";
            this.tbLog.Properties.ReadOnly = true;
            this.tbLog.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(610, 270);
            this.tbLog.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.tbLog.TabIndex = 6;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(875, 478);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 13);
            this.lblCount.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0/0";
            // 
            // lblEstTime
            // 
            this.lblEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstTime.Location = new System.Drawing.Point(57, 478);
            this.lblEstTime.Name = "lblEstTime";
            this.lblEstTime.Size = new System.Drawing.Size(814, 13);
            this.lblEstTime.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lblEstTime.TabIndex = 4;
            this.lblEstTime.Text = "00:00";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(140, 382);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 38);
            this.btnRemove.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFileName.Location = new System.Drawing.Point(24, 382);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(112, 38);
            this.btnGetFileName.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.btnGetFileName.TabIndex = 2;
            this.btnGetFileName.Text = "Add Excel File";
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // lbcFilePath
            // 
            this.lbcFilePath.HorizontalScrollbar = true;
            this.lbcFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbcFilePath.Name = "lbcFilePath";
            this.lbcFilePath.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcFilePath.Size = new System.Drawing.Size(879, 138);
            this.lbcFilePath.StyleController = this.ImportBillingDetailsFrmConvertedLayout;
            this.lbcFilePath.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFiles,
            this.layoutControlItemLog,
            this.layoutControlItemTime,
            this.layoutControlItemCount,
            this.layoutControlItemProgress,
            this.layoutControlGroupCommand,
            this.emptySpaceItemSpace,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItemPnlProg});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(903, 525);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemFiles
            // 
            this.layoutControlItemFiles.Control = this.lbcFilePath;
            this.layoutControlItemFiles.CustomizationFormText = "Files";
            this.layoutControlItemFiles.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFiles.MaxSize = new System.Drawing.Size(0, 142);
            this.layoutControlItemFiles.MinSize = new System.Drawing.Size(54, 142);
            this.layoutControlItemFiles.Name = "layoutControlItemFiles";
            this.layoutControlItemFiles.Size = new System.Drawing.Size(883, 142);
            this.layoutControlItemFiles.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemFiles.Text = "Files";
            this.layoutControlItemFiles.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemFiles.TextVisible = false;
            // 
            // layoutControlItemLog
            // 
            this.layoutControlItemLog.Control = this.tbLog;
            this.layoutControlItemLog.CustomizationFormText = "Log";
            this.layoutControlItemLog.Location = new System.Drawing.Point(269, 192);
            this.layoutControlItemLog.Name = "layoutControlItemLog";
            this.layoutControlItemLog.Size = new System.Drawing.Size(614, 274);
            this.layoutControlItemLog.Text = "Log";
            this.layoutControlItemLog.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLog.TextVisible = false;
            // 
            // layoutControlItemTime
            // 
            this.layoutControlItemTime.Control = this.lblEstTime;
            this.layoutControlItemTime.CustomizationFormText = "Time";
            this.layoutControlItemTime.Location = new System.Drawing.Point(0, 466);
            this.layoutControlItemTime.MaxSize = new System.Drawing.Size(0, 17);
            this.layoutControlItemTime.MinSize = new System.Drawing.Size(77, 17);
            this.layoutControlItemTime.Name = "layoutControlItemTime";
            this.layoutControlItemTime.Size = new System.Drawing.Size(863, 17);
            this.layoutControlItemTime.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemTime.Text = "Time";
            this.layoutControlItemTime.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemCount
            // 
            this.layoutControlItemCount.Control = this.lblCount;
            this.layoutControlItemCount.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItemCount.CustomizationFormText = "Count";
            this.layoutControlItemCount.Location = new System.Drawing.Point(863, 466);
            this.layoutControlItemCount.Name = "layoutControlItemCount";
            this.layoutControlItemCount.Size = new System.Drawing.Size(20, 17);
            this.layoutControlItemCount.Text = "Count";
            this.layoutControlItemCount.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItemCount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCount.TextVisible = false;
            // 
            // layoutControlItemProgress
            // 
            this.layoutControlItemProgress.Control = this.ProgressBarMain;
            this.layoutControlItemProgress.CustomizationFormText = "Progress";
            this.layoutControlItemProgress.Location = new System.Drawing.Point(0, 483);
            this.layoutControlItemProgress.MaxSize = new System.Drawing.Size(0, 22);
            this.layoutControlItemProgress.MinSize = new System.Drawing.Size(99, 22);
            this.layoutControlItemProgress.Name = "layoutControlItemProgress";
            this.layoutControlItemProgress.Size = new System.Drawing.Size(883, 22);
            this.layoutControlItemProgress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemProgress.Text = "Progress";
            this.layoutControlItemProgress.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlGroupCommand
            // 
            this.layoutControlGroupCommand.CustomizationFormText = "Command";
            this.layoutControlGroupCommand.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRemove,
            this.layoutControlItemAdd,
            this.layoutControlItemImport});
            this.layoutControlGroupCommand.Location = new System.Drawing.Point(0, 358);
            this.layoutControlGroupCommand.Name = "layoutControlGroupCommand";
            this.layoutControlGroupCommand.Size = new System.Drawing.Size(269, 108);
            this.layoutControlGroupCommand.Text = "Command";
            this.layoutControlGroupCommand.TextVisible = false;
            // 
            // layoutControlItemRemove
            // 
            this.layoutControlItemRemove.Control = this.btnRemove;
            this.layoutControlItemRemove.CustomizationFormText = "Remove";
            this.layoutControlItemRemove.Location = new System.Drawing.Point(116, 0);
            this.layoutControlItemRemove.MaxSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemove.MinSize = new System.Drawing.Size(89, 42);
            this.layoutControlItemRemove.Name = "layoutControlItemRemove";
            this.layoutControlItemRemove.Size = new System.Drawing.Size(129, 42);
            this.layoutControlItemRemove.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemRemove.Text = "Remove";
            this.layoutControlItemRemove.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemRemove.TextVisible = false;
            // 
            // layoutControlItemAdd
            // 
            this.layoutControlItemAdd.Control = this.btnGetFileName;
            this.layoutControlItemAdd.CustomizationFormText = "Add";
            this.layoutControlItemAdd.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAdd.MaxSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.MinSize = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.Name = "layoutControlItemAdd";
            this.layoutControlItemAdd.Size = new System.Drawing.Size(116, 42);
            this.layoutControlItemAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemAdd.Text = "Add";
            this.layoutControlItemAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAdd.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tbYear;
            this.layoutControlItem1.CustomizationFormText = "Year";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 324);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(269, 34);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "Year";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tbMonth;
            this.layoutControlItem2.CustomizationFormText = "Month";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 290);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(269, 34);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Text = "Month";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItemPnlProg
            // 
            this.layoutControlItemPnlProg.Control = this.PnlProg;
            this.layoutControlItemPnlProg.CustomizationFormText = "Progress Panal";
            this.layoutControlItemPnlProg.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItemPnlProg.MaxSize = new System.Drawing.Size(0, 50);
            this.layoutControlItemPnlProg.MinSize = new System.Drawing.Size(54, 50);
            this.layoutControlItemPnlProg.Name = "layoutControlItemPnlProg";
            this.layoutControlItemPnlProg.Size = new System.Drawing.Size(883, 50);
            this.layoutControlItemPnlProg.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemPnlProg.Text = "Progress Panal";
            this.layoutControlItemPnlProg.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemPnlProg.TextVisible = false;
            this.layoutControlItemPnlProg.TrimClientAreaToControl = false;
            this.layoutControlItemPnlProg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _0_4__Product_DetailsTableAdapter
            // 
            this._0_4__Product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // stock_MaterialTableAdapter1
            // 
            this.stock_MaterialTableAdapter.ClearBeforeFill = true;
            // 
            // ImportStock_MaterialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImportBillingDetailsFrmConvertedLayout);
            this.Name = "ImportStock_MaterialUC";
            this.Size = new System.Drawing.Size(903, 525);
            this.Load += new System.EventHandler(this.ImportStock_ListUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBillingDetailsFrmConvertedLayout)).EndInit();
            this.ImportBillingDetailsFrmConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPnlProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NICSQLTools.Data.dsData dsData;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSpace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImport;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraLayout.LayoutControl ImportBillingDetailsFrmConvertedLayout;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBarMain;
        private DevExpress.XtraEditors.MemoEdit tbLog;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblEstTime;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnGetFileName;
        private DevExpress.XtraEditors.ListBoxControl lbcFilePath;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFiles;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemProgress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupCommand;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRemove;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private NICSQLTools.Data.dsQry dsQry;
        private DevExpress.XtraEditors.SpinEdit tbMonth;
        private DevExpress.XtraEditors.SpinEdit tbYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraWaitForm.ProgressPanel PnlProg;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPnlProg;
        private NICSQLTools.Data.dsDataTableAdapters._0_4__Product_DetailsTableAdapter _0_4__Product_DetailsTableAdapter;
        private NICSQLTools.Data.dsQryTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private NICSQLTools.Data.dsDataTableAdapters.Stock_MaterialTableAdapter stock_MaterialTableAdapter;
    }
}
