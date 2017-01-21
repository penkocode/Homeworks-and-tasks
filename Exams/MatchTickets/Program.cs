using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            // VIP = 499.99
            //Normal = 249.99
            var ticketCat = category == "VIP" ? 499.99 : 249.99;

            var moneyleft = budget;

            if (people < 5)
            {
                moneyleft -= budget * 0.75;
            }
            else if (people >= 5 && people < 10)
            {
                moneyleft -= budget * 0.60;
            }
            else if (people >= 10 && people < 25)
            {
                moneyleft -= budget * 0.50;
            }
            else if (people >= 25 && people < 50)
            {
                moneyleft -= budget * 0.40;
            }
            else
            {
                moneyleft -= budget * 0.25;
            }
            var priceofTickets = people * ticketCat;
            if (priceofTickets > moneyleft)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", priceofTickets - moneyleft);
            }
            else
            {
                moneyleft -= priceofTickets;
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyleft);
            }
        }
    }

}