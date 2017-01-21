using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //Top Symbols

            Console.Write("+");

            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
                Console.WriteLine(" +");
            //Middle Symbols

            for (int j = 0; j <n-2; j++)
            {
                Console.Write("|");

                for (int i = 0; i < n - 2; i++)
                    Console.Write(" -");
                Console.WriteLine(" |");
            }

            //Bottom Symbols
            Console.Write("+");

            for (int i = 0; i < n - 2; i++)
                Console.Write(" -");
            Console.WriteLine(" +");

        }
    }
}