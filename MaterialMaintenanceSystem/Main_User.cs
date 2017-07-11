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
    public partial class Main_User : Form
    {
        public Main_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MMBom().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AddMM().Show();
        }
    }
}
