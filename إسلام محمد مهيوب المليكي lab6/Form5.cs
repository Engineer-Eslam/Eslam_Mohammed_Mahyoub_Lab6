using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    public partial class Form5 : Form
    {
        int seconds = -1, minutes = 0, hours = 0, days = 0;

        public Form5()
        {
            InitializeComponent();
            ResetButton.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetButton.Enabled = false;
            timer1.Interval = 1000;
            //timer1.Start();
            timer1.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ResetButton.Enabled = true;
            //timer1.Stop();
            timer1.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            seconds = -1;
            minutes = hours = days = 0;
            labSeconds.Text = labMinutes.Text = labHours.Text = "00";
            labDays.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            //if (seconds > 9)
            //    labSeconds.Text = seconds.ToString();
            //else
            //    labSeconds.Text = "0" + seconds.ToString();
            labSeconds.Text = (seconds < 10) ? "0" + seconds.ToString() : seconds.ToString();
            if (seconds >= 59)
            {
                seconds = 0;
                minutes++;
                //if (minutes > 9)
                //    labMinutes.Text = minutes.ToString();
                //else
                //    labMinutes.Text = "0" + minutes.ToString();
                labMinutes.Text = (minutes < 10) ? "0" + minutes.ToString() : minutes.ToString();
            }
            if (minutes >= 59)
            {
                minutes = 0;
                hours++;
                //if (hours > 9)
                //    labHours.Text = hours.ToString();
                //else
                //    labHours.Text = "0" + hours.ToString();
                labHours.Text = (hours < 10) ? "0" + hours.ToString() : hours.ToString();
            }
            if (hours >= 24)
            {
                hours = 0;
                days++;
                labDays.Text = days.ToString();
            }
        }

    }
}
