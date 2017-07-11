using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialMaintenanceSystem
{
    public partial class AddMM : Form
    {
        public AddMM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectImportXLS.Filter = "EXCEL文件|*.xls;*.xlsx";
            selectImportXLS.ShowDialog();
            LogFile lf = new LogFile();
           
            if(selectImportXLS.FileName!="")
            {
                Program.ImportXLSPath = selectImportXLS.FileName;
                dataGridView1.DataSource=ExcelOperation.getImportXLS();
                Dictionary<string, string> tmpDic = ConfigFile.getXLSDGVDic();
                dataGridView1.Columns["M_WBS"].DataPropertyName = "生日";
            }
         
        }

        private void Lf_notifyUser()
        {
            throw new NotImplementedException();
        }

        private void DTToDGV(DataTable dt)
        {
            string ss = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                




            }





        }

        private void AddMM_Load(object sender, EventArgs e)
        {

        }
    }
}
