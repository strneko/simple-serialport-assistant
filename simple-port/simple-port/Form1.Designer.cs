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
            this.receiveRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendRtb = new System.Windows.Forms.RichTextBox();
            this.BaudSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paritySelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stopSelect = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.openPortBtn = new System.Windows.Forms.Button();
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
            this.clearSendBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.HexSend = new System.Windows.Forms.CheckBox();
            this.autoSend = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.port.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portSelect
            // 
            this.portSelect.BackColor = System.Drawing.SystemColors.Info;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(115, 45);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(274, 32);
            this.portSelect.TabIndex = 0;
            // 
            // receiveRtb
            // 
            this.receiveRtb.Location = new System.Drawing.Point(547, 45);
            this.receiveRtb.Name = "receiveRtb";
            this.receiveRtb.Size = new System.Drawing.Size(720, 637);
            this.receiveRtb.TabIndex = 2;
            this.receiveRtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "发送";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "接收";
            // 
            // sendRtb
            // 
            this.sendRtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendRtb.Location = new System.Drawing.Point(547, 769);
            this.sendRtb.Name = "sendRtb";
            this.sendRtb.Size = new System.Drawing.Size(720, 342);
            this.sendRtb.TabIndex = 6;
            this.sendRtb.Text = "";
            this.sendRtb.Leave += new System.EventHandler(this.sendRtb_Leave);
            // 
            // BaudSelect
            // 
            this.BaudSelect.BackColor = System.Drawing.SystemColors.Info;
            this.BaudSelect.FormattingEnabled = true;
            this.BaudSelect.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.BaudSelect.Location = new System.Drawing.Point(115, 101);
            this.BaudSelect.Name = "BaudSelect";
            this.BaudSelect.Size = new System.Drawing.Size(274, 32);
            this.BaudSelect.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "端口号";
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
            // paritySelect
            // 
            this.paritySelect.BackColor = System.Drawing.SystemColors.Info;
            this.paritySelect.FormattingEnabled = true;
            this.paritySelect.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.paritySelect.Location = new System.Drawing.Point(115, 156);
            this.paritySelect.Name = "paritySelect";
            this.paritySelect.Size = new System.Drawing.Size(274, 32);
            this.paritySelect.TabIndex = 11;
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
            // dataSelect
            // 
            this.dataSelect.BackColor = System.Drawing.SystemColors.Info;
            this.dataSelect.FormattingEnabled = true;
            this.dataSelect.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataSelect.Location = new System.Drawing.Point(115, 215);
            this.dataSelect.Name = "dataSelect";
            this.dataSelect.Size = new System.Drawing.Size(274, 32);
            this.dataSelect.TabIndex = 13;
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
            // stopSelect
            // 
            this.stopSelect.BackColor = System.Drawing.SystemColors.Info;
            this.stopSelect.FormattingEnabled = true;
            this.stopSelect.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopSelect.Location = new System.Drawing.Point(115, 271);
            this.stopSelect.Name = "stopSelect";
            this.stopSelect.Size = new System.Drawing.Size(274, 32);
            this.stopSelect.TabIndex = 15;
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
            // openPortBtn
            // 
            this.openPortBtn.Location = new System.Drawing.Point(209, 333);
            this.openPortBtn.Name = "openPortBtn";
            this.openPortBtn.Size = new System.Drawing.Size(180, 85);
            this.openPortBtn.TabIndex = 19;
            this.openPortBtn.Text = "打开串口";
            this.openPortBtn.UseVisualStyleBackColor = true;
            this.openPortBtn.Click += new System.EventHandler(this.openPort_Click);
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
            this.autoClearReceive.CheckedChanged += new System.EventHandler(this.autoClearReceive_CheckedChanged);
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
            this.HexReceive.CheckedChanged += new System.EventHandler(this.HexReceive_CheckedChanged);
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
            this.clearReceive.Click += new System.EventHandler(this.clearReceive_Click);
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
            this.pauseReceive.Click += new System.EventHandler(this.pauseReceive_Click);
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
            this.sendDocument.Location = new System.Drawing.Point(232, 888);
            this.sendDocument.Name = "sendDocument";
            this.sendDocument.Size = new System.Drawing.Size(174, 46);
            this.sendDocument.TabIndex = 33;
            this.sendDocument.Text = "发送文件";
            this.sendDocument.UseVisualStyleBackColor = true;
            // 
            // openDocument
            // 
            this.openDocument.Font = new System.Drawing.Font("宋体", 9F);
            this.openDocument.Location = new System.Drawing.Point(31, 888);
            this.openDocument.Name = "openDocument";
            this.openDocument.Size = new System.Drawing.Size(174, 46);
            this.openDocument.TabIndex = 32;
            this.openDocument.Text = "打开文件";
            this.openDocument.UseVisualStyleBackColor = true;
            // 
            // clearSendBtn
            // 
            this.clearSendBtn.Font = new System.Drawing.Font("宋体", 9F);
            this.clearSendBtn.Location = new System.Drawing.Point(236, 830);
            this.clearSendBtn.Name = "clearSendBtn";
            this.clearSendBtn.Size = new System.Drawing.Size(174, 43);
            this.clearSendBtn.TabIndex = 31;
            this.clearSendBtn.Text = "清空发送";
            this.clearSendBtn.UseVisualStyleBackColor = true;
            this.clearSendBtn.Click += new System.EventHandler(this.clearSendBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("宋体", 9F);
            this.sendBtn.Location = new System.Drawing.Point(236, 773);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(174, 44);
            this.sendBtn.TabIndex = 30;
            this.sendBtn.Text = "手动发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
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
            this.HexSend.CheckedChanged += new System.EventHandler(this.HexSend_CheckedChanged);
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
            this.sendCountLabel,
            this.toolStripStatusLabel5,
            this.receiveCountLabel,
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
            // sendCountLabel
            // 
            this.sendCountLabel.AutoSize = false;
            this.sendCountLabel.Name = "sendCountLabel";
            this.sendCountLabel.Size = new System.Drawing.Size(100, 31);
            this.sendCountLabel.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // receiveCountLabel
            // 
            this.receiveCountLabel.AutoSize = false;
            this.receiveCountLabel.Name = "receiveCountLabel";
            this.receiveCountLabel.Size = new System.Drawing.Size(100, 31);
            this.receiveCountLabel.Text = "0";
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
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Controls.Add(this.clearSendBtn);
            this.Controls.Add(this.sendBtn);
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
            this.Controls.Add(this.openPortBtn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stopSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paritySelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BaudSelect);
            this.Controls.Add(this.sendRtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiveRtb);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.port);
            this.Name = "Main";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.port.ResumeLayout(false);
            this.port.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.RichTextBox receiveRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sendRtb;
        private System.Windows.Forms.ComboBox BaudSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox paritySelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dataSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stopSelect;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button openPortBtn;
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
        private System.Windows.Forms.Button clearSendBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.CheckBox HexSend;
        private System.Windows.Forms.CheckBox autoSend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox port;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel receiveCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

