using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_FirstApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            Button b = null;//empty reference (null)
            Button bb = null;

            b = new Button();
            bb = b;
            bb.Text = "AA";

            if (b==null)
            {
                MessageBox.Show("b==null " + b.Text);
            }
            else
            {
                MessageBox.Show("b!=null " + b.Text);
            }
            */



        }

        /*
        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            //OK
            //String tmp = textBoxLeft.Text;
            //textBoxLeft.Text = textBoxRight.Text;
            //textBoxRight.Text = tmp;

            //OK
            //Point tmp = textBoxLeft.Location;
            //textBoxLeft.Location = textBoxRight.Location;
            //textBoxRight.Location = tmp;

            //BAD WAY = references!!!
            //TextBox tmp = textBoxLeft;
            //textBoxLeft = textBoxRight;
            //textBoxRight = tmp;
        }
        */

        private void Calculate()
        {
            Decimal left;
            Decimal right;
            //left = Decimal.Parse(textBoxLeft.Text);
            //right = Convert.ToDecimal(textBoxRight.Text);
            if(Decimal.TryParse(textBoxLeft.Text, out left) &&
               Decimal.TryParse(textBoxRight.Text, out right))
            {
                textBoxCalculateValue.Text = (left + right).ToString();
                textBoxCalculateValue.Text = (left + right).ToString();
            }
            else
            {
                textBoxCalculateValue.Text = "Wrong values!";
            }
        }

        private void TextBoxRight_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void TextBoxLeft_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
