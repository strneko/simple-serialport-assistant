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
        private bool receivePause = false;
        private List<byte> receiveBuffer=new List<byte>();
        private int receiveCount = 0;
        public Main()
        {
            InitializeComponent();
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
            if (receivePause || !serialPort1.IsOpen) return;
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(dataTemp, 0, dataTemp.Length);
            receiveBuffer.AddRange(dataTemp);

            receiveCount += dataTemp.Length;
            receiveCountLabel.Text=receiveCount.ToString();
            this.Invoke(new EventHandler(delegate
            {
                string displayText;
                if (HexReceive.Checked)
                {
                    displayText = BitConverter.ToString(dataTemp).Replace("-", " ");
                }
                else
                {
                    displayText=Encoding.GetEncoding("gb2312").GetString(dataTemp).Replace("\0","\\0");
                }
                receiveRtb.AppendText(displayText);
            }
            ));
        }

        private void pauseReceive_Click(object sender, EventArgs e)
        {
            if (portOpen == false) { MessageBox.Show("串口未打开");return; }
            if (receivePause == false)
            {
                receivePause = true;
                serialPort1.DiscardInBuffer();
                pauseReceive.Text = "继续接收";
            }
            else
            {
                receivePause = false;
                pauseReceive.Text = "暂停";
            }
        }



        private void HexReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (receiveRtb.Text == "") return;
            if (HexReceive.Checked)
            {
                receiveRtb.Text = BitConverter.ToString(receiveBuffer.ToArray()).Replace("-", " ");
            }
            else
            {
                receiveRtb.Text = Encoding.GetEncoding("gb2312").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void clearReceive_Click(object sender, EventArgs e)
        {
            receiveRtb.Text = "";
            receiveBuffer.Clear();
            receiveCount = 0;
            receiveCountLabel.Text = receiveCount.ToString();
        }

        private void autoClearReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (autoClearReceive.Checked)
            { 
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(receiveCount >= 4096) 
            {
                receiveRtb.Text = "";
                receiveBuffer.Clear();
                receiveCount = 0;
                receiveCountLabel.Text = receiveCount.ToString();
            }
        }
    }
}
