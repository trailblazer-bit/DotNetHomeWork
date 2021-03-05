using System;

namespace PrimeDivisors
{
    class PrimeDivisors
    {
        static int number;
        static void Main(string[] args)
        {
            Input();
            if(number<=1)
                Console.WriteLine("{0}没有素数因子",number);
            else
            {
                Console.WriteLine("{0}的素数因子为:", number);
                PrimDivisors();
            }
        }

        //求出指定数据的素数因子
        static void PrimDivisors()
        {
            int n = number;
            for(int i=2;i<=n;i++)
            {
                while(n%i==0)
                {
                    Console.Write(i+" ");
                    n = n / i;
                }
            }
        }
        //输入一个指定的数据
        static void Input()
        {
            Console.WriteLine("请输入一个数:");
            number=int.Parse(Console.ReadLine().ToString());
        }
    }
}
