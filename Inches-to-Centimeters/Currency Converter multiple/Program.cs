using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter_multiple
{
    class CurrencyConverterProgram
    

    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string currencyOne = Console.ReadLine();
            string currencyTwo = Console.ReadLine();
            decimal conversionOne = new decimal();
            decimal conversionTwo = new decimal();

            decimal BGN = 1m;
            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;
            switch (currencyOne)
            {
                case "BGN":
                    conversionOne = amount * BGN;
                    break;

                case "USD":
                    conversionOne = amount * USD;
                    break;

                case "EUR":
                    conversionOne = amount * EUR;
                    break;

                case "GBP":
                    conversionOne = amount * GBP;
                    break;
                                     
            }
            switch (currencyTwo)
            {
                case "BGN":
                    conversionTwo = conversionOne / BGN;
                    break;
                case "USD":
                    conversionTwo = conversionOne / USD;
                    break;
                case "EUR":
                    conversionTwo = conversionOne / EUR;
                    break;
                case "GBP":
                    conversionTwo = conversionOne / GBP;
                    break;
               
            }
            Console.WriteLine(Math.Round(conversionTwo,2));
        }
    }
}
