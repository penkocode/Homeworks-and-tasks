using System;

namespace Small_Shop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            double productPrice = 0;
            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    productPrice = quantity * 0.50;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = quantity * 0.40;
                }
                else if (town == "Varna")
                {
                    productPrice = quantity * 0.45;
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    productPrice = quantity * 0.80;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = quantity * 0.70;
                }
                else if (town == "Varna")
                {
                    productPrice = quantity * 0.70;
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    productPrice = quantity * 1.20;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = quantity * 1.15;
                }
                else if (town == "Varna")
                {
                    productPrice = quantity * 1.10;
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    productPrice = quantity * 1.45;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = quantity * 1.30;
                }
                else if (town == "Varna")
                {
                    productPrice = quantity * 1.35;
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    productPrice = quantity * 1.60;
                }
                else if (town == "Plovdiv")
                {
                    productPrice = quantity * 1.50;
                }
                else if (town == "Varna")
                {
                    productPrice = quantity * 1.55;
                }
            }
            Console.WriteLine(productPrice);
        }
    }
}
