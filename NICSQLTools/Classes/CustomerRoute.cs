using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class CustomerRoute
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(CustomerRoute));
        #endregion
        #region -   Properties   -
        public static string Status08 { get { return "@08@"; } }
        #endregion
        #region -   Functions   -

        public static void CreateDefaultCustomer(ref Data.dsData._0_6_Customer_HNRow row)
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
        public static Data.dsData._0_6_Customer_HNRow GetCustomerRow(string CustomerId, Data.dsData._0_6_Customer_HNDataTable tbl)
        {
            //return null;
            Data.dsData._0_6_Customer_HNRow row = tbl.FindByCustomer_T(CustomerId);
            if (row == null)
            {
                Data.dsData._0_6_Customer_HNRow CusRow = tbl.New_0_6_Customer_HNRow();
                //////////////////Customer.CreateDefaultCustomer(ref CusRow);
                return CusRow;
            }
            else
                return row;
        }
        public static bool UpdateBulkCustomerRoute(SqlCommand cmd, Data.dsData.CustomerRouteDataTable BulkTable, int YearNum, int MonthNum)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.CustomerRoute";

            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = string.Format("DELETE FROM dbo.CustomerRoute WHERE YearNum = {0} AND MonthNum = {1}", YearNum, MonthNum);
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Route", "Route");
                bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("DeliveryDay", "DeliveryDay");

                bulkCopy.ColumnMappings.Add("ValidFrom", "ValidFrom");
                bulkCopy.ColumnMappings.Add("MonthNum", "MonthNum");
                bulkCopy.ColumnMappings.Add("YearNum", "YearNum");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                Logger.InfoFormat("BuldCopy Writing Successfull to Table {0}", BulkTableName);
                //Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                //Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return outPut;
        }
        private static bool DeleteMe(SqlCommand cmd, Data.dsData.CustomerRouteDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("CustomerRoute{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM CustomerRoute WHERE 1 = 0;", BulkTableName);
            Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Route", "Route"); bulkCopy.ColumnMappings.Add("Customer", "Customer");
                bulkCopy.ColumnMappings.Add("DeliveryDay", "DeliveryDay"); bulkCopy.ColumnMappings.Add("ValidFrom", "ValidFrom");
                bulkCopy.ColumnMappings.Add("YearNum", "YearNum"); bulkCopy.ColumnMappings.Add("MonthNum", "MonthNum");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into CustomerRoute as Target 
                using {0} as Source on 
                Target.Route = Source.Route
                AND Target.Customer = Source.Customer
                AND Target.DeliveryDay = Source.DeliveryDay
                AND Target.YearNum = Source.YearNum
                AND Target.MonthNum = Source.MonthNum
                WHEN MATCHED THEN
                UPDATE SET
                Target.ValidFrom = Source.ValidFrom
                WHEN NOT MATCHED THEN 
                INSERT (Route, Customer, DeliveryDay, ValidFrom, YearNum, MonthNum) VALUES 
                (Source.Route, Source.Customer, Source.DeliveryDay, Source.ValidFrom, Source.YearNum, Source.MonthNum);", BulkTableName);
                Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return outPut;
        }

        #endregion
        

    }
}
