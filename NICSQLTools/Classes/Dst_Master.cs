using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Dst_Master
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Dst_Master));

        public static bool UpdateBulkMaster(SqlCommand cmd, Data.dsData.Dst_MasterDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            //string BulkTableName = string.Format("Master{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            //cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM dbo.[0-1  Master All] WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Invoicekey", "Invoicekey"); bulkCopy.ColumnMappings.Add("BillingNumber", "BillingNumber");
                bulkCopy.ColumnMappings.Add("BillingType", "BillingType"); bulkCopy.ColumnMappings.Add("BillingDate", "BillingDate");
                bulkCopy.ColumnMappings.Add("Route", "Route"); bulkCopy.ColumnMappings.Add("Distributer", "Distributer");
                bulkCopy.ColumnMappings.Add("Product", "Product"); bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("Value", "Value"); bulkCopy.ColumnMappings.Add("CS", "CS");
                bulkCopy.ColumnMappings.Add("Vol", "Vol"); bulkCopy.ColumnMappings.Add("SalesType", "SalesType");
                bulkCopy.ColumnMappings.Add("ProductSalesType", "ProductSalesType"); bulkCopy.ColumnMappings.Add("systemdate", "systemdate");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn"); 

                bulkCopy.DestinationTableName = "[Dst_Master]";
                bulkCopy.BatchSize = BulkTable.Count;
                
                
                bulkCopy.WriteToServer(BulkTable);

                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Master Bulk - " + ex.Message);
            }
            return outPut;
        }
        

    }
}
