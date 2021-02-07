using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbInput.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbInput.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbInput.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbInput.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbInput.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbInput.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbInput.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbInput.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbInput.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbInput.Text += 0;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            tbInput.Text += '.';
        }
        double result;
        char sign = Char.MinValue;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            UseSign('+');
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            UseSign('-');
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            UseSign('*');
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
                UseSign('/');
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            tbInput.PlaceholderText = result.ToString();
            tbInput.Text = "";
            result = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbInput.PlaceholderText = "";
            result = 0;
            sign = Char.MinValue;

        }
        private void UseSign(char ch) 
        {
            if (sign == Char.MinValue)
            {
                result = Double.Parse(tbInput.Text);
                sign = ch;
                tbInput.Text = "";
            }
            else
            {
                Calculate();
                sign = ch;
                tbInput.PlaceholderText = result.ToString();
                tbInput.Text = "";

            }
        }

        private void Calculate() 
        {
            switch (sign)
            {
                case '+':
                    result += Double.Parse(tbInput.Text);
                    break;
                case '-':
                    result -= Double.Parse(tbInput.Text);
                    break;
                case '*':
                    result *= Double.Parse(tbInput.Text);
                    break;
                case '/':
                    result /= Double.Parse(tbInput.Text);
                    break;
                default:
                    break;
            }
        }

    }
}
