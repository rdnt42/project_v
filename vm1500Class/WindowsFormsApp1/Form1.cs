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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,START");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            myport.WriteLine("001,STOP");
        }

        private void init()
        {
            myport = new SerialPort();
            myport.BaudRate(9600);
            myport.PortName = "COM4";
            myport.Open();
        }


    }
}
