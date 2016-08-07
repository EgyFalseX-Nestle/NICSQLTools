using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using NICSQLTools.Classes.Managers;
using NICSQLTools.Views.Data.MSrv;

namespace NICSQLTools
{
    static class Program
    {
        public static string updatePath = Application.StartupPath + @"\zUpdateObject.exe";
        public static string updaterPath = Application.StartupPath + @"\Updater.exe";
        public static string AppPath = Application.StartupPath + @"\NICSQLTools.exe";
        public static string Log4NetFolder = Application.StartupPath + @"\L4N";
        public static string Log4NetConfigFile = Log4NetFolder + @"\L4N.config";
        public static string Log4NetLogFile = Log4NetFolder + @"\L4N.txt";
        public static string TilesLayoutFile = Application.StartupPath + @"\TilesLayoutFile";

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TestFrm frm = new TestFrm();
            //frm.ShowDialog();return;
            

            //UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

            try
            {
                Log4Net.L4N.Init();
                DataManager.PerformChangeExe();
                if (FXFW.SqlDB.LoadSqlDBPath("IC_DB"))
                {
                    Properties.Settings.Default["IC_DBConnectionString"] = FXFW.SqlDB.SqlConStr + ";Connection Timeout=60";
                    DevExpress.Xpo.XpoDefault.ConnectionString = FXFW.SqlDB.SqlConStr + ";Connection Timeout=60";
                    Init();
                    //Application.Run(new TestFrm());
                    Application.Run(new Views.Main.MainTilesFrm());
                }
            }
            catch (Exception ex)
            {
                NICSQLTools.Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId);
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Fatal, ex);
            }
        }
        public static void Init()
        {
            DataManager.Init();
            Classes.Managers.UserManager.Init();
            Classes.Dashboard.Init();
            Classes.QueryLayout.Init();
        }
        

    }
}
