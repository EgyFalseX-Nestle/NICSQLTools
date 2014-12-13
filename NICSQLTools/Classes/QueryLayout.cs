using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NICSQLTools.Classes.Managers;

namespace NICSQLTools.Classes
{
    public class QueryLayout
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(QueryLayout));
        public static Dashboard defaultInstance;
        public static Data.dsDataTableAdapters.AppDatasourceLayoutTableAdapter adpAppDatasourceLayout = new Data.dsDataTableAdapters.AppDatasourceLayoutTableAdapter();
        
        public struct DatasourceStrc
        {
            public Dictionary<string, System.Windows.Forms.Control> Controls;
            public DevExpress.XtraEditors.SimpleButton ExeButton;
            public DevExpress.XtraEditors.SimpleButton CancelButton;
            public int DashboadId;
            public string DatasourceName;
            public string DatasourceSPName;
            public SqlCommand Execommand;
        }
        public QueryLayout()
        {
 
        }
        public static void Init()
        {
            defaultInstance = new Dashboard();
            DataManager.SetAllCommandTimeouts(adpAppDatasourceLayout, DataManager.ConnectionTimeout);
        }
        public static int? InsertLayout(int DatasourceID, string DatasourceLayoutName, byte[] DatasourceLayoutData)
        {
            int? Id = null;
            try
            {
                SqlParameter PramDatasourceID = new SqlParameter("@DatasourceID", SqlDbType.Int);
                SqlParameter PramDatasourceLayoutName = new SqlParameter("@DatasourceLayoutName", SqlDbType.NVarChar);
                SqlParameter PramDatasourceLayoutData = new SqlParameter("@DatasourceLayoutData", SqlDbType.Image);
                SqlParameter PramUserIn = new SqlParameter("@UserIn", SqlDbType.Int);

                SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
                SqlCommand cmd = new SqlCommand("", con)
                {
                    CommandText = @"INSERT INTO dbo.AppDatasourceLayout (DatasourceID, DatasourceLayoutName, DatasourceLayoutData,
                    UserIn, DateIn) VALUES (@DatasourceID, @DatasourceLayoutName, @DatasourceLayoutData, @UserIn, GetDate()) SELECT SCOPE_IDENTITY()"
                };
                PramDatasourceID.Value = DatasourceID;
                PramDatasourceLayoutName.Value = DatasourceLayoutName;
                PramDatasourceLayoutData.Value = DatasourceLayoutData;
                PramUserIn.Value = Classes.Managers.UserManager.defaultInstance.User.UserId;
                cmd.Parameters.AddRange(new SqlParameter[] { PramDatasourceID, PramDatasourceLayoutName, PramDatasourceLayoutData, PramUserIn });

                con.Open();
                object obj = cmd.ExecuteScalar();
                con.Close();
                if (obj != null)
                    Id = Convert.ToInt32(obj);
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return Id;
        }
        public static bool UpdateDatasourceLayout(int DatasourceLayoutId, int DatasourceID, string DatasourceLayoutName, byte[] DatasourceLayoutData)
        {
            bool ReturnMe;
            int changes = adpAppDatasourceLayout.Update(DatasourceID, DatasourceLayoutName, DatasourceLayoutData, Classes.Managers.UserManager.defaultInstance.User.UserId, DatasourceLayoutId);

            if (changes != 0)
                ReturnMe = true;
            else
                ReturnMe = false;
            return ReturnMe;
        }
        /// <summary>
        /// Check if Selected DatasourceStrc have control with empty value or not
        /// </summary>
        /// <param name="dsStrc"> Pass DatasourceStrc to validate if it have empty control value</param>
        /// <returns>"True" = Have Empty value, "False" Haven't Empty Value</returns>
        public static bool ChekForEmptyPram(DatasourceStrc dsStrc)
        {
            foreach (KeyValuePair<string, System.Windows.Forms.Control> item in dsStrc.Controls)
            {
                DevExpress.XtraEditors.TextEdit ctr = (DevExpress.XtraEditors.TextEdit)item.Value;
                if (FXFW.SqlDB.IsNullOrEmpty(ctr.EditValue))
                    return true;
            }
            return false;
        }
        public static byte[] LoadDatasourceLayoutData(int DatasourceLayoutId)
        {
            byte[] output = new byte[1];
            try
            {
                output = adpAppDatasourceLayout.GetDatasourceLayoutData(DatasourceLayoutId);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return output;
        }
        public static bool DeleteDatasourceLayout(int DatasourceLayoutId)
        {
            try
            {
                if (adpAppDatasourceLayout.Delete(DatasourceLayoutId) > 0)
                    return true;
                else
                    return false;
                
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                return false;
            }
            
        }
        public static DevExpress.Utils.Menu.DXMenuItem CreateMenuItem(string MenuCaption, System.Drawing.Bitmap MenuImage, EventHandler ClickEvent)
        {
            DevExpress.Utils.Menu.DXMenuItem MenuItem = new DevExpress.Utils.Menu.DXMenuItem(MenuCaption, DevExpress.Utils.Menu.DXMenuItemPriority.Normal)
            {
                Image = MenuImage
            };
            MenuItem.Click += ClickEvent;

            return MenuItem;
        }
    }
}
