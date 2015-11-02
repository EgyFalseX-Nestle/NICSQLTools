using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class STI_Actv_Actual
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(STI_Actv_Actual));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkSTI_Actv_Actual(SqlCommand cmd, Data.dsData.STI_Actv_ActualDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.STI_Actv_Actual";
            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("BillingDocument", "BillingDocument"); bulkCopy.ColumnMappings.Add("ReferenceDocumentN", "ReferenceDocumentN");
                bulkCopy.ColumnMappings.Add("DistributionChannel", "DistributionChannel"); bulkCopy.ColumnMappings.Add("BillingDateForBil", "BillingDateForBil");
                bulkCopy.ColumnMappings.Add("AgreementVariousC", "AgreementVariousC"); bulkCopy.ColumnMappings.Add("SoldToParty", "SoldToParty");
                bulkCopy.ColumnMappings.Add("ConditionType", "ConditionType"); bulkCopy.ColumnMappings.Add("BillingType", "BillingType");
                bulkCopy.ColumnMappings.Add("ActualInvoicedQuan", "ActualInvoicedQuan"); bulkCopy.ColumnMappings.Add("ConditionValue", "ConditionValue");
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
