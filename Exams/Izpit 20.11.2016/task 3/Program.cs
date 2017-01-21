using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var childrens = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            // (249.90+749.50)*2 + hotel 580.93 
            // adult/childrens trainticketprice = 24.99 - / 14.99
            // adult busticketprice = 32.50 / 28.50
            // adult shipticketprice = 42.99 /39.99
            // adult plainticketprice = 70.00 / 50.00
            // nights per group = 82.99
            //comission = 10% of all amount.
            //"train”, “bus”, “boat” или “airplane”

            decimal vacationWithTrain = ((adults * 24.99m) + (childrens * 14.99m)) * 2;
            decimal hotel = nights * 82.99m;

            decimal vacationWithBus = ((adults * 32.50m) + (childrens * 28.50m))* 2;
            decimal vacationWithShip = ((adults * 42.99m) + (childrens * 39.99m)) * 2;
            decimal vacationWithAir = ((adults * 70.00m) + (childrens * 50.00m)) * 2;

            decimal commisionT = (vacationWithTrain + hotel) * 0.10m;
            decimal commisionB = (vacationWithBus + hotel) * 0.10m;
            decimal commisionS = (vacationWithShip + hotel) * 0.10m;
            decimal commisionA = (vacationWithAir + hotel) * 0.10m;

            if (transport == "train")
            {
                if (adults + childrens < 50)
                {

                    Console.WriteLine("{0:f2}", vacationWithTrain + commisionT + hotel);
                }
                else if (adults + childrens >= 50)
                {
                    
                    Console.WriteLine("{0:f2}",((vacationWithTrain*0.5m + commisionT + hotel)));
                }

            }
            else if (transport == "bus")
            {
                Console.WriteLine("{0:f2}", vacationWithBus + hotel + commisionB);
            }
            else if (transport == "boat")
            {
                Console.WriteLine("{0:f2}", vacationWithShip + hotel + commisionS);
            }
            else if (transport == "airplane")
            {
                Console.WriteLine("{0:f2}", vacationWithAir + hotel + commisionA);
            }
        }
    }
}
