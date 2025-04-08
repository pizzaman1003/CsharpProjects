using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "5";
            this.output.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "7";
            this.output.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "8";
            this.output.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "9";
            this.output.Text += input;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "4";
            this.output.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "6";
            this.output.Text += input;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "1";
            this.output.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "2";
            this.output.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "3";
            this.output.Text += input;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "0";
            this.output.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += ".";
            this.output.Text += input;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation =='+')
            {
                result = num1 + num2;
                output.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                output.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                output.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {result = num1 / num2;
                    output.Text = result.ToString();
                }
                else
                {
                    output.Text = "DIV/Zero!";
                }
            }
        }
    }
}
