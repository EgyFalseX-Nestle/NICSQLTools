using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.IO;
using log4net;
using System.Collections;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Threading.Tasks;
using Excel_VBA = Microsoft.Office.Interop.Excel; 

namespace NICSQLTools.Classes.Managers
{
    public class DataManager
    {
        #region -   Variables   -
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DataManager));
        public static DataManager defaultInstance;
        public static int ConnectionTimeout = 0;
        public static int SHRINKSIZE = 10;
        public static Char SplitChar = Convert.ToChar("|");
        public static string DecryptPassword = "FalseX";
        public static Data.dsDataTableAdapters.QueriesTableAdapter adpQry = new Data.dsDataTableAdapters.QueriesTableAdapter();
        public enum ParamDataSource
        {
            @SalesDistrict2
        }

        #endregion
        #region -   Properties   -
        public static string dbPath
        {
            get;
            set;
        }
        public static int UnknownCityId
        {
            get { return 999999999; }
        }
        public static string Route000001
        {
            get { return "000001"; }
        }
        public static string Route999999
        {
            get { return "999999"; }
        }
        public DateTime ServerDateTime
        {
            get { return (DateTime)adpQry.GetServerDate(); }
        }
        
        #region -   Unknown Codes   -
        #endregion
        #endregion
        #region -   Functions   -
        public static void Init()
        {
            defaultInstance = new DataManager();
            SetAllCommandTimeouts(adpQry, ConnectionTimeout);

            //Set Theme
            LoadTheme();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
        }

        static void LoadTheme()
        {
            if (File.Exists(FXFW.SqlDB.StyleSettingsPath))
            {
                FXFW.UserSkinSettings us = null;
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Stream fStream = new FileStream(FXFW.SqlDB.StyleSettingsPath, FileMode.Open);
                try { us = binFormat.Deserialize(fStream) as FXFW.UserSkinSettings; }
                finally { fStream.Close(); }

                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(us.SkinName);
            }



        }
        static void Default_StyleChanged(object sender, EventArgs e)
        {
            FXFW.UserSkinSettings us = new FXFW.UserSkinSettings { SkinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName };
            //SaveSettings
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (Stream fStream = new FileStream(FXFW.SqlDB.StyleSettingsPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember("CommandCollection",
                    System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (System.Data.IDbCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
        public static string GenerateDatabaseScript(string DatabasePath)
        {
            return string.Empty;//string.Format(Properties.Settings.Default.CreateDatabaseScript.Replace("FalseX2013", DatabasePath));
        }
        public static void PerformChangeExe()
        {
            if (Program.updatePath == System.Windows.Forms.Application.ExecutablePath)
            {
                byte[] data = File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                FileStream fs = File.Create(Program.AppPath);
                fs.Write(data, 0, data.Length);
                fs.Close();
                System.Diagnostics.Process.Start(Program.AppPath);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }
        }
        public static bool VersionExpired()
        {
            try
            {
                int currentVersion = Convert.ToInt32(System.Windows.Forms.Application.ProductVersion.Replace(".", ""));
                object MinAppVersion = adpQry.GetAppOptionValue(Uti.Types.AppOptionName.MinAppVersion.ToString());
                if (MinAppVersion == null)
                    return true;
                else
                {
                    if (currentVersion < Convert.ToInt32(MinAppVersion))
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId);
                return true;
            }
        }
        public static Dictionary<string, int> GetCurrentAssemblyFiles()
        {
            Dictionary<string, int> Asm = new Dictionary<string, int>();
            //int i = 0;
            //object obj = System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            //foreach (var assemblyName in System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            //{
            //    if (Asm.TryGetValue(assemblyName.Name + ".dll", out i))//Already Added
            //        continue;
            //    if (assemblyName.Name.StartsWith("System"))//.Net Dll
            //        continue;
            //    Asm.Add(assemblyName.Name.ToLower() + ".dll", Convert.ToInt32(assemblyName.Version.ToString().Replace(".", "")));
            //}
            //Asm.Add(System.Windows.Forms.Application.ProductName + ".exe", Convert.ToInt32(System.Windows.Forms.Application.ProductVersion.Replace(".", "")));
            Asm.Add("DevExpress.BonusSkins.v15.1.dll", 151600000);
            Asm.Add("DevExpress.Charts.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.CodeParser.v15.1.dll", 151600000);
            Asm.Add("DevExpress.Dashboard.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.Dashboard.v15.1.Win.dll", 151600000);
            Asm.Add("DevExpress.Data.v15.1.dll", 151600000);
            Asm.Add("DevExpress.DataAccess.v15.1.dll", 151600000);
            Asm.Add("DevExpress.DataAccess.v15.1.UI.dll", 151600000);
            Asm.Add("DevExpress.Map.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.Office.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.PivotGrid.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.Printing.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.RichEdit.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.Sparkline.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.Utils.v15.1.dll", 151600000);
            Asm.Add("DevExpress.Utils.v15.1.UI.dll", 151600000);
            Asm.Add("DevExpress.Xpo.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraBars.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraCharts.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraCharts.v15.1.Extensions.dll", 151600000);
            Asm.Add("DevExpress.XtraCharts.v15.1.UI.dll", 151600000);
            Asm.Add("DevExpress.XtraCharts.v15.1.Wizard.dll", 151600000);
            Asm.Add("DevExpress.XtraEditors.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraGauges.v15.1.Core.dll", 151600000);
            Asm.Add("DevExpress.XtraGauges.v15.1.Presets.dll", 151600000);
            Asm.Add("DevExpress.XtraGauges.v15.1.Win.dll", 151600000);
            Asm.Add("DevExpress.XtraGrid.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraLayout.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraMap.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraNavBar.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraPivotGrid.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraPrinting.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraReports.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraRichEdit.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraRichEdit.v15.1.Extensions.dll", 151600000);
            Asm.Add("DevExpress.XtraTreeList.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraVerticalGrid.v15.1.dll", 151600000);
            Asm.Add("DevExpress.XtraWizard.v15.1.dll", 151600000);


            Asm.Add("FXFW.dll", 1004);
            //Asm.Add("Interop.DAO.dll", 5000);
            Asm.Add("Ionic.Zip.dll", 1918);
            Asm.Add("log4net.dll", 12110);
            //Asm.Add("Microsoft.Office.Interop.Access.dll", 15004515);
            //Asm.Add("Microsoft.Office.interop.access.dao.dll", 15004410);
            Asm.Add(System.Windows.Forms.Application.ProductName + ".exe", Convert.ToInt32(System.Windows.Forms.Application.ProductVersion.Replace(".", "")));
            
            //Asm.Add("OFFICE.DLL", 15004610);
            return Asm;
        }
        public static NICSQLTools.Data.dsData.AppDependenceFileDataTable GetDownloadDependanceies()
        {
            using (NICSQLTools.Data.dsDataTableAdapters.AppDependenceFileTableAdapter adpQry = new Data.dsDataTableAdapters.AppDependenceFileTableAdapter())
            {
                NICSQLTools.Data.dsData.AppDependenceFileDataTable RequiredFilesTbl = new Data.dsData.AppDependenceFileDataTable();
                adpQry.FillByLiteData(RequiredFilesTbl);
                Dictionary<string, int> ExistsFiles = GetCurrentAssemblyFiles();
                for (int i = (RequiredFilesTbl.Count - 1); i >= 0; i--)
                {
                    NICSQLTools.Data.dsData.AppDependenceFileRow row = (NICSQLTools.Data.dsData.AppDependenceFileRow)RequiredFilesTbl.Rows[i];
                    int Version = 0;
                    if (ExistsFiles.TryGetValue(row.FileName, out Version))
                    {
                        if (row.FileVersion <= Version)
                            RequiredFilesTbl.Rows.RemoveAt(i);
                    }
                }
                return RequiredFilesTbl;
            }
        }
        public static Dictionary<string, int> GetDownloadDependanceies11()
        {
            Dictionary<string, int> output = new Dictionary<string,int>();
            Dictionary<string, int> ExistsFiles = GetCurrentAssemblyFiles();
            NICSQLTools.Data.dsDataTableAdapters.AppDependenceFileTableAdapter adpQry = new Data.dsDataTableAdapters.AppDependenceFileTableAdapter();
            NICSQLTools.Data.dsData.AppDependenceFileDataTable RequiredFilesTbl = new Data.dsData.AppDependenceFileDataTable();
            adpQry.FillByLiteData(RequiredFilesTbl);

            foreach (KeyValuePair<string, int> item in ExistsFiles)
            {
                NICSQLTools.Data.dsData.AppDependenceFileRow row = RequiredFilesTbl.FindByFileName(item.Key);
                if (row == null)// File Not Found On Server
                    output.Add(row.FileName, row.FileVersion);
                else
                {
                    if (item.Value > row.FileVersion)//Local File Is Newer
                        output.Add(row.FileName, row.FileVersion);
                }
            }
            return output;
        }
        public static void PerformUpdaterDownload(NICSQLTools.Data.dsData.AppDependenceFileDataTable tbl)
        {
            if (tbl.Count == 0)// No Update Found
                return;
            string Data = String.Format("{0}|{1}|", (int)NICSQLTools.Uti.Types.UpdaterArgsEnum.Download, Properties.Settings.Default.IC_DBConnectionString);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                Data += ((NICSQLTools.Data.dsData.AppDependenceFileRow)tbl.Rows[i]).FileName;
                if (i + 1 < tbl.Rows.Count)
                    Data += "|";
            }
            //MemoryMappedFile mmf = MemoryMappedFile.CreateNew("NICSQLToolsUpdateMap", 1024);
            //bool mutexCreated;
            //Mutex mutex = new Mutex(true, "NICSQLToolsUpdateMapMutex", out mutexCreated);
            //MemoryMappedViewStream stream = mmf.CreateViewStream();
            //BinaryWriter writer = new BinaryWriter(stream);
            //writer.Write(Data);// Write Data
            //mutex.ReleaseMutex(); mutex.WaitOne();

            //Data = FXFW.EncDec.Encrypt(Data, "FalseX");// Encrypt Arg Data
            Data = String.Format("\"{0}\"", Data);
            using (System.Diagnostics.Process process = new System.Diagnostics.Process() { StartInfo = new System.Diagnostics.ProcessStartInfo(Program.updaterPath, Data ) })
            {
                process.Start();
            }

            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }
        public static void PerformUpdaterUpload(Dictionary<string, int> FilesList)
        {
            string Data = String.Format("{0}{1}{2}{1}", (int)NICSQLTools.Uti.Types.UpdaterArgsEnum.Upload, SplitChar, Properties.Settings.Default.IC_DBConnectionString);
            
            foreach (KeyValuePair<string, int> item in FilesList)
            {
                Data += String.Format("{0}{1}{2}{1}", item.Key, SplitChar, item.Value);
            }
            Data = Data.Substring(0, Data.Length - 1);


            //Data = FXFW.EncDec.Encrypt(Data, "FalseX");// Encrypt Arg Data
            Data = String.Format("\"{0}\"", Data);
            using (System.Diagnostics.Process process = new System.Diagnostics.Process() { StartInfo = new System.Diagnostics.ProcessStartInfo(Program.updaterPath,  Data ) })
            {
                process.Start();
            }

            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        public static Dictionary<string, int> GetUploadDependanceies()
        {
            Dictionary<string, int> NeededFiles = new Dictionary<string, int>();
            using (NICSQLTools.Data.dsDataTableAdapters.AppDependenceFileTableAdapter adpQry = new Data.dsDataTableAdapters.AppDependenceFileTableAdapter())
            {
                NICSQLTools.Data.dsData.AppDependenceFileDataTable RequiredFilesTbl = new Data.dsData.AppDependenceFileDataTable();
                adpQry.FillByLiteData(RequiredFilesTbl);
                Dictionary<string, int> AppFiles = GetCurrentAssemblyFiles();
                foreach (KeyValuePair<string, int> item in AppFiles)
                {
                    Data.dsData.AppDependenceFileRow row = RequiredFilesTbl.FindByFileName(item.Key);
                    if (row == null)
                        NeededFiles.Add(item.Key, item.Value);
                    else
                    {
                        if (row.FileVersion < item.Value)
                            NeededFiles.Add(item.Key, item.Value);
                    }
                }
            }
            return NeededFiles;
        }

        public static DataTable LoadExcelFile1(string strFile, string sheetName, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                string query = string.Format("SELECT {0} FROM [{1}$]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MsgDlg.Show("Load Excel File Failed - " + ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            return dt;
        }
        public static DataTable LoadExcelFile1(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                //string strConnectionString = "";
                OleDbConnection con = new OleDbConnection("");
                
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                {
                    con.ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                    try { con.Open(); } catch (Exception ex)
                    {
                        if (ex.Message.Contains("provider is not registered on the local machine"))
                            con.ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.14.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                    }
                    con.Close();
                }
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    con.ConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                //connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.14.0;Data Source={0};ExtendedProperties=""Excel 12.0;HDR=YES;""";
                con.Open();
                DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                con.Close();
                if (dtSchema == null)
                    return dt;
                string sheetName = dtSchema.Rows[sheetIndex]["TABLE_NAME"].ToString();
                string query = string.Format("SELECT {0} FROM [{1}]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.ColumnName == "Sold-to party")
                    {
                        DataColumn NewCol = new DataColumn("Sold-to party By FalseX", typeof(string));
                        dt.Columns.Add(NewCol);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sold-to party By FalseX"] = dt.Rows[i]["Sold-to party"].ToString();
                        }
                        dt.Columns.Remove("Sold-to party");
                        dt.Columns["Sold-to party By FalseX"].ColumnName = "Sold-to party";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MsgDlg.Show("Load Excel File Failed - " + ex.Message, System.Windows.Forms.MsgDlg.MessageType.Error, ex);
            }
            return dt;
        }
        public static DataTable LoadExcelFile_VBA(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();

            try
            {
                Excel_VBA.Application xlApp;
                Excel_VBA.Workbook xlWorkBook;
                Excel_VBA.Worksheet xlWorkSheet;
                Excel_VBA.Range range;

                int rCnt = 0;
                int cCnt = 0;

                xlApp = new Excel_VBA.Application();
                xlWorkBook = xlApp.Workbooks.Open(strFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel_VBA.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                if (rowCount <= 1)
                    return dt;
                for (int colInx = 1; colInx <= colCount; colInx++)
                {
                    string colname = GetValidColumnName(Convert.ToString((range.Cells[1, colInx] as Excel_VBA.Range).Value), dt.Columns);
                    object TypeName = (object)(range.Cells[2, colInx] as Excel_VBA.Range).Value;
                    dt.Columns.Add(colname, TypeName == null ? typeof(string) : (TypeName).GetType());
                }
                string address = range.get_Address();
                string[] cells = address.Split(new char[] { ':' });
                string beginCell = cells[0].Replace("$", "");
                string endCell = cells[1].Replace("$", "");
                object[,] objectArray = xlWorkSheet.get_Range(beginCell + ":" + endCell).Value;
                for (rCnt = 2; rCnt <= rowCount; rCnt++)
                {
                    DataRow row = dt.NewRow();
                    for (cCnt = 1; cCnt <= colCount; cCnt++)
                    {
                        row[cCnt - 1] = objectArray[rCnt, cCnt];
                    }
                    dt.Rows.Add(row);
                }
                objectArray = null;
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return dt;
        }
        private static string GetValidColumnName(string colname, DataColumnCollection cols)
        {
            bool NameInUse = false;
            foreach (DataColumn col in cols)
            {
                if (col.ColumnName == colname)
                {
                    NameInUse = true;
                    break;
                }
            }
            if (!NameInUse)
                return colname;

            for (int i = 1; i < 255; i++)
            {
                bool nameExists = false;
                foreach (DataColumn col in cols)
                {
                    if (col.ColumnName == colname + i)
                    {
                        nameExists = true;
                        break;
                    }
                }
                if (!nameExists)
                {
                    colname = colname + i;
                    break;
                }
            }
            return colname;
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
                //MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

        public static MemoryStream CompressFile(byte[] date)
        {
            using (Ionic.Zip.ZipFile zFile = new Ionic.Zip.ZipFile())
            {
                zFile.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zFile.Comment = String.Format("This zip archive was created by the CreateZip example application on machine '{0}'", System.Net.Dns.GetHostName());
                zFile.AddEntry("zUpdateObject.exe", date);
                MemoryStream ms = new MemoryStream();
                zFile.Save(ms);
                return ms;
            }
        }
        public static MemoryStream DecompressFile(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            using (Ionic.Zip.ZipFile zFile = Ionic.Zip.ZipFile.Read(new MemoryStream(data)))
            {
                foreach (Ionic.Zip.ZipEntry entry in zFile)
                {
                    entry.Extract(ms);
                }
            }
            return ms;
        }

        public static DataTable GetStoredProcedureSchema(string StoredProcedureName)
        {
            try
            {
                //Get Requered Paramters For Stored Procedure
                Data.dsQryTableAdapters.Get_sp_PramTableAdapter adpPram = new Data.dsQryTableAdapters.Get_sp_PramTableAdapter();
                Data.dsQry.Get_sp_PramDataTable dtPram = adpPram.GetData(StoredProcedureName);

                using (SqlDataAdapter adp = new SqlDataAdapter(StoredProcedureName, Properties.Settings.Default.IC_DBConnectionString))
                {
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    //Add Paramters To Adapter
                    foreach (Data.dsQry.Get_sp_PramRow row in dtPram.Rows)
                        adp.SelectCommand.Parameters.Add(new SqlParameter(row.name, DBNull.Value));
                    //Try To Get Stored Procedure Schema
                    adp.FillSchema(ds, SchemaType.Source);
                    if (ds.Tables.Count > 0)
                        return ds.Tables[0];
                }
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return null;
        }
        public static List<DataTable> GetStoredProcedureSchema(Data.dsDataSource.AppDatasourceDataTable DashboardTbl)
        {
            List<DataTable> Tbls = new List<DataTable>();
            foreach (Data.dsDataSource.AppDatasourceRow row in DashboardTbl.Rows)
            {
                DataTable dt = GetStoredProcedureSchema(row.DatasourceSPName);
                if (dt != null)
                {
                    dt.TableName = row.DatasourceName;
                    dt.Namespace = row.DatasourceID.ToString();
                    Tbls.Add(dt);
                }
            }
            return Tbls;
        }
        public static void RefreshDatasourceSchema(ref DevExpress.DashboardWin.DashboardDesigner dashboardDesigner)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT DatasourceSPName FROM dbo.AppDatasource WHERE DatasourceID = @DatasourceID", con);
            SqlParameter ParamID = new SqlParameter("@DatasourceID", SqlDbType.Int);
            cmd.Parameters.Add(ParamID);
            try
            {
                con.Open();
                for (int i = 0; i < dashboardDesigner.Dashboard.DataSources.Count; i++)
                {
                    ParamID.Value = Convert.ToInt32(dashboardDesigner.Dashboard.DataSources[i].ComponentName.Replace("ID", ""));
                    object obj = cmd.ExecuteScalar();
                    if (obj != null)
                    {
                        DataTable dt = DataManager.GetStoredProcedureSchema(obj.ToString());
                        //dashboardDesigner.Dashboard.DataSources[i].ComponentName = "ID";
                        //DevExpress.DashboardCommon.DataSource ds = Classes.Dashboard.CreateDashboardDatasource(dt, dashboardDesigner.Dashboard.DataSources[i].Name, Convert.ToInt32(ParamID.Value));
                        dashboardDesigner.Dashboard.DataSources[i].Data = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            con.Close();
        }
        public static Task<DataTable> ExeDataSourceAsync(string StoredProcedureName, Dictionary<string, object> Paramters, SqlCommand cmd, SqlInfoMessageEventHandler InfoMessageHnd = null, StatementCompletedEventHandler StatementCompleted = null)
        {
            return Task<DataTable>.Run(() => 
            {
                DataTable dt = new DataTable();
                string logstring = string.Empty;
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter("", Properties.Settings.Default.IC_DBConnectionString);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.CommandText = StoredProcedureName;
                    logstring += StoredProcedureName + ": with Paramters " + Environment.NewLine;

                    if (InfoMessageHnd != null)
                        adp.SelectCommand.Connection.InfoMessage += InfoMessageHnd;
                    if (StatementCompleted != null)
                        adp.SelectCommand.StatementCompleted += StatementCompleted;

                    cmd = adp.SelectCommand;
                    foreach (KeyValuePair<string, object> item in Paramters)
                    {
                        adp.SelectCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                        logstring += item.Key + " = " + item.Value + Environment.NewLine;
                    }
                    adp.SelectCommand.CommandTimeout = DataManager.ConnectionTimeout;
                    Logger.Info(logstring);
                    adp.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                }
                return dt;
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID">Id of LookupId</param>
        /// <returns>List<object> 
        /// 1- Datatable
        /// 2- Display
        /// 3- Value
        /// </object></returns>
        public static List<object> ExeDSLookup(int ID)
        {
            List<object> output = new List<object>();
            DataTable dt = new DataTable();
            output.Add(dt);
            try
            {
                DataTable commandtextTbl = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("", Properties.Settings.Default.IC_DBConnectionString);
                adp.SelectCommand.CommandTimeout = DataManager.ConnectionTimeout;

                adp.SelectCommand.CommandText = "SELECT SQLStatment, DisplayName, ValueName FROM AppDatasourceLookup WHERE ID = " + ID;
                adp.Fill(commandtextTbl);
                if (commandtextTbl.Rows.Count == 0 || commandtextTbl.Rows[0]["SQLStatment"].ToString() == string.Empty)
                {
                    output.Add(string.Empty); output.Add(string.Empty);
                }
                else
                {
                    output.Add(commandtextTbl.Rows[0]["DisplayName"].ToString()); output.Add(commandtextTbl.Rows[0]["ValueName"].ToString());
                    adp.SelectCommand.CommandText = commandtextTbl.Rows[0]["SQLStatment"].ToString();
                    adp.Fill(dt);
                }

            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return output;

            
        }

        #region Rule
        public static NICSQLTools.Data.dsQry.DSForRuleDataTable LoadRuleDS(NICSQLTools.Data.dsQry.DSForRuleDataTable tbl, int RuleId, int DS)
        {
            SqlDataAdapter adp = new SqlDataAdapter("", Properties.Settings.Default.IC_DBConnectionString);
            tbl.Clear();
            adp.SelectCommand.CommandText = string.Format(@"WITH CTE1 AS
            (
            SELECT RuleID, DatasourceID FROM dbo.AppRuleDatasource WHERE RuleID = {0}
            )
            SELECT CAST(CASE WHEN RuleID IS NULL THEN 0 ELSE 1 END AS bit) AS EnableRule, RuleID, vAppDatasource_LUE.DatasourceID, vAppDatasource_LUE.DatasourceName, 
            vAppDatasource_LUE.DateIn, vAppDatasource_LUE.RealName, vAppDatasource_LUE.AppDatasourceTypeName, vAppDatasource_LUE.DSCategoryId 
            FROM vAppDatasource_LUE LEFT OUTER JOIN CTE1 ON vAppDatasource_LUE.DatasourceID = CTE1.DatasourceID
            WHERE DSCategoryId = {1}", RuleId, DS);
            try
            { adp.Fill(tbl); }
            catch (SqlException ex)
            { Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId); }
            return tbl;
        }
        public static bool AddRuleDS(int RuleId, int DS)
        {
            bool output = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO dbo.AppRuleDatasource (RuleID, DatasourceID) VALUES ({0}, {1})", RuleId, DS), con);
            try
            { con.Open(); cmd.ExecuteNonQuery(); output = true; con.Close(); }
            catch (SqlException ex)
            { Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId); }
            return output;
        }
        public static bool RemoveRuleDS(int RuleId, int DS)
        {
            bool output = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.IC_DBConnectionString);
            SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM dbo.AppRuleDatasource WHERE RuleID = {0} AND DatasourceID = {1}", RuleId, DS), con);
            try
            { con.Open(); cmd.ExecuteNonQuery(); output = true; con.Close(); }
            catch (SqlException ex)
            { Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId); }
            return output;
        }
        #endregion
        

        #endregion

    }
}