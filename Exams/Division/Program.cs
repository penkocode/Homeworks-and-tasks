using System;

class Division
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var n1 = 0.00;
        var n2 = 0.00;
        var n3 = 0.00;

        for (int i = 0; i < n; i++)
        {
            int numb = int.Parse(Console.ReadLine());
            if (numb % 2 == 0)
            {
                n1++;
            }
            if (numb % 3 == 0)
            {
                n2++;
            }
            if (numb % 4 == 0)
            {
                n3++;
            }
            
        }
        Console.WriteLine("{0:f2}%", n1 / n * 100);
        Console.WriteLine("{0:f2}%", n2 / n * 100);
        Console.WriteLine("{0:f2}%", n3 / n * 100);

    }
}