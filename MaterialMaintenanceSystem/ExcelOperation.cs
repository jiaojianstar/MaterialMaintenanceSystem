using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace MaterialMaintenanceSystem
{

    class ExcelOperation
    {
        
        public static DataTable getImportXLS()
        {
            DataTable dT=new DataTable();
            string strConn = "";
            LogFile lf  = new LogFile();
            if (!File.Exists(Program.ImportXLSPath))
            {
                lf.write("导入的EXCEL文件不存在");
                return null;
            }else
            {
                FileInfo tmpFI = new FileInfo(Program.ImportXLSPath);
                switch (tmpFI.Extension)
                {
                    case ".xls":
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Program.ImportXLSPath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                    case ".xlsx":
                        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Program.ImportXLSPath + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                        break;
                    default:
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Program.ImportXLSPath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                }
                OleDbConnection cnnxls = new OleDbConnection(strConn);
                //读取Excel里面有 表Sheet1
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                try
                {
                    
                    cnnxls.Open();
                    DataTable tmpDT= cnnxls.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    foreach (DataRow row in tmpDT.Rows)
                    {
                        //遍历弹出各Sheet的名称
                        Console.Write(row["TABLE_NAME"].ToString());
                    }
                    OleDbCommand odc = new OleDbCommand("select * from [data$]", cnnxls);                    
                    OleDbDataAdapter oda = new OleDbDataAdapter(odc);                    
                    oda.Fill(dT);
                    sw.Stop();
                    lf.write("读取文件：" + Program.ImportXLSPath + " 耗时：" + sw.ElapsedMilliseconds + "毫秒");
                    lf.write("表格共有" + dT.Rows.Count+"行，" + dT.Columns.Count+ "列");
                    //将Excel里面有表内容装载到内存表中！
                   
                }
                catch (Exception ex)
                {
                    lf.write("通过SQL方式读取EXCEL错误：" +ex.Message);

                }
             
                return dT;
            }


            


            


        }
    }
}
