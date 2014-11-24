using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NICSQLTools.Classes.Managers
{
    public class UserManager
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(UserManager));
        public static UserManager defaultInstance;
        public static Data.dsDataTableAdapters.UsersTableAdapter adpUser;
        public static Data.dsDataTableAdapters.RuleDetailTableAdapter adpUserRuleDetials;
        #endregion
        #region -   Properties   -
        public Uti.Types.UserInfo User = new Uti.Types.UserInfo();
        private NICSQLTools.Data.dsData.RuleDetailDataTable UserRuleDetialsTable = new Data.dsData.RuleDetailDataTable();
        #endregion
        #region -   Functions   -
        public static void Init()
        {
            adpUser = new Data.dsDataTableAdapters.UsersTableAdapter();
            adpUserRuleDetials = new Data.dsDataTableAdapters.RuleDetailTableAdapter();
            DataManager.SetAllCommandTimeouts(adpUser, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(adpUserRuleDetials, DataManager.ConnectionTimeout);

            defaultInstance = new UserManager();

        }
        public bool Login(string username, string password)
        {
            bool ReturnMe = false;
            try
            {
                Data.dsData.UsersDataTable UserTbl = adpUser.GetDataByNamePass(username, password);
                if (UserTbl.Rows.Count > 0)
                {
                    Data.dsData.UsersRow row = (Data.dsData.UsersRow)UserTbl.Rows[0];
                    User.UserId = row.UserID;
                    User.UserName = row.UserName;
                    User.RealName = row.RealName;
                    if (row.UserID == 1)
                        User.IsAdmin = true;
                    else
                        User.IsAdmin = false;
                    if (GetUserRules(User.UserId))
                        ReturnMe = true;    
                    Logger.InfoFormat("User Name {0} UserId {1} Logon Time {2}", User.UserName, User.UserId, DataManager.adpQry.GetServerDate());
                }
            }
            catch (SqlException ex)
            {
                Logger.Error(ex.Message, ex);
            }

            return ReturnMe;
        }
        private bool GetUserRules(int UserId)
        {
            adpUserRuleDetials.FillByUserID(UserRuleDetialsTable, UserId);
            return true;
        }
        public NICSQLTools.Data.dsData.RuleDetailRow RuleElementInformation(string ElementName)
        {
            NICSQLTools.Data.dsData.RuleDetailRow output = UserRuleDetialsTable.NewRuleDetailRow();
            output.Selecting = output.Inserting = output.Updateing = output.Deleting = false;

            foreach (NICSQLTools.Data.dsData.RuleDetailRow  element in UserRuleDetialsTable)
            {
                if (element.ItemName == ElementName)
                {
                    if (element.Selecting)
                        output.Selecting = true;
                    if (element.Inserting)
                        output.Inserting = true;
                    if (element.Updateing)
                        output.Updateing = true;
                    if (element.Deleting)
                        output.Deleting = true;
                }
            }
            return output;
        }
        #endregion

    }
}
