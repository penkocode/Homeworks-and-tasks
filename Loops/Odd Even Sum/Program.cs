using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num; 
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes Sum = "+ oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(oddSum-evenSum));
            }
        }
    }
}
