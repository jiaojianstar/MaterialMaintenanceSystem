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
    public partial class MMBom : Form
    {
        public MMBom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public MMBom(DataTable dt)
        {
            InitializeComponent();
            importToDGV(dt);
        }
        private void importToDGV(DataTable dt)
        {
          //  dataGridView1.DataSource
        }
    }
}
