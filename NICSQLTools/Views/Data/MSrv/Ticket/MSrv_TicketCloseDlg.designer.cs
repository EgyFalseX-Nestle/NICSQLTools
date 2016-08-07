namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    partial class MSrv_TicketCloseDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSrv_TicketCloseDlg));
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.deClosedDate = new DevExpress.XtraEditors.DateEdit();
            this.lueCloseMSrvTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.tbOpenComment = new DevExpress.XtraEditors.MemoEdit();
            this.btnSearchSerial = new DevExpress.XtraEditors.SimpleButton();
            this.tbTecEquipmentSerial = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deClosedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deClosedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCloseMSrvTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpenComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTecEquipmentSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.deClosedDate);
            this.dataLayoutControlMain.Controls.Add(this.lueCloseMSrvTypeId);
            this.dataLayoutControlMain.Controls.Add(this.tbOpenComment);
            this.dataLayoutControlMain.Controls.Add(this.btnSearchSerial);
            this.dataLayoutControlMain.Controls.Add(this.tbTecEquipmentSerial);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(737, 146, 330, 510);
            this.dataLayoutControlMain.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControlMain.Root = this.layoutControlGroupMain;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(484, 282);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // deClosedDate
            // 
            this.deClosedDate.EditValue = null;
            this.deClosedDate.Location = new System.Drawing.Point(82, 62);
            this.deClosedDate.Name = "deClosedDate";
            this.deClosedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deClosedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deClosedDate.Properties.DisplayFormat.FormatString = "yyy-MM-dd HH:mm";
            this.deClosedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deClosedDate.Properties.EditFormat.FormatString = "yyy-MM-dd HH:mm";
            this.deClosedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deClosedDate.Properties.Mask.EditMask = "yyy-MM-dd HH:mm";
            this.deClosedDate.Size = new System.Drawing.Size(390, 20);
            this.deClosedDate.StyleController = this.dataLayoutControlMain;
            this.deClosedDate.TabIndex = 26;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.deClosedDate, conditionValidationRule1);
            // 
            // lueCloseMSrvTypeId
            // 
            this.lueCloseMSrvTypeId.Location = new System.Drawing.Point(82, 38);
            this.lueCloseMSrvTypeId.Name = "lueCloseMSrvTypeId";
            this.lueCloseMSrvTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCloseMSrvTypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MSrvType", "Reason", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueCloseMSrvTypeId.Properties.DisplayMember = "MSrvType";
            this.lueCloseMSrvTypeId.Properties.DropDownRows = 10;
            this.lueCloseMSrvTypeId.Properties.NullText = "";
            this.lueCloseMSrvTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueCloseMSrvTypeId.Properties.ValueMember = "MSrvTypeId";
            this.lueCloseMSrvTypeId.Size = new System.Drawing.Size(390, 20);
            this.lueCloseMSrvTypeId.StyleController = this.dataLayoutControlMain;
            this.lueCloseMSrvTypeId.TabIndex = 25;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueCloseMSrvTypeId, conditionValidationRule2);
            // 
            // tbOpenComment
            // 
            this.tbOpenComment.Location = new System.Drawing.Point(82, 86);
            this.tbOpenComment.Name = "tbOpenComment";
            this.tbOpenComment.Properties.MaxLength = 255;
            this.tbOpenComment.Size = new System.Drawing.Size(390, 157);
            this.tbOpenComment.StyleController = this.dataLayoutControlMain;
            this.tbOpenComment.TabIndex = 24;
            // 
            // btnSearchSerial
            // 
            this.btnSearchSerial.Image = global::NICSQLTools.Properties.Resources.find_16x16;
            this.btnSearchSerial.Location = new System.Drawing.Point(410, 12);
            this.btnSearchSerial.Name = "btnSearchSerial";
            this.btnSearchSerial.Size = new System.Drawing.Size(62, 22);
            this.btnSearchSerial.StyleController = this.dataLayoutControlMain;
            this.btnSearchSerial.TabIndex = 22;
            this.btnSearchSerial.Text = "Find";
            this.btnSearchSerial.Click += new System.EventHandler(this.btnSearchSerial_Click);
            // 
            // tbTecEquipmentSerial
            // 
            this.tbTecEquipmentSerial.EnterMoveNextControl = true;
            this.tbTecEquipmentSerial.Location = new System.Drawing.Point(82, 12);
            this.tbTecEquipmentSerial.Name = "tbTecEquipmentSerial";
            this.tbTecEquipmentSerial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTecEquipmentSerial.Properties.Appearance.Options.UseFont = true;
            this.tbTecEquipmentSerial.Size = new System.Drawing.Size(324, 22);
            this.tbTecEquipmentSerial.StyleController = this.dataLayoutControlMain;
            this.tbTecEquipmentSerial.TabIndex = 18;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbTecEquipmentSerial, conditionValidationRule3);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::NICSQLTools.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 23);
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
            this.btnCancel.Location = new System.Drawing.Point(325, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 23);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(484, 282);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(464, 262);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(313, 235);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(151, 27);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 235);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 27);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tbTecEquipmentSerial;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(398, 26);
            this.layoutControlItem3.Text = "Serial";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSearchSerial;
            this.layoutControlItem7.Location = new System.Drawing.Point(398, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(66, 26);
            this.layoutControlItem7.Text = "Find Serial";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem9.Control = this.tbOpenComment;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(464, 161);
            this.layoutControlItem9.Text = "Comment";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueCloseMSrvTypeId;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem4.Text = "Ticket Reason";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.deClosedDate;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(464, 24);
            this.layoutControlItem5.Text = "Close In";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // MSrv_TicketCloseDlg
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSrv_TicketCloseDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Dlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deClosedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deClosedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCloseMSrvTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpenComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTecEquipmentSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.TextEdit tbTecEquipmentSerial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnSearchSerial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.MemoEdit tbOpenComment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit lueCloseMSrvTypeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit deClosedDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}