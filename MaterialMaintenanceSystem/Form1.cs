using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MaterialMaintenanceSystem
{
    public partial class loginForm : Form
    {
        int loginErr = 1;
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.ConfigFilePath= Environment.CurrentDirectory+"\\config.txt";
            ConfigFile.getConfig();
            tssl1.Text = "用户未登录！";

            if (Program.ConfigFileReadError != "")
            {
                tssl3.Text = Program.ConfigFileReadError;
                tssl3.ForeColor = Color.Red;
                loginBTZ.Enabled = false;
            }
            else
            {
                tssl3.Text = "已载入配置文件";
            }
        }

        private void loginBTZ_Click(object sender, EventArgs e)
        {
            new Main_User().Show();
            /**
            int loginStat = 0;
            string sqlCMD = "";
           
            PostDB pdb = null;
            if (TB_StaffID.Text == "")
            {
                MessageBox.Show("用户账号不能为空！");
                TB_StaffID.Focus();
            }
            else
            if (TB_PWD.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                TB_PWD.Focus();
            }
            else {
                tssl1.Text = "登录中";
                try
                {
                    pdb = new PostDB(Program.ServerPath, Program.ServerPort, Program.DBName, Program.DBUserName, Program.Pwd);
                    sqlCMD = "select count(*) from user_info where staffid='" + TB_StaffID.Text + "' and pwd='" + TB_PWD.Text + "'";
                    loginStat = pdb.ExecuteSQLScalar(sqlCMD);
                }
                catch (Exception ex)
                {
                    LogFile.write("登录异常，错误信息： " + ex.Message);

                }
                if (loginStat == 1)
                {
                    MessageBox.Show("登录成功！");
                    Program.staffID = TB_StaffID.Text;
                    sqlCMD = "select username,sapdisname,pwd,userrole from user_info where staffid='" + Program.staffID + "'";
                    DataSet userDS = pdb.GetRecordSet(sqlCMD);
                    Program.userName = userDS.Tables[0].Rows[0].Field<string>("username");
                    Program.sapDisName = userDS.Tables[0].Rows[0].Field<string>("sapdisname");
                    Program.Pwd = userDS.Tables[0].Rows[0].Field<string>("pwd");
                    Program.userRole = userDS.Tables[0].Rows[0].Field<string>("userrole");
                    tssl1.Text = Program.userName + " 已登录";
                    LogFile.write("用户已登录！");
                    if (Program.userRole == "管理员")
                    {
                        //此处应修改为激活管理员窗口，暂时用这个调试
                        new Main_User().Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("用户名或密码错误!");
                    LogFile.write("工号： "+TB_StaffID.Text+",尝试用错误的用户名或密码登录,次数： "+ loginErr);
                    loginErr = loginErr + 1;
                }




            }*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssl2.Text= DateTime.Now.ToString();
        }
    }
}
