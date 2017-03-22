using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public static Calculator calculator;
        public int cnt;
        public int cnt1 = 0;
        public int cnt2 = 0;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (calculator.operation == Calculator.Operation.NONE ||
                calculator.operation == Calculator.Operation.NUMBER)
            {
                display.Text += btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.PLUS)
            {
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
                cnt = 1;
            }
            else if (calculator.operation == Calculator.Operation.MINUS)
            {
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
                cnt = 2;
            }
            else if (calculator.operation == Calculator.Operation.MULT)
            {
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
                cnt = 3;
            }
            else if (calculator.operation == Calculator.Operation.DIV)
            {
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
                cnt = 4;
            }
            calculator.operation = Calculator.Operation.NUMBER;
        }

        private void button12_Click(object sender, EventArgs e) // вывод результата после функций
        {
            if (cnt2 == 0)
                calculator.saveSecondNumber(display.Text);
            else
                calculator.saveFirstNumber(display.Text);
            switch (cnt)
            {
                case 1:
                    display.Text = calculator.getResultPlus().ToString();
                    calculator.firstNumber = calculator.getResultPlus();
                    cnt2++;
                    break;
                case 2:
                    display.Text = calculator.getResultMinus().ToString();
                    calculator.firstNumber = calculator.getResultMinus();
                    cnt2++;
                    break;
                case 3:
                    display.Text = calculator.getResultMult().ToString();
                    calculator.firstNumber = calculator.getResultMult();
                    cnt2++;
                    break;
                case 4:
                    display.Text = calculator.getResultDiv().ToString();
                    calculator.firstNumber = calculator.getResultDiv();
                    cnt2++;
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e) // plus
        {
            calculator.operation = Calculator.Operation.PLUS;
        }

        private void button13_Click(object sender, EventArgs e) // minus
        {
            calculator.operation = Calculator.Operation.MINUS;
        }

        private void button14_Click(object sender, EventArgs e) // division
        {
            calculator.operation = Calculator.Operation.DIV;
        }

        private void button15_Click(object sender, EventArgs e) // multiplication
        {
            calculator.operation = Calculator.Operation.MULT;
        }

        private void button16_Click(object sender, EventArgs e) // C
        {
            int lenght = display.Text.Length - 1;
            string text = display.Text;
            display.Clear();
            for (int i = 0; i < lenght; i++)
            {
                display.Text = display.Text + text[i];
            }
        }

        private void button17_Click(object sender, EventArgs e) // CE
        {
            display.Text = "";
            display.Focus();
        }

        private void button18_Click(object sender, EventArgs e) // percent
        {
            calculator.operation = Calculator.Operation.PERS;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getResultPer().ToString();
        }

        private void button19_Click(object sender, EventArgs e) // sqrt
        {
            calculator.operation = Calculator.Operation.SQRT;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getResultSqrt().ToString();
        }

        private void button20_Click(object sender, EventArgs e) // square
        {
            calculator.operation = Calculator.Operation.SQR;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getResultSqr().ToString();
        }

        private void button21_Click(object sender, EventArgs e) // complex
        {
            calculator.operation = Calculator.Operation.COMP;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getResultComp().ToString();
        }

        private void button26_Click(object sender, EventArgs e) // memory save
        {
            calculator.memoryNumber += double.Parse(display.Text);
            display.Clear();
        }

        private void button23_Click(object sender, EventArgs e) // memory return
        {
                display.Text = calculator.memoryNumber.ToString();
        }

        private void button22_Click(object sender, EventArgs e) // memory clear
        {
            calculator.memoryNumber = 0;
        }

        private void button24_Click(object sender, EventArgs e) // memory plus
        {
            calculator.operation = Calculator.Operation.MPLUS;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getMemoryPlus().ToString();
        }

        private void button25_Click(object sender, EventArgs e) // memory minus
        {
            calculator.operation = Calculator.Operation.MMINUS;
            calculator.saveFirstNumber(display.Text);
            display.Text = calculator.getMemoryMinus().ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (cnt1 == 0)
            {
                display.Text += ",";
                cnt1 = 1;
            }
            else { }
        }

        private void button28_Click(object sender, EventArgs e) // +/-
        {
            calculator.saveFirstNumber(display.Text);
            if (calculator.firstNumber > 0)
            {
                (display.Text) = (0 - calculator.firstNumber).ToString();
            }
            else
            {
                display.Text = Math.Abs(calculator.firstNumber).ToString(); 
            }
        }

    }
}
