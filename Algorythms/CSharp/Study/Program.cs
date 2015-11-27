using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            new Points().Process();
            new Points().Process2();



            /*List<int> l = new List<int>();
            for (int i = 2; i < 1000; i++)
            {
                l.Add(Joseph.Process(i, 10));
            }
            l.ToArray();*/

            /*IList<int> res = new List<int>();
            for (int i=0; i<100; i++)
            {
                res.Add(Excs317.Test());
            }
            double result = res.Average();*/

            //Eratosphen.Process();

            /*int[] a = new int[99];
            for (int i = 0; i < 99; i++)
            {
                a[i] = 98 - i;
            }
            for (int i = 0; i < 99; i++)
            {
                a[i] = a[a[i]];
            }*/

            //Search.Find();
            /*double Hn = Harmonic.Calculate(120);
            double Hnn = Harmonic.CalculateNative(120);*/

            //int N = 1000000;
            /*var arr = new Dictionary<int, long>();
            for (int i = 100; i < 1000; i++)
            {
                arr.Add(i, TestFor(i));
            }*/
        }

        private static long TestFor(int N)
        {
            var data = new List<int>(N);
            var wt = new List<int>(); // trees sizes
            for (int i = 0; i < N; i++)
            {
                data.Add(i);
                wt.Add(1);
            }
            var map = new List<Tuple<int, int>>(N - 1); // data
            for (int i = 0; i < N - 2; i++)
            {
                map.Add(GeneratePair(N));
            }
            DateTime start = DateTime.Now;
            long ribs = 0;
            foreach (Tuple<int, int> tuple in map)
            {
                //Link1(data, tuple.Item1, tuple.Item2);
                //Link2(data, tuple.Item1, tuple.Item2);
                //Link3(data, wt, tuple.Item1, tuple.Item2);
                //Link31(data, wt, tuple.Item1, tuple.Item2);
                ribs += Link4(data, wt, tuple.Item1, tuple.Item2);
            }
            TimeSpan taken = DateTime.Now - start;
            /*DateTime start2 = DateTime.Now;
            foreach (Tuple<int, int> tuple in map)
            {
                //Link1(data, tuple.Item1, tuple.Item2);
                //Link2(data, tuple.Item1, tuple.Item2);
                //Link3(data, wt, tuple.Item1, tuple.Item2);
                Link31(data, wt, tuple.Item1, tuple.Item2);
                //Link4(data, wt, tuple.Item1, tuple.Item2);
            }
            TimeSpan taken2 = DateTime.Now - start2;*/
            return ribs;
        }

        /// <summary>
        /// Быстрый поиск.
        /// </summary>
        private static void Link1(List<int> arr, int a, int b)
        {
            int t = arr[a];
            int arrb = arr[b];
            if (t == arr[b])
            {
                return; // already linked
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == t)
                {
                    arr[i] = arrb;
                }
            }
        }

        /// <summary>
        /// Быстрое объединение
        /// </summary>
        private static void Link2(List<int> arr, int a, int b)
        {
            int rootA, rootB;
            for (rootA = a; arr[rootA] != rootA; rootA = arr[rootA]) ;
            for (rootB = b; arr[rootB] != rootB; rootB = arr[rootB]) ;
            if (rootA != rootB)
            {
                arr[rootA] = rootB;
            }
        }

        /// <summary>
        /// Взвешенное быстрое объединение 
        /// </summary>
        private static void Link3(List<int> arr, List<int> wt, int a, int b)
        {
            int rootA, rootB;
            for (rootA = a; arr[rootA] != rootA; rootA = arr[rootA]) ;
            for (rootB = b; arr[rootB] != rootB; rootB = arr[rootB]) ;
            if (rootA != rootB)
            {
                if (wt[rootA] < wt[rootB])
                {
                    arr[rootA] = rootB;
                    wt[rootA] += wt[rootB];
                }
                else
                {
                    arr[rootB] = rootA;
                    wt[rootB] += wt[rootA];
                }
            }
        }

        /// <summary>
        /// Взвешенное быстрое объединение по высоте дерева
        /// </summary>
        private static void Link31(List<int> arr, List<int> wt, int a, int b)
        {
            int rootA, rootB;
            // wt тут используем как высоту а не вес
            int heightA = 1, heightB = 1;
            for (rootA = a; arr[rootA] != rootA; rootA = arr[rootA])
            {
                heightA++;
            }
            if (wt[rootA] < heightA)
            {
                wt[rootA] = heightA;
            }
            for (rootB = b; arr[rootB] != rootB; rootB = arr[rootB])
            {
                heightB++;
            }
            if (wt[rootB] < heightB)
            {
                wt[rootB] = heightB;
            }
            if (rootA != rootB)
            {
                if (wt[rootA] < wt[rootB])
                {
                    arr[rootA] = rootB;
                    wt[rootA] ++;
                }
                else
                {
                    arr[rootB] = rootA;
                    wt[rootB] ++;
                }
            }
        }

        /// <summary>
        /// Взвешенное быстрое объединение со сжатием пути делением пополам
        /// </summary>
        private static long Link4(List<int> arr, List<int> wt, int a, int b)
        {
            long ribs = 0;
            int rootA, rootB;
            for (rootA = a; arr[rootA] != rootA; rootA = arr[rootA])
            {
                arr[rootA] = arr[arr[rootA]];
            }
            for (rootB = b; arr[rootB] != rootB; rootB = arr[rootB])
            {
                arr[rootB] = arr[arr[rootB]];
            }
            if (rootA != rootB)
            {
                if (wt[rootA] < wt[rootB])
                {
                    arr[rootA] = rootB;
                    ribs++;
                    wt[rootA] += wt[rootB];
                }
                else
                {
                    arr[rootB] = rootA;
                    ribs++;
                    wt[rootB] += wt[rootA];
                }
            }
            return ribs;
        }

        private static Tuple<int, int> GeneratePair(int N)
        {
            return new Tuple<int, int>(rnd.Next(0, N), rnd.Next(0, N));
        }
    }
}
