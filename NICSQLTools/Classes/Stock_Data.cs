using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Stock_Data
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Stock_Data));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkStock_Data(SqlCommand cmd, Data.dsData.Stock_DataDataTable BulkTable, DateTime StockDate)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "Stock_Data";

            try
            {
                //Delete All Recored Before Inserting
                cmd.Parameters.Add("@StockDate", System.Data.SqlDbType.DateTime); cmd.Parameters[0].Value = StockDate;
                cmd.CommandText = "DELETE FROM Stock_Data WHERE StockDate = @StockDate";
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("StockDate", "StockDate");
                bulkCopy.ColumnMappings.Add("Material", "Material");
                bulkCopy.ColumnMappings.Add("Plant", "Plant");
                bulkCopy.ColumnMappings.Add("Location", "Location");
                bulkCopy.ColumnMappings.Add("Status", "Status");
                bulkCopy.ColumnMappings.Add("CS", "CS");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                Logger.InfoFormat("BuldCopy Writing Successfull to Table {0}", BulkTableName);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return outPut;
        }

        #endregion

    }
}
