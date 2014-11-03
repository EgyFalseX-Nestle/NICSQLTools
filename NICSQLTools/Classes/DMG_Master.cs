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
                //Deleting data before saving new 1
                var result = from row in BulkTable.AsEnumerable()
                             group row by row["Document Date"] into grp
                             select new { BillingDate = grp.Key };
                cmd.CommandText = "Delete From dbo.DMG_Master Where [Document Date] = @BillingDate";
                cmd.Parameters.Add(new SqlParameter("@BillingDate", System.Data.SqlDbType.DateTime));
                foreach (var item in result)
                {
                    System.Windows.Forms.Application.DoEvents();
                    cmd.Parameters["@BillingDate"].Value = item.BillingDate;
                    cmd.ExecuteNonQuery();
                }

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Route", "Route"); bulkCopy.ColumnMappings.Add("Assignment", "Assignment");
                bulkCopy.ColumnMappings.Add("Billing Date", "Billing Date");
                bulkCopy.ColumnMappings.Add("Billing Document", "Billing Document"); bulkCopy.ColumnMappings.Add("Item", "Item");
                bulkCopy.ColumnMappings.Add("Sales unit", "Sales unit"); bulkCopy.ColumnMappings.Add("Order Quantity", "Order Quantity");
                bulkCopy.ColumnMappings.Add("Material", "Material"); bulkCopy.ColumnMappings.Add("Document Date", "Document Date");
                bulkCopy.ColumnMappings.Add("Sales Document", "Sales Document"); bulkCopy.ColumnMappings.Add("Sold-to party", "Sold-to party");
                bulkCopy.ColumnMappings.Add("Distribution Channel", "Distribution Channel");

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
