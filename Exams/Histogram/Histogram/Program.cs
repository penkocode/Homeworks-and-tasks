using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else
                    p5++;
               
            }
            var p1perc = p1 * 100.0 / n;
            var p2perc = p2 * 100.0 / n;
            var p3perc = p3 * 100.0 / n;
            var p4perc = p4 * 100.0 / n;
            var p5perc = p5 * 100.0 / n;

            Console.WriteLine("{0:f2}%", p1perc);
            Console.WriteLine("{0:f2}%", p2perc);
            Console.WriteLine("{0:f2}%", p3perc);
            Console.WriteLine("{0:f2}%", p4perc);
            Console.WriteLine("{0:f2}%", p5perc);

        }

    }
}
