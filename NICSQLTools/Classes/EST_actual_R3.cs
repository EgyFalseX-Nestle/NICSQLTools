using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class EST_actual_R3
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(EST_actual_R3));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkEST_actual_R3(SqlCommand cmd, Data.dsData.EST_actual_R3DataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.EST_actual_R3";
            try
            {

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Payer", "Payer"); bulkCopy.ColumnMappings.Add("Billing Document", "Billing Document");
                bulkCopy.ColumnMappings.Add("Agreement (various c", "Agreement (various c");
                bulkCopy.ColumnMappings.Add("Distribution Channel", "Distribution Channel");
                bulkCopy.ColumnMappings.Add("Billing Type", "Billing Type");
                bulkCopy.ColumnMappings.Add("Sold-to party", "Sold-to party");
                bulkCopy.ColumnMappings.Add("Name of Person who C", "Name of Person who C");
                bulkCopy.ColumnMappings.Add("Assignment number", "Assignment number");

                bulkCopy.ColumnMappings.Add("Reference Document N", "Reference Document N");
                bulkCopy.ColumnMappings.Add("Billing date for bil", "Billing date for bil");
                bulkCopy.ColumnMappings.Add("Net Value in Documen", "Net Value in Documen");

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
