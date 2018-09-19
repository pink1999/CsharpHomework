using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void AllPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0)
                {
                    int j;
                    for (j = 2; j < i; j++)
                    {
                        if (j % i == 0) return;

                    }
                    if (j == i)
                        Console.Write(i + " ");
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Write("请输入一个整数：");
            string s = Console.ReadLine();
            int a = Int32.Parse(s);
            Console.Write("这个整数的所有素数因子为：");
            AllPrime(a);
        }
    }
}
