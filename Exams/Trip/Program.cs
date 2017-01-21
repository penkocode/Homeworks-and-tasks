using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double seasonbudget;
            if (budget<=100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season=="summer")
                {
                    seasonbudget = budget * 0.3;
                    Console.WriteLine("Camp - {0:f2}", seasonbudget);
                }
                else
                {
                    seasonbudget = budget * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", seasonbudget);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    seasonbudget = budget * 0.4;
                    Console.WriteLine("Camp - {0:F2}", seasonbudget);
                }
                else
                {
                    seasonbudget = budget * 0.8;
                    Console.WriteLine("Hotel - {0:F2}", seasonbudget);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                seasonbudget = budget * 0.9;
                Console.WriteLine("Hotel - {0:F2}", seasonbudget);

            }
        }

    }
}
