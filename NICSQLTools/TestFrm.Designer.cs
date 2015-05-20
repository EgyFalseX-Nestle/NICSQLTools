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
            this.excelDynamicUpdateUC1 = new NICSQLTools.Views.Qry.ExcelDynamicUpdateUC();
            this.SuspendLayout();
            // 
            // excelDynamicUpdateUC1
            // 
            this.excelDynamicUpdateUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelDynamicUpdateUC1.Location = new System.Drawing.Point(0, 0);
            this.excelDynamicUpdateUC1.Name = "excelDynamicUpdateUC1";
            this.excelDynamicUpdateUC1.Size = new System.Drawing.Size(908, 480);
            this.excelDynamicUpdateUC1.TabIndex = 0;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.Controls.Add(this.excelDynamicUpdateUC1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            this.Load += new System.EventHandler(this.TestFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Qry.ExcelDynamicUpdateUC excelDynamicUpdateUC1;




    }
}