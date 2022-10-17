using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private double valueFirst = 0;
        private double valuesecond = 0;
        private double Result = 0;
        private string operations = "+";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox.Text=="0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text+= "1";
            }

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }

        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox.Text);
            textBox.Clear();
            operations = "+";

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox.Text);
            textBox.Clear();
            operations = "-";

        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox.Text);
            textBox.Clear();
            operations = "*";

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox.Text);
            textBox.Clear();
            operations = "/";

        }

        private void modulusButton_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(textBox.Text);
            textBox.Clear();
            operations = "%";

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length>0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            else
            {
                textBox.Text = " ";
                textBox.Text = "0";
            }

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch(operations)
            {

                case "+":
                    valuesecond =double.Parse(textBox.Text);
                    Result = valueFirst + valuesecond;
                    textBox.Text = Result.ToString();
                    break;

                case "-":
                    valuesecond = double.Parse(textBox.Text);
                    Result = valueFirst + valuesecond;
                    textBox.Text = Result.ToString();
                    break;
                case "*":
                    valuesecond = double.Parse(textBox.Text);
                    Result = valueFirst + valuesecond;
                    textBox.Text = Result.ToString();
                    break;
                case "/":
                    valuesecond = double.Parse(textBox.Text);
                    Result = valueFirst + valuesecond;
                    textBox.Text = Result.ToString();
                    break;
                case "%":
                    valuesecond = double.Parse(textBox.Text);
                    Result = valueFirst % valuesecond;
                    textBox.Text = Result.ToString();
                    break;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valuesecond = 0;
            valueFirst = 0;
            textBox.Text = "0";
        }
    }
}
