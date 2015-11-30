using System;
using ConsoleApplication1.Generators;

namespace ConsoleApplication1.Tasks
{
    internal class TaskSearch : GraphProcessingTaskBase
    {
        private readonly Random r;

        public TaskSearch(int vertexes) : 
            base(vertexes)
        {
            r = new Random(DateTime.Now.Millisecond);
        }

        protected override void Prepare(IGraph graph)
        {
            var gen = new GraphGeneratorRandomEdges(Vertexes, false);
            gen.Fill(graph);
        }

        protected override void ProcessInternal(IGraph graph)
        {
            int s = Vertexes * 10;
            for (int i = 0; i < s; i++)
            {
                int v = r.Next(Vertexes);
                int w = r.Next(Vertexes);
                if (v == w)
                {
                    i--;
                    continue;
                }
                bool b = graph.IsConnected(v, w);
            }
        }
    }
}
