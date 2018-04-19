using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception
{

    public partial class Form1 : Form
    {
        string exp;
        public Form1()
        {
            this.KeyDown += new KeyEventHandler(button1_KeyDown); 
            InitializeComponent();
            _Calculate.Enabled = false;
        }

        class MyException : ApplicationException
        {

            public string ErrorMessage = "";
            public MyException(string str) :
                base(str)
            {
                ErrorMessage = str;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Input.Text == "")
            {
                _Calculate.Enabled = false;
            }
            else
                _Calculate.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Input.Text += '0';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void One_Click(object sender, EventArgs e)
        {
            Input.Text += '1';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Input.Text += '2';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Input.Text += '3';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }


        private void Four_Click(object sender, EventArgs e)
        {
            Input.Text += '4';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Input.Text += '5';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Input.Text += '6';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Input.Text += '7';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Height_Click(object sender, EventArgs e)
        {
            Input.Text += '8';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Input.Text += '9';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Input.Text += '*';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Input.Text += '/';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            Input.Text += '+';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Input.Text += '-';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void LeftBracket_Click(object sender, EventArgs e)
        {
            Input.Text += '(';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void RightBracket_Click(object sender, EventArgs e)
        {
            Input.Text += ')';
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Clear_Click(object sender, EventArgs e)
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

        private void _Point_Click(object sender, EventArgs e)
        {
            Input.Text += ",";
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(new object(), new EventArgs ());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    exp = Convert.ToString(Input.Text);
                    result.Text = "";
                    result.Text = p.Eval(exp).ToString();
                }
                catch (MyException ex)
                {
                    if (ex.ErrorMessage == "Деление на 0!")
                    {
                        result.Text = "";
                        result.Text = "Деление на 0 невозможно!";
                        MessageBox.Show("ERROR! \n" + ex.ErrorMessage);
                    }
                    else
                        MessageBox.Show("ERROR! \n" + ex.ErrorMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR! \n" + ex.Message);
                }
                Input.Focus();
                Input.SelectionStart = Input.Text.Length;
            }
        Parser p = new Parser();
        class Parser
        {
            enum Types { none, delim, var, num };
            enum Errors { Sint, NoBalance, NoNum, divZero};

            string Term;
            string symbol;
            int TermIndex;
            Types symbolType;

            public double Eval(string expstr) 
            {
                double result;
                Term = expstr;
                TermIndex = 0;
                GetSymbol();
                    if (symbol == "")
                        {
                            SyntaxErr(Errors.NoNum);
                            return 0.0;
                        }
                     EvalAdd(out result);
                          if (symbol != "")
                                 SyntaxErr(Errors.Sint);
                return result;
            }

            void EvalAdd(out double result)
            {
                string Operation;
                double half_res;
                EvalMult(out result);
                     while ((Operation = symbol) == "+" || Operation == "-")
                        {
                             GetSymbol();
                             EvalMult(out half_res);
                                switch (Operation)
                                    {
                                        case "-":
                                            result = result - half_res;
                                           break;
                                        case "+":
                                             result = result + half_res;
                                            break;
                                    }
                        }
                }
            void EvalMult(out double result)
            {
                string Operation;
                double half_res = 0.0;
                EvalExp1(out result);
                while ((Operation = symbol) == "*" || Operation == "/")
                {
                    GetSymbol();
                    EvalExp1(out half_res);
                    Console.WriteLine(half_res);
                    switch (Operation)
                    {
                        case "*":
                            result = result * half_res;
                            break;
                        case "/":
                            if (half_res == 0.0)
                                SyntaxErr(Errors.divZero);
                            result = result / half_res;
                            break;
                    }
                }

            }
            void EvalExp1(out double result)
            {
                string Operation;
                Operation = "";
                if ((symbolType == Types.delim) &&
                    symbol == "+" || symbol == "-")
                {
                    Operation = symbol;
                    GetSymbol();
                }
                EvalExp2(out result);
                if (Operation == "-") result = -result;
            }
            void EvalExp2(out double result)
            {
                if ((symbol == "("))
                {
                    GetSymbol();
                    EvalAdd(out result);
                    if (symbol != ")")
                        SyntaxErr(Errors.NoBalance);
                    GetSymbol();
                }
                else at(out result);
            }

            void at(out double result)
            {
                switch (symbolType)
                {
                    case Types.num:
                        try
                        {
                            result = Double.Parse(symbol);
                        }
                        catch (FormatException)
                        {
                            result = 0.0;
                            SyntaxErr(Errors.Sint);
                        }
                        GetSymbol();
                        return;
                    default:
                        result = 0.0;
                        SyntaxErr(Errors.Sint);
                        break;
                }
            }
            void SyntaxErr(Errors error)
            {
                string[] err = {
                           "Синтаксическая ошибка!",
                           "Неправильно расставлены скобки!",
                           "Нет выражения!",
                           "Деление на 0!",
                       };
                throw new MyException(err[error.GetHashCode()]);
            }

            bool IsSign(char c)
            {
                if (("+-/*%=()".IndexOf(c) != -1)) return true;
                return false;
            }

            void GetSymbol()
            {
                symbolType = Types.none;
                symbol = "";
                if (TermIndex == Term.Length) return;
                while (TermIndex < Term.Length && Char.IsWhiteSpace(Term[TermIndex]))
                    ++TermIndex;
                if (TermIndex == Term.Length)  return;
                if (IsSign(Term[TermIndex]))
                {
                    symbol += Term[TermIndex];
                    TermIndex++;
                    symbolType = Types.delim;
                }
                else if (Char.IsLetter(Term[TermIndex]))
                {
                    SyntaxErr(Errors.Sint);
                }
                else if (Char.IsDigit(Term[TermIndex]))
                {
                    while (!IsSign(Term[TermIndex]))
                    {
                        symbol += Term[TermIndex];
                        TermIndex++;
                        if (TermIndex >= Term.Length) 
                            break;
                    }
                    symbolType = Types.num;
                }
            }
        }
    }
}
