using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Covertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            String inputType = Console.ReadLine();
            String outputType = Console.ReadLine();

            double numInMeters = 0.0;

            if (inputType == "m")
            {
                numInMeters = num / 1;
            }
            else if (inputType == "mm")
            {
                numInMeters = num / 1000;
            }
            else if (inputType == "cm")
            {
                numInMeters = num / 100;
            }
            else if (inputType == "mi")
            {
                numInMeters = num / 0.000621371192;
            }
            else if (inputType == "in")
            {
                numInMeters = num / 39.3700787;
            }
            else if (inputType == "km")
            {
                numInMeters = num / 0.001;
            }
            else if (inputType == "ft")
            {
                numInMeters = num / 3.2808399;
            }
            else
            {
                numInMeters = num / 1.0936133;
            }

            var outputnum = 0.0;


            if (outputType == "m")
            {
                outputnum = numInMeters * 1;
            }
            else if (outputType == "mm")
            {
                outputnum = numInMeters * 1000;
            }
            else if (outputType == "cm")
            {
                outputnum = numInMeters * 100;
            }
            else if (outputType == "mi")
            {
                outputnum = numInMeters * 0.000621371192;
            }
            else if (outputType == "in")
            {
                outputnum = numInMeters * 39.3700787;
            }
            else if (outputType == "km")
            {
                outputnum = numInMeters * 0.001;
            }
            else if (outputType == "ft")
            {
                outputnum = numInMeters * 3.2808399;
            }
            else
            {
                outputnum = numInMeters * 1.0936133;
            }

            Console.WriteLine("{0} {1}", outputnum, outputType);
        }
    }
}
