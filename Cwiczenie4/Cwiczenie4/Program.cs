using System;

namespace Cwiczenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 4");

            // 1.
            Day today;
            int day_nr = 0;

            string input;
            bool is_day_in_range = false;

            while(!is_day_in_range)
            {
                Console.WriteLine("\nPodaj numer dnia tygodnia:");
                input = Console.ReadLine();

                if(!int.TryParse(input, out day_nr))
                {
                    Console.WriteLine("Błędny format danych.");
                    continue;
                }

                if(day_nr > 0 && day_nr < 8)
                {
                    is_day_in_range = true;
                }
                else
                {
                    Console.WriteLine("Podany numer nie mieści się w zakresie 1-7.");
                }
            }

            Console.WriteLine("Dniem o numerze {0} jest " + (Day)day_nr, day_nr);

            // 2.
            Wartosc wart;
            int input_int = 0;

            bool is_input_in_range = false;
            while(!is_input_in_range)
            {
                Console.WriteLine("\nPodaj liczbę naturalną większą lub równą 0:");
                input = Console.ReadLine();

                if (!int.TryParse(input, out input_int))
                {
                    Console.WriteLine("Błędny format danych.");
                    continue;
                }

                if (!(input_int >= 0))
                {
                    Console.WriteLine("Liczba poza zakresem.");
                    continue;
                }
                else
                {
                    is_input_in_range = true;
                }
            }

            if(input_int < 10)
            {
                wart = Wartosc.mala;
            }
            else if(input_int < 100)
            {
                wart = Wartosc.srednia;
            }
            else
            {
                wart = Wartosc.duza;
            }

            Console.WriteLine("Podana liczba jest " + wart.ToString());

        }

        enum Day
        {
            Poniedzialek = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        };

        enum Wartosc
        {
            mala,
            srednia,
            duza
        };

    }
}
