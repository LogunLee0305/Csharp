using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace receiveTemp
{
    public partial class Form1 : Form
    {
        SerialPort SP;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SerialPort 초기 설정
            SP = new SerialPort();
            SP.DataReceived += new SerialDataReceivedEventHandler(SP_DataReceived);

            SP.PortName = "COM5";
            SP.BaudRate = 9600;
            SP.Parity = Parity.None;
            SP.StopBits = StopBits.One;
            SP.Open();
            //SP.ReadTimeout = (int)100;
            //SP.WriteTimeout = (int)100;
        }


        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (SP.IsOpen)
            {
                string c = "℃";
                string str = SP.ReadLine();
                this.label2.Text = str + c;
            }
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SP.Close();
        }

    }
}
