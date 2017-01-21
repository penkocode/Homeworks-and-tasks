using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbastr = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var birthDate = DateTime.ParseExact(dbastr, format, System.Globalization.CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString(format));

        }
    }
}
