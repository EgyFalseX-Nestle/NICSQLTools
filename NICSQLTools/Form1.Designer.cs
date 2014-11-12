namespace NICSQLTools
{
    partial class Form1
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
            this.userUC1 = new NICSQLTools.Views.Permission.UserUC();
            this.SuspendLayout();
            // 
            // userUC1
            // 
            this.userUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userUC1.Location = new System.Drawing.Point(0, 0);
            this.userUC1.Name = "userUC1";
            this.userUC1.Size = new System.Drawing.Size(738, 337);
            this.userUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 337);
            this.Controls.Add(this.userUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Permission.UserUC userUC1;




    }
}