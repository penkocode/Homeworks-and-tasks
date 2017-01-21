using System;

class Program
{
    static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());
        var inputMetric = Console.ReadLine();
        var outputMetric = Console.ReadLine();

        var mm = 1000.0;
        var cm = 100.0;
        var mi = 0.000621371192;
        var inn = 39.3700787;
        var km = 0.001;
        var ft = 3.2808399;
        var yd = 1.0936133;
        var m = 1.0;

        if (inputMetric == "mm")        { number = number / mm;}
        else if (inputMetric == "mi")   { number = number / mi;}
        else if (inputMetric == "inn")  { number = number / inn;}
        else if (inputMetric == "ft")   { number = number / ft; }
        else if (inputMetric == "km")   { number = number / km; }
        else if (inputMetric == "yd")   { number = number / yd; }
        else if (inputMetric == "cm")   { number = number / cm; }
        else if (inputMetric == "m")     { number = number / m; }

        if (outputMetric == "mm")        {number = number * mm; }
        else if (outputMetric == "mi")   { number = number * mi; }
        else if (outputMetric == "inn")  { number = number * inn; }
        else if (outputMetric == "ft")   { number = number * ft; }
        else if (outputMetric == "km")   { number = number * km; }
        else if (outputMetric == "yd")   { number = number * yd; }
        else if (outputMetric == "cm")   { number = number * cm; }
        else if (outputMetric == "m")    { number = number * m; }

        Console.WriteLine("{0} {1}",number,inputMetric);



    }
}