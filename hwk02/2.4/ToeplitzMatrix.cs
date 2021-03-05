using System;

namespace _2._4
{
    class ToeplitzMatrix
    {
        static int m;
        static int n;
        static int[,] matrix;
        static void Main(string[] args)
        {
            Input();
            if(IsToeplitzMatrix(matrix))
                Console.WriteLine("这是一个托普利茨矩阵");
            else
                Console.WriteLine("这不是一个托普利茨矩阵");
        }

        //数据输入
        //输入格式
        /* 第一行写出矩阵的行数和列数
         * 接下来几行给出矩阵
         * 3 4
         * 1 2 3 4
         * 5 1 2 3
         * 9 5 1 2
         * 
         */
        static void Input()
        {
            string[] strs = Console.ReadLine().ToString().Split(" ");
            m = int.Parse(strs[0]);
            n = int.Parse(strs[1]);
            matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                strs = Console.ReadLine().ToString().Split(" ");
                for (int j = 0; j < strs.Length; j++)
                    matrix[i, j] = int.Parse(strs[j]);
            }
        }

        //判断一个矩阵是否为托普利茨矩阵
        static bool IsToeplitzMatrix(int [,]matrix)
        {
            bool flag = true; ;
            for (int i = 1; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                        flag = false;
            return flag;
        }
    }
}
