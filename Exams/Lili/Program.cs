using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {

            var ageLili = int.Parse(Console.ReadLine());
            var londryPrice = decimal.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var toys = 0;
            var money = 0;
            var even = 1;


            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + 10*even-1;
                    even++;

                }
                else if (i % 2 == 1)
                {
                    toys++;
                }

            }
            money += toys * toyPrice;
            if (money<londryPrice)
            {
                Console.WriteLine("No! {0:f2}",londryPrice-money);
            }
            else
            {
                Console.WriteLine("Yes! {0:f2}",money-londryPrice);
            }



        }
    }
}
