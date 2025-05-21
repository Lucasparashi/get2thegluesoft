using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Display "Hello World!" when the BTN is clicked.
        private void btnHW_Click(object sender, EventArgs e)
        {
            labelHW.Visible = true;
            labelHW.Text = "Hello World!";
        }
    }
}
