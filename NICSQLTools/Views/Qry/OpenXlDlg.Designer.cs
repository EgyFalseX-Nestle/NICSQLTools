namespace NICSQLTools.Views.Qry
{
    partial class OpenXlDlg
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.wizardControlMain = new DevExpress.XtraWizard.WizardControl();
            this.OpenExcelWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beOpenFile = new DevExpress.XtraEditors.ButtonEdit();
            this.ParamtersWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.dxVP = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).BeginInit();
            this.wizardControlMain.SuspendLayout();
            this.OpenExcelWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beOpenFile.Properties)).BeginInit();
            this.ParamtersWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControlMain
            // 
            this.wizardControlMain.Controls.Add(this.OpenExcelWizardPage);
            this.wizardControlMain.Controls.Add(this.ParamtersWizardPage);
            this.wizardControlMain.Controls.Add(this.completionWizardPage);
            this.wizardControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlMain.Location = new System.Drawing.Point(0, 0);
            this.wizardControlMain.Name = "wizardControlMain";
            this.wizardControlMain.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.OpenExcelWizardPage,
            this.ParamtersWizardPage,
            this.completionWizardPage});
            this.wizardControlMain.Size = new System.Drawing.Size(684, 461);
            this.wizardControlMain.Text = "Open Excel File";
            this.wizardControlMain.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControlMain.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControlMain_SelectedPageChanging);
            this.wizardControlMain.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlMain_CancelClick);
            // 
            // OpenExcelWizardPage
            // 
            this.OpenExcelWizardPage.Controls.Add(this.labelControl1);
            this.OpenExcelWizardPage.Controls.Add(this.beOpenFile);
            this.OpenExcelWizardPage.Name = "OpenExcelWizardPage";
            this.OpenExcelWizardPage.Size = new System.Drawing.Size(624, 299);
            this.OpenExcelWizardPage.Text = "Please select excel file and press Next";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(73, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Select Excel File";
            // 
            // beOpenFile
            // 
            this.beOpenFile.Location = new System.Drawing.Point(73, 151);
            this.beOpenFile.Name = "beOpenFile";
            this.beOpenFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.beOpenFile.Properties.Appearance.Options.UseFont = true;
            this.beOpenFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::NICSQLTools.Properties.Resources.up_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.beOpenFile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beOpenFile.Size = new System.Drawing.Size(478, 26);
            this.beOpenFile.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Must select excel file to continue";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxVP.SetValidationRule(this.beOpenFile, conditionValidationRule2);
            this.beOpenFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beOpenFile_ButtonClick);
            // 
            // ParamtersWizardPage
            // 
            this.ParamtersWizardPage.AllowBack = false;
            this.ParamtersWizardPage.Controls.Add(this.layoutControlMain);
            this.ParamtersWizardPage.Name = "ParamtersWizardPage";
            this.ParamtersWizardPage.Size = new System.Drawing.Size(624, 299);
            this.ParamtersWizardPage.Text = "Connection Paramters";
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(706, 193, 323, 383);
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlMain.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlMain.Root = this.layoutControlGroupMain;
            this.layoutControlMain.Size = new System.Drawing.Size(624, 299);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(624, 299);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(624, 299);
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel workbook *.xlsx|*.xlsx|All Files *.*|*.*";
            this.ofd.Title = "choose excel file to add";
            // 
            // OpenXlDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.wizardControlMain);
            this.Name = "OpenXlDlg";
            this.Text = "Open Excel file";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).EndInit();
            this.wizardControlMain.ResumeLayout(false);
            this.OpenExcelWizardPage.ResumeLayout(false);
            this.OpenExcelWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beOpenFile.Properties)).EndInit();
            this.ParamtersWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlMain;
        private DevExpress.XtraWizard.WelcomeWizardPage OpenExcelWizardPage;
        private DevExpress.XtraWizard.WizardPage ParamtersWizardPage;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit beOpenFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxVP;
    }
}