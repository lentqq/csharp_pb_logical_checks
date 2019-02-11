using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            double bonuses = 0;
            //First group bonuses
            if (inputNumber <= 100)
            {
                bonuses = 5;
            }
            else
            {
                bonuses = inputNumber * 0.2;
            }
            if (inputNumber > 1000)
            {
                bonuses = inputNumber * 0.1;
            }

            //Second group bonuses
            if (inputNumber % 2 == 0)
            {
                bonuses++;
            }
            if (inputNumber % 10 == 5)
            {
                bonuses += 2;
            }
            //Print Result
            Console.WriteLine(bonuses);
            Console.WriteLine(inputNumber + bonuses);
        }
    }
}
