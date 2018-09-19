using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //从键盘上接受两个数字 

            string s = "";
            int a = 0;
            int b = 0;
            Console.Write("Please input an int : ");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please input another int : ");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            //计算a*b             int c = a * b;
            //显示a*b的结果             Console.WriteLine(a + " * " + b + " = " + c);
        }
    }
}
