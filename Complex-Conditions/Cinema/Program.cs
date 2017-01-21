using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
           
            if (projectionType == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", (r * c) * 12.00);

            }
            else if (projectionType == "Normal")
            {
                Console.WriteLine("{0:f2} leva",(r * c) * 7.50);
            }
            else if (projectionType=="Discount")
            {
                Console.WriteLine("{0:f2} leva", (r*c)*5.00);
            }

        }
    }
}
