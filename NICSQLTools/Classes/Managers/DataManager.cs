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
        public static void PerformUpdate()
        {
            int currentVersion = Convert.ToInt32(System.Windows.Forms.Application.ProductVersion.Replace(".", ""));
            int? serverVersion = adpQry.GetAppVersion();

            try
            {
                if (serverVersion == null)
                {
                    if (!Classes.Managers.UserManager.defaultInstance.User.IsAdmin)
                        return;
                    if (System.Windows.Forms.MsgDlg.Show("لا يوجد محتوي للبرنامج علي الخادم. هل ترغب في ارسال هذه النسخه للخادم؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                        return;
                    byte[] data = File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                    adpQry.SetAppData(data, currentVersion);

                }
                else
                {
                    if (serverVersion == currentVersion)
                        return;
                    else if (serverVersion < currentVersion)
                    {
                        if (!Classes.Managers.UserManager.defaultInstance.User.IsAdmin)
                            return;
                        if (System.Windows.Forms.MsgDlg.Show("هذه الاصداره جديده عن الموجوده علي الخادم, هل ترغب في تحديث الخادم؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                            return;
                        byte[] data = File.ReadAllBytes(System.Windows.Forms.Application.ExecutablePath);
                        //Compress File
                        MemoryStream ms = CompressFile(data);
                        adpQry.SetAppData(ms.ToArray(), currentVersion);
                    }
                    else
                    {
                        if (System.Windows.Forms.MsgDlg.Show("يوجد اصداره جديده من البرنامج علي الخادم, هل ترغب في التحديث؟", System.Windows.Forms.MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                            return;
                        byte[] data = adpQry.GetAppData();
                        //Decompress File
                        MemoryStream ms = DecompressFile(data);
                        FileStream fs = File.Create(Program.updatePath);
                        fs.Write(ms.ToArray(), 0, Convert.ToInt32(ms.Length));
                        fs.Close();
                        System.Diagnostics.Process.Start(Program.updatePath);
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
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
            Asm.Add("DevExpress.BonusSkins.v14.1.dll", 14180);
            Asm.Add("DevExpress.Charts.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Dashboard.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Dashboard.v14.1.Win.dll", 14180);
            Asm.Add("DevExpress.Data.v14.1.dll", 14180);
            Asm.Add("DevExpress.DataAccess.v14.1.dll", 14180);
            Asm.Add("DevExpress.DataAccess.v14.1.UI.dll", 14180);
            Asm.Add("DevExpress.Map.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Office.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.PivotGrid.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Printing.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.RichEdit.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Sparkline.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.Utils.v14.1.dll", 14180);
            Asm.Add("DevExpress.Utils.v14.1.UI.dll", 14180);
            Asm.Add("DevExpress.Xpo.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraBars.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraCharts.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraCharts.v14.1.UI.dll", 14180);
            Asm.Add("DevExpress.XtraCharts.v14.1.Wizard.dll", 14180);
            Asm.Add("DevExpress.XtraEditors.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraGauges.v14.1.Core.dll", 14180);
            Asm.Add("DevExpress.XtraGauges.v14.1.Win.dll", 14180);
            Asm.Add("DevExpress.XtraGrid.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraLayout.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraMap.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraNavBar.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraPivotGrid.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraPrinting.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraRichEdit.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraRichEdit.v14.1.Extensions.dll", 14180);
            Asm.Add("DevExpress.XtraTreeList.v14.1.dll", 14180);
            Asm.Add("DevExpress.XtraVerticalGrid.v14.1.dll", 14180);
            Asm.Add("FXFW.dll", 1001);
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

            Data = FXFW.EncDec.Encrypt(Data, "FalseX");// Encrypt Arg Data
            using (System.Diagnostics.Process process = new System.Diagnostics.Process() { StartInfo = new System.Diagnostics.ProcessStartInfo(Program.updaterPath, Data) })
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


            Data = FXFW.EncDec.Encrypt(Data, "FalseX");// Encrypt Arg Data
            using (System.Diagnostics.Process process = new System.Diagnostics.Process() { StartInfo = new System.Diagnostics.ProcessStartInfo(Program.updaterPath, Data) })
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

        public static DataTable LoadExcelFile(string strFile, string sheetName, string ColumnsNames)
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
        public static DataTable LoadExcelFile(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);

                //strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);

                OleDbConnection con = new OleDbConnection(strConnectionString);
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
        public static List<DataTable> GetStoredProcedureSchema(Data.dsData.AppDatasourceDataTable DashboardTbl)
        {
            List<DataTable> Tbls = new List<DataTable>();
            foreach (Data.dsData.AppDatasourceRow row in DashboardTbl.Rows)
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
        public static DataTable ExeDataSource(string StoredProcedureName, Dictionary<string, object> Paramters, SqlCommand cmd, SqlInfoMessageEventHandler InfoMessageHnd = null, StatementCompletedEventHandler StatementCompleted = null)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("", Properties.Settings.Default.IC_DBConnectionString);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.CommandText = StoredProcedureName;

            if (InfoMessageHnd != null)
                adp.SelectCommand.Connection.InfoMessage += InfoMessageHnd;
            if (StatementCompleted != null)
                adp.SelectCommand.StatementCompleted += StatementCompleted;

            cmd = adp.SelectCommand;
            foreach (KeyValuePair<string, object> item in Paramters)
                adp.SelectCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
            try
            {
                adp.SelectCommand.CommandTimeout = DataManager.ConnectionTimeout;
                adp.Fill(dt);
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            return dt;
        }

        #endregion

    }
}