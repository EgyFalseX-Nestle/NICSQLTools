using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Dst_Customer
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Dst_Customer));
        public static string DefaultCustomerName
        {
            get { return "Auto Generate Customer"; }
        }
        public static string CustomerGroupIdDirect
        {
            get { return "Direct"; }
        }
        public static string CustomerTypeIdDirect
        {
            get { return "Direct"; }
        }
        public static string CustomerType2IdDirect
        {
            get { return "Direct"; }
        }
        public static string SubchannelIdDirect
        {
            get { return "Grocery"; }
        }
        public static int CustomerTypeCodeDirect
        {
            get { return 1; }
        }

        public static void CreateDefaultCustomer(ref Data.dsData.Dst_CustomerRow row)
        {
            //row.CustomerNameEn1 = DefaultCustomerName;
            //row.CustomerNameEn2 = string.Empty;
            //row.CustomerNameAr1 = string.Empty;
            //row.CustomerNameAr2 = string.Empty;
            //row.CustHierLevel6Id = UnknownCustHierLevel6Id;
            //row.SubchannelId = Customer.SubchannelIdDirect;
            //row.CustomerTypeId = Customer.CustomerTypeIdDirect;
            //row.CustomerType2Id = Customer.CustomerType2IdDirect;
            //row.CustomerGroupId = Customer.CustomerGroupIdDirect;
            //row.CustomerAddress = string.Empty;
            //row.CityId = UnknownCityId;
        }
        public static Data.dsData.Dst_CustomerRow GetCustomerRow(Int64 CustomerId, Data.dsData.Dst_CustomerDataTable tbl)
        {
            //return null;
            Data.dsData.Dst_CustomerRow row = tbl.FindByCustomer(CustomerId);
            if (row == null)
            {
                Data.dsData.Dst_CustomerRow CusRow = tbl.NewDst_CustomerRow();
                //////////////////Customer.CreateDefaultCustomer(ref CusRow);
                return CusRow;
            }
            else
                return row;
        }
        public static bool UpdateBulkCustomer(SqlCommand cmd, Data.dsData.Dst_CustomerDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Dst_Customers{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Dst_Customer WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, );
            cmd.ExecuteNonQuery();

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Customer", "Customer"); bulkCopy.ColumnMappings.Add("CustomerName", "CustomerName");
                bulkCopy.ColumnMappings.Add("CustomerName2", "CustomerName2"); bulkCopy.ColumnMappings.Add("CustomerNameAr", "CustomerNameAr");
                bulkCopy.ColumnMappings.Add("CustomerName2Ar", "CustomerName2Ar"); bulkCopy.ColumnMappings.Add("Level3", "Level3");
                bulkCopy.ColumnMappings.Add("Subchannel", "Subchannel"); bulkCopy.ColumnMappings.Add("CustomerType", "CustomerType");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into Dst_Customer as Target 
                using {0} as Source on Target.Customer = Source.Customer when matched then 
                update set 
                Target.CustomerName = Source.CustomerName,
                Target.CustomerName2 = Source.CustomerName2,
                Target.CustomerNameAr = Source.CustomerNameAr,
                Target.CustomerName2Ar = Source.CustomerName2Ar,
                Target.Level3 = Source.Level3,
                Target.Subchannel = Source.Subchannel,
                Target.CustomerType = Source.CustomerType,
                when not matched then 
                insert (Customer,CustomerName,CustomerName2, CustomerNameAr, CustomerName2Ar, Level3, Subchannel, CustomerType) values 
                (Source.Customer, Source.CustomerName2, Source.CustomerNameAr, Source.CustomerName2Ar, Source.Level3, Source.Level3, Source.Subchannel, Source.CustomerType);", BulkTableName);
                //Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                //Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save Dst_Customer Bulk - " + ex.Message);
            }
            return outPut;
        }
        

    }
}
