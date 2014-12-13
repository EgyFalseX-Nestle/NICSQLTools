using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NICSQLTools.Classes
{
    public static class Authentication
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Authentication));
        public static bool RequestAuthentication()
        {
            bool output = false;
            try
            {
                string MachineID = FXFW.License.LicenseKeyFrm.CUPID();
                byte[] bytRequest = Encoding.Unicode.GetBytes(MachineID);
                object AuthenticationId = Classes.Managers.DataManager.adpQry.AuthenticationId_Get(bytRequest);

                if (AuthenticationId == null)
                {
                    //Test Mode........
                    Classes.Managers.DataManager.adpQry.AuthenticationRequest(bytRequest, Classes.Managers.UserManager.defaultInstance.User.UserId);
                    ApproveAuthentication((int)Classes.Managers.DataManager.adpQry.AuthenticationId_Get(bytRequest));
                    //////////////////////////

                    //if (MsgDlg.Show(String.Format("Your PC Is not Authorized To Run This Application{0}Wanna Ask For Approve ?", Environment.NewLine), MsgDlg.MessageType.Question) == DialogResult.Yes)
                    //{//Yes
                    //    Classes.Managers.DataManager.adpQry.AuthenticationRequest(bytRequest, Classes.Managers.UserManager.defaultInstance.User.UserId);
                    //    MsgDlg.Show(String.Format("Your Request Send To Administrator, Please Wait For Approval.{0} Application Will Shutdown", Environment.NewLine), MsgDlg.MessageType.Success);
                    //}
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else// Have Request
                {
                    object bytApprove = Classes.Managers.DataManager.adpQry.AuthenticationApproveSearch(Convert.ToInt32(AuthenticationId));
                    if (bytApprove == null)// Request In Pending State
                    {
                        MsgDlg.Show(String.Format("Administrator Did Not Answer Your Request Yet, Please Wait For Approval.{0}Application Will Shutdown", Environment.NewLine), MsgDlg.MessageType.Info);
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                    else// Request Have Approval
                    {
                        string Data = Encoding.Unicode.GetString((byte[])bytApprove);
                        if (FXFW.License.LicenseKeyFrm.Compare2(Data, Application.ProductName))
                            output = true;
                        else
                            output = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }

            return output;
        }
        public static bool ApproveAuthentication(int AuthenticationId)
        {
            try
            {
                byte[] bytRequest = (byte[])Classes.Managers.DataManager.adpQry.AuthenticationRequestMessage_Get(Convert.ToInt32(AuthenticationId));
                string CPUID = Encoding.Unicode.GetString(bytRequest);
                string ApproveMessage = FXFW.License.LicenseKeyGeneratorFrm.LncKey(CPUID + Application.ProductName);
                Classes.Managers.DataManager.adpQry.AuthenticationApproveMessage_Set(Encoding.Unicode.GetBytes(ApproveMessage), AuthenticationId);
                return true;
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
            }
            return false;
        }
        

    }
}
