using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MaterialMaintenanceSystem
{
    public class LogFile
    {
        public delegate void logFileWERR();
        public event logFileWERR notifyUser;
       
        public  void write(string logstr)
        {
             
             FileStream logfs;
            try
            {
                if (Program.WriteLogFile)
                {
                    if (!File.Exists(Program.LogFilePath))
                    {
                        File.Create(Program.LogFilePath);
                    }

                    logfs = new FileStream(Program.LogFilePath, FileMode.Append,FileAccess.Write);
                   
                    byte[] w_str = new UTF8Encoding(true).GetBytes(Program.userName + "(" + Program.staffID + ")    " +DateTime.Now.ToLocalTime().ToString() + "    "+ logstr + "\r\n");
                    logfs.Write(w_str, 0, w_str.Length);
                    logfs.Close();
                   
                }
            }
            catch (Exception e)
            {
                Program.LogFileWriteError = "log文件写入错误，错误信息：" + e.Message.ToString();
                
            }


        }
    }
}
