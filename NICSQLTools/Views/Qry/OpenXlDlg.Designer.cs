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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenXlDlg));
            this.wizardControlMain = new DevExpress.XtraWizard.WizardControl();
            this.OpenExcelWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.beOpenFile = new DevExpress.XtraEditors.ButtonEdit();
            this.ParamtersWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.gridControlJobs = new DevExpress.XtraGrid.GridControl();
            this.gridViewJobs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditParam = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.dxVP = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).BeginInit();
            this.wizardControlMain.SuspendLayout();
            this.OpenExcelWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beOpenFile.Properties)).BeginInit();
            this.ParamtersWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParam)).BeginInit();
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
            this.wizardControlMain.Size = new System.Drawing.Size(684, 389);
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
            this.OpenExcelWizardPage.Size = new System.Drawing.Size(624, 221);
            this.OpenExcelWizardPage.Text = "Please select excel file and press Next";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(73, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Select Excel File";
            // 
            // beOpenFile
            // 
            this.beOpenFile.Location = new System.Drawing.Point(73, 111);
            this.beOpenFile.Name = "beOpenFile";
            this.beOpenFile.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.beOpenFile.Properties.Appearance.Options.UseFont = true;
            this.beOpenFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::NICSQLTools.Properties.Resources.up_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.beOpenFile.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beOpenFile.Size = new System.Drawing.Size(478, 30);
            this.beOpenFile.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Must select excel file to continue";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxVP.SetValidationRule(this.beOpenFile, conditionValidationRule1);
            this.beOpenFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beOpenFile_ButtonClick);
            // 
            // ParamtersWizardPage
            // 
            this.ParamtersWizardPage.AllowBack = false;
            this.ParamtersWizardPage.Controls.Add(this.gridControlJobs);
            this.ParamtersWizardPage.Name = "ParamtersWizardPage";
            this.ParamtersWizardPage.Size = new System.Drawing.Size(624, 221);
            this.ParamtersWizardPage.Text = "Connection Paramters";
            // 
            // gridControlJobs
            // 
            this.gridControlJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlJobs.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlJobs.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlJobs.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlJobs.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlJobs.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlJobs.Location = new System.Drawing.Point(0, 0);
            this.gridControlJobs.MainView = this.gridViewJobs;
            this.gridControlJobs.Name = "gridControlJobs";
            this.gridControlJobs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditSelect,
            this.repositoryItemButtonEditParam});
            this.gridControlJobs.Size = new System.Drawing.Size(624, 221);
            this.gridControlJobs.TabIndex = 0;
            this.gridControlJobs.UseEmbeddedNavigator = true;
            this.gridControlJobs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewJobs});
            // 
            // gridViewJobs
            // 
            this.gridViewJobs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewJobs.GridControl = this.gridControlJobs;
            this.gridViewJobs.Name = "gridViewJobs";
            this.gridViewJobs.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewJobs.OptionsFind.AllowFindPanel = false;
            this.gridViewJobs.OptionsMenu.EnableColumnMenu = false;
            this.gridViewJobs.OptionsMenu.EnableFooterMenu = false;
            this.gridViewJobs.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewJobs.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewJobs.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewJobs.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewJobs.OptionsView.ShowGroupPanel = false;
            this.gridViewJobs.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Select";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEditSelect;
            this.gridColumn1.FieldName = "Select";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 47;
            // 
            // repositoryItemCheckEditSelect
            // 
            this.repositoryItemCheckEditSelect.AutoHeight = false;
            this.repositoryItemCheckEditSelect.Name = "repositoryItemCheckEditSelect";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Connection Name";
            this.gridColumn2.FieldName = "ConnectionName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 252;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Datasource Name";
            this.gridColumn3.FieldName = "DatasourceName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 223;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Change Paramters";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditParam;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 107;
            // 
            // repositoryItemButtonEditParam
            // 
            this.repositoryItemButtonEditParam.AutoHeight = false;
            this.repositoryItemButtonEditParam.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditParam.Name = "repositoryItemButtonEditParam";
            this.repositoryItemButtonEditParam.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditParam.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditParam_ButtonClick);
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(624, 221);
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
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.wizardControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenXlDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Excel file";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).EndInit();
            this.wizardControlMain.ResumeLayout(false);
            this.OpenExcelWizardPage.ResumeLayout(false);
            this.OpenExcelWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beOpenFile.Properties)).EndInit();
            this.ParamtersWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParam)).EndInit();
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
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxVP;
        private DevExpress.XtraGrid.GridControl gridControlJobs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewJobs;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditParam;
    }
}