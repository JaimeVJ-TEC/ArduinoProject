﻿using System;
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
using System.Timers;

namespace ArduinoProject
{
    public partial class Form1 : Form
    {
        SerialPort Arduino;
        bool takingBPM = false;
        bool showLoad = true;
        bool fine = false;
        int AverageBPM = 0;
        int AvgAux = 0;
        int AvgCount = 0;
        Thread thread;

        public Form1()
        {
            InitializeComponent();

            Arduino = new SerialPort();
            Arduino.PortName = "COM3";
            Arduino.BaudRate = 115200;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            Arduino.Open();
            thread = new Thread(Read);
            thread.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            picDedo.Visible = false;
            lblNofinger.Visible = false;
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
            CerrarPuerto();
        }

        void CerrarPuerto()
        {
            if (!(thread is null))
            {
                try
                {
                    thread.Abort();
                }
                catch(Exception)
                {

                }
            }
            try
            {
                if (Arduino.IsOpen)
                    Arduino.Close();
            }
            catch(Exception)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarPuerto();
        }

        void Read()
        {
            while (true)
            {
                string Line = Arduino.ReadLine();
                Console.WriteLine(Line);
                if(Line.Contains("No finger"))
                {
                    picLoad.Invoke(new Action(() => picLoad.Visible = false));
                    picDedo.Invoke(new Action(() => picDedo.Visible = true));
                    lblNofinger.Invoke(new Action(() => lblNofinger.Visible = true));
                    picFine.Invoke(new Action(() => picFine.Visible = false));
                    lblFine.Invoke(new Action(() => lblFine.Visible = false));
                    picWarning.Invoke(new Action(() => picWarning.Visible = false));
                    lblWarning.Invoke(new Action(() => lblWarning.Visible = false));
                }
                else if (Line.Contains("BEAT"))
                {
                    PlayAnim();
                }
                else if(Line.Contains('|'))
                {
                    string[] resultados = Line.Split('|');
                    if(showLoad)
                        picLoad.Invoke(new Action(() => picLoad.Visible = true));
                    else
                        picLoad.Invoke(new Action(() => picLoad.Visible = false));

                    AvgAux += int.Parse(resultados[1]);
                    AvgCount++;
                    Console.WriteLine(AvgAux);
                    Console.WriteLine(AvgCount);

                    if(!takingBPM)
                        GetAvg();

                    if(AverageBPM > 100)
                    {
                        picWarning.Invoke(new Action(() => picWarning.Visible = true));
                        lblWarning.Invoke(new Action(() => lblWarning.Visible = true));
                        picFine.Invoke(new Action(() => picFine.Visible = false));
                        lblFine.Invoke(new Action(() => lblFine.Visible = false));
                    }
                    else if (!showLoad)
                    {
                        picFine.Invoke(new Action(() => picFine.Visible = true));
                        lblFine.Invoke(new Action(() => lblFine.Visible = true));
                        picWarning.Invoke(new Action(() => picWarning.Visible = false));
                        lblWarning.Invoke(new Action(() => lblWarning.Visible = false));
                    }
                    //lblBPM.Invoke(new Action(() => lblBPM.Text = resultados[1]+" bpm"));
                    picDedo.Invoke(new Action(() => picDedo.Visible = false));
                    lblNofinger.Invoke(new Action(() => lblNofinger.Visible = false));
                }
            }
        }

        void PlayAnim()
        {
            System.Timers.Timer T = new System.Timers.Timer();
            T.Interval = 250;
            T.AutoReset = false;
            T.Elapsed += new ElapsedEventHandler(TimerElapsed);
            T.Start();
            picHeart.Invoke(new Action(() => picHeart.Size = new Size(92,76)));
        }

        void GetAvg()
        {
            System.Timers.Timer T = new System.Timers.Timer();
            T.Interval = 10000;
            T.AutoReset = false;
            T.Elapsed += new ElapsedEventHandler(TimerAvgElapsed);
            takingBPM = true;
            T.Start();
        }

        void TimerAvgElapsed(object sender, ElapsedEventArgs e)
        {
            var Timer = (System.Timers.Timer)sender;
            AverageBPM = AvgCount == 0 ? AvgAux / 1 : AvgAux / AvgCount;
            lblBPM.Invoke(new Action(() => lblBPM.Text = AverageBPM + " bpm"));
            showLoad = false;
            AvgAux = 0;
            AvgCount = 0;
            takingBPM = false;
            try
            {
                Timer.Dispose();
            }
            catch(Exception)
            {

            }
        }

        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            picHeart.Invoke(new Action(() => picHeart.Size = new Size(80, 66)));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
