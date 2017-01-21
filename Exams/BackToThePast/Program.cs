using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var yearsTolive = int.Parse(Console.ReadLine());

            var years = 18;

            for (int i = 1800; i <= yearsTolive; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= (12000 + 50 * years);
                }
                years++;
            }
            if (money < 0)
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
            }

        }
    }
}
