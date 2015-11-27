using System;

namespace Study
{
    public static class Excs317
    {
        public static int Test()
        {
            Random r = new Random();
            int N = 1000;
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = 0;
            }
            int tries = 0;
            int j = 0;
            do
            {
                tries ++;
                j = r.Next(1000);
                if (a[j] == 1)
                {
                    break;
                }
                a[j] = 1;
            } while (true);
            return tries;
        }
    }
}
