using System;
using System.Threading;

namespace Lambdas
{
    class Program
    {
        private delegate int GetTwoBoolsReturnIntDelegate(bool a, bool b);

        static void Main(string[] args)
        {
            GetTwoBoolsReturnIntDelegate d = (a, b) =>
            {
                if (a && b) return 1; 
                return 2;
            };
            int v = d(true, true);

            var t = new Thread(ts => Console.WriteLine("Thread worked."));
            t.Start();
            t.Join();
            Console.Read();
        }
    }
}
