using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    partial class Program
    {
        //使用事件机制，模拟实现一个闹钟的定时功能，可以设置闹钟，在闹钟时间到了以后，在控制台显示提示信息
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("请输入闹钟的时：");
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour<0||hour>23)
            {
                Console.WriteLine("错误的信息！");
                
            }
            Console.WriteLine("请输入闹钟的分：");
            int minute = Convert.ToInt32(Console.ReadLine());
            if (minute < 0 || minute > 59)
            {
                Console.WriteLine("错误的信息！");

            }
            Console.WriteLine("请输入闹钟的秒：");
            int second = Convert.ToInt32(Console.ReadLine());
            if (second < 0 || second > 59)
            {
                Console.WriteLine("错误的信息！");

            }
            Clock MyClock = new Clock(hour,minute,second);
            MyClock.Begin();
            //等待键盘输入，退出程序。使调试时能看到输出结果。如果没有此句，命令窗口会一闪而过。 
            Console.ReadKey();

        }
    }
}
