namespace MaterialMaintenanceSystem
{
    partial class MMBom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkToDB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_WBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Ev_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Pro_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_M_Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_M_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Next_M_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Comp_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Q_Stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "理货员:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "物料编码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkToDB,
            this.serial,
            this.物料编码,
            this.M_Batch,
            this.M_quantity,
            this.M_Serial,
            this.M_WBS,
            this.M_Project,
            this.M_Ev_Type,
            this.M_Supplier,
            this.M_Pro_Date,
            this.M_M_Cycle,
            this.Last_M_Date,
            this.Next_M_Date,
            this.M_Comp_Date,
            this.M_Q_Stat,
            this.M_Type,
            this.M_Stat});
            this.dataGridView1.Location = new System.Drawing.Point(27, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkToDB
            // 
            this.checkToDB.Frozen = true;
            this.checkToDB.HeaderText = "选中";
            this.checkToDB.Name = "checkToDB";
            this.checkToDB.Width = 50;
            // 
            // serial
            // 
            this.serial.Frozen = true;
            this.serial.HeaderText = "序号";
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            this.serial.Width = 70;
            // 
            // 物料编码
            // 
            this.物料编码.HeaderText = "M_Code";
            this.物料编码.Name = "物料编码";
            this.物料编码.ReadOnly = true;
            this.物料编码.Width = 150;
            // 
            // M_Batch
            // 
            this.M_Batch.HeaderText = "批次";
            this.M_Batch.Name = "M_Batch";
            this.M_Batch.Width = 150;
            // 
            // M_quantity
            // 
            this.M_quantity.HeaderText = "数量";
            this.M_quantity.Name = "M_quantity";
            this.M_quantity.ReadOnly = true;
            this.M_quantity.Width = 70;
            // 
            // M_Serial
            // 
            this.M_Serial.HeaderText = "序列号";
            this.M_Serial.Name = "M_Serial";
            this.M_Serial.ReadOnly = true;
            this.M_Serial.Width = 150;
            // 
            // M_WBS
            // 
            this.M_WBS.HeaderText = "项目WBS";
            this.M_WBS.Name = "M_WBS";
            // 
            // M_Project
            // 
            this.M_Project.HeaderText = "项目名称";
            this.M_Project.Name = "M_Project";
            // 
            // M_Ev_Type
            // 
            this.M_Ev_Type.HeaderText = "评估类型";
            this.M_Ev_Type.Name = "M_Ev_Type";
            this.M_Ev_Type.ReadOnly = true;
            // 
            // M_Supplier
            // 
            this.M_Supplier.HeaderText = "供应商";
            this.M_Supplier.Name = "M_Supplier";
            this.M_Supplier.ReadOnly = true;
            // 
            // M_Pro_Date
            // 
            this.M_Pro_Date.HeaderText = "生产日期";
            this.M_Pro_Date.Name = "M_Pro_Date";
            this.M_Pro_Date.ReadOnly = true;
            // 
            // M_M_Cycle
            // 
            this.M_M_Cycle.HeaderText = "保养周期";
            this.M_M_Cycle.Name = "M_M_Cycle";
            this.M_M_Cycle.ReadOnly = true;
            // 
            // Last_M_Date
            // 
            this.Last_M_Date.HeaderText = "上次保养日期";
            this.Last_M_Date.Name = "Last_M_Date";
            this.Last_M_Date.ReadOnly = true;
            // 
            // Next_M_Date
            // 
            this.Next_M_Date.HeaderText = "下次保养日期";
            this.Next_M_Date.Name = "Next_M_Date";
            this.Next_M_Date.ReadOnly = true;
            // 
            // M_Comp_Date
            // 
            this.M_Comp_Date.HeaderText = "保养日期";
            this.M_Comp_Date.Name = "M_Comp_Date";
            this.M_Comp_Date.ReadOnly = true;
            // 
            // M_Q_Stat
            // 
            this.M_Q_Stat.HeaderText = "质检状态";
            this.M_Q_Stat.Name = "M_Q_Stat";
            this.M_Q_Stat.ReadOnly = true;
            // 
            // M_Type
            // 
            this.M_Type.HeaderText = "保养类型";
            this.M_Type.Name = "M_Type";
            this.M_Type.ReadOnly = true;
            // 
            // M_Stat
            // 
            this.M_Stat.HeaderText = "保养状态";
            this.M_Stat.Name = "M_Stat";
            this.M_Stat.ReadOnly = true;
            // 
            // MMBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MMBom";
            this.Text = "物料保养明细表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkToDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_WBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Ev_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Pro_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_M_Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_M_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Next_M_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Comp_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Q_Stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Stat;
    }
}