using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        LoRaParameterModel LoRaPM;

        ComportFunctionality CF = new ComportFunctionality();
        SerialPort sp;
        private bool Console_receiving = false;
        private Thread t;
        //使用委派顯示 Console 畫面
        delegate void Display(string buffer);

        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Comportrefreshbtn_Click(object sender, EventArgs e)
        {
            string[] ports = CF.SearchComport();
            listBox_Com.Items.Clear();

            foreach (var item in ports)
            {
                listBox_Com.Items.Add(item);
            }

        }

        private void listBox_Com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //initial LoRa model
            LoRaPM = new LoRaParameterModel();

            string[] ports = CF.SearchComport();
            listBox_Com.Items.Clear();

            foreach (var item in ports)
            {
                listBox_Com.Items.Add(item);
            }
        }

        private void Comportrefreshbtn_Click_1(object sender, EventArgs e)
        {
            string[] ports = CF.SearchComport();
            listBox_Com.Items.Clear();

            foreach (var item in ports)
            {
                listBox_Com.Items.Add(item);
            }

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string curPort = listBox_Com.SelectedItem.ToString();
                string curBaud = comboBox_baud.Text;
                if(curPort != null)
                {
                    Console_Connect(curPort, int.Parse(curBaud));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

      
            // Console_Connect();

            Object aa = new object();
            aa = "QQ";
            SendData(aa);


        }

        private void Console_Connect(string COM, Int32 baud)
        {
            try
            {
                sp = new SerialPort();

                if (sp.IsOpen)
                {
                    sp.Close();
                }

                //設定 Serial Port 參數
                sp.PortName = COM;
                sp.BaudRate = baud;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;

                if (!sp.IsOpen)
                {
                    //開啟 Serial Port
                    sp.Open();

                    Console_receiving = true;

                    //開啟執行續做接收動作
                    t = new Thread(DoReceive);
                    t.IsBackground = true;
                    t.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //關閉 Console
        private void CloseComport()
        {
            try
            {
                sp.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
        private void DoReceive()
        {
            Byte[] buffer = new Byte[1024];

            try
            {
                while (Console_receiving)
                {
                    if (sp.BytesToRead > 0)
                    {
                        Int32 length = sp.Read(buffer, 0, buffer.Length);

                        string buf = Encoding.ASCII.GetString(buffer);

                        Array.Resize(ref buffer, length);
                        //Display d = new Display(ConsoleShow);
                        //this.Invoke(d, new Object[] { buf });
                        //Array.Resize(ref buffer, 1024);
                    }

                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console_receiving = false;
            //關閉 Serial Port
            CloseComport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] ports = CF.SearchComport();
            listBox_Com.Items.Clear();

            foreach (var item in ports)
            {
                listBox_Com.Items.Add(item);
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            CloseComport();
        }

        public void SendData(Object sendBuffer)
        {
            if (sendBuffer != null)
            {
                Byte[] buffer = sendBuffer as Byte[];

                try
                {
                    sp.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    CloseComport();
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
