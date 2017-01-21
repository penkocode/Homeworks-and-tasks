using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure =  Console.ReadLine();

            if (figure == "square")
            {
                var input1 = double.Parse(Console.ReadLine());
                var square = Math.Round(input1 * input1,3);
             
                Console.WriteLine(square);

            }
            else if (figure == "rectangle")
            {
                var input1 = double.Parse(Console.ReadLine());
                var input2 = double.Parse(Console.ReadLine());
                var rectangle = Math.Round(input1 * input2,3);
                Console.WriteLine(rectangle);
            }
            else if (figure == "circle")
            {
                var input1 = double.Parse(Console.ReadLine());
                var circle = Math.Round(Math.PI * input1 * input1,3);
                Console.WriteLine(circle);
            }
            else if (figure == "triangle")
            {
                var input1 = double.Parse(Console.ReadLine());
                var input2 = double.Parse(Console.ReadLine());
                var triangle = Math.Round(input1 * input2/2,3);
                Console.WriteLine(triangle);
            }
            
            }
        }
    }

