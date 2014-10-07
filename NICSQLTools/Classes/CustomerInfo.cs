using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class CustomerInfo
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(CustomerInfo));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkCustomerInfo(SqlCommand cmd, Data.dsData.CustomerInfoDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "CustomerInfo";
            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = "DELETE FROM CustomerInfo";
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Distribution Channel", "Distribution Channel");
                bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("Start date of validity", "Start date of validity");
                bulkCopy.ColumnMappings.Add("End date of validity", "End date of validity");
                bulkCopy.ColumnMappings.Add("City", "City");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Error while trying to save Bulk - " + ex.Message, ex);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Bulk - " + ex.Message);
            }
            return outPut;
        }
        #endregion

    }
}
