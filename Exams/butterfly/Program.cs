using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int halfSizeOfRows = n - 2;

        for (int i = 1; i <= halfSizeOfRows; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}\\ /{0}", new string('*', halfSizeOfRows));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', halfSizeOfRows));
            }
        }

        Console.WriteLine("{0} @ {0}", new string(' ', halfSizeOfRows));

        for (int i = 1; i <= halfSizeOfRows; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', halfSizeOfRows));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', halfSizeOfRows));
            }
        }
    }
}

