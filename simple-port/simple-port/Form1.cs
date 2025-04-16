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
using static System.Net.Mime.MediaTypeNames;

namespace simple_port
{
    public partial class Main : Form
    {
        private bool portOpen = false;
        private bool receivePause = false;
        private List<byte> receiveBuffer=new List<byte>();
        private List<byte> sendBuffer = new List<byte>();
        private int receiveCount = 0;
        private int sendCount = 0;
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

        private void sendData()
        {
            Console.WriteLine(sendBuffer.ToString());
            serialPort1.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendCount += sendBuffer.Count;
            sendCountLabel.Text=sendCount.ToString();
            
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
            
            
            

            sendData();
        }

        private void clearSendBtn_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            sendRtb.Text = "";
            sendCount = 0;
            sendCountLabel.Text = sendCount.ToString();
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
                    displayText=Encoding.GetEncoding("UTF-8").GetString(dataTemp).Replace("\0","\\0");
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
                receiveRtb.Text = Encoding.GetEncoding("UTF-8").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
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

        public static bool IsHexadecimal(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // 检查是否有0x或0X前缀
            int startIndex = 0;
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                startIndex = 2;
            }

            // 检查剩余字符是否都是16进制数字
            for (int i = startIndex; i < input.Length; i++)
            {
                char c = input[i];
                if (!((c >= '0' && c <= '9') ||
                      (c >= 'A' && c <= 'F') ||
                      (c >= 'a' && c <= 'f')))
                {
                    return false;
                }
            }

            return input.Length > startIndex; // 确保至少有一个16进制数字
        }

        private void HexSend_CheckedChanged(object sender, EventArgs e)
        {
            if (sendRtb.Text == "") return;
            if (HexSend.Checked)
            {
                sendRtb.Text = BitConverter.ToString(sendBuffer.ToArray()).Replace("-", " ");
            }
            else
            {
                sendRtb.Text = Encoding.GetEncoding("UTF-8").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void sendRtb_Leave(object sender, EventArgs e)
        {
            if (HexSend.Checked)
            {
                string val = sendRtb.Text.Replace(" ", "");
                if (!IsHexadecimal(val))
                {
                    MessageBox.Show("请输入正确的十六进制数据！");
                    sendRtb.Select();
                    return;
                }
               
                byte[] bytes = new byte[val.Length / 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(val.Substring(i * 2, 2), 16);
                }
                sendBuffer.Clear();
                sendBuffer.AddRange(bytes);
                return;
            }
            sendBuffer.Clear();
            sendBuffer.AddRange(Encoding.UTF8.GetBytes(sendRtb.Text));
        }
    }
}
