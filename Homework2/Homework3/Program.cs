using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2到100以内的素数有：");
            int i, j = 2;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;

                }
                if (j == i)
                    Console.Write(i + " ");

            }
        }
    }
}
