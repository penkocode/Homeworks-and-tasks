using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMinutes = minutes + 15;
            var totalHours = hour + totalMinutes / 60;
            var minutesAfterHours = totalMinutes % 60;

            if (totalHours == 24)
            {
                Console.WriteLine("0:{0:00}", minutesAfterHours);
            }
            else
            {
                Console.WriteLine("{0:0}:{1:00}", totalHours, minutesAfterHours);
            }
        }
    }
}
