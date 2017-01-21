using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetable_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegKG = int.Parse(Console.ReadLine());
            var fruitKG = int.Parse(Console.ReadLine());
            var euro = 1.94;

            var total = ((vegPrice * vegKG) + (fruitPrice * fruitKG)) / euro; 
            Console.WriteLine(total);
        }


    }
}
