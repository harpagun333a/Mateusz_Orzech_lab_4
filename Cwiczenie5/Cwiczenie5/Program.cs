using System;

namespace Cwiczenie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 5");

            string input;
            bool czy_samogloska = false;

            char[] samogloski = new char[] { 'a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
  
            Console.WriteLine("\nPodaj pojedynczy symbol: ");

            while((input = Console.ReadLine()) != "-1")
            {
                czy_samogloska = false;

                if(input.Length != 1)
                {
                    Console.WriteLine("Niepoprawna liczba znaków.\n\nPodaj pojedynczy symbol: ");
                    continue;
                }

                if(char.IsDigit(char.Parse(input)))
                {
                    Console.WriteLine("To jest cyfra");
                }
                else
                {
                    for(int i=0; i < samogloski.Length; i++)
                    {
                        if(char.Parse(input) == samogloski[i])
                        {
                            czy_samogloska = true;
                            break;
                        }
                    }

                    if(czy_samogloska)
                    {
                        Console.WriteLine("To jest samogłoska");
                    }
                    else
                    {
                        Console.WriteLine("To nie jest ani samogłoska ani cyfra");
                    }
                }
                Console.WriteLine("\nPodaj pojedynczy symbol: ");
            }
        }
    }
}
