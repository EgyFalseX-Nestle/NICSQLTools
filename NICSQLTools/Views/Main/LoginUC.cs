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
using NICSQLTools.Views.Main;
using DevExpress.XtraSplashScreen;
using System.IO;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Views.Main
{
    public partial class LoginUC : XtraUserControl
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(LoginUC));

        private readonly string LoginInfoFileName = Application.StartupPath + "\\loginInfo";
        public LoginUC()
        {
            InitializeComponent();

            if (File.Exists(LoginInfoFileName))
            {
                FileStream fs = File.Open(LoginInfoFileName, FileMode.Open, FileAccess.Read);
                byte[] buff = new byte[fs.Length];
                fs.Read(buff, 0, Convert.ToInt32(fs.Length));
                fs.Close(); fs.Dispose();
                string username = Encoding.Default.GetString(buff, 0, buff.Length);
                tbUsername.EditValue = username;
                tbPassword.Focus();
            }
        }
        private void LoginUI_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();

            //tbUsername.EditValue = "admin"; tbPassword.EditValue = "admin";
            //btnLogin_Click(btnLogin, EventArgs.Empty);

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbUsername.EditValue) || FXFW.SqlDB.IsNullOrEmpty(tbPassword.EditValue))
                return;

            MainTilesFrm _parent = (MainTilesFrm)ParentForm;
            if (UserManager.defaultInstance.Login(tbUsername.EditValue.ToString(), tbPassword.EditValue.ToString()))
            {
                SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormCaption("Updating .......");
                //Check If Application Version Is no longer able to run or update
                if (DataManager.VersionExpired())
                {
                    MsgDlg.Show("Application is too old to perform an update, please ask for new version ...", MsgDlg.MessageType.Error);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                if (UserManager.defaultInstance.User.UserId == 1)
                {
                    Dictionary<string, int> UploadFiles = DataManager.GetUploadDependanceies();
                    if (UploadFiles.Count > 0)
                    {
                        if (MsgDlg.Show(String.Format("{0} New Files Found{1}Are You Sure You Wanna Update Server List?", UploadFiles.Count, Environment.NewLine), MsgDlg.MessageType.Question) == DialogResult.Yes)
                            DataManager.PerformUpdaterUpload(UploadFiles);// Perform Update Server If Exists
                    }
                }
                DataManager.PerformUpdaterDownload(DataManager.GetDownloadDependanceies());// Perform Update Client If Exists
                SplashScreenManager.CloseForm(false);

                //string xx = FXFW.License.LicenseKeyGeneratorFrm.XXX();
                //Classes.Authentication.ApproveAuthentication(2);

                if (Classes.Authentication.RequestAuthentication())// Check Authentication
                {
                    SaveLoginInfoToFile();// Save UserName Into File For Auto Load
                    _parent.LoadLayout();
                    _parent.ActivateRules();
                    _parent.windowsUIView.ActivateContainer(_parent.tileContainerMain);
                    _parent.AddPrivateButtions();//Add User Private Buttons
                    btnLogin.Enabled = false;
                }
            }
            else
            {
                MsgDlg.Show("Wrong username/password. Please try again", MsgDlg.MessageType.Error);
            }
        }
        private void SaveLoginInfoToFile()
        {
            FileStream fs = File.Open(LoginInfoFileName, FileMode.Create, FileAccess.Write);
            byte[] buff = Encoding.Default.GetBytes(tbUsername.EditValue.ToString());

            fs.Write(buff, 0, buff.Length);

            fs.Flush(); fs.Close(); fs.Dispose();

        }
        
    }
}
