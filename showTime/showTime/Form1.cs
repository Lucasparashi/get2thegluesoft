using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1S.Tick += timer1S_Tick;//Trigger the tick event every second
            timer1S.Start();
        }
        //this method is called every second to update the lblTime with the current time
        private void timer1S_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
