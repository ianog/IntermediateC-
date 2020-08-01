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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Set textbox background colour and set RBG text box to values
        private void setColour() {
            tbxColour.BackColor = Color.FromArgb((int)HsbRed.Value, (int)HsbGreen.Value, (int)HsbBlue.Value);
            TxtRedValue.Text = HsbRed.Value.ToString();
            TxtBlueValue.Text = HsbBlue.Value.ToString();
            TxtGreenValue.Text = HsbGreen.Value.ToString();
        }



        private void HsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            setColour();
        }

        private void HsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            setColour();
        }

        private void HsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            setColour();
        }

        private void HsbAlpha_Scroll(object sender, ScrollEventArgs e)
        {
            setColour();
        }

        private void tbxColour_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TxtRedValue_TextChanged(object sender, EventArgs e)
        {
            checkTextValue(TxtRedValue.Text, 'R');
        }

       // Check if the value of the text box is a number, if so, check if it is valid for RGB, and set value based on case. If textbox value is not a number, default to 0
        private void checkTextValue(string text, char RGB)
        {
            int value;
            if (int.TryParse(text, out value))
            {
                if (value >= 0 & value < 256)
                {
                    switch (RGB)
                    { 
                        case 'R':
                            HsbRed.Value = value;
                            break;

                        case 'G':
                            HsbGreen.Value = value;
                            break;

                        case 'B':
                            HsbBlue.Value = value;
                            break;
                        default:
                           break;
                                             
                    }
          
                    setColour();
                }
            }
            else {
                MessageBox.Show("Value should be from 0 to 255");
                switch (RGB)
                {
                    case 'R':
                        HsbRed.Value = 0;
                        break;

                    case 'G':
                        HsbGreen.Value = 0;

                        break;

                    case 'B':
                        HsbBlue.Value = 0;
                        break;
                    default:
                        break;

                }
                setColour();
            }
        }

        private void TxtRedValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtGreenValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkTextValue(TxtGreenValue.Text, 'G');
        }

        private void TxtBlueValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkTextValue(TxtBlueValue.Text, 'B');
        }

        private void TxtBlueValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
