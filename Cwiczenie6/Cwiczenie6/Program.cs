using System;

namespace Cwiczenie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 6");

            string input = "";

            while(input != "q")
            {
                Console.Write("\nIn: ");
                input = Console.ReadLine();

                for(int i = input.Length - 1; i > 0; i--)
                {
                    input = input.Insert(i, " ");
                }

                Console.WriteLine("Out: " + input);
            }
        }
    }
}
