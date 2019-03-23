using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9.GUI
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        bool isSecondNumber;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
            isSecondNumber = false;
        }

        public void AddDigit(String digit)
        {
            if (display.Text.Equals("0") || isSecondNumber)
                display.Text = digit;
            else
                display.Text += digit;

            isSecondNumber = false;
        }

        public void ChooseOperation(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "+":
                    calculator.OperationCode = 1;
                    break;
                case "-":
                    calculator.OperationCode = 2;
                    break;
                case "*":
                    calculator.OperationCode = 3;
                    break;
                case "/":
                    calculator.OperationCode = 4;
                    break;
                default:
                    break;
            }

            calculator.Number1 = Convert.ToDouble(display.Text);
            this.isSecondNumber = true;

        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            AddDigit(((Button)sender).Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(display.Text) * (-1);
            display.Text = number.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
                display.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculator.Number2 = Convert.ToDouble(display.Text);
            calculator.Calculate();
            display.Text = calculator.Result;
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            calculator.Memory = 0;
            labelMemory.Visible = false;
        }

        private void buttonMemoryRead_Click(object sender, EventArgs e)
        {
            display.Text = calculator.Memory.ToString();
        }

        private void buttonMemoryPlus_Click(object sender, EventArgs e)
        {
            calculator.Memory += Convert.ToDouble(display.Text);
            isSecondNumber = true;
            if (calculator.Memory != 0)
                labelMemory.Visible = true;
            else
                labelMemory.Visible = false;
        }

        private void buttonMemoryMinus_Click(object sender, EventArgs e)
        {
            calculator.Memory -= Convert.ToDouble(display.Text);
            isSecondNumber = true;
            if (calculator.Memory != 0)
                labelMemory.Visible = true;
            else
                labelMemory.Visible = false;
        }
    }
}
