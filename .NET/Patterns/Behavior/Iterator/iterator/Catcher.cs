using System;
using System.Collections.Generic;

namespace iterator
{
    internal class Catcher
    {
        public IEnumerable<int> Generator()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            while (true)
            {
                try
                {
                    yield return r.Next(0, 100);
                }
                /*catch
                {
                    // but yield return cannot appear in try/catch block! 
                    // only try/finally is possible!
                    // but Finally is not guaranteed to execute!!
                }*/
                finally
                {
                    r.ToString();
                }
            }
        }
    }
}
