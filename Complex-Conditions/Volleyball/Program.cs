using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var hweekends = int.Parse(Console.ReadLine());
            var sweekends = 48 - hweekends;
            double playdays = (sweekends * 3.0 / 4) + (p * 2.0 / 3) + hweekends;
            if (year == "normal")
            {
                Console.WriteLine("{0}", (int)playdays);
            }
            else
            {
                Console.WriteLine("{0}", (int)(playdays * 0.15 + playdays));
            }
        }
    }
}
