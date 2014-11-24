using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.IO;
using log4net;

namespace NICSQLTools
{
    public class DataManager
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DataManager));
        public static DataManager defaultInstance;
        public static int ConnectionTimeout = 0;
        public static int SHRINKSIZE = 10;
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
                Logger.Error(ex.Message, ex);
            }
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
                Logger.Error(ex.Message, ex);
            }
            return null;
        }
        public static List<DataTable> GetStoredProcedureSchema(Data.dsData.AppDashboardDSDataTable DashboardTbl)
        {
            List<DataTable> Tbls = new List<DataTable>();
            foreach (Data.dsData.AppDashboardDSRow row in DashboardTbl.Rows)
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
            SqlCommand cmd = new SqlCommand("SELECT DatasourceSPName FROM dbo.AppDashboardDS WHERE DatasourceID = @DatasourceID", con);
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
                Logger.Error(ex.Message, ex);
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
                Logger.Error(ex.Message, ex);
            }
            return dt;
        }

        #endregion

    }
}