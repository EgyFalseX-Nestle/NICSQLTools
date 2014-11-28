using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace NICSQLTools
{
    static class Program
    {
        public static string updatePath = Application.StartupPath + @"\zUpdateObject.exe";
        public static string updaterPath = Application.StartupPath + @"\Updater.exe";
        public static string AppPath = Application.StartupPath + @"\NICSQLTools.exe";
        public static string Log4NetFolder = Application.StartupPath + @"\Log4Net";
        public static string Log4NetConfigFile = Log4NetFolder + @"\NICSQLToolsLog4Net.config";
        public static string Log4NetLogFile = Log4NetFolder + @"\NICSQLToolsLog4Net.txt";

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

            Log4Net.L4N.Init();
            DataManager.PerformChangeExe(); 
            if (FXFW.SqlDB.LoadSqlDBPath("IC_DB"))
            {
                Properties.Settings.Default["IC_DBConnectionString"] = FXFW.SqlDB.SqlConStr;
                DevExpress.Xpo.XpoDefault.ConnectionString = FXFW.SqlDB.SqlConStr;
                Init();
                //Set User Info

                //Application.Run(new TestFrm());

                //Dictionary<string, int> asm = DataManager.GetCurrentAssemblyFiles();
                //foreach (var item in asm)
                //{
                //    MessageBox.Show(String.Format("Name: {0}{1}Version: {2}", item.Key, Environment.NewLine, item.Value));
                //}

                //NICSQLTools.Data.dsData.AppDependenceFileDataTable tbl = new Data.dsData.AppDependenceFileDataTable();
                //NICSQLTools.Data.dsData.AppDependenceFileRow row1 = tbl.NewAppDependenceFileRow();
                //row1.FileName = "DevExpress.BonusSkins.v14.1.dll"; row1.FileVersion = 1000;
                //tbl.Rows.Add(row1);

                //NICSQLTools.Data.dsData.AppDependenceFileRow row2 = tbl.NewAppDependenceFileRow();
                //row2.FileName = "DevExpress.Dashboard.v14.1.Core.dll"; row2.FileVersion = 1000;
                //tbl.Rows.Add(row2);

                DataManager.PerformUpdaterDownload(DataManager.GetDownloadDependanceies());
                //Application.Run(new NICSQLTools.Forms.Main.MainTilesFrm());
            }
            
        }
        public static void Init()
        {
            DataManager.Init();
            Classes.Managers.UserManager.Init();
            Classes.Dashboard.Init();
        }
        

    }
}
