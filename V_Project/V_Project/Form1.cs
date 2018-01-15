
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
using System.IO;
using USBHIDDRIVER;
using USBHIDDRIVER.List;
using System.Threading;

namespace V_Project

{

    public partial class Form1 : Form
    {

        USBHIDDRIVER.USBInterface usb = new USBInterface("vid_ffff", "pid_0003");   //HID thermostat

        private SerialPort myport;                                                  //Arduino port
        //private SerialPort mytermo;                                               //COM thermostat
        delegate void SetTextMainCallback(string text);                             //data from arduino  
        delegate void SetTextThermCallback(string text);                            //data from thermostat


        public Form1()
        {
            InitializeComponent();
            GetNamePort();
            GetHid();
        }

        void GetNamePort()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxSerial.Items.AddRange(ports);
            comboBoxThermo.Items.AddRange(ports);
        }

        void GetHid()
        {
            bool connect = usb.Connect();
            if (connect == true) // выводим сообщение о состоянии подключения
            {
                usb.enableUsbBufferEvent(new System.EventHandler(myEventCacher));
                textBoxRead.Text = "OK THERMO";
            }
            else
            {
             //   textBoxRead.Text = "NOT OK"; // выводим сообщение если устройство откл. (тоже для удобства)
            }
        }

        private void SetTextMain(string text)
        {

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxRead.InvokeRequired)
            {
                SetTextMainCallback d = new SetTextMainCallback(SetTextMain);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                String[] message = new String[20];                                          //split array from MK
                int checkSum;
                String unitID_in;
                String command_in;
                String data_id;
                String data_state;

                try
                {
                    message = text.Split(',');                                              //split data from serial to message array
                    checkSum = Convert.ToInt32(message[message.Length - 2]);                //checkSum,STR from MK
                   
                    if (text.Length == checkSum)// checkSum)
                    {
                        unitID_in = message[1];
                        command_in = message[2];
                        data_id = message[3];
                        data_state = message[4];                      

                        switch (command_in)
                        {
                            case "DATA":
                                textBox10L.Text = message[3];
                                textBoxVac.Text = message[4];
                                textBoxStg.Text = message[7];
                               // textBoxVlvTwo.Text = message[5];
                                //textBoxVac.Text = message[4];
                                //textBoxStg.Text = message[6];
                                break;
                            case "VLV":
                                if (data_id == "1")
                                    progressBarVlv1.Value = Convert.ToInt16(data_state);
                                else if (data_id == "2")
                                    progressBarVlv2.Value = Convert.ToInt16(data_state);
                                break;
                            case "LVL":
                                if (data_id == "1")
                                    progressBarLvl.Value = Convert.ToInt16(data_state);
                                break;
                            case "VAC":
                                if (data_id == "1")
                                    progressBarVac.Value = Convert.ToInt16(data_state);
                                break;
                        }
                    }
                    else {
                       //send retry
                    }
                       
                }
                catch
                {
                
                }
                textBoxRead.Text = text;

            }
        }

      /*  private void SetTextTherm(string text)
        {
            if (this.textBoxRead.InvokeRequired)
            {
                SetTextThermCallback d = new SetTextThermCallback(SetTextTherm);
                this.Invoke(d, new object[] { text });
            }
            else if (command_in == "ANSWERSET")
            {
                if (text.IndexOf("0x00") > 0)
                    textBoxRead.Text = "OK SEND";
            }

            textBoxRead.Text = text;
        }*/

        private void serialPortArd_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String data = myport.ReadExisting();
            while (data.IndexOf("STP") <= 0)
            {
                data = data + myport.ReadExisting();
            }

            StreamWriter file = new StreamWriter("D:\\arduino_project\\vm1500\\data\\classTest.txt", true);
            file.WriteLine(data + "," + DateTime.Now.ToString() + '\n');
            file.Close();
            SetTextMain(data);
            //recordData = data;                                                          //for timer2 record
        }

        public void myEventCacher(object sender, EventArgs e)
        {/*

            if (USBHIDDRIVER.USBInterface.usbBuffer.Count > 0)
            {
                byte[] currentRecord = new byte[64];
                int counter = 0;
                lock (USBHIDDRIVER.USBInterface.usbBuffer.SyncRoot)
                {
                    while ((byte[])USBHIDDRIVER.USBInterface.usbBuffer[counter] == null)
                    {

                        USBHIDDRIVER.USBInterface.usbBuffer.RemoveAt(0);
                    }
                    currentRecord = (byte[])USBHIDDRIVER.USBInterface.usbBuffer[0];
                    USBHIDDRIVER.USBInterface.usbBuffer.RemoveAt(0);
                }
                string text = System.Text.Encoding.ASCII.GetString(currentRecord);
                //@ использование дословных строк может убрать \n (или просто не переносить сроку)
                text = text.Replace("\0", " ").Replace("\n", "");//.Replace("0x00", "");
                command_in = "ANSWERSET";
                SetTextTherm(text);
                usb.stopRead();
            }*/
        }


       


        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxSerial.Text == ""))
                {
                    textBoxRead.Text = "Select Port";
                }

                else
                {
                    myport = new SerialPort();
                    myport.BaudRate = 115200;//9600;                     
                    myport.Parity = Parity.None;
                    myport.StopBits = StopBits.One;
                    myport.Handshake = Handshake.None;
                    myport.PortName = comboBoxSerial.Text;
                    myport.ReadTimeout = 500;                    // TIME OUT
                    myport.DataReceived += new SerialDataReceivedEventHandler(serialPortArd_DataReceived);
                    myport.Open();

                    openSerial(true);
                    progressBarState.Value = 100;

                    textBoxTermSet.Text = "25";
                    textBoxVacSet.Text = "750";
                    textBoxVlv1.Text = "0";
                    textBoxVlv2.Text = "0";
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBoxRead.Text = "Port not open";
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            myport.Close();
            openSerial(false);
            progressBarState.Value = 0;
            if (timer1.Enabled == true)
                timer1.Enabled = false;
        }

        void openSerial(bool state)
        {
            btn_close.Enabled = state;
            btn_open.Enabled = !state;
            btnVacOff.Enabled = state;
            btnVacOn.Enabled = state;
            btn_start.Enabled = state;
            btn_stop.Enabled = state;
            btn_stage.Enabled = state;
            btn_send.Enabled = state;
            btn_read.Enabled = state;
            btnVlv1On.Enabled = state;
            btnVlv1Off.Enabled = state;
            btnVlv2On.Enabled = state;
            btnVlv2Off.Enabled = state;
            btnLaserOn.Enabled = state;
            btnLaserOff.Enabled = state;
            btnTermOn.Enabled = state;
            btnTermOff.Enabled = state;
            comboBoxStage.Enabled = state;
            textBoxSend.Enabled = state;
        }

        void sendPack(String pack)
        {
            String formPack = "STR,001," + pack + ",";
            formPack +=(formPack.Length +6).ToString() + ",STP";
            myport.WriteLine(formPack);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // myport.WriteLine(textBoxSend.Text);
            sendPack(textBoxSend.Text);
             textBoxSend.Text = "";

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,BGN,1");
            sendPack("BGN,1");
            if (!timer1.Enabled == true)
                timer1.Enabled = true;
            // timer1.Enabled = true;
            // btn_next_stage.Enabled = true;
            // StreamWriter file = new StreamWriter("D:\\arduino_project\\vm1500\\data\\test.txt");
            // file.Write( "we ");
            //file.Close();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //  myport.WriteLine("001,END,1");
            sendPack("END,1");
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,GET,DATA");
            sendPack("GET,DATA");
            if (!timer1.Enabled == true)
                timer1.Enabled = true;
        }

        private void btn_stage_Click(object sender, EventArgs e)
        {
            String text = comboBoxStage.Text;
            //myport.WriteLine("001,STG," + text);
            sendPack("STG," + text);
        }
        private void btn_next_stage_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,STG,NEXT");
            sendPack("STG,NEXT");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // myport.WriteLine("001,GET,DATA");
            sendPack("GET,DATA");
        }

        private void btnTermOn_Click(object sender, EventArgs e)
        {
            usb.write(Encoding.ASCII.GetBytes(":170053-M SET.IDX WR 3"));
            usb.write(Encoding.ASCII.GetBytes(":170053-M SET.VAL WR " + textBoxTermSet.Text));
            usb.startRead();
        }

        private void btnTermOff_Click(object sender, EventArgs e)
        {
            usb.write(Encoding.ASCII.GetBytes(":170053-M SET.IDX WR 3"));
            usb.write(Encoding.ASCII.GetBytes(":170053-M SET.VAL WR 25"));
        }

        private void btnVacOn_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,VAC,1," + textBoxVacSet.Text + ",1");
            sendPack("VAC,1," + textBoxVacSet.Text + ",1");
        }

        private void btnVacOff_Click(object sender, EventArgs e)
        {
            //myport.WriteLine("001,VAC,0,750,1");
            sendPack("VAC,0,750,1");
        }

        private void btnVlv1On_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,VLV,1," + textBoxVlv1.Text + ",1");
            sendPack("VLV,1," + textBoxVlv1.Text + ",1");
        }

        private void btnVlv1Off_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,VLV,0," + textBoxVlv1.Text + ",1");
            sendPack("VLV,0," + textBoxVlv1.Text + ",1");
        }

        private void btnVlv2On_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,VLV,1," + textBoxVlv2.Text + ",2");
            sendPack("VLV,1," + textBoxVlv2.Text + ",2");
        }

        private void btnVlv2Off_Click(object sender, EventArgs e)
        {
            // myport.WriteLine("001,VLV,0," + textBoxVlv2.Text + ",2");
            sendPack("VLV,0," + textBoxVlv2.Text + ",2");
        }


        private void btnLaserOn_Click(object sender, EventArgs e)
        {
           // myport.WriteLine("001,LVL,1");
            sendPack("LVL,1");
            btnLaserOn.Enabled = false;
            btnLaserOff.Enabled = true;
        }

        private void btnLaserOff_Click(object sender, EventArgs e)
        {
            //myport.WriteLine("001,LVL,0");
            sendPack("LVL,0");
            btnLaserOn.Enabled = true;
            btnLaserOff.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                timer2.Start();
            }
            else
                timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("D:\\arduino_project\\vm1500\\data\\classTest.txt", true);
           // file.WriteLine(recordData + "," + DateTime.Now.ToString() + '\n');
            file.Close();
        }

        private void checkBoxTherm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTherm.Checked)
            {
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
            myport.Close();
            myport.Open();
        }
    }
}
