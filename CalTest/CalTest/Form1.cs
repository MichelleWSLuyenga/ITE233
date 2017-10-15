using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalTest
{
    public partial class Form1 : Form
    {
        String input = String.Empty;
        String operand1 = String.Empty;
        String operand2 = String.Empty;
        char operation;
        double result = 0.0;
        Boolean fl = false;


        public Form1()
        {
            InitializeComponent();
        }
        // 1
        private void One_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = ""; 
            input += "1";
            this.textBox1.Text += input;
            fl = false;
        }
        // 2
        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
            fl = false;
        }
        // 3
        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
            fl = false;
        }
        // 4
        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
            fl = false;
        }
        // 5
        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
            fl = false;
        }
        // 6
        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
            fl = false;
        }
        // 7
        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
            fl = false;
        }
        // 8
        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
            fl = false;
        }
        // 9
        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
            fl = false;
        }
        // 0
        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
            fl = false;
        }
        // .
        private void period_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
            fl = false;
        }
        // /
        private void division_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = String.Empty;
        }
        // *
        private void multiplication_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = String.Empty;
        }
        // +
        private void addition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = String.Empty;
        }
        // - 
        private void substraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = String.Empty;
        }
        // =
        private void equalTo_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            if(operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
               
            }
            else if(operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if(operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if(operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            fl = true;

          //  num1 = textBox1.Text;
        }
        // C
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            input = String.Empty;
        }


    }
}
