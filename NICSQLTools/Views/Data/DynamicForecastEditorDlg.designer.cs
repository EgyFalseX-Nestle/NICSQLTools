namespace NICSQLTools.Views.Data
{
    partial class DynamicForecastEditorDlg
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicForecastEditorDlg));
            this.dsData = new NICSQLTools.Data.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tbType = new DevExpress.XtraEditors.TextEdit();
            this.tbDF = new DevExpress.XtraEditors.TextEdit();
            this.tbPeriod = new DevExpress.XtraEditors.TextEdit();
            this.tbBusinessUnit = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lueCostcenter = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCostcenter = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueGLAccount = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSGLAccount = new DevExpress.Data.Linq.LinqServerModeSource();
            this.tbYear = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetplaceId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpOhda = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetsdate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusinessUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCostcenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCostcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGLAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGLAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetsdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.tbType);
            this.dataLayoutControlMain.Controls.Add(this.tbDF);
            this.dataLayoutControlMain.Controls.Add(this.tbPeriod);
            this.dataLayoutControlMain.Controls.Add(this.tbBusinessUnit);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.lueCostcenter);
            this.dataLayoutControlMain.Controls.Add(this.lueGLAccount);
            this.dataLayoutControlMain.Controls.Add(this.tbYear);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.DataSource = this.dsData;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(789, 140, 330, 510);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControlMain.Root = this.layoutControlGroupMain;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 230);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // tbType
            // 
            this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.Type", true));
            this.tbType.Location = new System.Drawing.Point(75, 168);
            this.tbType.Name = "tbType";
            this.tbType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbType.Properties.Appearance.Options.UseFont = true;
            this.tbType.Size = new System.Drawing.Size(327, 22);
            this.tbType.StyleController = this.dataLayoutControlMain;
            this.tbType.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbType, conditionValidationRule1);
            // 
            // tbDF
            // 
            this.tbDF.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.DF", true));
            this.tbDF.Location = new System.Drawing.Point(75, 142);
            this.tbDF.Name = "tbDF";
            this.tbDF.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDF.Properties.Appearance.Options.UseFont = true;
            this.tbDF.Properties.DisplayFormat.FormatString = "f2";
            this.tbDF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbDF.Properties.EditFormat.FormatString = "f2";
            this.tbDF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbDF.Properties.Mask.EditMask = "f2";
            this.tbDF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbDF.Size = new System.Drawing.Size(327, 22);
            this.tbDF.StyleController = this.dataLayoutControlMain;
            this.tbDF.TabIndex = 20;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbDF, conditionValidationRule2);
            // 
            // tbPeriod
            // 
            this.tbPeriod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.Period", true));
            this.tbPeriod.Location = new System.Drawing.Point(75, 116);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbPeriod.Properties.Appearance.Options.UseFont = true;
            this.tbPeriod.Properties.MaxLength = 1;
            this.tbPeriod.Size = new System.Drawing.Size(327, 22);
            this.tbPeriod.StyleController = this.dataLayoutControlMain;
            this.tbPeriod.TabIndex = 19;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbPeriod, conditionValidationRule3);
            // 
            // tbBusinessUnit
            // 
            this.tbBusinessUnit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.BusinessUnit", true));
            this.tbBusinessUnit.Location = new System.Drawing.Point(75, 90);
            this.tbBusinessUnit.Name = "tbBusinessUnit";
            this.tbBusinessUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbBusinessUnit.Properties.Appearance.Options.UseFont = true;
            this.tbBusinessUnit.Size = new System.Drawing.Size(327, 22);
            this.tbBusinessUnit.StyleController = this.dataLayoutControlMain;
            this.tbBusinessUnit.TabIndex = 18;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbBusinessUnit, conditionValidationRule4);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(263, 23);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NICSQLTools.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(279, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 23);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // lueCostcenter
            // 
            this.lueCostcenter.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.Costcenter", true));
            this.lueCostcenter.Location = new System.Drawing.Point(75, 12);
            this.lueCostcenter.Name = "lueCostcenter";
            this.lueCostcenter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueCostcenter.Properties.Appearance.Options.UseFont = true;
            this.lueCostcenter.Properties.Appearance.Options.UseTextOptions = true;
            this.lueCostcenter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueCostcenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCostcenter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CostCenter", "Cost Center", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CostCenterDesc", "Cost Center Desc", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Magnitude", "Magnitude", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BusinessUnit", "Business Unit", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Owner", "Owner", 48, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Owner2", "Owner2", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Assetplace", "Assetplace", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueCostcenter.Properties.DataSource = this.LSMSCostcenter;
            this.lueCostcenter.Properties.DisplayMember = "CostCenter";
            this.lueCostcenter.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueCostcenter.Properties.NullText = "";
            this.lueCostcenter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueCostcenter.Properties.ValueMember = "CostCenter";
            this.lueCostcenter.Size = new System.Drawing.Size(327, 22);
            this.lueCostcenter.StyleController = this.dataLayoutControlMain;
            this.lueCostcenter.TabIndex = 11;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueCostcenter, conditionValidationRule5);
            // 
            // LSMSCostcenter
            // 
            this.LSMSCostcenter.ElementType = typeof(NICSQLTools.Data.Linq.CostCostcenter);
            this.LSMSCostcenter.KeyExpression = "[CostCenter]";
            // 
            // lueGLAccount
            // 
            this.lueGLAccount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.GLAccount", true));
            this.lueGLAccount.Location = new System.Drawing.Point(75, 38);
            this.lueGLAccount.Name = "lueGLAccount";
            this.lueGLAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueGLAccount.Properties.Appearance.Options.UseFont = true;
            this.lueGLAccount.Properties.Appearance.Options.UseTextOptions = true;
            this.lueGLAccount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueGLAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGLAccount.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GLAccount", "GL Account", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountDesc", "Account Desc", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNature", "Account Nature", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountNature2", "Account Nature2", 104, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShouldPaid", "Should Paid", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Controllable", "Controllable", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "Emp Name", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueGLAccount.Properties.DataSource = this.LSMSGLAccount;
            this.lueGLAccount.Properties.DisplayMember = "GLAccount";
            this.lueGLAccount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueGLAccount.Properties.NullText = "";
            this.lueGLAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueGLAccount.Properties.ValueMember = "GLAccount";
            this.lueGLAccount.Size = new System.Drawing.Size(327, 22);
            this.lueGLAccount.StyleController = this.dataLayoutControlMain;
            this.lueGLAccount.TabIndex = 14;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueGLAccount, conditionValidationRule6);
            // 
            // LSMSGLAccount
            // 
            this.LSMSGLAccount.ElementType = typeof(NICSQLTools.Data.Linq.CostAccountNature);
            this.LSMSGLAccount.KeyExpression = "[GLAccount]";
            // 
            // tbYear
            // 
            this.tbYear.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "CostDynamicForecast.Year", true));
            this.tbYear.Location = new System.Drawing.Point(75, 64);
            this.tbYear.Name = "tbYear";
            this.tbYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbYear.Properties.Appearance.Options.UseFont = true;
            this.tbYear.Properties.Mask.EditMask = "n0";
            this.tbYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbYear.Size = new System.Drawing.Size(327, 22);
            this.tbYear.StyleController = this.dataLayoutControlMain;
            this.tbYear.TabIndex = 6;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbYear, conditionValidationRule7);
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 230);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssetplaceId,
            this.ItemForEmpOhda,
            this.layoutControlItem1,
            this.ItemForAssetsdate,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 210);
            // 
            // ItemForAssetplaceId
            // 
            this.ItemForAssetplaceId.Control = this.lueCostcenter;
            this.ItemForAssetplaceId.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetplaceId.Name = "ItemForAssetplaceId";
            this.ItemForAssetplaceId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetplaceId.Text = "Costcenter";
            this.ItemForAssetplaceId.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmpOhda
            // 
            this.ItemForEmpOhda.Control = this.lueGLAccount;
            this.ItemForEmpOhda.Location = new System.Drawing.Point(0, 26);
            this.ItemForEmpOhda.Name = "ItemForEmpOhda";
            this.ItemForEmpOhda.Size = new System.Drawing.Size(394, 26);
            this.ItemForEmpOhda.Text = "GLAccount";
            this.ItemForEmpOhda.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(267, 182);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(127, 28);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForAssetsdate
            // 
            this.ItemForAssetsdate.Control = this.tbYear;
            this.ItemForAssetsdate.Location = new System.Drawing.Point(0, 52);
            this.ItemForAssetsdate.Name = "ItemForAssetsdate";
            this.ItemForAssetsdate.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetsdate.Text = "Year";
            this.ItemForAssetsdate.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 182);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(267, 28);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tbBusinessUnit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(394, 26);
            this.layoutControlItem3.Text = "BusinessUnit";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tbPeriod;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(394, 26);
            this.layoutControlItem4.Text = "Period";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tbDF;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(394, 26);
            this.layoutControlItem5.Text = "DF";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tbType;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(394, 26);
            this.layoutControlItem6.Text = "Type";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 13);
            // 
            // DynamicForecastEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 230);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DynamicForecastEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusinessUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCostcenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCostcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGLAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGLAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetsdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NICSQLTools.Data.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetsdate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetplaceId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpOhda;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lueCostcenter;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCostcenter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.LookUpEdit lueGLAccount;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSGLAccount;
        private DevExpress.XtraEditors.TextEdit tbYear;
        private DevExpress.XtraEditors.TextEdit tbType;
        private DevExpress.XtraEditors.TextEdit tbDF;
        private DevExpress.XtraEditors.TextEdit tbPeriod;
        private DevExpress.XtraEditors.TextEdit tbBusinessUnit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}