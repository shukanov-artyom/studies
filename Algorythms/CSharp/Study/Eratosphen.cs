using System;

namespace Study
{
    public static class Eratosphen
    {
        public static void Process()
        {
            DateTime t1 = DateTime.Now;
            /*IDictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < 10000; i++)
            {
                result[i] = Get(i);
            }
            using (FileStream fs = new FileStream("c:\\out.csv", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter w = new StreamWriter(fs))
                {
                    foreach (KeyValuePair<int, int> pair in result)
                    {
                        w.WriteLine(String.Format("{0},{1}", pair.Key, pair.Value));
                    }
                }
            }*/
            Get(1000000);
            TimeSpan ts= DateTime.Now - t1;
        }

        public static int Get(int N)
        {
            int i;
            int[] a = new int[N];
            for (i = 2; i < N; i++)
            {
                a[i] = 1;
            }
            for (i=2; i<N; i++)
            {
                if (a[i] == 1) // проверка 
                {
                    long k = 0;
                    for (int j = i; (long)i*j < N; j++)
                    {
                        k = (long)i * j;
                        a[k] = 0;
                    }
                }
            }
            int result = 0;
            for (int k=0; k<N; k++)
            {
                if (a[k] == 1)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
