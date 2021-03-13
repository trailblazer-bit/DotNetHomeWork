using System;
using _3._1;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            double totalArea = 0.0;
            int kind;
            ShapeFactory shapeFactory = new ShapeFactory();

            for (int i=0;i<10;i++)
            {
                kind = r.Next(0, 3);
                double []arr=InputShapeInfo(kind);

                totalArea += shapeFactory.GetShape(kind, arr).CalculateArea();
            }
            Console.WriteLine("面积总和为:"+totalArea);
        }
        //输入相关的形状信息,并且返回某个形状的边长数组
        static double[] InputShapeInfo(int kind)
        {
            if (kind == 0)
                Console.WriteLine("请输入长方形的长和宽:");
            else if (kind == 1)
                Console.WriteLine("请输入正方形的边长:");
            else if (kind == 2)
                Console.WriteLine("请输入三角形的三边长:");
            else
                ;
            String[] nums = Console.ReadLine().Split(" ");
            double[] arr = new double[nums.Length];
            for (int j = 0; j < nums.Length; j++)
                arr[j] = Double.Parse(nums[j]);
            return arr;
        }
    }


    public class ShapeFactory
    {
        //工厂模式，生产长方形，正方形，三角形形状的对象
        public  IShape GetShape(int kind, params double[] arr)
        {
            IShape shape = null;
            switch (kind)
            {
                case 0:
                    {
                        IsParamsLegal(arr);
                        shape = new Rectangle(arr[0], arr[1]);
                        break;
                    }
                case 1:
                    {
                        IsParamsLegal(arr);
                        shape = new Square(arr[0]);
                        break;
                    }
                case 2:
                    {
                        IsParamsLegal(arr);
                        shape = new Triangle(arr[0], arr[1], arr[2]);
                        break;
                    }

                default: break;
            }
            return shape;
        }
        //在每次创建一个形状对象之前都进行参数合法性验证
        public static void  IsParamsLegal(params double[]arr)
        {
            bool flag = true;
            if (arr == null || arr.Length ==0)
                flag=false;
            else
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] <= 0)
                    {
                        flag = false;
                        break;
                    }
            }
            if (!flag)
                throw new ArgumentException("多边形的边长参数不合法!!!");
        }
    }
}
