using System;

namespace Study
{
    public class Joseph
    {
        public static int Process(int N, int M)
        {
            CyclicList lst = new CyclicList();
            ListElement<int> pt = new ListElement<int>(0);
            lst.Add(pt, pt);
            for (int i = 1; i < N; i++)
            {
                var tm = new ListElement<int>(i);
                lst.Add(tm, pt);
                pt = tm;
            }
            ListElement<int> el = pt;
            while (el.Next != el)
            {
                for (int i = 0; i < M; i++)
                {
                    el = el.Next;
                }
                Console.WriteLine("Remove {0}", el.Next.Value);
                el.Next = el.Next.Next;
            }
            return el.Value;
        }
    }
}
