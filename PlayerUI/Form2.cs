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
        public delegate void ChartDelegate(string sectionBuffers);

        string buf;

        #region Delegate Functions
        public void DoChart1update(string sectionBuffers)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    ChartDelegate delegateMethod = new ChartDelegate(this.DoChart1update);
                    this.Invoke(delegateMethod, new object[] { sectionBuffers });


                }
                else
                {
                    LoRaPM.AppEUI = sectionBuffers.Substring(0, 16);
                    LoRaPM.AppsKey = sectionBuffers.Substring(16, 32);
                    LoRaPM.DevAddr = sectionBuffers.Substring(48, 8);
                    LoRaPM.DevEUI = sectionBuffers.Substring(56, 16);
                    LoRaPM.NwksKey = sectionBuffers.Substring(72, 32);
                    LoRaPM.GatewayChannel = sectionBuffers.Substring(104, 1);
                    LoRaPM.RadioFrequency = sectionBuffers.Substring(105, 9);
                    LoRaPM.Sf = sectionBuffers.Substring(114, 2);

                    //richTextBox2.Text = LoRaPM.AppEUI;
                    richTextBox_APPEUI.Text = LoRaPM.AppEUI;
                    richTextBox_APPSKEY.Text = LoRaPM.AppsKey;
                    richTextBoxDEVADDR.Text = LoRaPM.DevAddr;
                    richTextBoxDEVEUI.Text = LoRaPM.DevEUI;
                    richTextBoxNWKSKEY.Text = LoRaPM.NwksKey;
                    richTextBoxGATEWAYCHANNEL.Text = LoRaPM.GatewayChannel;
                    richTextBoxRADIOFREQUENCY.Text = LoRaPM.RadioFrequency;
                    richTextBoxSF.Text = LoRaPM.Sf;
                }
            }
            catch (Exception err)
            {            
                //MessageBox.Show(err.Message);
            }


        }
        #endregion

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
            sp = new SerialPort();
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
                    string firstMessage = "1";
                    byte[] messaage = { 1 };
                    SendData(messaage);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

        private void Console_Connect(string COM, Int32 baud)
        {
            try
            {
               

                if (sp.IsOpen)
                {
                    sp.Close();
                    sp.Dispose();
                    label_ComportStatus.Text = "Close";
                    button_Connect.Enabled = true;
                }

                if (!sp.IsOpen)
                {

                    //設定 Serial Port 參數
                    sp.PortName = COM;
                    sp.BaudRate = baud;
                    sp.DataBits = 8;
                    sp.StopBits = StopBits.One;

                    //開啟 Serial Port
                    sp.Open();
                    button_Connect.Enabled = false;
                    label_ComportStatus.Text = "Open";

                    Console_receiving = true;

                    //開啟執行續做接收動作
                    t = new Thread(DoReceive);
                    t.IsBackground = true;
                    t.Start();

                    Thread.Sleep(100);

                }
            }
            catch (Exception ex)
            {
                
                sp.Close();
                sp.Dispose();
                label_ComportStatus.Text = "Close";
               // MessageBox.Show(ex.Message);
            }
        }

        //關閉 Console
        private void CloseComport()
        {
            try
            {
                sp.Close();
                button_Connect.Enabled = true;
                if (t != null)
                {
                    if (t.IsAlive)
                    {
                        t.Abort();
                    }
 
                }
               
                sp.Dispose();
                label_ComportStatus.Text = "Close";
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
                        if (buf.Length < 100)
                        {
                            Console.Read();
                        }
                        Array.Resize(ref buffer, length);

                        DoChart1update(buf);
                        //Display d = new Display(ConsoleShow);
                        //this.Invoke(d, new Object[] { buf });
                        //Array.Resize(ref buffer, 1024);
                    }

                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console_receiving = false;
            //關閉 Serial Port
            CloseComport();
            label_ComportStatus.Text = "Close";
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
            label_ComportStatus.Text = "Close";
        }

        public void SendData(string sendBuffer)
        {
            if (sendBuffer != null)
            {
                //Byte[] buffer = sendBuffer as Byte[];

                try
                {
                    sp.Write(sendBuffer);
                }
                catch (Exception ex)
                {
                    CloseComport();
                    label_ComportStatus.Text = "Close";
                    //MessageBox.Show(ex.Message);
                }
            }
        }
        public void SendData(byte[] sendBuffer)
        {
            if (sendBuffer != null)
            {
                //Byte[] buffer = sendBuffer as Byte[];

                try
                {
                    sp.Write(sendBuffer,0,1);
                }
                catch (Exception ex)
                {
                    CloseComport();
                    label_ComportStatus.Text = "Close";
                    //MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
