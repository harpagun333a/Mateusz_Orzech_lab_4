using System;

namespace Cwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie2");

            // (a)
            Point2D_private point_private1;
            //Console.WriteLine(point_private1.ToString()); //Nie da się

            // (b)
            Point2D_private point_private2 = new Point2D_private();
            Console.WriteLine(point_private2.ToString());

            // (d)
            Point2D_konstruktor point_konstruktor1 = new Point2D_konstruktor();
            point_konstruktor1.Print2DPoint();

        }


        struct Point2D_konstruktor
        {
            private int x;
            private int y;

            // (c)
            //public Point2D_konstruktor()  // Nie da się
            //{
            //}

            public Point2D_konstruktor(int dx = 0, int dy = 0)
            {
                x = dx;
                y = dy;
            }

            public void Reset()
            {
                x = 0;
                y = 0;
            }

            public void IncrX(int dx)
            {
                x += dx;
            }

            public void IncrY(int dy)
            {
                y += dy;
            }

            public void Print2DPoint()
            {
                Console.WriteLine("x = " + x.ToString());
                Console.WriteLine("y = " + y.ToString());
                Console.WriteLine();
            }

            public double Dist(Point2D_konstruktor point)
            {
                return Math.Sqrt((x - point.x) * (x - point.x) + (y - point.y) * (y - point.y));
            }
        }

        struct Point2D_private
        {
            private int x;
            private int y;

            public void Reset()
            {
                x = 0;
                y = 0;
            }

            public void IncrX(int dx)
            {
                x += dx;
            }

            public void IncrY(int dy)
            {
                y += dy;
            }

            public void Print2DPoint()
            {
                Console.WriteLine("x = " + x.ToString());
                Console.WriteLine("y = " + y.ToString());
                Console.WriteLine();
            }

            public double Dist(Point2D_private point)
            {
                return Math.Sqrt((x - point.x) * (x - point.x) + (y - point.y) * (y - point.y));
            }
        }
    }
}
