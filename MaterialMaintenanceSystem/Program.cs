using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaterialMaintenanceSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        public static string ServerPort="";
        public static string DBUserName="";
        public static string ServerPath="";
        public static string DBName="";
        public static string Pwd="123456";
        public static int LoginFlag;
        public static string LogFilePath="";
        public static string ConfigFilePath="";
        public static string ImportXLSPath = "";
        public static string ExportXLSPath = "";
        public static string LogFileWriteError="";
        public static string ConfigFileReadError="";
        public static bool WriteLogFile = true;
        public static string staffID = "";
        public static string userName = "";
        public static string sapDisName = "";
        public static string userRole = "";
        public static string keyValueStr = "";
        public static int XLSColsCount = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
