using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
                Console.Write("*");
                for (var col = 1; col < n; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }

        }
    }
}

