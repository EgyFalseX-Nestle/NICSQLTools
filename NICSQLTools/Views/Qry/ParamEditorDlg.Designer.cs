namespace NICSQLTools.Views.Qry
{
    partial class ParamEditorDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamEditorDlg));
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
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
            this.layoutControlMain.Size = new System.Drawing.Size(410, 314);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "layoutControlGroupMain";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(410, 314);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // ParamEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 314);
            this.Controls.Add(this.layoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParamEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramters Editors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParamEditorDlg_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
    }
}