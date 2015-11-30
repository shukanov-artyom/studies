using System;
using ConsoleApplication1.Tasks;

namespace ConsoleApplication1
{
    internal class Measure : IDisposable
    {
        private readonly DateTime start;
        private readonly IGraph graph;
        private readonly IGraphProcessingTask task;

        public Measure(IGraph graph, IGraphProcessingTask task)
        {
            this.graph = graph;
            this.task = task;
            start = DateTime.Now;
        }

        public void Dispose()
        {
            DateTime end = DateTime.Now;
            Console.WriteLine("{0} for {1} time {2} ms", 
                task.GetType().Name, 
                graph.GetType().Name, 
                (end - start).TotalMilliseconds);
        }
    }
}
