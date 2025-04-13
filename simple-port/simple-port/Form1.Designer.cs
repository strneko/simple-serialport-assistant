namespace simple_port
{
    partial class Main
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
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.receive_rtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.send_rtb = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.openPort = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.autoClearReceive = new System.Windows.Forms.CheckBox();
            this.HexReceive = new System.Windows.Forms.CheckBox();
            this.clearReceive = new System.Windows.Forms.Button();
            this.pauseReceive = new System.Windows.Forms.Button();
            this.selectPath = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sendDocument = new System.Windows.Forms.Button();
            this.openDocument = new System.Windows.Forms.Button();
            this.clearSend = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.HexSend = new System.Windows.Forms.CheckBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.port = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.port.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portSelect
            // 
            this.portSelect.BackColor = System.Drawing.SystemColors.Info;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.portSelect.Location = new System.Drawing.Point(115, 45);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(274, 32);
            this.portSelect.TabIndex = 0;
            this.portSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // receive_rtb
            // 
            this.receive_rtb.Location = new System.Drawing.Point(547, 45);
            this.receive_rtb.Name = "receive_rtb";
            this.receive_rtb.Size = new System.Drawing.Size(720, 637);
            this.receive_rtb.TabIndex = 2;
            this.receive_rtb.Text = "";
            this.receive_rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "发送";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "接收";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // send_rtb
            // 
            this.send_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.send_rtb.Location = new System.Drawing.Point(547, 769);
            this.send_rtb.Name = "send_rtb";
            this.send_rtb.Size = new System.Drawing.Size(720, 342);
            this.send_rtb.TabIndex = 6;
            this.send_rtb.Text = "";
            this.send_rtb.TextChanged += new System.EventHandler(this.send_rtb_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.comboBox1.Location = new System.Drawing.Point(115, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 32);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "端口号";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "波特率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "校验位";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.comboBox2.Location = new System.Drawing.Point(115, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 32);
            this.comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "数据位";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.comboBox3.Location = new System.Drawing.Point(115, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(274, 32);
            this.comboBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "停止位";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.comboBox4.Location = new System.Drawing.Point(115, 271);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(274, 32);
            this.comboBox4.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 28);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "RTS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 390);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 28);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "DTR";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(209, 333);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(180, 85);
            this.openPort.TabIndex = 19;
            this.openPort.Text = "打开串口";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "接收配置";
            // 
            // autoClearReceive
            // 
            this.autoClearReceive.AutoSize = true;
            this.autoClearReceive.Location = new System.Drawing.Point(31, 528);
            this.autoClearReceive.Name = "autoClearReceive";
            this.autoClearReceive.Size = new System.Drawing.Size(138, 28);
            this.autoClearReceive.TabIndex = 21;
            this.autoClearReceive.Text = "自动清空";
            this.autoClearReceive.UseVisualStyleBackColor = true;
            // 
            // HexReceive
            // 
            this.HexReceive.AutoSize = true;
            this.HexReceive.Location = new System.Drawing.Point(31, 585);
            this.HexReceive.Name = "HexReceive";
            this.HexReceive.Size = new System.Drawing.Size(138, 28);
            this.HexReceive.TabIndex = 22;
            this.HexReceive.Text = "十六进制";
            this.HexReceive.UseVisualStyleBackColor = true;
            // 
            // clearReceive
            // 
            this.clearReceive.Font = new System.Drawing.Font("宋体", 9F);
            this.clearReceive.Location = new System.Drawing.Point(232, 520);
            this.clearReceive.Name = "clearReceive";
            this.clearReceive.Size = new System.Drawing.Size(174, 41);
            this.clearReceive.TabIndex = 23;
            this.clearReceive.Text = "手动清空";
            this.clearReceive.UseVisualStyleBackColor = true;
            this.clearReceive.Click += new System.EventHandler(this.button2_Click);
            // 
            // pauseReceive
            // 
            this.pauseReceive.Font = new System.Drawing.Font("宋体", 9F);
            this.pauseReceive.Location = new System.Drawing.Point(232, 581);
            this.pauseReceive.Name = "pauseReceive";
            this.pauseReceive.Size = new System.Drawing.Size(174, 43);
            this.pauseReceive.TabIndex = 24;
            this.pauseReceive.Text = "暂停";
            this.pauseReceive.UseVisualStyleBackColor = true;
            // 
            // selectPath
            // 
            this.selectPath.Font = new System.Drawing.Font("宋体", 9F);
            this.selectPath.Location = new System.Drawing.Point(31, 637);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(174, 45);
            this.selectPath.TabIndex = 25;
            this.selectPath.Text = "选择路径";
            this.selectPath.UseVisualStyleBackColor = true;
            // 
            // saveData
            // 
            this.saveData.Font = new System.Drawing.Font("宋体", 9F);
            this.saveData.Location = new System.Drawing.Point(232, 637);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(174, 45);
            this.saveData.TabIndex = 26;
            this.saveData.Text = "保存数据";
            this.saveData.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "发送配置";
            // 
            // sendDocument
            // 
            this.sendDocument.Font = new System.Drawing.Font("宋体", 9F);
            this.sendDocument.Location = new System.Drawing.Point(236, 899);
            this.sendDocument.Name = "sendDocument";
            this.sendDocument.Size = new System.Drawing.Size(174, 46);
            this.sendDocument.TabIndex = 33;
            this.sendDocument.Text = "发送文件";
            this.sendDocument.UseVisualStyleBackColor = true;
            // 
            // openDocument
            // 
            this.openDocument.Font = new System.Drawing.Font("宋体", 9F);
            this.openDocument.Location = new System.Drawing.Point(35, 899);
            this.openDocument.Name = "openDocument";
            this.openDocument.Size = new System.Drawing.Size(174, 46);
            this.openDocument.TabIndex = 32;
            this.openDocument.Text = "打开文件";
            this.openDocument.UseVisualStyleBackColor = true;
            // 
            // clearSend
            // 
            this.clearSend.Font = new System.Drawing.Font("宋体", 9F);
            this.clearSend.Location = new System.Drawing.Point(236, 834);
            this.clearSend.Name = "clearSend";
            this.clearSend.Size = new System.Drawing.Size(174, 43);
            this.clearSend.TabIndex = 31;
            this.clearSend.Text = "清空发送";
            this.clearSend.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("宋体", 9F);
            this.send.Location = new System.Drawing.Point(236, 773);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(174, 44);
            this.send.TabIndex = 30;
            this.send.Text = "手动发送";
            this.send.UseVisualStyleBackColor = true;
            // 
            // HexSend
            // 
            this.HexSend.AutoSize = true;
            this.HexSend.Location = new System.Drawing.Point(35, 838);
            this.HexSend.Name = "HexSend";
            this.HexSend.Size = new System.Drawing.Size(138, 28);
            this.HexSend.TabIndex = 29;
            this.HexSend.Text = "十六进制";
            this.HexSend.UseVisualStyleBackColor = true;
            // 
            // autoSend
            // 
            this.autoSend.AutoSize = true;
            this.autoSend.Location = new System.Drawing.Point(35, 781);
            this.autoSend.Name = "autoSend";
            this.autoSend.Size = new System.Drawing.Size(138, 28);
            this.autoSend.TabIndex = 28;
            this.autoSend.Text = "自动发送";
            this.autoSend.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 1010);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "自动发送周期(ms）";
            // 
            // port
            // 
            this.port.Controls.Add(this.label3);
            this.port.Location = new System.Drawing.Point(31, 9);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(400, 459);
            this.port.TabIndex = 36;
            this.port.TabStop = false;
            this.port.Text = "串口配置";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(250, 1010);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(156, 32);
            this.comboBox5.TabIndex = 37;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1157);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1279, 41);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 31);
            this.toolStripStatusLabel1.Text = "状态:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 31);
            this.toolStripStatusLabel2.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 31);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(100, 31);
            this.toolStripStatusLabel6.Text = "0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(110, 31);
            this.toolStripStatusLabel7.Text = "清空计数";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 1198);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sendDocument);
            this.Controls.Add(this.openDocument);
            this.Controls.Add(this.clearSend);
            this.Controls.Add(this.send);
            this.Controls.Add(this.HexSend);
            this.Controls.Add(this.autoSend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.pauseReceive);
            this.Controls.Add(this.clearReceive);
            this.Controls.Add(this.HexReceive);
            this.Controls.Add(this.autoClearReceive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.send_rtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receive_rtb);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.port);
            this.Name = "Main";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.port.ResumeLayout(false);
            this.port.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.RichTextBox receive_rtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox send_rtb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox autoClearReceive;
        private System.Windows.Forms.CheckBox HexReceive;
        private System.Windows.Forms.Button clearReceive;
        private System.Windows.Forms.Button pauseReceive;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sendDocument;
        private System.Windows.Forms.Button openDocument;
        private System.Windows.Forms.Button clearSend;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.CheckBox HexSend;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox port;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

