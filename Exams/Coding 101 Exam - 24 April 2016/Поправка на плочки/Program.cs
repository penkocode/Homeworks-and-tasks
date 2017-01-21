using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaSize = double.Parse(Console.ReadLine());
            var wideBlocks = double.Parse(Console.ReadLine());
            var lenghtBlocks = double.Parse(Console.ReadLine());
            var wideBench = double.Parse(Console.ReadLine());
            var lenghtBench = double.Parse(Console.ReadLine());

            double buildingArea = ((areaSize * areaSize) - (wideBench*lenghtBench));
            double oneBlockSize = wideBlocks * lenghtBlocks;
            double blockForArea = buildingArea / oneBlockSize;
            double timeForbuild = blockForArea * 0.2;

            Console.WriteLine( blockForArea);
            Console.WriteLine(timeForbuild);
        }
    }
}
