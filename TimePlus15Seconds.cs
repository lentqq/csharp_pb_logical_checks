using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time_plus_15_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int time = minutes + 15;
            int hour1 = hour + 1;
            int minutes1 = time - 60;
            int hour2 = hour1 - 24;

            if (time < 59)
            {
                Console.WriteLine("{0}:{1}", hour, time);
            }
            else if (time > 59)
            {

                if (minutes1 < 10)
                {
                    Console.WriteLine("{0}:0{1}", hour1, minutes1);
                }
                else if (hour1 >= 24)
                {
                    Console.WriteLine("{0}:{1}", hour2, minutes1);
                }

                else
                {
                    Console.WriteLine("{0}:{1}", hour1, minutes1);
                }

            }
           
        }
    }
}
