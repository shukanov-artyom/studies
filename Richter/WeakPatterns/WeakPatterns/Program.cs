using System;

namespace WeakPatterns
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Foo f = new Foo(); // event source
            for (int i = 0; i < 20000; i++)
            {
                var b = new Bar();
                f.Click += b.Method;
            }
            //f.OnClick(EventArgs.Empty);
            GC.Collect();
            f.OnClick(EventArgs.Empty);
            Console.Read();
        }

        private class Bar
        {
            public void Method(object s, EventArgs e)
            {
                Console.WriteLine("Cliecked");
            }
        }
    }
}
