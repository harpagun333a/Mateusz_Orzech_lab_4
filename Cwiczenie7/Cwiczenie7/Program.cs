using System;

namespace Cwiczenie7
{
    class Program
    {
        static int maxIntValue = 2147483647;

        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 7");

            int n;

            Console.WriteLine("\nPrzykład przepełnienia");
            n = maxIntValue;
            Console.WriteLine(n);
            n += 10;
            Console.WriteLine(n);
            Console.WriteLine();

            // Wyrzucenie błędu podczas przepełnienia
            try
            {
                n = checked(maxIntValue + 10);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Wystąpił błąd przepełnienia.");
            }

        }
    }
}
