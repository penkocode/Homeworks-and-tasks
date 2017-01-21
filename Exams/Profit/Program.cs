using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var dollarrate = double.Parse(Console.ReadLine());

            var monthSalary = days * money;
            var yearSalary = monthSalary* 12 + monthSalary *2.5;
           
            var yearSaleryAfterTax = yearSalary - 25 * yearSalary / 100;
            var dayIncomWithTax = yearSaleryAfterTax * dollarrate/ 365;
            

            Console.WriteLine("{0:F2}",dayIncomWithTax);
            }         
        }
    }

