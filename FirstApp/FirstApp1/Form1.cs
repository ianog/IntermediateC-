using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonHappy_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = true;
            picSad.Visible = false;
        }

        private void radioButtonSad_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = false;
            picSad.Visible = true;
        }
    }
}
