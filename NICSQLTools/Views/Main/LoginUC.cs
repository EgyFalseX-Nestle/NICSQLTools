using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NICSQLTools.Forms.Main;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Views.Main
{
    public partial class LoginUC : DevExpress.XtraEditors.XtraUserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }
        private void LoginUI_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();

            tbUsername.EditValue = "admin"; tbPassword.EditValue = "admin";
            btnLogin_Click(btnLogin, EventArgs.Empty);

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbUsername.EditValue) || FXFW.SqlDB.IsNullOrEmpty(tbPassword.EditValue))
                return;

            MainTilesFrm _parent = (MainTilesFrm)this.ParentForm;
            if (Classes.Managers.UserManager.defaultInstance.Login(tbUsername.EditValue.ToString(), tbPassword.EditValue.ToString()))
            {
                SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormCaption("Updating .......");
                DataManager.PerformUpdaterDownload(DataManager.GetDownloadDependanceies());// Perform Update If Exists
                if (Classes.Managers.UserManager.defaultInstance.User.UserId == 1)
                {
                    Dictionary<string, int> UploadFiles = DataManager.GetUploadDependanceies();
                    if (UploadFiles.Count > 0)
                    {
                        if (MsgDlg.Show(String.Format("{0} New Files Found{1}Are You Sure You Wanna Update Server List?", UploadFiles.Count, Environment.NewLine), MsgDlg.MessageType.Question) == DialogResult.Yes)
                            DataManager.PerformUpdaterUpload(UploadFiles);// Perform Download If Exists
                    }
                }
                SplashScreenManager.CloseForm(false);

                _parent.windowsUIView.ActivateContainer(_parent.tileContainerMain);
                _parent.ActivateRules();
            }
            else
            {
                MsgDlg.Show("Wrong username/password. Please try again", MsgDlg.MessageType.Error);
            }
        }
        
    }
}
