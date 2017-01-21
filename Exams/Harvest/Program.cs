using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var grapePerSQM = double.Parse(Console.ReadLine());
            var wineRequired = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalGrape = area * grapePerSQM;
            var wine = (40 * totalGrape) / 100;
            var wineTotal = wine / 2.5;
            
            if (wineRequired <= wineTotal)
            {
                var literperperson = ((wineTotal - wineRequired) / workers);
                var litersleft = wineTotal - wineRequired;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineTotal));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(litersleft),
                Math.Ceiling(literperperson));
            }
            else if (wineTotal <= wineRequired)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                Math.Floor(wineRequired - wineTotal));
            }
        }
    }
}
