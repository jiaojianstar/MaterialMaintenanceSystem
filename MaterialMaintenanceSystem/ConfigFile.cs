using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace MaterialMaintenanceSystem
{
    class ConfigFile
    {
        public  ConfigFile()
        {
         
          
        }     
        public static void getConfig()
        {
            LogFile lf = new LogFile();
          //  Program.ConfigFilePath = Environment.CurrentDirectory + "\\config.txt";

            if (!File.Exists(Program.ConfigFilePath))
            {
                Program.ConfigFileReadError = "配置文件不存在";
                
            }else{
                string[] configStr = File.ReadAllLines(Program.ConfigFilePath, Encoding.GetEncoding("GB2312"));
                foreach (string tmpstr in configStr)
                {
                    if (tmpstr.StartsWith("DataBasePath="))
                    {
                        Program.ServerPath = getAttr(tmpstr);

                    }
                    else
                    if (tmpstr.StartsWith("DataBasePort="))
                    {
                        Program.ServerPort = getAttr(tmpstr);
                    }
                    else
                    if (tmpstr.StartsWith("DataBaseUser="))
                    {
                        Program.DBUserName = getAttr(tmpstr);
                    }
                    else
                        if (tmpstr.StartsWith("DateBasePWD="))
                    {
                        Program.Pwd = getAttr(tmpstr);
                    }
                    else
                        if (tmpstr.StartsWith("DataBaseName="))
                    {
                        Program.DBName = getAttr(tmpstr);
                    }
                    else
                         if (tmpstr.StartsWith("LogFilePath="))
                    {
                        Program.LogFilePath = getAttr(tmpstr);
                    }
                    else
                         if (tmpstr.StartsWith("XLSSHSToDGVCOL="))
                    {
                        Program.keyValueStr = getAttr(tmpstr);
                    }
                    else
                         if (tmpstr.StartsWith("XLSColsCount="))
                    {
                        Int16 parseR = 0;
                        if (Int16.TryParse(getAttr(tmpstr), out parseR))
                        {
                            Program.XLSColsCount = parseR;
                        }
                        else
                        {
                            lf.write("XLSColsCount为空或者不为Int16整数");
                        }

                        
                    }
                    else
                        if (getAttr(tmpstr) == "false")
                    {
                        Program.WriteLogFile = false;
                    }
                   






                }
               
                

            }

        }
        private static string getAttr(string readLine)
        {
            string[] tmpstr = readLine.Split('=');
            return tmpstr[1];
        }
        public static Dictionary<string, string> getXLSDGVDic()
        {
            LogFile lf = new LogFile();
            Dictionary<string, string> tmpDic = new Dictionary<string, string>();
            if (Program.keyValueStr.StartsWith("{") && Program.keyValueStr.EndsWith("}"))
            {
                string tmpStr = Program.keyValueStr.Substring(1);
                tmpStr = tmpStr.Remove(tmpStr.Length - 1);
                string[] tmpStrs = tmpStr.Split(',');
                Regex rgx = new Regex(@"""([\w]+)""-""([\w]+)""");
                MatchCollection mc=  rgx.Matches(tmpStr);
                if (mc.Count == Program.XLSColsCount)
                {
                    //    Console.Write(mc.Count);
                    //    Console.Write(mc[0].Groups.Count);    
                    for (int i = 0; i < tmpStrs.Length; i++)
                    {
                        tmpDic.Add(mc[i].Groups[1].ToString(), mc[i].Groups[2].ToString());
                    }
                }
                else
                {
                    lf.write("声明的XLS列数与对照字符串列数不同！");
                }

            }
            else {
                lf.write("XLS转程序DGV显示的列名键值对左右{}不匹配！");
            }



            return tmpDic;

        }
        public void setConfig()
        {



        }
    }
}
