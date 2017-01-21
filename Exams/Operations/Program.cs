using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            var addRes = n1 + n2; // +
            var subRes = n1 - n2; // -
            var mulRes = n1 * n2; // *
            var devRes = (double)n1 / n2; // /
            var modRes = (double)n1 % n2; // %
            string oddOrEven = "";

            switch (oper)
            {
                case "+":
                    if (addRes % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine(" {0} " + oper + " {1} = {2} - " + oddOrEven ,n1, n2, addRes);
                
                    break;


                case "-":
                    if (subRes % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine(" {0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, subRes);

                    break;

                case "*":
                    if (mulRes % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine(" {0} " + oper + " {1} = {2} - " + oddOrEven, n1, n2, mulRes);

                    break;

                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine(" {0} " + oper + " {1} = {2:0.00}", n1, n2, devRes);
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine(" {0} " + oper + " {1} = {2}", n1, n2, modRes);
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
