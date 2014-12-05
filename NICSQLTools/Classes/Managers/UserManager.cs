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
        public static Data.dsDataTableAdapters.AppUsersTableAdapter adpUser;
        public static Data.dsDataTableAdapters.AppRuleDetailTableAdapter adpUserRuleDetials;
        private static Data.dsQryTableAdapters.SalesDistrict2TableAdapter adpUserSalesDistrict2;
        public static readonly int SuperAdminId = 1;
        //public static Data.dsQry.sales
        #endregion
        #region -   Properties   -
        public Uti.Types.UserInfo User = new Uti.Types.UserInfo();
        private NICSQLTools.Data.dsData.AppRuleDetailDataTable UserRuleDetialsTable = new Data.dsData.AppRuleDetailDataTable();
        public NICSQLTools.Data.dsQry.SalesDistrict2DataTable UserRuleSalesDistrictTable = new Data.dsQry.SalesDistrict2DataTable();
        #endregion
        #region -   Functions   -
        public static void Init()
        {
            adpUser = new Data.dsDataTableAdapters.AppUsersTableAdapter();
            adpUserRuleDetials = new Data.dsDataTableAdapters.AppRuleDetailTableAdapter();
            adpUserSalesDistrict2 = new Data.dsQryTableAdapters.SalesDistrict2TableAdapter();
            DataManager.SetAllCommandTimeouts(adpUser, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(adpUserRuleDetials, DataManager.ConnectionTimeout);
            DataManager.SetAllCommandTimeouts(adpUserSalesDistrict2, DataManager.ConnectionTimeout);

            defaultInstance = new UserManager();

        }
        public bool Login(string username, string password)
        {
            bool ReturnMe = false;
            try
            {
                Data.dsData.AppUsersDataTable UserTbl = adpUser.GetDataByNamePass(username, password);
                if (UserTbl.Rows.Count > 0)
                {
                    Data.dsData.AppUsersRow row = (Data.dsData.AppUsersRow)UserTbl.Rows[0];
                    User.UserId = row.UserID;
                    User.UserName = row.UserName;
                    User.RealName = row.RealName;
                    if (row.UserID == 1)
                        User.IsAdmin = true;
                    else
                        User.IsAdmin = false;
                    if (GetUserRules(User.UserId))
                        ReturnMe = true;
                    if (GetUserSalesDistrict(User.UserId))
                        ReturnMe = true;
                    Logger.InfoFormat("User Name {0} UserId {1} Logon Time {2}", User.UserName, User.UserId, DataManager.adpQry.GetServerDate());
                }
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }

            return ReturnMe;
        }
        private bool GetUserRules(int UserId)
        {
            adpUserRuleDetials.FillByUserID(UserRuleDetialsTable, UserId);
            return true;
        }
        private bool GetUserSalesDistrict(int UserId)
        {
            if (UserId == SuperAdminId)
                adpUserSalesDistrict2.Fill(UserRuleSalesDistrictTable);
            else
                adpUserSalesDistrict2.FillByUserId(UserRuleSalesDistrictTable, UserId);

            return true;
        }
        public NICSQLTools.Data.dsData.AppRuleDetailRow RuleElementInformation(string ElementName)
        {
            NICSQLTools.Data.dsData.AppRuleDetailRow output = UserRuleDetialsTable.NewAppRuleDetailRow();
            if (User.IsAdmin)
            {
                output.Selecting = output.Inserting = output.Updateing = output.Deleting = true;
                return output;
            }
            output.Selecting = output.Inserting = output.Updateing = output.Deleting = false;

            foreach (NICSQLTools.Data.dsData.AppRuleDetailRow  element in UserRuleDetialsTable)
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
