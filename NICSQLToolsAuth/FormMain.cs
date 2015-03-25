using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NICSQLToolsAuth
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == string.Empty)
                return;
            ApproveAuthentication(Convert.ToInt32(txtId.Text), true);
            MessageBox.Show("Done ...", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == string.Empty)
                return;
            ApproveAuthentication(Convert.ToInt32(txtId.Text), false);
            MessageBox.Show("Done ...", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ApproveAuthentication(int AuthenticationId, bool Approve)
        {
            string bytRequest = adpQry.AuthenticationRequestMessage_Get(Convert.ToInt32(AuthenticationId)).ToString();
            string BiosId = bytRequest;
            string ApproveMessage = FXFW.License.LicenseKeyGeneratorFrm.LncKey(BiosId + "NICSQLTools");
            if (Approve)
                adpQry.AuthenticationApproveMessage_Set(ApproveMessage, AuthenticationId);
            else
                adpQry.AuthenticationApproveMessage_Set("FalseX", AuthenticationId);
        }


    }
}
