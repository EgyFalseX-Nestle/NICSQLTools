using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class UMD
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(UMD));
        #endregion
        #region -   Properties   -
        
        #endregion
        #region -   Functions   -
        public static bool UpdateBulkUMD(SqlCommand cmd, Data.dsData.UMDDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.UMD";
            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = "DELETE FROM dbo.UMD";
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("Name1En", "Name1En");
                bulkCopy.ColumnMappings.Add("Name3En", "Name3En");
                bulkCopy.ColumnMappings.Add("Name1Ar", "Name1Ar");
                bulkCopy.ColumnMappings.Add("Name3Ar", "Name3Ar");
                bulkCopy.ColumnMappings.Add("CityAr", "CityAr");
                bulkCopy.ColumnMappings.Add("CityEn", "CityEn");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn");

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
