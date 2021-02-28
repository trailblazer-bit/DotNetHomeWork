using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入参与运算的第一个数:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入参与运算的第二个数:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入运算符:");
            char op = Convert.ToChar(Console.ReadLine());
            Calculator(a, b, op);
        }

        public static void Calculator(double a,double b,char ch)
        {
            double result=0.0;
            switch(ch)
            {
                case '+':result=a + b;break;
                case '-':result=a - b;break;
                case '*':result=a * b;break;
                case '/':
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("错误！除数不能为0！");
                            return;
                        }                       
                        else
                            result = a / b;
                        break;
                    }
                case '%':
                    {
                        if((int)a==a&&(int)b==b)
                        {
                            if(b==0)
                            {
                                Console.WriteLine("第二个数不能为0！");
                                return;
                            }
                            result = a % b;
                        }
                        else
                        {
                            Console.WriteLine("参与求余运算的两个数必须是整数！");
                            return;
                        }
                        break;
                          
                    }
                default:Console.WriteLine("输入的运算符错误！");return;
            }
            Console.WriteLine("{0}{1}{2}={3}", a, ch, b, result);
        }
    }
}
