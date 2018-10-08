using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    partial class Program
    {
        class Clock
        {
            private int hour, minute, second;
            public Clock(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            //开始计时
            public void Begin()
            {

                Timer timer = new Timer
                {
                    Enabled = true,
                    Interval = 1000

                };
                timer.Start();
                timer.Elapsed += timer_Elapsed;
                timer.AutoReset = true;


            }
            void timer_Elapsed(object source, ElapsedEventArgs e)
            {
                if (DateTime.Now.Hour == hour && DateTime.Now.Minute == minute && DateTime.Now.Second == second)
                {
                    Console.WriteLine("到" + DateTime.Now.ToString() + "了！！");
                }
            }

        }
    }
    
}
