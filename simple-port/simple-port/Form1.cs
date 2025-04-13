using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_port
{
    public partial class Main : Form
    {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if(this.send_rtb.Text != "")
            {
                this.receive_rtb.AppendText(this.send_rtb.Text);
                this.send_rtb.Text = "";
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

                serialPort1.PortName = portSelect.Text;

                if (serialPort1.IsOpen)
                {
                    MessageBox.Show(serialPort1.PortName + "已经打开");
                    return;
                }

                serialPort1.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString() + " " +serialPort1.PortName.ToString());
            }
        }
    }
}
