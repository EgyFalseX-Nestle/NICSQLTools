using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class CustomerSSInfo
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(CustomerSSInfo));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkCustomerSSInfo(SqlCommand cmd, Data.dsData.CustomerSSInfoDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.CustomerSSInfo";
            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = "DELETE FROM dbo.CustomerSSInfo";
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("Sold-to party", "Sold-to party");
                bulkCopy.ColumnMappings.Add("Name 3", "Name 3");
                bulkCopy.ColumnMappings.Add("Region", "Region");
                bulkCopy.ColumnMappings.Add("CustHier Level 6", "CustHier Level 6");
                bulkCopy.ColumnMappings.Add("L6 Code", "L6 Code");
                bulkCopy.ColumnMappings.Add("CustHier Level 5", "CustHier Level 5");
                bulkCopy.ColumnMappings.Add("L5 Code", "L5 Code");
                bulkCopy.ColumnMappings.Add("CustHier Level 4", "CustHier Level 4");
                bulkCopy.ColumnMappings.Add("L4 Code", "L4 Code");
                bulkCopy.ColumnMappings.Add("CustHier Level 3", "CustHier Level 3");
                bulkCopy.ColumnMappings.Add("L3 Code", "L3 Code");
                bulkCopy.ColumnMappings.Add("Distribution channel", "Distribution channel");
                bulkCopy.ColumnMappings.Add("DC Code", "DC Code");

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
