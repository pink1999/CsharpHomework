using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static int ArrayMax(int[] A)
        {
            int max = 0;
            int len = A.Length;
            for (int i = 0; i < len - 1; i++)
            {
                if (A[i] > A[i + 1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
                else
                    i++;
                max = A[i + 1];
            }
            return max;
        }
        static int ArrayMin(int[] A)
        {
            int min = 0;
            int len = A.Length;
            for (int i = 0; i < len - 1; i++)
            {
                if (A[i] < A[i + 1])
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                }
                else
                    i++;
                min = A[i + 1];
            }
            return min;
        }
        static double ArrayAverage(int[] A)
        {
            int len = A.Length;
            double s = 0;
            for (int i = 0; i < len; i++)
            {
                s = s + A[i];
            }
            double average = s / len;
            return average;
        }
        static int ArraySum(int[] A)
        {
            int len = A.Length;
            int s = 0;
            for (int i = 0; i < len; i++)
            {
                s = s + A[i];
            }

            return s;
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int a = ArrayMax(A);
            int b = ArrayMin(A);
            double c = ArrayAverage(A);
            int d = ArraySum(A);
            Console.WriteLine("数组的最大值为：" + a);
            Console.WriteLine("数组的最小值为：" + b);
            Console.WriteLine("数组的平均值为：" + c);
            Console.WriteLine("数组的和为：" + d);
        }
    }
}
