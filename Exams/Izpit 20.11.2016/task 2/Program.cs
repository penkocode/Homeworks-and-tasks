using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var kilos = double.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine());

            var dogneeds = days * dog;
            var catneeds = days * cat;
            var turtleneeds = (days * turtle) / 1000;
            var totalfood = dogneeds + catneeds + turtleneeds;

            if (totalfood <= kilos)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(kilos - totalfood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalfood - kilos));
            }


        }
    }
}
