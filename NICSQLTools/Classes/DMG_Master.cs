using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class DMG_Master
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DMG_Master));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkDMG_Master(SqlCommand cmd, Data.dsData.DMG_MasterDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.DMG_Master";
            try
            {

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Billing Document", "Billing Document"); bulkCopy.ColumnMappings.Add("Route", "Route");
                bulkCopy.ColumnMappings.Add("Reference Document N", "Reference Document N");
                bulkCopy.ColumnMappings.Add("Distribution Channel", "Distribution Channel"); bulkCopy.ColumnMappings.Add("Billing date for bil", "Billing date for bil");
                bulkCopy.ColumnMappings.Add("Billing Type", "Billing Type"); bulkCopy.ColumnMappings.Add("Sold-to party", "Sold-to party");
                bulkCopy.ColumnMappings.Add("Billing item", "Billing item"); bulkCopy.ColumnMappings.Add("Material Number", "Material Number");
                bulkCopy.ColumnMappings.Add("Sales unit", "Sales unit"); bulkCopy.ColumnMappings.Add("Condition type", "Condition type");
                bulkCopy.ColumnMappings.Add("Actual Invoiced Quan", "Actual Invoiced Quan"); bulkCopy.ColumnMappings.Add("Condition value", "Condition value");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
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
