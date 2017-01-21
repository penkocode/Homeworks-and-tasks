using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonuScore = 0.0;
            var bonuScore2 = 0.0;
            if (number <=100)
            {
                bonuScore = bonuScore + 5;
            }
            else if (number <= 1000)
            {
                bonuScore = number*0.2;
            }
            else 
            {
                bonuScore = number * 0.1;
            }
            if (number %2 == 0)
            {
                bonuScore2 = 1;
            }
            else if (number % 5 == 0)
            {
                bonuScore2 = 2;
            }
            var result = bonuScore + bonuScore2;
            var result2 = number + result;
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
