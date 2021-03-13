using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape square = new Square(8);
            Console.WriteLine("正方形面积为:"+square.CalculateArea());
            Console.WriteLine(square.IsLegal());

            IShape triangle = new Triangle(12, 56,48);
            Console.WriteLine("三角形面积为:"+triangle.CalculateArea());
            Console.WriteLine(triangle.IsLegal());

            IShape rectangle = new Rectangle(12, 34);
            Console.WriteLine("长方形面积为:"+rectangle.CalculateArea());
            Console.WriteLine(rectangle.IsLegal());
        }
    }


    public interface IShape
    {
        //计算面积
        double CalculateArea();

        //判断形状是否合法
        bool IsLegal();
    }

    //长方形类
    public class Rectangle : IShape
    {
        public double Width
        {
            get;set;
        }

        public double Height
        {
            get;set;
        }

        public Rectangle(double width,double height)
        {
            this.Width = width;
            this.Height = height;
            if (!IsLegal())
                throw new ArgumentException("输入的长方形的长或宽不合法!");
        }
        public double CalculateArea()
        {
            return Width * Height;
        }

        public  bool IsLegal()
        {
            return Width > 0 && Height > 0;
        }
    }
    //三角形类
    public class Triangle : IShape
    {
        public double Side1 { get;set;}
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1,double side2,double side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            if (!IsLegal())
                throw new ArgumentException("输入的三角形三边不合法！");
        }
        public double CalculateArea()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return area;
        }

        public bool IsLegal()
        {
            bool flag1, flag2, flag3;
            flag1 = (Side1 + Side2) > Side3;
            flag2 = (Side2 + Side3) > Side1;
            flag3 = (Side1 + Side3) > Side2;

            return flag1 && flag2 && flag3 && Side1 > 0 && Side2 > 0&&Side3>0 ;
        }
    }
    
    //正方形类
    public class Square :IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
            if (!IsLegal())
                throw new ArgumentException("输入的正方形的边长不合法");
        }

        public  double CalculateArea()
        {
            return this.Side * this.Side;
        }

        public bool IsLegal()
        {
            return this.Side > 0;
        }

    }

}
