using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace NICSQLTools.Classes.msExcel.DynamicRefresh
{
    public static class DynamicRefresh
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DynamicRefresh));
        private static NICSQLTools.Data.dsDataTableAdapters.AppDatasourceParamTableAdapter adpParam = new Data.dsDataTableAdapters.AppDatasourceParamTableAdapter();
        
        public static List<System.Data.DataTable> GetExcelConnections(string filename)
        {
            List<System.Data.DataTable> output = new List<System.Data.DataTable>();
            Data.dsDataSource.AppExcelDynamicUpdateDataTable DynTbl = new Data.dsDataSource.AppExcelDynamicUpdateDataTable();
            Data.dsDataSource.AppExcelDynamicUpdateParamDataTable DynParamTbl = new Data.dsDataSource.AppExcelDynamicUpdateParamDataTable();
            output.Add(DynTbl); output.Add(DynParamTbl);

            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Workbook excelWorkBook = null;
            try
            {
                // Create an instance of Excel.
                excelApplication = new Microsoft.Office.Interop.Excel.Application();
                //Create a workbook and add a worksheet.
                excelWorkBook = excelApplication.Workbooks.Open(filename);//excelApplication.Workbooks.Open("csharp.net-informations.xls", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                for (int inx = 1; inx < excelWorkBook.Connections.Count + 1; inx++)
                {
                    Microsoft.Office.Interop.Excel.WorkbookConnection obj = excelWorkBook.Connections[inx];
                    if (obj.OLEDBConnection.CommandType != XlCmdType.xlCmdSql)// this connection is not cmd type
                        continue;
                    List<string> connectiontextList = ParseCommandText(obj.OLEDBConnection.CommandText);
                    if (connectiontextList.Count == 0)//Can't read connectiontext
                        continue;
                    int? DatasourceID = GetspID(connectiontextList[0]); // sp not found or user have no role
                    if (DatasourceID == null)
                        continue;
                    connectiontextList.RemoveAt(0);//Remove Sp Name From Paramters List
                    Data.dsDataSource.AppExcelDynamicUpdateRow DynRow = DynTbl.NewAppExcelDynamicUpdateRow();
                    DynRow.AppExcelDynamicUpdateId = inx; DynRow.FileName = System.IO.Path.GetFileName(filename);
                    DynRow.FilePath = filename; DynRow.DatasourceID = (int)DatasourceID;
                    DynRow.ExcuteResultId = (int)xlTypes.ExcuteResult.Ready; DynRow.ConnectionName = obj.Name;
                    DynTbl.AddAppExcelDynamicUpdateRow(DynRow);
                    GetSpParam(DynRow, ref DynParamTbl, connectiontextList);// Get Paramters Information
                }

                //obj.OLEDBConnection.Connection = getconnectionstring("FalseXDell", "IC_DB", "sa", "123456");
                //obj.OLEDBConnection.SavePassword = false;
                //obj.OLEDBConnection.CommandType = XlCmdType.xlCmdSql;
                //obj.OLEDBConnection.CommandText = "SELECT * FROM [dbo].[AppUsers]";
                //obj.Refresh();
                //obj.OLEDBConnection.Connection = getconnectionstring("RemovedByNICSQLTools", "RemovedByNICSQLTools", "RemovedByNICSQLTools", "RemovedByNICSQLTools");
                //excelWorkBook.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                releaseObject(excelWorkBook);
                excelApplication.Quit();
                releaseObject(excelApplication);
            }
            return output;
        }
        /// <summary>
        /// Extract spName and its paramters from xl connectionText
        /// </summary>
        /// <param name="commandtext">connectionText connection text inside xl workbook</param>
        /// <returns></returns>
        private static List<string> ParseCommandText(string commandtext)
        {
            commandtext = commandtext.Trim();
            List<string> output = new List<string>();
            int i = 0;
            string spName = string.Empty;
            for (i = 0; i < commandtext.Length; i++)
            {
                if (commandtext[i] == ' ' || commandtext[i] == '\'')
                {
                    output.Add(spName);
                    break;
                }
                spName += commandtext[i];
            }
            string[] param = commandtext.Substring(i).Trim().Split(',');
            foreach (string item in param)
                output.Add(item.Replace('\'', ' ').Trim());
            return output;
        }
        /// <summary>
        /// Return Datasource Id
        /// </summary>
        /// <param name="spName">sp Name</param>
        /// <returns></returns>
        private static int? GetspID(string spName)
        {
            int? output = null;
            foreach (Data.dsQry.UserRuleDatasourceRow row in Classes.Managers.UserManager.defaultInstance.UserDatasource)
            {
                if (row.DatasourceSPName.ToLower() == spName.ToLower())
                {
                    output = row.DatasourceID;
                    break;
                }
            }
            return output;
        }
        /// <summary>
        /// Get Paramters Rows Depand on Datasource ID that Path In DynRow
        /// </summary>
        /// <param name="DynRow"> Datasource Information</param>
        /// <param name="DynParamTbl">output Paramters Table</param>
        /// <param name="ParamValue">Paramters Selected Values</param>
        private static void GetSpParam(Data.dsDataSource.AppExcelDynamicUpdateRow DynRow, ref Data.dsDataSource.AppExcelDynamicUpdateParamDataTable DynParamTbl, List<string> ParamValue)
        {
            Data.dsData.AppDatasourceParamDataTable tbl = adpParam.GetDataByDatasourceID(DynRow.DatasourceID);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                Data.dsDataSource.AppExcelDynamicUpdateParamRow row = DynParamTbl.NewAppExcelDynamicUpdateParamRow();
                if (DynParamTbl.Rows.Count == 0)// Set Primary Key
                    row.AppExcelDynamicUpdateParamId = 1;
                else
                    row.AppExcelDynamicUpdateParamId = ((Data.dsDataSource.AppExcelDynamicUpdateParamRow)DynParamTbl.Rows[DynParamTbl.Rows.Count - 1]).AppExcelDynamicUpdateParamId + 1;
                row.AppExcelDynamicUpdateId = DynRow.AppExcelDynamicUpdateId;
                row.AppDatasourceParamID = tbl[i].AppDatasourceParamID;
                if (ParamValue.Count > i)// Assign Selected Values
                    row.ParamValue = ParamValue[i];
                DynParamTbl.AddAppExcelDynamicUpdateParamRow(row);
            }
        }
        /// <summary>
        /// Prepare Excel Connection String
        /// </summary>
        /// <param name="servername"></param>
        /// <param name="databaseame"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string getconnectionstring(string servername, string databaseame, string username, string password)
        {
            return string.Format(@"OLEDB;Provider=SQLOLEDB.1;Password={0};Persist Security Info=True;User ID={1};Initial Catalog={2};Data Source={3};Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=MohamedAlyOmarPC;Use Encryption for Data=False;Tag with column collation when possible=False", password, username, databaseame, servername);
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, Managers.UserManager.defaultInstance.User.UserId);
                System.Windows.Forms.MsgDlg.Show(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            finally
            {
                GC.Collect();
            }
        }
        
    }
}
