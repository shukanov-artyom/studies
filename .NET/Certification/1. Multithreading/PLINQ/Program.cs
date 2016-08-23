using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // давайте попробуем обойти коллекцию объектов асинхронно
            // для этого нам нужны какие-то длительные операции с каждым элеменом колекции, например асинхронный ввод-вывод.
            // и сравним время

            TimeSpan par = Measure(DoParallel);
            Cleanup();
            TimeSpan seq = Measure(DoSequential);
            Cleanup();

            Console.WriteLine($"Sequential Result: {seq.Milliseconds} ms");
            Console.WriteLine($"Parallel Result: {par.Milliseconds} ms");
            // параллелизм тут, похоже, совсем не к месту.
            Console.Read();
        }

        private static void DoParallel()
        {
            ParallelQuery<string> pEnumerable = Paths().AsParallel();
            pEnumerable.ForAll(ProcessFile); // простая PLINQ-операция с помощью метода расширения.
            IEnumerable<string> p = pEnumerable.AsSequential(); // конвертируем параллельную последовательноть (!!) в обычный энумерабл.
        }

        private static void DoSequential()
        {
            foreach (string path in Paths())
            {
                ProcessFile(path);
            }
        }

        private static TimeSpan Measure(Action doer)
        {
            DateTime start = DateTime.Now;
            doer.Invoke();
            DateTime finish = DateTime.Now;
            return finish - start;
        }

        private static IEnumerable<string> Paths()
        {
            foreach (int i in Enumerable.Range(0, 100))
            {
                yield return $@"C:\tmp\file{i}.txt";
            }
        }

        private static IEnumerable<string> GetLines()
        {
            foreach (int i in Enumerable.Range(0, 10))
            {
                yield return Guid.NewGuid().ToString();
            }
        }

        private static void ProcessFile(string s)
        {
            //using (FileStream fs = File.OpenWrite(s))
            using (MemoryStream fs = new MemoryStream())
            {
                using (StreamWriter w = new StreamWriter(fs))
                {
                    foreach (string line in GetLines())
                    {
                        w.WriteLine(line);
                    }
                }
            }
        }

        private static void Cleanup()
        {
            foreach (string path in Paths())
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                };
            }
        }
    }
}
