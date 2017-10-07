/* Testes Manuel Robalinho
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char   operation;
        double topr1;
        char  oldOper = Convert.ToChar("+");

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        txtInput.Text += "1";
                        break;
                    case "btnTwo":
                        txtInput.Text += "2";
                        break;
                    case "btnThree":
                        txtInput.Text += "3";
                        break;
                    case "btnFour":
                        txtInput.Text += "4";
                        break;
                    case "btnFive":
                        txtInput.Text += "5";
                        break;
                    case "btnSix":
                        txtInput.Text += "6";
                        break;
                    case "btnSeven":
                        txtInput.Text += "7";
                        break;
                    case "btnEight":
                        txtInput.Text += "8";
                        break;
                    case "btnNine":
                        txtInput.Text += "9";
                        break;
                    case "btnZero":
                        txtInput.Text += "0";
                        break;
                    case "btnDot":
                        if(!txtInput.Text.Contains("."))
                            txtInput.Text += ".";
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                //case '+':
                //case '-':
                //case '*':
                //case '/':
                //case '.':
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }           
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double opr1;  // MRobalinho
            operand1 = txtInput.Text; 
            double.TryParse(operand1, out opr1);  // MRobalinho
            operation = '+';
            txtInput.Text = string.Empty;
            textTot.Text = textTot.Text + oldOper + operand1;   // MRobalinho

            if (oldOper == Convert.ToChar("+"))
            {
     //           Console.WriteLine("Antes: " + Convert.ToString(topr1) + "   Valor " + Convert.ToString(opr1));
                topr1 = topr1 + opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("-"))
            {
              topr1 = topr1 - opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("*"))
            {
              topr1 = topr1 * opr1;  // MRobalinho
            }
            else  
            {
              topr1 = topr1 / opr1;  // MRobalinho
            }
          
            oldOper = operation;
            textParc.Text = Convert.ToString(topr1); // MRobalinho
            Console.WriteLine("Soma - Antes: " + Convert.ToString(topr1)+ "   Valor " + Convert.ToString(opr1));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double opr1;  // MRobalinho
            operand1 = txtInput.Text;
            double.TryParse(operand1, out opr1);  // MRobalinho

            operation = '-';
            txtInput.Text = string.Empty;
            textTot.Text = textTot.Text + oldOper + operand1;   // MRobalinho
            if (oldOper == Convert.ToChar("+"))
            {
                topr1 = topr1 + opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("-"))
            {
                topr1 = topr1 - opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("*"))
            {
                topr1 = topr1 * opr1;  // MRobalinho
            }
            else
            {
                topr1 = topr1 / opr1;  // MRobalinho
            }
            oldOper = operation;
            textParc.Text = Convert.ToString(topr1);  // MRobalinho
        }
    
        private void btnMulitply_Click(object sender, EventArgs e)
        {
            double opr1;  // MRobalinho
            operand1 = txtInput.Text;
            double.TryParse(operand1, out opr1);  // MRobalinho
    
            operation = '*';
            txtInput.Text = string.Empty;
            textTot.Text = textTot.Text + oldOper + operand1;   // MRobalinho
            if (oldOper == Convert.ToChar("+"))
            {
                topr1 = topr1 + opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("-"))
            {
                topr1 = topr1 - opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("*"))
            {
                topr1 = topr1 * opr1;  // MRobalinho
            }
            else
            {
                topr1 = topr1 / opr1;  // MRobalinho
            }
            oldOper = operation;
            textParc.Text = Convert.ToString(topr1);  // MRobalinho
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double opr1;  // MRobalinho
            operand1 = txtInput.Text;
            double.TryParse(operand1, out opr1);  // MRobalinho
   
            operation = '/';
            txtInput.Text = string.Empty;
            textTot.Text = textTot.Text + oldOper + operand1;   // MRobalinho
            if (oldOper == Convert.ToChar("+"))
            {
                topr1 = topr1 + opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("-"))
            {
                topr1 = topr1 - opr1;  // MRobalinho
            }
            else if (oldOper == Convert.ToChar("*"))
            {
                topr1 = topr1 * opr1;  // MRobalinho
            }
            else
            {
                topr1 = topr1 / opr1;  // MRobalinho
            }
            oldOper = operation;
            textParc.Text = Convert.ToString(topr1); // MRobalinho
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = txtInput.Text;
            textTot.Text = textTot.Text + oldOper + operand2 + "=";  // MRobalinho

            double opr1, opr2;
            //          double.TryParse(operand1, out opr1);
            opr1 = topr1;  // MRobalinho
            double.TryParse(operand2, out opr2);

            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
            }

            txtInput.Text = result.ToString();
            textParc.Text = Convert.ToString(result); // MRobalinho
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            textTot.Text = string.Empty;  // MRobalinho
            textParc.Text = string.Empty;  // MRobalinho
            oldOper = Convert.ToChar("+");  // MRobalinho
            topr1 = 0;
        }

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            double opr1;
     
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnByTwo_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 2).ToString();
              }
        }

        private void btnByFour_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 4).ToString();
            }
        }

        private void textTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
