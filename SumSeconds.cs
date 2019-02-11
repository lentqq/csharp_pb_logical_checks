using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int seconds = time1 + time2 + time3;

            int outputMinutes = seconds / 60;
            int outputSeconds = seconds % 60;

            if (outputSeconds < 10)
            {
                Console.WriteLine("{0}:0{1}", outputMinutes, outputSeconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", outputMinutes, outputSeconds);
            }
        }
    }
}
