using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyException : ApplicationException
        {
            public string ErrorMessage = "";
            public MyException(string str)
                : base(str)
            {
                ErrorMessage = str;
            }
        }

        string number1 = "";
        string Operator = "";
        enum Errors {divZero, Tan, Sqrt, Ln, Sint, NoNum, Factor}; 

        void SyntaxErr(Errors error) 
        {
            string[] err = {
                           "Деление на 0!",
                           "Такого значения тангенса не существует!",
                           "Корень из отрицательного числа!",
                           "Натуральный логарифм от неположительного числа!",
                           "Синтаксическая ошибка!",
                           "Нет значения!",
                           "Факториал отрицательного числа!"
                          };
           throw new MyException (err[error.GetHashCode()]);
        }

        void EnableButtons(bool en) 
        {
            _Add.Enabled = en;
            _Mult.Enabled = en;
            _Div.Enabled = en;
            _Sub.Enabled = en;
        }

        private void _One_Click(object sender, EventArgs e)
        {
            Input.Text += '1';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length; 
        }

        private void _Two_Click(object sender, EventArgs e)
        {
            Input.Text += '2';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Three_Click(object sender, EventArgs e)
        {
            Input.Text += '3';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Four_Click(object sender, EventArgs e)
        {
            Input.Text += '4';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Five_Click(object sender, EventArgs e)
        {
            Input.Text += '5';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Six_Click(object sender, EventArgs e)
        {
            Input.Text += '6';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Seven_Click(object sender, EventArgs e)
        {
            Input.Text += '7';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Eight_Click(object sender, EventArgs e)
        {
            Input.Text += '8';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Nine_Click(object sender, EventArgs e)
        {
            Input.Text += '9';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Zero_Click(object sender, EventArgs e)
        {
            Input.Text += '0';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length; 
        }

        private void _Calculate_Click(object sender, EventArgs e)
        {
            Calculate();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        void Calculate() 
        {
            double c;
            if (Input.Text == "")
            {
                Input.Text = "0";
            }
            if (!(Double.TryParse(Input.Text, out c)))
            {
                SyntaxErr(Errors.Sint); 
                return;
            }
            if (number1 == "")
            {
                SyntaxErr(Errors.NoNum);
                return;
            }
            if (!(Double.TryParse(number1, out c)))
            {
                SyntaxErr(Errors.Sint);
                return;
            }
        
            double a = Convert.ToDouble(number1);
            double b = Convert.ToDouble(Input.Text);
            switch (Operator)
            {
                case "+": Input.Text = (a + b).ToString();
                    break;
                case "-": Input.Text = (a - b).ToString();
                    break;
                case "*": Input.Text = (a * b).ToString();
                    break;
                case "/": try { 
                            Input.Text = (a / b).ToString(); 
                               }
                         catch (MyException ex) { SyntaxErr(Errors.divZero); }
                    break;
            }
            number1 = "";
            EnableButtons(true);
        }

        private void _Add_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
            {
                if (Input.Text == "")
                    number1 = "0";
                else
                    number1 = Input.Text;
                Input.Text = "";
                Operator = "+";
                EnableButtons(false);
            }
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Div_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
            {
                if (number1 != "") Calculate();
                else
                {
                    if (Input.Text == "")
                        number1 = "0";
                    else
                        number1 = Input.Text;
                    Input.Text = "";
                }
                Operator = "/";
                EnableButtons(false);
            }
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Mult_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
            {
                if (number1 != "") Calculate();
                else
                {
                    if (Input.Text == "")
                        number1 = "0";
                    else
                        number1 = Input.Text;
                    Input.Text = "";
                }
                Operator = "*";
                EnableButtons(false);
            }
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Sub_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
            {
                if (number1 != "") Calculate();
                else
                {
                    if (Input.Text == "")
                        number1 = "0";
                    else
                        number1 = Input.Text;
                    Input.Text = "";
                }
                Operator = "-";
                EnableButtons(false);
            }
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _Clear_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Operator = "";
            EnableButtons(true);
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _CE_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _BS_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length > 0) 
                Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Sin_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                Input.Text = Math.Sin(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Cos_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                Input.Text = Math.Cos(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Tan_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                if (Math.Cos(c) == 0) SyntaxErr(Errors.Tan);
                else Input.Text = Math.Tan(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Pow_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                Input.Text = Math.Pow(Convert.ToDouble(Input.Text), 3).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Sqr_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                Input.Text = Math.Pow(Convert.ToDouble(Input.Text), 2).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Point_Click(object sender, EventArgs e)
        {
            Input.Text += ",";
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Exp_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                Input.Text = Math.Exp(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Fact_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else 
                if (c < 0) SyntaxErr(Errors.Factor);
                else
                {
                    double n = Convert.ToDouble(Input.Text);
                    double result = 1;
                    for (int i = 1; i <= n; i++) result *= i;
                    Input.Text = result.ToString();
                }
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Ln_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else 
                 if (c <= 0) SyntaxErr(Errors.Ln);
                 else Input.Text = Math.Log10(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void _Sqrt_Click(object sender, EventArgs e)
        {
            double c;
            if (!(Double.TryParse(Input.Text, out c)))
                SyntaxErr(Errors.Sint);
            else
                if (c < 0) SyntaxErr(Errors.Sqrt);
                else Input.Text = Math.Sqrt(Convert.ToDouble(Input.Text)).ToString();
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
