using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name== "banana" || name=="apple" || name== "kiwi" || name=="lemon" || name=="grapes" || name=="cherry" )
            {
                Console.WriteLine("fruit");
            }
            else if (name== "tomato" || name=="cucumber"||name=="pepper"|| name=="carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
