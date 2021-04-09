using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwk07
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        int n;
        double leng;
        double per1;
        double per2;
        double th1;
        double th2;
        Pen p;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.splitContainer1.Panel2.CreateGraphics();
            }

            //输入异常处理
            try
            {
                n = Int32.Parse(textBox1.Text);
                leng = Double.Parse(textBox2.Text);
                per1 = Double.Parse(textBox3.Text);
                per2 = Double.Parse(textBox4.Text);
                th1 = Double.Parse(textBox5.Text);
                th2 = Double.Parse(textBox6.Text);
                p = new Pen(button3.BackColor, float.Parse(textBox7.Text));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Application.Exit();
            }


            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);

        }
        void  drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {           
            graphics.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //显示颜色对话框
            DialogResult dr = colorDialog1.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                this.button3.BackColor = colorDialog1.Color;
            }
        }

    }
}
