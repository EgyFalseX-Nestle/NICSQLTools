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
            this.components = new System.ComponentModel.Container();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.salesDistrict2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQry = new NICSQLTools.Data.dsQry();
            this.salesDistrict2TableAdapter = new NICSQLTools.Data.dsQryTableAdapters.SalesDistrict2TableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ccbe = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrict2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(388, 1);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // salesDistrict2BindingSource
            // 
            this.salesDistrict2BindingSource.DataMember = "SalesDistrict2";
            this.salesDistrict2BindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesDistrict2TableAdapter
            // 
            this.salesDistrict2TableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(372, 250);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ccbe
            // 
            this.ccbe.Location = new System.Drawing.Point(209, 327);
            this.ccbe.Name = "ccbe";
            this.ccbe.Properties.AllowMultiSelect = true;
            this.ccbe.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.ccbe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbe.Properties.DataSource = this.salesDistrict2BindingSource;
            this.ccbe.Properties.DisplayMember = "Sales District 2";
            this.ccbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ccbe.Properties.ValueMember = "Sales District 2";
            this.ccbe.Size = new System.Drawing.Size(100, 20);
            this.ccbe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 477);
            this.Controls.Add(this.ccbe);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDistrict2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Data.dsQry dsQry;
        private System.Windows.Forms.BindingSource salesDistrict2BindingSource;
        private Data.dsQryTableAdapters.SalesDistrict2TableAdapter salesDistrict2TableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbe;












    }
}