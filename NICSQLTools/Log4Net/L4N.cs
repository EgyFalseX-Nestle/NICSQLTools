using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NICSQLTools.Log4Net
{
    public static  class L4N
    {
        public static void Init()
        {
            if (!Directory.Exists(Program.Log4NetFolder))
                Directory.CreateDirectory(Program.Log4NetFolder);
            if (!File.Exists(Program.Log4NetConfigFile))
            {
                StreamWriter sw = File.CreateText(Program.Log4NetConfigFile);
                sw.Write(Properties.Settings.Default.L4N);
                sw.Close();
            }
            if (!File.Exists(Program.Log4NetLogFile))
                File.Create(Program.Log4NetLogFile).Close();

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Program.Log4NetConfigFile));
        }
    }
}
