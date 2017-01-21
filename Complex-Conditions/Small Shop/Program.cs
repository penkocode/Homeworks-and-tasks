using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            var quntity = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (product=="coffee")
                    Console.WriteLine(0.50 * quntity);
                else if (product=="water")
                    Console.WriteLine(0.80* quntity);
                if (product=="beer")
                    Console.WriteLine(1.20 * quntity);
                else if (product=="sweets")
                    Console.WriteLine(1.45*quntity);
                if (product=="peanuts")
                    Console.WriteLine(1.60*quntity);
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(0.40 * quntity);
                else if (product == "water")
                    Console.WriteLine(0.70 * quntity);
                if (product == "beer")
                    Console.WriteLine(1.15 * quntity);
                else if (product == "sweets")
                    Console.WriteLine(1.30 * quntity);
                if (product == "peanuts")
                    Console.WriteLine(1.50 * quntity);
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                    Console.WriteLine(0.45 * quntity); 
                else if (product == "water")
                    Console.WriteLine(0.70 * quntity);
                if (product == "beer")
                    Console.WriteLine(1.10 * quntity);
                else if (product == "sweets")
                    Console.WriteLine(1.35 * quntity);
                if (product == "peanuts")
                    Console.WriteLine(1.55 * quntity);
            }
           
        }
    }
}
