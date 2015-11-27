using System;
using ConsoleApplication1.Generators;
using ConsoleApplication1.Utils;

namespace ConsoleApplication1.Tasks
{
    /// <summary>
    /// поиск простого пути в графе.
    /// </summary>
    public class TaskFindSimplePath : GraphProcessingTaskBase
    {
        private readonly Random r = new Random(DateTime.Now.Millisecond);

        public TaskFindSimplePath(int vertexes) : 
            base(vertexes)
        {
        }

        protected override void Prepare(IGraph graph)
        {
            var gen = new GraphGeneratorRandomEdges(Vertexes, false);
            gen.Fill(graph);
        }

        protected override void ProcessInternal(IGraph graph)
        {
            for (int v = 0; v < Vertexes; v++)
            {
                int w;
                do
                {
                    w = r.Next(Vertexes);
                } while (v == w);
                GraphUtils.SimplePath(graph, v, w);
            }
        }
    }
}
