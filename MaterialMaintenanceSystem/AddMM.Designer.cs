namespace MaterialMaintenanceSystem
{
    partial class AddMM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.Alert_Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectImportXLS = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.M_Stat,
            this.Alert_Days});
            this.dataGridView1.Location = new System.Drawing.Point(38, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 600);
            this.dataGridView1.TabIndex = 5;
            // 
            // serial
            // 
            this.serial.Frozen = true;
            this.serial.HeaderText = "序号";
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            // 
            // 物料编码
            // 
            this.物料编码.HeaderText = "M_Code";
            this.物料编码.Name = "物料编码";
            this.物料编码.ReadOnly = true;
            // 
            // M_Batch
            // 
            this.M_Batch.HeaderText = "批次";
            this.M_Batch.Name = "M_Batch";
            // 
            // M_quantity
            // 
            this.M_quantity.HeaderText = "数量";
            this.M_quantity.Name = "M_quantity";
            this.M_quantity.ReadOnly = true;
            // 
            // M_Serial
            // 
            this.M_Serial.HeaderText = "序列号";
            this.M_Serial.Name = "M_Serial";
            this.M_Serial.ReadOnly = true;
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
            // Alert_Days
            // 
            this.Alert_Days.HeaderText = "保养提醒天数";
            this.Alert_Days.Name = "Alert_Days";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "逐条新增数据";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excel批量导入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddMM";
            this.Text = "AddMM";
            this.Load += new System.EventHandler(this.AddMM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Alert_Days;
        private System.Windows.Forms.OpenFileDialog selectImportXLS;
    }
}