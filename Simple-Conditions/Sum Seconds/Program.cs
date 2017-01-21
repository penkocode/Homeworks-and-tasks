using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());
            var totalSeconds = t1 + t2 + t3;
            var minutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;
            if (seconds > 9)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
        }
    }
}