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

namespace ArduinoProject
{
    public partial class Form1 : Form
    {
        SerialPort Arduino;

        public Form1()
        {
            InitializeComponent();

            Arduino = new SerialPort();
            Arduino.PortName = "COM3";
            Arduino.BaudRate = 115200;
            timer.Interval = 20;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Arduino.Open();
            timer.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            CerrarPuerto();
        }

        void CerrarPuerto()
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
                timer.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarPuerto();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string Line = Arduino.ReadLine();
            richTextBox1.Text += Line;

            switch(Line)
            {
                case "No finger":
                    lblNofinger.Text = "Coloque su dedo en el sensor";
                    lblNofinger.Visible = true;
                    break;

                case "NO SENSOR":
                    lblNofinger.Text = "Sensor no encontrado";
                    lblNofinger.Visible = true;
                    break;

                case "BEAT":
                    lblNofinger.Visible = false;
                    break;

                default:
                    if(Line.Contains('|'))
                    {
                        string[] resultados = Line.Split('|');
                        lblBPM.Text = resultados[1];
                        lblNofinger.Visible = false;
                    }
                    break;
            }
        }
    }
}
