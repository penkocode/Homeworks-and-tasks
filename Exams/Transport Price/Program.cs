using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            string daypart = Console.ReadLine();
            var dayTaxi = 0.70+(0.79*km);
            var nightTaxi = 0.70 + 0.90 * km;
            var Train = 0.06 * km;
            var Bus = 0.09 * km;
            

            if (km <= 20 & daypart=="day")
            {
                Console.WriteLine(dayTaxi);
            }
            else if (km<=20 && daypart=="night")
            {
                Console.WriteLine(nightTaxi);
            }
           

            if (km >= 100)
            {
                Console.WriteLine(Train);
            }

            else if (20<=km)
            {
                Console.WriteLine(Bus);
            }
        }
    }
}
