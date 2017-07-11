namespace MaterialMaintenanceSystem
{
    partial class loginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_StaffID = new System.Windows.Forms.TextBox();
            this.TB_PWD = new System.Windows.Forms.TextBox();
            this.loginBTZ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_StaffID
            // 
            this.TB_StaffID.Location = new System.Drawing.Point(219, 52);
            this.TB_StaffID.Name = "TB_StaffID";
            this.TB_StaffID.Size = new System.Drawing.Size(100, 22);
            this.TB_StaffID.TabIndex = 0;
            // 
            // TB_PWD
            // 
            this.TB_PWD.Location = new System.Drawing.Point(219, 111);
            this.TB_PWD.Name = "TB_PWD";
            this.TB_PWD.PasswordChar = '#';
            this.TB_PWD.Size = new System.Drawing.Size(100, 22);
            this.TB_PWD.TabIndex = 1;
            // 
            // loginBTZ
            // 
            this.loginBTZ.Location = new System.Drawing.Point(219, 187);
            this.loginBTZ.Name = "loginBTZ";
            this.loginBTZ.Size = new System.Drawing.Size(100, 48);
            this.loginBTZ.TabIndex = 2;
            this.loginBTZ.Text = "登录";
            this.loginBTZ.UseVisualStyleBackColor = true;
            this.loginBTZ.Click += new System.EventHandler(this.loginBTZ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl3,
            this.tssl2,
            this.toolStripStatusLabel1,
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl2
            // 
            this.tssl2.Name = "tssl2";
            this.tssl2.Size = new System.Drawing.Size(0, 20);
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 20);
            // 
            // tssl3
            // 
            this.tssl3.AutoSize = false;
            this.tssl3.Name = "tssl3";
            this.tssl3.Size = new System.Drawing.Size(152, 20);
            this.tssl3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(345, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 260);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBTZ);
            this.Controls.Add(this.TB_PWD);
            this.Controls.Add(this.TB_StaffID);
            this.Name = "loginForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_StaffID;
        private System.Windows.Forms.TextBox TB_PWD;
        private System.Windows.Forms.Button loginBTZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl2;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripStatusLabel tssl3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

