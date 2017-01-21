using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skomriqKiloprice = double.Parse(Console.ReadLine());
            var cacaKiloprice = double.Parse(Console.ReadLine());
            var kiloPalamud = double.Parse(Console.ReadLine());
            var kiloSafrid = double.Parse(Console.ReadLine());
            var kiloMidi = double.Parse(Console.ReadLine());

            var cenaPalamud = skomriqKiloprice + skomriqKiloprice * 0.60;
            var cenakiloPalamud = kiloPalamud * cenaPalamud;
            var cenaKiloSafrid = cacaKiloprice + cacaKiloprice * 0.80;
            var sumaSafrid = cenaKiloSafrid * kiloSafrid;
            var cenaKiloMidi = kiloMidi * 7.50;

            var totalFishprice = cenakiloPalamud + sumaSafrid + cenaKiloMidi;

            Console.WriteLine("{0:f2}", totalFishprice);



        }
    }
}
