using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            var workdaysplaytime = 63;
            var holydaysplaytime = 127;
            var year = 365;
            var sleep = 30000;

            var workdaystotal = year - days;
            var totalplaytime = (workdaystotal*workdaysplaytime)+(days*holydaysplaytime);
            var totalsleeptime = totalplaytime - sleep;

            var diffhour = Math.Abs(totalsleeptime / 60);
            var diffmin = Math.Abs(totalsleeptime % 60);
            if (totalplaytime > sleep)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", diffhour, diffmin);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", diffhour, diffmin);
            }

        }
    }
}
