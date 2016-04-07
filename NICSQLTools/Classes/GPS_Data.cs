using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class GPS_Data
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(GPS_Data));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkGPS_Data(SqlCommand cmd, Data.dsData.GPS_DataDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("GPS_Data{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM dbo.GPS_Data WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, );
            cmd.ExecuteNonQuery();

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Plate", "Plate"); bulkCopy.ColumnMappings.Add("StartTime", "StartTime");
                bulkCopy.ColumnMappings.Add("EndTime", "EndTime"); bulkCopy.ColumnMappings.Add("Stop_Idle", "Stop_Idle");
                bulkCopy.ColumnMappings.Add("Customer", "Customer"); 

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                //cmd.CommandText = string.Format(@"merge into GPS_Data as Target 
                //using {0} as Source on Target.StartTime = Source.StartTime AND Target.EndTime = Source.EndTime AND Target.Plate = Source.Plate
                //when matched then 
                //update set 
                //Target.Stop_Idle = Source.Stop_Idle,
                //Target.Customer = Source.Customer
                //when not matched then 
                //insert (StartTime,EndTime,Stop_Idle, Customer, Plate) values 
                //(Source.StartTime, Source.EndTime, Source.Stop_Idle, Source.Customer, Source.Plate);", BulkTableName);

                cmd.CommandText = string.Format(@"

INSERT INTO [dbo].[GPS_Data] ([StartTime], [EndTime], [Stop_Idle], [Customer], [Plate])
SELECT [StartTime], [EndTime], [Stop_Idle], [Customer], [Plate] FROM {0}
WHERE NOT EXISTS(SELECT * FROM [dbo].[GPS_Data] 
WHERE [StartTime] = {0}.[StartTime] AND [EndTime] = {0}.[EndTime] AND [Plate] = {0}.[Plate])", BulkTableName);

                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save GPS_Data Bulk - " + ex.Message);
            }
            return outPut;
        }
        #endregion

    }
}
