using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountTo10
{
    public partial class Form1 : Form
    {
        int currentCount = 0;

        public Form1()
        {
            InitializeComponent();

            //Setting tmer defaut & event
            timerCount.Interval = 1000;
            timerCount.Tick += TimerCount_Tick; // Event trigger when timer ticks
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            currentCount = 0; // Reset to 0
            lblCount.Text = currentCount.ToString(); // Update label to show 0

            int speed = (int)numSpeed.Value; // Get the speed from input
            int baseInterval = 1000;
            timerCount.Interval = baseInterval / speed; // Adjust the timer speed
            timerCount.Start();
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            currentCount++;
            lblCount.Text = currentCount.ToString(); // Update label to show the current count
            // Stop when count to 10
            if (currentCount >= 10) 
            {
                timerCount.Stop();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
