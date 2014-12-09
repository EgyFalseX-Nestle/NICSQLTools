namespace NICSQLTools
{
    partial class TestFrm
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
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsms)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(218, 117);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DataSource = this.lsms;
            this.checkedComboBoxEdit1.Properties.DisplayMember = "Material_Number";
            this.checkedComboBoxEdit1.Properties.ValueMember = "Material_Number";
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(276, 20);
            this.checkedComboBoxEdit1.TabIndex = 0;
            // 
            // lsms
            // 
            this.lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail);
            this.lsms.KeyExpression = "[Material_Number]";
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.Data.Linq.LinqServerModeSource lsms;



    }
}