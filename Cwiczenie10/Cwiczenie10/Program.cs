using System;

namespace Cwiczenie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 10");

            short sh = 1;
            int i = 2;
            long l = 3;
            uint ui = 4;
            ushort ush = 5;


            // Przyklady konwersji niejawnej
            i = sh;
            l = i;
            l = sh;
            ui = ush;

            // Przykłady konwersji jawnej
            sh = (short)i;
            i = (int)l;
            sh = (short)l;
            ush = (ushort)ui;
        }
    }
}
