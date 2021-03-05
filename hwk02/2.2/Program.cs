using System;
using System.Collections;

namespace _2._2
{
    class Program
    {
        static int[] nums;
        static void Main(string[] args)
        {
            Input();
            Console.WriteLine("数组最大值为:"+MaxValue(nums));
            Console.WriteLine("数组最小值为:" + MinValue(nums));
            Console.WriteLine("数组平均值为:" + Average(nums));
            Console.WriteLine("数组元素和为:" + Sum(nums));
        }
        //输入一个整数数组
        static void Input()
        {
            int n = int.Parse(Console.ReadLine().ToString());
            nums = new int[n];
            string[] strs = Console.ReadLine().ToString().Split(" ");
            for (int i = 0; i < strs.Length; i++)
                nums[i]=int.Parse(strs[i]);
        }
        //求最大值
        static int MaxValue(int[] nums)
        {
            int max=int.MinValue;
            for (int i = 0; i < nums.Length; i++)
                if (max < nums[i])
                    max = nums[i];
            return max;
        }
        //求最小值
        static int MinValue(int [] nums)
        {
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
                if (min > nums[i])
                    min = nums[i];
            return min;
        }
        //求平均值
        static double  Average(int[] nums)
        {
            return Sum(nums)*1.0/nums.Length;
        }
        //求和
        static int Sum  (int [] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum;
        }
    }
}
