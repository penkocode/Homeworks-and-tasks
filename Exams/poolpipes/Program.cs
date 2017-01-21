using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolpipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var totalWater = P1 * hours + P2 * hours;
            if (totalWater < v)
            {
                Console.WriteLine("The pool is {0} % full.Pipe 1: {1}%.Pipe 2: {2}%.",
                  Math.Truncate (totalWater/v*100),
                  Math.Truncate (P1 *hours/totalWater*100),
                  Math.Truncate(P2 * hours/totalWater*100));
            }
            else

            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, totalWater - v);
            }

        }

    }
}
