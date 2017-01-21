using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            h = h * 100;
            var rows = h / 120;
            rows = Math.Floor(rows);
            w = w * 100 - 100;
            var descs = w / 70;
            descs = Math.Floor(descs);
            var result = rows * descs - 3;
            Console.WriteLine(result);

        }
    }
}
