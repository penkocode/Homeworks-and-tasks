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
            var lenghtOfarea = double.Parse(Console.ReadLine());
            var wideOfBlock = double.Parse(Console.ReadLine());
            var lenghtOfBlock = double.Parse(Console.ReadLine());
            var wideOfBench = double.Parse(Console.ReadLine());
            var lenghtOfBench = double.Parse(Console.ReadLine());

            var area = ((lenghtOfarea * lenghtOfarea)- (wideOfBench*lenghtOfBench));
           
            var blockArea = lenghtOfBlock * wideOfBlock;
            var blocksCount = area / blockArea;
           
            var time = blocksCount*0.2;

            Console.WriteLine(blocksCount);
            Console.WriteLine(time);
        }
        
    }
}
