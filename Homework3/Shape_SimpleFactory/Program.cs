using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_SimpleFactory
{
    //抽象形状接口：抽象产品类
    public interface IShape
    {
        double Squ();
        string GetShape();
    }

    //三角形类：具体产品接口
    public class Triangle : IShape
    {
        double s;
        public double Squ()
        {
            Console.WriteLine("please input the lengths of the sides:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a + b <= c | a + c <= b | b + c <= a)
                Console.WriteLine("不能构成三角形！");
            else
            {
                double p = (a + b + c) / 2.0;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }
        public string GetShape()
        {
            return "Triangle";
        }

    }

    //圆形类：具体产品接口
    public class Circle : IShape
    {
        double s;
        public double Squ()
        {
            Console.WriteLine("please input the radius:");
            double a = double.Parse(Console.ReadLine());
            s = 3.14 * a * a;
            Console.WriteLine("it's square is " + s);
            return s;
        }
        public string GetShape()
        {
            return "Circle";
        }

    }

    //正方形类：具体产品接口
    public class Square : IShape
    {
        double s;
        public double Squ()
        {
            Console.WriteLine("please input the lengeh of the side:");
            double a = double.Parse(Console.ReadLine());
            s = a * a;
            Console.WriteLine("it's square is " + s);
            return s;
        }
        public string GetShape()
        {
            return "Square";
        }

    }

    //矩形类：具体产品接口
    public class Rectangle : IShape
    {
        double s;
        public double Squ()
        {
            Console.WriteLine("please input two lengehs of the side:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            s = a * b;
            Console.WriteLine("it's square is " + s);
            return s;
        }
        public string GetShape()
        {
            return "Rectangle";
        }

    }

    //工厂类
    public class Factory
    {
        
        public IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "Triangle":
                    return new Triangle();
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }

    //客户类
    public class Client
    {
        static void Main(string[] args)
        {
            IShape shape1;
            double s;
            Console.WriteLine("Please choose one shape:");
            Console.WriteLine("Triangle   Cirle   ");
            string s1 = Console.ReadLine();
            Factory f = new Factory();
            shape1 = f.GetShape(s1); //获取形状
            switch (s1)
            {
                case "Triangle":
                    s =shape1.Squ();
                    Console.WriteLine("it's square is " + s);
                    break;
                case "Circle":
                    s = shape1.Squ();
                    Console.WriteLine("it's square is " + s);
                    break;
                case "Square":
                    s = shape1.Squ();
                    Console.WriteLine("it's square is " + s);
                    break;
                case "Rectangle":
                    s = shape1.Squ();
                    Console.WriteLine("it's square is " + s);
                    break;
                default:
                    s = 0;
                    Console.WriteLine("错误！");
                    break;
            }
        }
    }
}

