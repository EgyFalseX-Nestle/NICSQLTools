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
        #endregion
        #region -   Properties   -
        public Uti.Types.UserInfo User = new Uti.Types.UserInfo();
        #endregion
        #region -   Functions   -
        public static void Init()
        {
            adpUser = new Data.dsDataTableAdapters.UsersTableAdapter();
            DataManager.SetAllCommandTimeouts(adpUser, DataManager.ConnectionTimeout);

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
        #endregion

    }
}
