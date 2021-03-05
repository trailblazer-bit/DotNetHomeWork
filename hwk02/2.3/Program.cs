using System;

namespace _2._3
{
    class Program
    {
        static int max = 100;
        static bool[] is_Prime = new bool[max];
        static void Main(string[] args)
        {
            Init();
            //0和1都不是素数
            is_Prime[0] = is_Prime[1] = false;
            Console.WriteLine("从2到100之间的素数有:");
            CountPrime();

        }
        static void Init()
        {
            for (int i = 0; i < is_Prime.Length; i++)
                is_Prime[i] = true;
        }

        //用埃氏筛法求出从2到100之间的素数
        static void CountPrime()
        {
            int i;
            for(i=2;i<max;i++)
            {
                if(is_Prime[i])
                {
                    Console.Write(i+" ");
                    for (int j = 2 * i; j <max; j += i)
                        is_Prime[j] = false;
                }
            }

        }
        
    }
}
