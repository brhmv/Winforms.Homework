using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        #region NumberButtons

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" && textBox.Text != null)
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }
        #endregion

        #region OperationsButtons
        private void btn_plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "-";
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "*";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "0";
            Operation = "/";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        #endregion

        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }
    }
}