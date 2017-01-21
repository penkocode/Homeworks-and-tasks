using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectHours = double.Parse(Console.ReadLine());
            var daysAvailible = double.Parse(Console.ReadLine());
            var overTimeWorkers = int.Parse(Console.ReadLine());

            var workdays = daysAvailible * 0.90;
            var overtime = overTimeWorkers * 2 * daysAvailible;
            var workHours = Math.Floor(workdays * 8 + overtime);

            if (projectHours<=workHours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
            }




        }
    }
}
