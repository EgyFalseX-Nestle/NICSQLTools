using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Dst_Route
    {

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Dst_Route));
        public static string DefaultRouteName
        {
            get { return "Auto Generate Route"; }
        }
        public static void CreateDefaultRoute(ref Data.dsData.Dst_RouteRow row)
        {
            row.RouteName = DefaultRouteName;
            row.Supervisor = string.Empty;
        }
        public static Data.dsData.Dst_RouteRow GetRouteNumber(string RouteNumber, Data.dsData.Dst_RouteDataTable tbl)
        {
            RouteNumber = RouteNumber.ToUpper();
            for (int i = 0; i < tbl.Count; i++)
            {
                if (tbl[i].Route.ToUpper() == RouteNumber)
                    return tbl[i];
            }
            //Data.dsData.Dst_RouteRow row = tbl.NewDst_RouteRow();
            //Dst_Route.CreateDefaultRoute(ref row);
            return null;
        }
        public static bool UpdateBulkRoute(SqlCommand cmd, Data.dsData.Dst_RouteDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("Routes{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM Routes WHERE 1 = 0;", BulkTableName);
            //Logger.InfoFormat("Creating Temp table '{0}' {1}", BulkTableName, cmd.ExecuteNonQuery());

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Route", "Route");
                bulkCopy.ColumnMappings.Add("RouteName", "RouteName"); bulkCopy.ColumnMappings.Add("Distributer", "Distributer");
                bulkCopy.ColumnMappings.Add("SalesMan", "SalesMan"); bulkCopy.ColumnMappings.Add("BrandRoute", "BrandRoute");
                bulkCopy.ColumnMappings.Add("Supervisor", "Supervisor"); bulkCopy.ColumnMappings.Add("Region", "Region");
                bulkCopy.DestinationTableName = "Dst_Route";
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"merge into Dst_Route as Target 
            USING {0} AS Source on Target.Route = Source.Route WHEN MATCHED THEN 
            UPDATE SET 
                Target.RouteName = Source.RouteName,
                Target.Distributer = Source.Distributer,
                Target.SalesMan = Source.SalesMan,
                Target.BrandRoute = Source.BrandRoute,
                Target.Supervisor = Source.Supervisor,
                Target.Region = Source.Region,
            WHEN NOT MATCHED THEN 
                INSERT (Route, RouteName, Distributer, SalesMan, BrandRoute, Supervisor, Region) values 
                (Source.Route, Source.RouteName, Source.Distributer, Source.SalesMan, Source.BrandRoute, Source.Supervisor, Source.Region);", BulkTableName);
                //Logger.DebugFormat("Merge Complete - {0}", cmd.ExecuteNonQuery());
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                //Logger.DebugFormat("Temp Table Droped {0}", cmd.ExecuteNonQuery());
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return outPut;
        }

    }
}
