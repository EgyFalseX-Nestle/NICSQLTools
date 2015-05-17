using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Stock_List
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Stock_List));
        #endregion
        #region -   Properties   -
        #endregion
        #region -   Functions   -

        public static bool UpdateBulkStockList(SqlCommand cmd, Data.dsData.Stock_ListDataTable BulkTable, int YearNum, int MonthNum)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.Stock_List";

            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = string.Format("DELETE FROM dbo.Stock_List WHERE YearNum = {0} AND MonthNum = {1}", YearNum, MonthNum);
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Material", "Material");
                bulkCopy.ColumnMappings.Add("Batch", "Batch");
                bulkCopy.ColumnMappings.Add("Plant", "Plant");
                bulkCopy.ColumnMappings.Add("Storage Bin", "Storage Bin");
                bulkCopy.ColumnMappings.Add("Storage Type", "Storage Type");
                bulkCopy.ColumnMappings.Add("Total Stock", "Total Stock");
                bulkCopy.ColumnMappings.Add("Base Unit of Measure", "Base Unit of Measure");
                bulkCopy.ColumnMappings.Add("Last movement", "Last movement");
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
