using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area
{
    class Program
    {
        static void Main(string[] args)
        {
            String figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine("{0}", area);
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                double area = side1 * side2;
                Console.WriteLine("{0}", area);
            }
            else if (figure =="circle")
            {
                double r = double.Parse(Console.ReadLine());

                double area = r * r * Math.PI;

                Console.WriteLine("{0}",area);
            }
            else
            {
                figure = "triangle";

                double side1 = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = (side1 * height)/2;

                Console.WriteLine("{0}",area);
            }
        }
    }
}
