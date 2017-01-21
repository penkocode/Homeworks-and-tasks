using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit1 = int.Parse(Console.ReadLine());
            var digit2 = int.Parse(Console.ReadLine());
            var digit3 = int.Parse(Console.ReadLine());
            
            if (digit1==digit2 & digit2==digit3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
