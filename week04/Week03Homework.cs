using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
            lblExpression.TextAlign = ContentAlignment.MiddleRight;
            lblNumbers.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            lblNumbers.Text = target.Text;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblExpression.Text);
            operation = "+";
            lblExpression.Text += " + ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblExpression.Text);
            operation = "-";
            lblExpression.Text += " - ";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblExpression.Text);
            operation = "*";
            lblExpression.Text += " * ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(lblExpression.Text);
            operation = "/";
            lblExpression.Text += " / ";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string expression = lblExpression.Text;
            string[] parts = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3)
            {
                double secondNumber = Convert.ToDouble(parts[2]);
                double result = 0;

                if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operation == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (operation == "*")
                {
                    result = firstNumber * secondNumber;
                }
                else if (operation == "/")
                {
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                }

                lblExpression.Text += " = " + result.ToString();
                lblNumbers.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("잘못된 입력 형식입니다.");
            }
        }

    }
}
