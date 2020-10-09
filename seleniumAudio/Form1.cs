using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace seleniumAudio
{
    public partial class Form1 : Form
    {
        static string url = "https://services-elementary.activebc.ru/na/";
        // string url = "https://services-elementary.activebc.ru/tasks/pserna/BOR_16ce643c1b/task_16/211.wav";
        //https://services-elementary.activebc.ru/na/pser?s=11

        selenium Driver = new selenium(url);
        private volatile bool _isRunning;

        public Form1()
        {
            InitializeComponent();


        }

        private void btnZapusk_Click(object sender, EventArgs e)
        {
            // string url = "https://services-elementary.activebc.ru/na/";
            // selenium Driver= new selenium(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string url = textBox1.Text;
            WebClient Client = new WebClient();
            try
            {
                Thread.Sleep(100);
                Client.DownloadFile(Driver.NextAudio(),
                    @"D:\prog1\Sound" + "\\" +
                    Path.GetFileName("211.wav")); // записывает все в 1 файл
                // Client.DownloadFile(Driver.NextAudio(), @"D:\prog1\Sound" + "\\" + Path.GetFileName(Driver.NextAudio()));
                Thread.Sleep(100);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Нет элемента");

            }


            clsWaveProcessor Wp = new clsWaveProcessor();
            Thread.Sleep(100);
            if (Wp.StripSilence(@"D:\prog1\Sound\211.wav") == false)
            {
                Driver.Shum();
            }
            else
            {
                Driver.ProblemNet();
            }

        }

        private void robot_Click(object sender, EventArgs e)
        {
            clsWaveProcessor Wp = new clsWaveProcessor();

            if (Wp.StripSilence(@"D:\prog1\Sound\211.wav") == false) MessageBox.Show("Шум");

        }

        private void NextBlock_Click(object sender, EventArgs e)
        {
            Driver.NextBlock();
        }

        private void curkel_Click(object sender, EventArgs e)
        {
             //   _isRunning = true;
            //(new System.Threading.Thread(delegate() { Cikl(); })).Start(); // попытка сделать поток
            Cikl();
        }

        private void stopRobot_Click(object sender, EventArgs e)
        {
           // _isRunning = false;
        }

        public void Cikl()
        {
            int skolko = Convert.ToInt32(kolCurckle.Text);

            //while (_isRunning)
            //{

            

            for (int i = 0; i < skolko; i++)
            {
                WebClient Client = new WebClient();

                Schetchik.Text = Convert.ToString(i);

                try
                {
                    Thread.Sleep(500);
                    Client.DownloadFile(Driver.NextAudio(),
                        textBox1.Text + "\\" +
                        Path.GetFileName("211.wav")); // записывает все в 1 файл

                    // Client.DownloadFile(Driver.NextAudio(), @"D:\prog1\Sound" + "\\" + Path.GetFileName(Driver.NextAudio()));

                }
                catch (Exception exception)
                {
                    // MessageBox.Show("Нет элемента");

                }

                clsWaveProcessor Wp = new clsWaveProcessor();

                if (Driver.NextBlock())
                {

                }
                else
                {
                    Thread.Sleep(1000);
                    if (Wp.StripSilence(@"D:\prog1\Sound\211.wav") == false)
                    {
                        Driver.Shum();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Driver.ProblemNet();
                    }
                }
            //}
        }
    }
    }



}
