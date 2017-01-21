using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (var dig1 = 1; dig1 <=n; dig1++)
            for (var dig2 = 1; dig2 <=n; dig2++)
            for (var symb1 ='a'; symb1<'a' +l; symb1++)
            for (var symb2 = 'a'; symb2 <'a' + l; symb2++)
            for (var dig3 = Math.Max(dig1,dig2)+1; dig3 <=n; dig3++)
           {
            Console.Write("{0}{1}{2}{3}{4} ", dig1,dig2,symb1,symb2,dig3);
           }
            Console.WriteLine();
        }
    }
}
