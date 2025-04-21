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
    public partial class FormMain : Form
    {
        string currentOperator = "";
        string firstOperand = "";
        bool isOperatorClicked = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button target = (sender as Button);

            if (target != null) {
                if (isOperatorClicked) {
                    lblNumbers.Text = "";
                    isOperatorClicked = false;
                }

                if (lblNumbers.Text == "0") {
                    lblNumbers.Text = target.Text;
                } else {
                    lblNumbers.Text += target.Text;
                }
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button target = (sender as Button);
            if (target != null) {
                if (!string.IsNullOrEmpty(currentOperator)) {
                    btnCal_Click(sender, EventArgs.Empty);
                }
                firstOperand = lblNumbers.Text;
                currentOperator = target.Text;
                lblExpression.Text = firstOperand + " " + currentOperator;
                isOperatorClicked = true;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperator) || string.IsNullOrEmpty(firstOperand)) {
                return;
            }

            int opr1 = int.Parse(firstOperand);
            int opr2 = int.Parse(lblNumbers.Text);
            int result;

            switch (currentOperator) {
                case "+":
                    result = opr1 + opr2;
                    break;
                case "-":
                    result = opr1 - opr2;
                    break;
                case "*":
                    result = opr1 * opr2;
                    break;
                case "/":
                    if (opr2 == 0) {
                        MessageBox.Show("연산수행 불가");
                        return;
                    }
                    result = opr1 / opr2;
                    break;
                default:
                    return;
            }
            lblExpression.Text = firstOperand + " " + currentOperator + " " + lblNumbers.Text + " = " + result;
            lblNumbers.Text = result.ToString();
            currentOperator = "";
            firstOperand = "";
        }
    }
}
