namespace NICSQLTools.Views.Data
{
    partial class AddDatasourceWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDatasourceWiz));
            this.wizardControlMain = new DevExpress.XtraWizard.WizardControl();
            this.SelectSPWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.gridControlSP = new DevExpress.XtraGrid.GridControl();
            this.rOUTINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataSource = new NICSQLTools.Data.dsDataSource();
            this.gridViewSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROUTINE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colLAST_ALTERED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParamtersWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.gridControlParam = new DevExpress.XtraGrid.GridControl();
            this.pARAMETERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewParam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPARAMETER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParamDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLookupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditLookupID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSLookup = new DevExpress.Data.Linq.LinqServerModeSource();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.lueType = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSAppDatasourceType = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxVP = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.rOUTINESTableAdapter = new NICSQLTools.Data.dsDataSourceTableAdapters.ROUTINESTableAdapter();
            this.pARAMETERSTableAdapter = new NICSQLTools.Data.dsDataSourceTableAdapters.PARAMETERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).BeginInit();
            this.wizardControlMain.SuspendLayout();
            this.SelectSPWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTINESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            this.ParamtersWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARAMETERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLookupID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSLookup)).BeginInit();
            this.completionWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControlMain
            // 
            this.wizardControlMain.Controls.Add(this.SelectSPWizardPage);
            this.wizardControlMain.Controls.Add(this.ParamtersWizardPage);
            this.wizardControlMain.Controls.Add(this.completionWizardPage);
            this.wizardControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControlMain.Location = new System.Drawing.Point(0, 0);
            this.wizardControlMain.Name = "wizardControlMain";
            this.wizardControlMain.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.SelectSPWizardPage,
            this.ParamtersWizardPage,
            this.completionWizardPage});
            this.wizardControlMain.Size = new System.Drawing.Size(684, 389);
            this.wizardControlMain.Text = "Select data source";
            this.wizardControlMain.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControlMain.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControlMain_SelectedPageChanging);
            this.wizardControlMain.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControlMain_CancelClick);
            this.wizardControlMain.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControlMain_FinishClick);
            // 
            // SelectSPWizardPage
            // 
            this.SelectSPWizardPage.Controls.Add(this.gridControlSP);
            this.SelectSPWizardPage.Name = "SelectSPWizardPage";
            this.SelectSPWizardPage.Size = new System.Drawing.Size(624, 221);
            this.SelectSPWizardPage.Text = "Please select stored procedure as data source";
            // 
            // gridControlSP
            // 
            this.gridControlSP.DataSource = this.rOUTINESBindingSource;
            this.gridControlSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSP.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlSP.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlSP.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlSP.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlSP.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlSP.Location = new System.Drawing.Point(0, 0);
            this.gridControlSP.MainView = this.gridViewSP;
            this.gridControlSP.Name = "gridControlSP";
            this.gridControlSP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditYMD});
            this.gridControlSP.Size = new System.Drawing.Size(624, 221);
            this.gridControlSP.TabIndex = 0;
            this.gridControlSP.UseEmbeddedNavigator = true;
            this.gridControlSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSP});
            // 
            // rOUTINESBindingSource
            // 
            this.rOUTINESBindingSource.DataMember = "ROUTINES";
            this.rOUTINESBindingSource.DataSource = this.dsDataSource;
            // 
            // dsDataSource
            // 
            this.dsDataSource.DataSetName = "dsDataSource";
            this.dsDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewSP
            // 
            this.gridViewSP.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Lime;
            this.gridViewSP.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewSP.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridViewSP.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewSP.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Lime;
            this.gridViewSP.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gridViewSP.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewSP.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROUTINE_NAME,
            this.colCREATED,
            this.colLAST_ALTERED});
            this.gridViewSP.GridControl = this.gridControlSP;
            this.gridViewSP.Name = "gridViewSP";
            this.gridViewSP.OptionsBehavior.Editable = false;
            this.gridViewSP.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSP.OptionsView.ShowDetailButtons = false;
            this.gridViewSP.OptionsView.ShowGroupPanel = false;
            this.gridViewSP.OptionsView.ShowIndicator = false;
            // 
            // colROUTINE_NAME
            // 
            this.colROUTINE_NAME.Caption = "NAME";
            this.colROUTINE_NAME.FieldName = "ROUTINE_NAME";
            this.colROUTINE_NAME.Name = "colROUTINE_NAME";
            this.colROUTINE_NAME.Visible = true;
            this.colROUTINE_NAME.VisibleIndex = 0;
            this.colROUTINE_NAME.Width = 291;
            // 
            // colCREATED
            // 
            this.colCREATED.Caption = "CREATED";
            this.colCREATED.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colCREATED.FieldName = "CREATED";
            this.colCREATED.Name = "colCREATED";
            this.colCREATED.Visible = true;
            this.colCREATED.VisibleIndex = 1;
            this.colCREATED.Width = 165;
            // 
            // repositoryItemDateEditYMD
            // 
            this.repositoryItemDateEditYMD.AutoHeight = false;
            this.repositoryItemDateEditYMD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.Name = "repositoryItemDateEditYMD";
            // 
            // colLAST_ALTERED
            // 
            this.colLAST_ALTERED.Caption = "LAST ALTERED";
            this.colLAST_ALTERED.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colLAST_ALTERED.FieldName = "LAST_ALTERED";
            this.colLAST_ALTERED.Name = "colLAST_ALTERED";
            this.colLAST_ALTERED.Visible = true;
            this.colLAST_ALTERED.VisibleIndex = 2;
            this.colLAST_ALTERED.Width = 166;
            // 
            // ParamtersWizardPage
            // 
            this.ParamtersWizardPage.Controls.Add(this.gridControlParam);
            this.ParamtersWizardPage.Name = "ParamtersWizardPage";
            this.ParamtersWizardPage.Size = new System.Drawing.Size(624, 221);
            this.ParamtersWizardPage.Text = "Data source paramters";
            // 
            // gridControlParam
            // 
            this.gridControlParam.DataSource = this.pARAMETERSBindingSource;
            this.gridControlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParam.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlParam.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlParam.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlParam.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlParam.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlParam.Location = new System.Drawing.Point(0, 0);
            this.gridControlParam.MainView = this.gridViewParam;
            this.gridControlParam.Name = "gridControlParam";
            this.gridControlParam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditLookupID});
            this.gridControlParam.Size = new System.Drawing.Size(624, 221);
            this.gridControlParam.TabIndex = 0;
            this.gridControlParam.UseEmbeddedNavigator = true;
            this.gridControlParam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParam});
            // 
            // pARAMETERSBindingSource
            // 
            this.pARAMETERSBindingSource.DataMember = "PARAMETERS";
            this.pARAMETERSBindingSource.DataSource = this.dsDataSource;
            // 
            // gridViewParam
            // 
            this.gridViewParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPARAMETER_NAME,
            this.colParamDisplayName,
            this.colLookupID});
            this.gridViewParam.GridControl = this.gridControlParam;
            this.gridViewParam.Name = "gridViewParam";
            this.gridViewParam.OptionsFind.AllowFindPanel = false;
            this.gridViewParam.OptionsMenu.EnableColumnMenu = false;
            this.gridViewParam.OptionsMenu.EnableFooterMenu = false;
            this.gridViewParam.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewParam.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewParam.OptionsView.ShowGroupPanel = false;
            this.gridViewParam.OptionsView.ShowIndicator = false;
            // 
            // colPARAMETER_NAME
            // 
            this.colPARAMETER_NAME.Caption = "Param Name";
            this.colPARAMETER_NAME.FieldName = "PARAMETER_NAME";
            this.colPARAMETER_NAME.Name = "colPARAMETER_NAME";
            this.colPARAMETER_NAME.OptionsColumn.ReadOnly = true;
            this.colPARAMETER_NAME.Visible = true;
            this.colPARAMETER_NAME.VisibleIndex = 0;
            // 
            // colParamDisplayName
            // 
            this.colParamDisplayName.Caption = "Param Display Name";
            this.colParamDisplayName.FieldName = "ParamDisplayName";
            this.colParamDisplayName.Name = "colParamDisplayName";
            this.colParamDisplayName.Visible = true;
            this.colParamDisplayName.VisibleIndex = 1;
            // 
            // colLookupID
            // 
            this.colLookupID.Caption = "Lookup";
            this.colLookupID.ColumnEdit = this.repositoryItemLookUpEditLookupID;
            this.colLookupID.FieldName = "LookupID";
            this.colLookupID.Name = "colLookupID";
            this.colLookupID.Visible = true;
            this.colLookupID.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditLookupID
            // 
            this.repositoryItemLookUpEditLookupID.AutoHeight = false;
            this.repositoryItemLookUpEditLookupID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditLookupID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupName", "Lookup Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SQLStatment", "SQL Statment", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Display Name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueName", "Value Name", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditLookupID.DataSource = this.LSMSLookup;
            this.repositoryItemLookUpEditLookupID.DisplayMember = "LookupName";
            this.repositoryItemLookUpEditLookupID.Name = "repositoryItemLookUpEditLookupID";
            this.repositoryItemLookUpEditLookupID.NullText = "";
            this.repositoryItemLookUpEditLookupID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditLookupID.ValueMember = "ID";
            // 
            // LSMSLookup
            // 
            this.LSMSLookup.ElementType = typeof(NICSQLTools.Data.Linq.AppDatasourceLookup);
            this.LSMSLookup.KeyExpression = "[ID]";
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Controls.Add(this.layoutControl1);
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(624, 221);
            this.completionWizardPage.Text = "Select data source type";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rtb);
            this.layoutControl1.Controls.Add(this.tbName);
            this.layoutControl1.Controls.Add(this.lueType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(976, 317, 303, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(624, 221);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rtb
            // 
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Location = new System.Drawing.Point(12, 76);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(600, 133);
            this.rtb.TabIndex = 4;
            this.rtb.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(510, 20);
            this.tbName.StyleController = this.layoutControl1;
            this.tbName.TabIndex = 0;
            // 
            // lueType
            // 
            this.lueType.Location = new System.Drawing.Point(102, 36);
            this.lueType.Name = "lueType";
            this.lueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AppDatasourceTypeName", "App Datasource Type Name", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueType.Properties.DataSource = this.LSMSAppDatasourceType;
            this.lueType.Properties.DisplayMember = "AppDatasourceTypeName";
            this.lueType.Properties.NullText = "";
            this.lueType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueType.Properties.ValueMember = "AppDatasourceTypeId";
            this.lueType.Size = new System.Drawing.Size(510, 20);
            this.lueType.StyleController = this.layoutControl1;
            this.lueType.TabIndex = 1;
            // 
            // LSMSAppDatasourceType
            // 
            this.LSMSAppDatasourceType.ElementType = typeof(NICSQLTools.Data.Linq.AppDatasourceType_LUE);
            this.LSMSAppDatasourceType.KeyExpression = "[AppDatasourceTypeId]";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 221);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tbName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(604, 24);
            this.layoutControlItem1.Text = "Data source name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(604, 24);
            this.layoutControlItem2.Text = "Data source type";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rtb;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(604, 153);
            this.layoutControlItem3.Text = "Help";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 13);
            // 
            // rOUTINESTableAdapter
            // 
            this.rOUTINESTableAdapter.ClearBeforeFill = true;
            // 
            // pARAMETERSTableAdapter
            // 
            this.pARAMETERSTableAdapter.ClearBeforeFill = true;
            // 
            // AddDatasourceWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.wizardControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDatasourceWiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose data source";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControlMain)).EndInit();
            this.wizardControlMain.ResumeLayout(false);
            this.SelectSPWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTINESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            this.ParamtersWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARAMETERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditLookupID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSLookup)).EndInit();
            this.completionWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAppDatasourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControlMain;
        private DevExpress.XtraWizard.WelcomeWizardPage SelectSPWizardPage;
        private DevExpress.XtraWizard.WizardPage ParamtersWizardPage;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxVP;
        private DevExpress.XtraGrid.GridControl gridControlParam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParam;
        private DevExpress.XtraGrid.GridControl gridControlSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSP;
        private NICSQLTools.Data.dsDataSource dsDataSource;
        private System.Windows.Forms.BindingSource rOUTINESBindingSource;
        private NICSQLTools.Data.dsDataSourceTableAdapters.ROUTINESTableAdapter rOUTINESTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTINE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATED;
        private DevExpress.XtraGrid.Columns.GridColumn colLAST_ALTERED;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private System.Windows.Forms.BindingSource pARAMETERSBindingSource;
        private NICSQLTools.Data.dsDataSourceTableAdapters.PARAMETERSTableAdapter pARAMETERSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPARAMETER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colParamDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colLookupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditLookupID;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSLookup;
        private DevExpress.XtraEditors.LookUpEdit lueType;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAppDatasourceType;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.RichTextBox rtb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}