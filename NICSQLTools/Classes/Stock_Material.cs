using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Stock_Material
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Stock_Material));
        #endregion
        #region -   Properties   -
        #endregion
        #region -   Functions   -

        public static bool UpdateBulkStock_Material(SqlCommand cmd, Data.dsData.Stock_MaterialDataTable BulkTable, int YearNum, int MonthNum)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.Stock_Material";

            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = string.Format("DELETE FROM dbo.Stock_Material WHERE YearNum = {0} AND MonthNum = {1}", YearNum, MonthNum);
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Material", "Material");
                bulkCopy.ColumnMappings.Add("Batch", "Batch");
                bulkCopy.ColumnMappings.Add("Plant", "Plant");
                bulkCopy.ColumnMappings.Add("BatchStatus", "BatchStatus");
                bulkCopy.ColumnMappings.Add("DisplayUnitMeasure", "DisplayUnitMeasure");
                bulkCopy.ColumnMappings.Add("Unrestricted", "Unrestricted");
                bulkCopy.ColumnMappings.Add("InQualityInsp", "InQualityInsp");
                bulkCopy.ColumnMappings.Add("RestrictedUseStock", "RestrictedUseStock");
                bulkCopy.ColumnMappings.Add("Blocked", "Blocked");
                bulkCopy.ColumnMappings.Add("Returns", "Returns");
                bulkCopy.ColumnMappings.Add("StockInTransit", "StockInTransit");
                bulkCopy.ColumnMappings.Add("TransitCC", "TransitCC");
                bulkCopy.ColumnMappings.Add("OpDelive", "OpDelive");
                bulkCopy.ColumnMappings.Add("MonthNum", "MonthNum");
                bulkCopy.ColumnMappings.Add("YearNum", "YearNum");
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
