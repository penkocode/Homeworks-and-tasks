using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
            new string('.', n + 1),
            new string('_',2*n+1));

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string ('.',i),
                    new string ('_',(4*n+3)-2*i-4));

            }

        }
    }
}
