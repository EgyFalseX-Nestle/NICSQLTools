using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools
{
    public static class Cost
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Cost));

        public static readonly string _colCostcenter = "New CC NO";
        public static readonly string _colGLAccount = "Acc No";
        public static readonly string _colDF = "DF";
        public static readonly string _colType = "Type";
        public static readonly string _IC_BU = "IC BU";
        public static readonly string _FC = "F&C";

        public static readonly string _colAct_GLAccount = "Cost Element";
        public static readonly string _colAct_Costcenter = "Cost Center";
        public static readonly string _colAct_OffsettingAccount = "Offsetting acct no#";
        public static readonly string _colAct_OffsettingAccountName = "Name of offsetting account";
        public static readonly string _colAct_Desc = "Name";
        public static readonly string _colAct_DocumentHeaderText = "Document Header Text";
        public static readonly string _colAct_DocumentType = "Document type";
        public static readonly string _colAct_RefDocumentNumber = "Ref Document Number";
        public static readonly string _colAct_DocumentNumber = "Document Number";
        public static readonly string _colAct_Period = "Period";
        public static readonly string _colAct_UserName = "User Name";
        public static readonly string _colAct_ValueTranCurr = "Value TranCurr";
        public static readonly string _colAct_TransactionCurrency = "Transaction Currency";
        public static readonly string _colAct_VblValue_ObjCurr = "Vbl# value/Obj# curr";
        public static readonly string _colAct_ObjectCurrency = "Object Currency";
        public static readonly string _colAct_DocumentDate = "Document Date";
        public static readonly string _colAct_PostingDate = "Posting Date";
        public static readonly string _colAct_FiscalYear = "Fiscal Year";
        public static readonly string _colAct_FromPeriod = "From Period";
        public static bool UpdateBulkCostDynamicForecast(SqlCommand cmd, Data.dsData.CostDynamicForecastDataTable BulkTable, int Year, int Period)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            const string BulkTableName = "dbo.CostDynamicForecast";
            try
            {
                //Delete All Recored Before Inserting
                cmd.CommandText = string.Format("DELETE FROM dbo.CostDynamicForecast WHERE Year = {0} AND Period = {1}", Year, Period);
                cmd.ExecuteNonQuery();

                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("Costcenter", "Costcenter");
                bulkCopy.ColumnMappings.Add("GLAccount", "GLAccount");
                bulkCopy.ColumnMappings.Add("Year", "Year");
                bulkCopy.ColumnMappings.Add("BusinessUnit", "BusinessUnit");
                bulkCopy.ColumnMappings.Add("Period", "Period");
                bulkCopy.ColumnMappings.Add("DF", "DF");
                bulkCopy.ColumnMappings.Add("Type", "Type");
                
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn");
                bulkCopy.ColumnMappings.Add("DateIn", "DateIn");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);
                Logger.InfoFormat("BuldCopy Writing Successfull to Table {0}", BulkTableName);
                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return outPut;
        }

        public static bool UpdateBulkCostActual(SqlCommand cmd, Data.dsData.CostCostActualDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                cmd.CommandTimeout = 0; bulkCopy.BulkCopyTimeout = 0;

                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("GLAccount", "GLAccount"); bulkCopy.ColumnMappings.Add("Costcenter", "Costcenter");
                bulkCopy.ColumnMappings.Add("OffsettingAccount", "OffsettingAccount"); bulkCopy.ColumnMappings.Add("OffsettingAccountName", "OffsettingAccountName");
                bulkCopy.ColumnMappings.Add("Desc", "Desc"); bulkCopy.ColumnMappings.Add("DocumentHeaderText", "DocumentHeaderText");
                bulkCopy.ColumnMappings.Add("DocumentType", "DocumentType"); bulkCopy.ColumnMappings.Add("RefDocumentNumber", "RefDocumentNumber");
                bulkCopy.ColumnMappings.Add("DocumentNumber", "DocumentNumber"); bulkCopy.ColumnMappings.Add("Period", "Period");
                bulkCopy.ColumnMappings.Add("UserName", "UserName"); bulkCopy.ColumnMappings.Add("ValueTranCurr", "ValueTranCurr");
                bulkCopy.ColumnMappings.Add("TransactionCurrency", "TransactionCurrency"); bulkCopy.ColumnMappings.Add("VblValue_ObjCurr", "VblValue_ObjCurr");
                bulkCopy.ColumnMappings.Add("ObjectCurrency", "ObjectCurrency"); bulkCopy.ColumnMappings.Add("DocumentDate", "DocumentDate");
                bulkCopy.ColumnMappings.Add("PostingDate", "PostingDate"); bulkCopy.ColumnMappings.Add("FiscalYear", "FiscalYear");
                bulkCopy.ColumnMappings.Add("FromPeriod", "FromPeriod");
                bulkCopy.ColumnMappings.Add("UserIn", "UserIn"); bulkCopy.ColumnMappings.Add("DateIn", "DateIn");

                bulkCopy.DestinationTableName = "[CostCostActual]";
                bulkCopy.BatchSize = BulkTable.Count;


                bulkCopy.WriteToServer(BulkTable);

                outPut = true;
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MessageBox.Show("Error while trying to save CostCostActual Bulk - " + ex.Message);
            }
            return outPut;
        }
    }
}
