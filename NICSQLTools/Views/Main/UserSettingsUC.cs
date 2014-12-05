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
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId;
                NICSQLTools.Views.Main.MainTilesFrm MainForm = (NICSQLTools.Views.Main.MainTilesFrm)this.ParentForm;
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
                NICSQLTools.Views.Main.MainTilesFrm MainForm = (NICSQLTools.Views.Main.MainTilesFrm)this.ParentForm;
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

    }
}
