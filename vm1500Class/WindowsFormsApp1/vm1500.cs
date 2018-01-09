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

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
       // public event SerialDataReceivedEventHandler DataReceived;
        private SerialPort myport;
        private SerialPort mytermo;
        delegate void SetTextCallback(string text);
        String[] message;
        String unitID_in;
        String command_in;
        String data_in;
        int system_state;
        enum STATE
        {
            LOCKED,
            NORMAL,
        };

        public Form1()
        {
            InitializeComponent();
            GetNamePort();
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox2.Text = text;
                
                if (command_in == "DATA")
                {
                    this.textBox10L.Text = message[2];
                    this.textBox80L.Text = message[3];
                    this.textBoxVac.Text = message[4];
                    this.textBoxStg.Text = message[7];
                    
                }

                else if (command_in == "SET")
                {
                    this.mytermo.Write(data_in + "\r"); //Без переноса каретки не работает
                }

                else if  (command_in == "VAC")
                {
                    this.progressBarVac.Value = Convert.ToInt16(data_in);
                }

                else if (command_in == "TERM")
                {

                    this.progressBarTerm.Value = Convert.ToInt16(data_in);
                }

                else if (command_in == "PUMPL")
                {

                    this.progressBarPumpL.Value = Convert.ToInt16(data_in);
                }

                else if (command_in == "PUMPR")
                {

                    this.progressBarPumpR.Value = Convert.ToInt16(data_in);
                }

            }
            system_state = (int)STATE.NORMAL;
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            system_state = (int)STATE.LOCKED;

            String data = myport.ReadExisting();
            while (data.IndexOf("SBIT")<=0)
            {
                data = data + myport.ReadExisting();
            }
                //System.Threading.Thread.Sleep(50);

            //data = data + myport.ReadExisting();
            StreamWriter file = new StreamWriter("D:\\arduino_project\\vm1500\\data\\" + DateTime.Now.ToString().Substring(0, 5) + ".txt", true);
            file.WriteLine(data +","+ DateTime.Now.ToString());
            file.Close();
            message = data.Split(',');
            unitID_in = message[0];
            command_in = message[1];
            data_in = message[2];
            if (command_in == "DATA"&& unitID_in=="001")
            {

            }
                SetText(data);
        }
        void GetNamePort()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,STAGE,STAGE1");
            timer1.Enabled = true;
            // StreamWriter file = new StreamWriter("D:\\arduino_project\\vm1500\\data\\test.txt");
            // file.Write( "we ");
            //file.Close();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,STOP,");
        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    textBox2.Text = "Select Port";
                }
                else {
                    mytermo = new SerialPort();
                    myport = new SerialPort();
                    

                    myport.BaudRate = 9600;
                    mytermo.BaudRate = 9600;

                    myport.Parity = Parity.None;
                    mytermo.Parity = Parity.None;

                    myport.StopBits = StopBits.One;
                    mytermo.StopBits = StopBits.One;

                    myport.Handshake = Handshake.None;
                    mytermo.Handshake = Handshake.None;

                    myport.PortName = comboBox1.Text;
                    mytermo.PortName = "COM7";

                    myport.ReadTimeout = 500;       // TIME OUT
                   

                    myport.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    mytermo.Open();
                    myport.Open();
                    

                    progressBar1.Value = 100;
                    btnTermOff.Enabled = true;
                    btnTermOn.Enabled = true;
                    btnVacOff.Enabled = true;
                    btnVacOn.Enabled = true;
                    btn_start.Enabled = true;
                    btn_stop.Enabled = true;
                    btn_stage.Enabled = true;
                    btn_close.Enabled = true;
                    btn_open.Enabled = false;
                    btn_send.Enabled = true;
                    btn_read.Enabled = true;

                    comboBox2.Enabled = true;
                    textBox1.Enabled = true;
                    textBoxTermSet.Text = "25";
                    textBoxVacSet.Text = "750";
                    textBoxPumpL.Text = "300";
                    textBoxPumpR.Text = "300";

                }


            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "Wrong";
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            myport.Close();
            mytermo.Close();
            progressBar1.Value = 0;
            timer1.Enabled = false;
            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            btn_stage.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = true;
            btn_send.Enabled = false;
            btnTermOff.Enabled = false;
            btnTermOn.Enabled = false;
            btnVacOff.Enabled = false;
            btnVacOn.Enabled = false;
            btn_read.Enabled = false;

            comboBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            myport.WriteLine(textBox1.Text);
            textBox1.Text = "";

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,GET,DATA");
           /* try
            {
                textBox2.Text = myport.ReadLine();
            }

            catch(TimeoutException)
            {
                textBox2.Text = "TIME OUT";

            }*/
        }

       

        private void btn_stage_Click(object sender, EventArgs e)
        {
            String text = comboBox2.Text;
            myport.WriteLine("001,STAGE,"+text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (system_state != (int)STATE.LOCKED)
                myport.WriteLine("001,GET,DATA");

            else
            {
                  System.Threading.Thread.Sleep(100);
                  myport.WriteLine("001,GET,DATA");
            }
        }

        private void btnTermOn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,TERMON,"+textBoxTermSet.Text);
         
        }

        private void btnTermOff_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,TERMOFF,25" );
        }

        private void btnVacOn_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,VACON," + textBoxVacSet.Text);
        }

        private void btnVacOff_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,VACOFF,750");
        }

        private void btnPumpLon_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,PUMPONL," + textBoxPumpL);
        }

        private void btnPumpLoff_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,PUMPOFFL," + textBoxPumpL);
        }

        private void btnPumpRon_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,PUMPONR," + textBoxPumpR);
        }

        private void btnPumpRoff_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,PUMPOFFR," + textBoxPumpR);
        }
    }
}
