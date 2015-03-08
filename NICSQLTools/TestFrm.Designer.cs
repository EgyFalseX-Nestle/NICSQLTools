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
            this.lsms = new DevExpress.Data.Linq.LinqServerModeSource();
            this.qryCustomerInfoUC1 = new NICSQLTools.Views.Qry.QryCustomerInfoUC(null);
            ((System.ComponentModel.ISupportInitialize)(this.lsms)).BeginInit();
            this.SuspendLayout();
            // 
            // lsms
            // 
            this.lsms.ElementType = typeof(NICSQLTools.Data.Linq.vAppProductDetail);
            this.lsms.KeyExpression = "[Material_Number]";
            // 
            // qryCustomerInfoUC1
            // 
            this.qryCustomerInfoUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qryCustomerInfoUC1.Location = new System.Drawing.Point(0, 0);
            this.qryCustomerInfoUC1.Name = "qryCustomerInfoUC1";
            this.qryCustomerInfoUC1.Size = new System.Drawing.Size(784, 393);
            this.qryCustomerInfoUC1.TabIndex = 0;
            // 
            // TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.qryCustomerInfoUC1);
            this.Name = "TestFrm";
            this.Text = "TestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.lsms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Data.Linq.LinqServerModeSource lsms;
        private Views.Qry.QryCustomerInfoUC qryCustomerInfoUC1;



    }
}