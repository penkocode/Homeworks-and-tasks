using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            var unit = double.Parse(Console.ReadLine());

            var price = 0.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = unit * 2.50;
                }
                else if (fruit == "apple")
                {
                    price = unit * 1.20;
                }
                else if (fruit == "orange")
                {
                    price = unit * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = unit * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = unit * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = unit * 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = unit * 3.85;
                }
                else
                { Console.WriteLine("error"); }

            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    price = unit * 2.70;
                }
                else if (fruit == "apple")
                {
                    price = unit * 1.25;
                }
                else if (fruit == "orange")
                {
                    price = unit * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = unit * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = unit * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = unit * 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = unit * 4.20;
                }
                else
                { Console.WriteLine("error"); }

            }

            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("{0:F2}", price);

        }
    }
}