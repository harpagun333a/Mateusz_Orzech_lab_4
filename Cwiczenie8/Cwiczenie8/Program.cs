using System;

namespace Cwiczenie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 8\n");

            // punkt nr 1
            Point p = new Point(1, 2);
            Coords c = new Coords(3, 4);

            p.print();
            c.print();

            Fun1(p);
            Fun2(c);

            Console.WriteLine();
            p.print();
            c.print();

            // punkt nr 2
            Point p1 = new Point(3, 3);
            Point p2 = new Point(3, 3);
            Coords c1 = new Coords(3, 3);
            Coords c2 = new Coords(3, 3);

            Console.WriteLine("\n\n");

            Console.WriteLine(Object.Equals(p1, p2));
            Console.WriteLine(Object.Equals(c1, c2));
            Console.WriteLine(Object.Equals(c1, p1));

            Console.WriteLine();

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.Equals(p1));
            Console.WriteLine(p2.Equals(c2));

            Console.WriteLine();

            Console.WriteLine(Object.ReferenceEquals(p1, p2));
            Console.WriteLine(Object.ReferenceEquals(c1, c2));
            Console.WriteLine(Object.ReferenceEquals(c1, p1));

        }

        public struct Coords
        {
            public int x, y;
            public Coords(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

            public void print()
            {
                Console.WriteLine("Coords:\nx: " + x + "\ny: " + y);
            }
        }

        public class Point
        {
            public int x, y;
            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }

            public void print()
            {
                Console.WriteLine("Punkt:\nx: " + x + "\ny: " + y);
            }
        }

        static void Fun1(Point p)
        {
            p.x = 6;
            p.y = 6;
        }

        static void Fun2(Coords c)
        {
            c.x = 7;
            c.y = 7;
        }
    }
}
