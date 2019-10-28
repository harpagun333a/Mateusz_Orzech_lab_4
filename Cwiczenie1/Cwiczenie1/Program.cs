using System;

namespace Cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point2D punkt1 = new Point2D(1, 2);
            Point2D punkt2 = new Point2D(3, 4);

            // Test działania metod
            punkt1.Print2DPoint();
            punkt1.IncrX(2);
            punkt1.Print2DPoint();
            punkt1.IncrY(3);
            punkt1.Print2DPoint();
            punkt1.Reset();
            punkt1.Print2DPoint();
            Console.WriteLine(punkt1.Dist(punkt2));
            Console.WriteLine();

            // wprowadzanie danych
            Point2D[] points = new Point2D[5];
            string tmp;
            int cos;
            const int rad = 5;
            bool w_okregu = false;

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Podaj wartosc x dla " + (i+1).ToString() + " srodka okregu");
                tmp = Console.ReadLine();
                points[i].x = int.Parse(tmp);
                Console.WriteLine("Podaj wartosc y dla " + (i + 1).ToString() + " srodka okregu");
                tmp = Console.ReadLine();
                points[i].y = int.Parse(tmp);
            }

            while (!w_okregu)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (points[i].Dist(points[4]) < rad)
                    {
                        w_okregu = true;
                    }
                    if (w_okregu)
                    {
                        Console.WriteLine("Punkt 5 w jednym z okregow");
                        break;
                    }
                }
                if (!w_okregu)
                {
                    Console.WriteLine("Punkt 5 nie miesci sie w zadnym z okregow");
                    Console.WriteLine("Podaj wartosc x dla 5 srodka okregu");
                    tmp = Console.ReadLine();
                    points[4].x = int.Parse(tmp);
                    Console.WriteLine("Podaj wartosc y dla 5 srodka okregu");
                    tmp = Console.ReadLine();
                    points[4].y = int.Parse(tmp);
                }
            }
        }

        struct Point2D
        {
            public Point2D(int dx, int dy)
            {
                x = dx;
                y = dy;
            }

            public int x;
            public int y;

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

            public double Dist(Point2D point)
            {
                return Math.Sqrt((x - point.x) * (x - point.x) + (y - point.y) * (y - point.y));
            }
        }
    }
}
