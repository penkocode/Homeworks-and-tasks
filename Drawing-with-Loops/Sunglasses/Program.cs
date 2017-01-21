using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //Top line
            Console.Write(new string('*',2*n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            //Middle Left and Right
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/',2*n-2));
                Console.Write("*");
                char c = ' ';
                if (i == (n-1) / 2 - 1) 
                {
                    c = '|';
                }
                Console.Write(new string(c,n));

                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");
            }

            //Bottom Line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
