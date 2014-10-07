using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Equipment
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Equipment));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkEquipment(SqlCommand cmd, Data.dsData.EquipmentDataTable BulkTable, int YearNum, int MonthNum)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "Equipment";

            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = string.Format("DELETE FROM Equipment WHERE YearNum = {0} AND MonthNum = {1}", YearNum, MonthNum);
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Equipment", "Equipment");
                bulkCopy.ColumnMappings.Add("Serial Number", "Serial Number");
                bulkCopy.ColumnMappings.Add("Material", "Material");
                bulkCopy.ColumnMappings.Add("ConstructYear", "ConstructYear");
                bulkCopy.ColumnMappings.Add("Description", "Description");
                bulkCopy.ColumnMappings.Add("Func Loc", "Func Loc");
                bulkCopy.ColumnMappings.Add("Valid From", "Valid From");
                bulkCopy.ColumnMappings.Add("Inventory number", "Inventory number");
                bulkCopy.ColumnMappings.Add("MonthNum", "MonthNum");
                bulkCopy.ColumnMappings.Add("YearNum", "YearNum");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                Logger.InfoFormat("BuldCopy Writing Successfull to Table {0}", BulkTableName);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Bulk - " + ex.Message, ex);
            }
            return outPut;
        }

        #endregion

    }
}
