using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var europeAlbumsSold = int.Parse(Console.ReadLine());
            decimal AlbumsPriceEuro = decimal.Parse(Console.ReadLine());

            var northAlbums = int.Parse(Console.ReadLine());
            decimal AlbumPriceDolars = decimal.Parse(Console.ReadLine());

            var southAlbums = int.Parse(Console.ReadLine());
            decimal AlbumPricePeso = decimal.Parse(Console.ReadLine());

            var concerts = int.Parse(Console.ReadLine());
            decimal singleConcertprofitEuro = decimal.Parse(Console.ReadLine());

          decimal totalAlbumsIncome = 0;

            totalAlbumsIncome += (europeAlbumsSold * AlbumsPriceEuro) * 1.94M;
            totalAlbumsIncome += (northAlbums * AlbumPriceDolars) * 1.72M;
            totalAlbumsIncome += (southAlbums * AlbumPricePeso)/ 332.74M;

            totalAlbumsIncome *= 0.65M;
            totalAlbumsIncome *= 0.8M;

            decimal totalConcertIncome = (concerts*singleConcertprofitEuro)*1.94M;

            if (totalConcertIncome>=100000.00M)
            {
                totalConcertIncome *= 0.85M;
            }
            if (totalConcertIncome>=totalAlbumsIncome)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", totalConcertIncome);
            }
            else
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalAlbumsIncome);
            }
        

        }
    }
}
