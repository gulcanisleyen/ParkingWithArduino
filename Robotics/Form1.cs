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

namespace Robotics
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            Control.CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
            try
            {
                serialPort.PortName = "COM7";
                if (!serialPort.IsOpen)
                    serialPort.Open();
            }
              
            catch (Exception ex)
            {
                
            }
            serialPort.DataReceived += serialPort_DataReceived;
        }





        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
                string oku = serialPort.ReadLine();
                string[] mesafe = oku.Split(',');
            text1.Text = mesafe[0] + " cm";
            text2.Text = mesafe[1] + " cm";
            mesafeOn(int.Parse(mesafe[0]));
                mesafeArka(int.Parse(mesafe[1]));
                System.Threading.Thread.Sleep(10);
            }
            


        private void mesafeOn(int mesafe)
        {


            if (mesafe > 20 && mesafe < 30)
            {
                
                Onyesil.Visible = true;
                Onsarı.Visible = false;
                Onkırmızı.Visible = false;
                led1.Visible = true;
                led2.Visible = false;
                led3.Visible = false;
                solisaretci1.Visible = true;
                solisaretci2.Visible = false;
                solisaretci3.Visible = false;
            }
            if (mesafe > 10 && mesafe < 19)
            {
                Onsarı.Visible = true;
                Onyesil.Visible = false;
                Onkırmızı.Visible = false;
                led1.Visible = false;
                led2.Visible = true;
                led3.Visible = false;
                solisaretci1.Visible = false;
                solisaretci2.Visible = true;
                solisaretci3.Visible = false;

            }
            if (mesafe > 0 && mesafe < 9)
            {
                Onkırmızı.Visible = true;
                Onyesil.Visible = false;
                Onsarı.Visible = false;
                led1.Visible = false;
                led2.Visible = false;
                led3.Visible = true;
                solisaretci1.Visible = false;
                solisaretci2.Visible = false;
                solisaretci3.Visible = true;
            }

        }


        private void mesafeArka(int mesafe)
        {


            if (mesafe > 20 && mesafe < 30)
            {
                Onyesil.Visible = true;
                Onsarı.Visible = false;
                Onkırmızı.Visible = false;
                led4.Visible = true;
                led5.Visible = false;
                led6.Visible = false;
                sagisaretci1.Visible = true;
                sagisaretci2.Visible = false;
                sagisaretci3.Visible = false;
            }
            if (mesafe > 10 && mesafe < 19)
            {
                Onsarı.Visible = true;
                Onyesil.Visible = false;
                Onkırmızı.Visible = false;
                led4.Visible = false;
                led5.Visible = true;
                led6.Visible = false;
                sagisaretci1.Visible = false;
                sagisaretci2.Visible = true;
                sagisaretci3.Visible = false;
            }
            if (mesafe > 0 && mesafe < 9)
            {
                Arkakırmızı.Visible = true;
                Onyesil.Visible = false;
                Onsarı.Visible = false;
                led4.Visible = false;
                led5.Visible = false;
                led6.Visible = true;
                sagisaretci1.Visible = false;
                sagisaretci2.Visible = false;
                sagisaretci3.Visible = true;
            }

        }

        private void sarı_Click(object sender, EventArgs e)
        {

        }

        private void kırmızı_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void led5_Click(object sender, EventArgs e)
        {

        }
    }
}
    