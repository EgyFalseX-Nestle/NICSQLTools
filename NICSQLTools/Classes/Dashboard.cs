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
    public class Dashboard
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Dashboard));
        public static Dashboard defaultInstance;
        public static Data.dsDataTableAdapters.AppDashboardSchemaTableAdapter adpDashboardSchema = new Data.dsDataTableAdapters.AppDashboardSchemaTableAdapter();
        public static string ComponentNamePerfix = "ID";
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
        public Dashboard()
        {
 
        }
        public static void Init()
        {
            defaultInstance = new Dashboard();
            DataManager.SetAllCommandTimeouts(adpDashboardSchema, DataManager.ConnectionTimeout);
        }
        public static int? InsertDashboard(NICSQLTools.Data.dsData.AppDashboardSchemaRow SavingRow)
        {
            int? Id = null;
            try
            {
                SqlParameter PramDashboardSchemaName = new SqlParameter("@DashboardSchemaName", SqlDbType.NVarChar);
                SqlParameter PramDashboardSchemaData = new SqlParameter("@DashboardSchemaData", SqlDbType.Image);
                SqlParameter PramUserIn = new SqlParameter("@UserIn", SqlDbType.Int);

                SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
                SqlCommand cmd = new SqlCommand("", con)
                {
                    //Should Make Id Not Auto Idnetity
                    CommandText = @"INSERT INTO AppDashboardSchema (DashboardSchemaName,
                    DashboardSchemaData, UserIn, DateIn) VALUES (@DashboardSchemaName, @DashboardSchemaData, @UserIn, GetDate()) SELECT SCOPE_IDENTITY()"
                };
                PramDashboardSchemaName.Value = SavingRow.DashboardSchemaName;
                PramDashboardSchemaData.Value = SavingRow.DashboardSchemaData;
                PramUserIn.Value = Classes.Managers.UserManager.defaultInstance.User.UserId;
                cmd.Parameters.AddRange(new SqlParameter[] { PramDashboardSchemaName, PramDashboardSchemaData, PramUserIn });

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
        public static bool UpdateDashboardSchema(NICSQLTools.Data.dsData.AppDashboardSchemaRow SavingRow)
        {
            bool ReturnMe;
            int changes = adpDashboardSchema.Update(SavingRow.DashboardSchemaName, SavingRow.DashboardSchemaData, Classes.Managers.UserManager.defaultInstance.User.UserId,
                SavingRow.DashboardSchemaId, SavingRow.DashboardSchemaId);

            if (changes != 0)
                ReturnMe = true;
            else
                ReturnMe = false;
            return ReturnMe;
        }
        public static string ZZ_ConvertDashboardXML(DevExpress.DashboardCommon.Dashboard dashboard)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            dashboard.SaveToXml(ms);
            string ReturnMe = Encoding.UTF8.GetString(ms.ToArray());
            
            if (ReturnMe[0] == Convert.ToChar("?"))
                return ReturnMe.Remove(0, 1);
            return ReturnMe;
        }
        public static System.IO.MemoryStream ZZ_ConvertDashboardXML(string xmlData)
        {
            return new System.IO.MemoryStream(Encoding.UTF8.GetBytes(xmlData));
        }
        public static DevExpress.DashboardCommon.DataSource CreateDashboardDatasource(DataTable dt, string dsName, int dsID)
        {
            return new DevExpress.DashboardCommon.DataSource(dsName, dt) { ComponentName = ComponentNamePerfix + dsID };
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

    }
}
