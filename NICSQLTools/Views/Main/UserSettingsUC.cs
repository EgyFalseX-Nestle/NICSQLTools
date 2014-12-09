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
using System.IO;

namespace NICSQLTools.Views.Main
{
    public partial class UserSettingsUC : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UserSettingsUC));
        public UserSettingsUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlMain, true);
            tbUsername.EditValue = Classes.Managers.UserManager.defaultInstance.User.UserName;
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId;
                MainTilesFrm MainForm = (MainTilesFrm)ParentForm;
                FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
                MainForm.windowsUIView.SaveLayoutToStream(fs);
                fs.Close();
                MsgDlg.Show("Settings Saved ...", MsgDlg.MessageType.Success);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void btnResertLayout_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            try
            {
                string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId;
                if (File.Exists(FileName))
                    File.Delete(FileName);
                MainTilesFrm MainForm = (MainTilesFrm)ParentForm;
                MainForm.windowsUIView.OptionsLayout.Reset();
                //MsgDlg.Show("Settings Deleted ...", MsgDlg.MessageType.Success);
                if (MsgDlg.Show(String.Format("To Apply Default Settings Please Restart Application{0}Are You Sure ?", Environment.NewLine), MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            if (!dxvpLoginInfoChange.Validate())
                return;
            if (!Classes.Managers.UserManager.defaultInstance.CheckCurrentPassword(tbCurentpassword.EditValue.ToString()))
            {
                MsgDlg.Show("Wrong Current Password", MsgDlg.MessageType.Error);
                return;
            }
            if (tbNewpassword1.EditValue.ToString() != tbNewpassword2.EditValue.ToString())
            {
                MsgDlg.Show("New Password Not Equal ReEntered New Password", MsgDlg.MessageType.Error);
                return;
            }
            if (MsgDlg.Show("Are You Sure Wanna Change login Information ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            if (Classes.Managers.UserManager.defaultInstance.ChangeLogininfo(tbUsername.EditValue.ToString(), tbNewpassword1.EditValue.ToString()))
                MsgDlg.Show("Username / Password Changed", MsgDlg.MessageType.Success);
            else
                MsgDlg.Show("Error While Tring To Change Login Info", MsgDlg.MessageType.Error);
        }

    }
}
