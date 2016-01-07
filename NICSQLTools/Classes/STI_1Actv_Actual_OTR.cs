using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class STI_1Actv_Actual_OTR
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(STI_1Actv_Actual_OTR));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkActual_OTR(SqlCommand cmd, Data.dsData.STI_1Actv_Actual_OTRDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.STI_1Actv_Actual_OTR";
            try
            {

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("BillingDocNo", "BillingDocNo"); bulkCopy.ColumnMappings.Add("SalesDocument", "SalesDocument");
                bulkCopy.ColumnMappings.Add("OrderType", "OrderType");
                bulkCopy.ColumnMappings.Add("BillingStatus", "BillingStatus"); bulkCopy.ColumnMappings.Add("Payer", "Payer");
                bulkCopy.ColumnMappings.Add("CreatedBy", "CreatedBy"); bulkCopy.ColumnMappings.Add("DocumentDate", "DocumentDate");
                bulkCopy.ColumnMappings.Add("OrderNetValue", "OrderNetValue"); bulkCopy.ColumnMappings.Add("ShipTo", "ShipTo");
                bulkCopy.ColumnMappings.Add("SoldToParty", "SoldToParty"); bulkCopy.ColumnMappings.Add("ActivityNumber", "ActivityNumber");
                bulkCopy.ColumnMappings.Add("ShippingCondition", "ShippingCondition");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn"); bulkCopy.ColumnMappings.Add("DateIn", "DateIn");

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
