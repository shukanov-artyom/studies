using System;

namespace Study
{
    public class Points
    {
        private int G = 0;
        private ListElement<Point>[,] grid;
        int N = 1000;
        double d = 0.1;
        private int count = 0;

        public void Process()
        {
            Random r = new Random();
            Point[] a = new Point[N];
            //List<Tuple<Point,Point>> result = new List<Tuple<Point, Point>>();
            for (int i = 0; i < N; i++)
            {
                a[i] = new Point();
                a[i].X = r.Next(100);
                a[i].Y = r.Next(100);
            }
            int result = 0;
            int checks = 0;
            for (int i = 0; i < N; i++) // перебираем все точки
            {
                for (int j = i+1; j < N; j++)
                {
                    checks++;
                    if (Length(a[i], a[j]) < d)
                    {
                        result++;
                    }
                }
            }
        }

        public void Process2()
        {
            int N = 1000;
            Random r = new Random();
            Point[] a = new Point[N];

            G = (int)(1/d);

            grid = new ListElement<Point>[G+2,G+2];
            for (int i = 0; i < G + 2; i++)
            {
                for (int j = 0; j < G + 2; j++)
                {
                    grid[i, j] = null;
                }
            }

            for (int i = 0; i < N; i++)
            {
                gridinsert(r.Next(1), r.Next(1));
            }
        }

        private void gridinsert(int x, int y)
        {
            int X = x*G + 1;
            int Y = y*G + 1;
            ListElement<Point> s, t = 
                new ListElement<Point>(new Point(){X = x, Y = y})
                                      {
                                          Next = grid[X,Y]
                                      };
            for (int i = X - 1; i <= X + 1; i++)
            {
                for (int j = Y - 1; j < Y + 1; j++)
                {
                    for (s = grid[i, j]; s != null; s = s.Next)
                    {
                        if (Length(s.Value, t.Value) > d)
                        {
                            count ++;
                        }
                    }
                }
            }
            grid[X, Y] = t;
        }

        private static double Length(Point a, Point b)
        {
            double dx = (b.X - a.X)*(b.X - a.X);
            double dy = (b.Y - a.Y)*(b.Y - a.Y);
            return Math.Sqrt(dx + dy);
        }

        private class Point
        {
            public double X
            {
                get;
                set;
            }

            public double Y
            {
                get;
                set;
            }
        }
    }
}
