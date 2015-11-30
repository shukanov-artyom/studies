using System;
using System.Collections.Generic;

namespace Study
{
    class Search
    {
        private const int N = 1000, M = 10000;

        public static void Find()
        {
            var data = new int[M];
            for (int i = 0; i < M - 1; i++)
            {
                data[i] = i;
            }
            var rnds = new int[N];
            var rnd = new Random();
            for (int i = 0; i < N - 1; i++)
            {
                rnds[i] = rnd.Next(M);
            }
            var found = new List<int>();
            foreach (int r in rnds)
            {
                foreach (var d in data)
                {
                    if (r == d)
                    {
                        if (!found.Contains(d))
                        {
                            found.Add(d);
                        }
                    }
                }
            }
        }
    }
}
