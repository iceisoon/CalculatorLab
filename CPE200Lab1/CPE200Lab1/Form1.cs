using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float firstnumber;
        float secondnumber;
        float result;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        int foo;
       
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains(".") == false)
            {
                if (lblDisplay.Text.Length < 8)
                {
                    if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                    {
                        lblDisplay.Text = ((Button)sender).Text;
                    }
                    else
                    {
                        lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                    }
                }
            }
            if(lblDisplay.Text.Contains(".") == true)
            {
                if(lblDisplay.Text.Length <9)
                {
                    if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                    {
                        lblDisplay.Text = ((Button)sender).Text;
                    }
                    else
                    {
                        lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                    }
                }
            }
        }
        
        private void btnDot_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Contains (".") == false)
            {
                lblDisplay.Text = lblDisplay.Text + ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
            lblDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Length != 1)
            {
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
            }
            else
            {
                lblDisplay.Text = "0";
            }
            
        }

        private void bitPercent_Click(object sender, EventArgs e)
        {
            float a;
            a = float.Parse(lblDisplay.Text);
            a = (a / 100) * firstnumber;
            if(operation == "+" )
            {
                result = firstnumber + a;
            }
            if(operation == "-" )
            {
                result = firstnumber - a;
            }
            lblDisplay.Text = Convert.ToString(result);

        }
        
        private void btnOperator_Click(object sender, EventArgs e)
        {
            firstnumber = float.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = ((Button)sender).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondnumber = float.Parse(lblDisplay.Text);
            if(operation == "+")
            {
                result = (firstnumber + secondnumber);
                lblDisplay.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if(operation == "-")
            {
                result = (firstnumber - secondnumber);
                lblDisplay.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "X")
            {
                result = (firstnumber * secondnumber);
                lblDisplay.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if(operation == "÷")
            {
                if(secondnumber == 0)
                {
                    lblDisplay.Text = "Error";
                }
                else
                {
                    result = (firstnumber / secondnumber);
                    lblDisplay.Text = Convert.ToString(result);
                    firstnumber = result;
                }
            }
            if (lblDisplay.Text.Length > 9 && lblDisplay.Text.Contains('.') == true)
            {
                lblDisplay.Text = "Error";
            }
            if (lblDisplay.Text.Length > 8 && lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text = "Error";
            }
        }
               
   

    }
}
