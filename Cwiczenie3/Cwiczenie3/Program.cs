using System;

namespace Cwiczenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3");
            string input;

            int tmp_int;
            float tmp_float;
            string tmp_string;

            int inty = 0;
            int floaty = 0;
            int stringi = 0;

            while((input = Console.ReadLine()) != "-1")
            {
                Console.WriteLine("Napisz daną typu int, float lub string:");
                if (int.TryParse(input, out tmp_int))
                {
                    inty += 1;
                }
                else if (float.TryParse(input, out tmp_float))
                {
                    floaty += 1;
                }
                else
                {
                    stringi += 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Liczba wprowadzonych zmiennych typu int: " + inty.ToString());
            Console.WriteLine("Liczba wprowadzonych zmiennych typu float: " + floaty.ToString());
            Console.WriteLine("Liczba wprowadzonych zmiennych typu string: " + stringi.ToString());

        }
    }
}
