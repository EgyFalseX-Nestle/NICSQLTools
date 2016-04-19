using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class HH_Data
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(HH_Data));
        public static bool UpdateBulk(SqlCommand cmd, Data.dsData.HH_DataDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
          
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("InvoiceNo", "InvoiceNo"); bulkCopy.ColumnMappings.Add("BillDate", "BillDate");
                bulkCopy.ColumnMappings.Add("Customer", "Customer"); bulkCopy.ColumnMappings.Add("RouteNumber", "RouteNumber");
                bulkCopy.ColumnMappings.Add("CashSales", "CashSales"); bulkCopy.ColumnMappings.Add("CreditSales", "CreditSales");
                bulkCopy.ColumnMappings.Add("Code", "Code");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn"); bulkCopy.ColumnMappings.Add("DateIn", "DateIn");

                bulkCopy.DestinationTableName = "HH_Data";
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
