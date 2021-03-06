﻿namespace NICSQLTools.Views.Main
{
    partial class LoginUC
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
            this.tbUsername = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tbPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemImg = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItembtnLogin = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItembtnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.EnterMoveNextControl = true;
            this.tbUsername.Location = new System.Drawing.Point(191, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbUsername.Properties.Appearance.Options.UseFont = true;
            this.tbUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.tbUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbUsername.Properties.NullText = "Enter Username here";
            this.tbUsername.Properties.ValidateOnEnterKey = true;
            this.tbUsername.Size = new System.Drawing.Size(245, 26);
            this.tbUsername.StyleController = this.layoutControlMain;
            this.tbUsername.TabIndex = 0;
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.btnLogin);
            this.layoutControlMain.Controls.Add(this.pictureEdit1);
            this.layoutControlMain.Controls.Add(this.tbUsername);
            this.layoutControlMain.Controls.Add(this.tbPassword);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1065, 292, 324, 459);
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(800, 400);
            this.layoutControlMain.TabIndex = 4;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Image = global::NICSQLTools.Properties.Resources.Lock16;
            this.btnLogin.Location = new System.Drawing.Point(140, 72);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(296, 26);
            this.btnLogin.StyleController = this.layoutControlMain;
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::NICSQLTools.Properties.Resources.LoginLogo256;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(124, 124);
            this.pictureEdit1.StyleController = this.layoutControlMain;
            this.pictureEdit1.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.EnterMoveNextControl = true;
            this.tbPassword.Location = new System.Drawing.Point(191, 42);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbPassword.Properties.Appearance.Options.UseFont = true;
            this.tbPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.tbPassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbPassword.Properties.UseSystemPasswordChar = true;
            this.tbPassword.Properties.ValidateOnEnterKey = true;
            this.tbPassword.Size = new System.Drawing.Size(245, 26);
            this.tbPassword.StyleController = this.layoutControlMain;
            this.tbPassword.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItembtnLogin,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItemImg});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 400);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemImg
            // 
            this.layoutControlItemImg.Control = this.pictureEdit1;
            this.layoutControlItemImg.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItemImg.CustomizationFormText = "Image";
            this.layoutControlItemImg.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemImg.MaxSize = new System.Drawing.Size(128, 128);
            this.layoutControlItemImg.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControlItemImg.Name = "layoutControlItemImg";
            this.layoutControlItemImg.Size = new System.Drawing.Size(128, 380);
            this.layoutControlItemImg.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemImg.Text = "layoutControlItemImg";
            this.layoutControlItemImg.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemImg.TextToControlDistance = 0;
            this.layoutControlItemImg.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tbUsername;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem3.CustomizationFormText = "Username";
            this.layoutControlItem3.Location = new System.Drawing.Point(128, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(300, 30);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(652, 30);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Username";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tbPassword;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem2.CustomizationFormText = "Password";
            this.layoutControlItem2.Location = new System.Drawing.Point(128, 30);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(300, 30);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(652, 30);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItembtnLogin
            // 
            this.layoutControlItembtnLogin.Control = this.btnLogin;
            this.layoutControlItembtnLogin.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItembtnLogin.CustomizationFormText = "Login Button";
            this.layoutControlItembtnLogin.Location = new System.Drawing.Point(128, 60);
            this.layoutControlItembtnLogin.MaxSize = new System.Drawing.Size(300, 30);
            this.layoutControlItembtnLogin.MinSize = new System.Drawing.Size(59, 26);
            this.layoutControlItembtnLogin.Name = "layoutControlItembtnLogin";
            this.layoutControlItembtnLogin.Size = new System.Drawing.Size(652, 320);
            this.layoutControlItembtnLogin.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItembtnLogin.Text = "layoutControlItembtnLogin";
            this.layoutControlItembtnLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItembtnLogin.TextToControlDistance = 0;
            this.layoutControlItembtnLogin.TextVisible = false;
            // 
            // LoginUC
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControlMain);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItembtnLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbUsername;
        private DevExpress.XtraEditors.TextEdit tbPassword;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImg;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItembtnLogin;
    }
}
