using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class EquipmentAll
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(EquipmentAll));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkEquipmentAll(SqlCommand cmd, Data.dsData.EquipmentAllDataTable BulkTable, int YearNum, int MonthNum)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.EquipmentAll";
            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = "DELETE FROM dbo.EquipmentAll";
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Asset", "Asset");
                bulkCopy.ColumnMappings.Add("CapDate", "CapDate");
                bulkCopy.ColumnMappings.Add("AcquisVal", "AcquisVal");
                bulkCopy.ColumnMappings.Add("AccumDep", "AccumDep");
                bulkCopy.ColumnMappings.Add("BookVal", "BookVal");
                bulkCopy.ColumnMappings.Add("CostCtr", "CostCtr");
                bulkCopy.ColumnMappings.Add("AcqYear", "AcqYear");
                bulkCopy.ColumnMappings.Add("InventNo", "InventNo");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                //Update BookValue in Equipment with new values from EquipmentAll
                cmd.CommandText = string.Format(@"UPDATE dbo.Equipment SET BookValue = dbo.EquipmentAll.BookVal
                FROM dbo.Equipment INNER JOIN dbo.EquipmentAll ON dbo.Equipment.[Inventory number] = '0' + dbo.EquipmentAll.Asset + '-0000'
                WHERE (dbo.Equipment.YearNum = {0}) AND (dbo.Equipment.MonthNum = {1})", YearNum, MonthNum);
                cmd.ExecuteNonQuery();
                
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Bulk - " + ex.Message);
            }
            return outPut;
        }
        #endregion

    }
}
