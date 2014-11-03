using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class DMG_Reason
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DMG_Reason));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkDMG_Reason(SqlCommand cmd, Data.dsData.DMG_ReasonDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("dbo.DMG_Reason{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM dbo.DMG_Reason WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());
            

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Billing Document", "Billing Document"); bulkCopy.ColumnMappings.Add("Reference Document N", "Reference Document N");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"INSERT INTO dbo.[DMG_Reason] ([Billing Document], [Reference Document N])
                SELECT [Billing Document], [Reference Document N] FROM {0}
                WHERE NOT EXISTS(SELECT [Billing Document] FROM dbo.[DMG_Reason] WHERE [Billing Document] = {0}.[Billing Document])", BulkTableName);
                Logger.DebugFormat("Inserting Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save DMG_Reason Bulk - " + ex.Message, ex);
            }
            return outPut;
        }
        #endregion

    }
}
