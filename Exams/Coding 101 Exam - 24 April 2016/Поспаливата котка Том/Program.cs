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
            var holydays = int.Parse(Console.ReadLine());

            var workdays = 63;
            var vacantion = 127;
            var year = 365;
            var sleep = 30000;

            var workdaystotal = year - holydays;
            var totalplaytime = (workdaystotal * workdays) + (holydays * vacantion);
            var totalsleep = totalplaytime-sleep;
            var hours = Math.Abs(totalsleep / 60);
            var minutes = Math.Abs(totalsleep % 60);

            if (totalplaytime > sleep)
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
