using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_port
{
    public partial class Main : Form
    {
        private bool portOpen = false;
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadSerial()
        {
            
            // 直接操作注册表
            //RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            //string[] sSubKeys = keyCom.GetValueNames();
            //foreach (string sSubKey in sSubKeys)
            //{
            //    string portName=(string)keyCom.GetValue(sSubKey);
            //    portSelect.Items.Add(portName);
            //}
            portSelect.Items.Clear();
            string[] ports=SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portSelect.Items.Add(port);
            }
            if(portSelect.Items.Count==0)
            {
                portSelect.Items.Add("未找到可用串口");
            }
            this.portSelect.SelectedIndex = 0;
            this.BaudSelect.SelectedIndex = 1;
            this.paritySelect.SelectedIndex = 0;
            this.dataSelect.SelectedIndex = 3;
            this.stopSelect.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadSerial();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if(this.sendRtb.Text != "")
            {
                this.receiveRtb.AppendText(this.sendRtb.Text);
                this.sendRtb.Text = "";
            }
            else
            {
                MessageBox.Show("请输入数据");
            }
        }

        private void send_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openPort_Click(object sender, EventArgs e)
        {
            try 
            {
                
                if (portSelect.Text=="")
                {
                    MessageBox.Show("请选择端口");
                    return;
                }
                if (portOpen == false)
                {
                    serialPort1.PortName = portSelect.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudSelect.Text);
                    serialPort1.DataBits = Convert.ToInt32(dataSelect.Text);
                    switch (paritySelect.Text)
                    {
                        case "NONE":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "ODD":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "EVEN":
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            break;
                    }
                    switch (stopSelect.SelectedIndex)
                    {
                        //1 1.5 2
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }
                    serialPort1.Open();
                    openPortBtn.Text = "关闭串口";
                    portOpen = true;
                }
                else 
                {
                    serialPort1.Close();
                    portOpen = false;
                    openPortBtn.Text = "打开串口";
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString() + " " +serialPort1.PortName.ToString());
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(sendRtb.Text == "")
            {
                MessageBox.Show("内容为空");
                return;
            }
            if (serialPort1.IsOpen==false) 
            {
                MessageBox.Show("串口未打开");
                return;
            }
            serialPort1.Write(sendRtb.Text);
        }

        private void clearSendBtn_Click(object sender, EventArgs e)
        {
            sendRtb.Text = "";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataReceive = serialPort1.ReadExisting();
            receiveRtb.AppendText(dataReceive);
        }
    }
}
