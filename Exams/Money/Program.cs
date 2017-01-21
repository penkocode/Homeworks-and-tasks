using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var yoan = double.Parse(Console.ReadLine());
            var comssion = double.Parse(Console.ReadLine()) / 100.00;

            var bitExchange = (bitcoin * 1168); //Bitcoin to BGN
            var yoanExchange = (yoan * 0.15) * 1.76; //yoan to USD -> BGN
            var totalEUR = (bitExchange + yoanExchange) / 1.95;
            totalEUR -= totalEUR * comssion;
            Console.WriteLine(totalEUR);

        }
    }
}
