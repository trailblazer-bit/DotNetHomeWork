using System;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator();
        }

        public void Calculator()
        {
            double a = 0;
            double b = 0;
            char op = '\0';
            string message = "";
            if (this.textBox1.Text.Length != 0)
                a = Double.Parse(this.textBox1.Text);
            if (this.textBox2.Text.Length != 0)
                b = Double.Parse(this.textBox2.Text);
            if (this.comboBox1.SelectedItem != null)
                op = this.comboBox1.SelectedItem.ToString()[0];

            double result = 0.0;
            switch (op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/':
                    {
                        if (b == 0)
                        {
                            message="错误！除数不能为0！";
                            ShowMessage(message);
                            return;
                        }
                        else
                            result = a / b;
                        break;
                    }
                case '%':
                    {
                        if ((int)a == a && (int)b == b)
                        {
                            if (b == 0)
                            {
                                message="第二个数不能为0！";
                                ShowMessage(message);
                                return;
                            }
                            result = a % b;
                        }
                        else
                        {
                           message="参与求余运算的两个数必须是整数！";
                            ShowMessage(message);
                            return;
                        }
                        break;

                    }
                default: message="输入的运算符错误！"; ShowMessage(message);  return;
            }
            this.textBox3.Text = result.ToString();
        }

        public void  ShowMessage(string message)
        {
            MessageBox.Show(
               message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
               );
        }
    }
}
