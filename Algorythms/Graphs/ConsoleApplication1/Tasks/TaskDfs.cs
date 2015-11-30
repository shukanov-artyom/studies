using System;
using System.Collections.Generic;
using ConsoleApplication1.Generators;
using ConsoleApplication1.Utils;

namespace ConsoleApplication1.Tasks
{
    internal class TaskDfs : GraphProcessingTaskBase
    {
        Random r = new Random(DateTime.Now.Millisecond);

        public TaskDfs(int vertexes) : 
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
            for (int i = 0; i < Vertexes; i++)
            {
                int w = r.Next(Vertexes);
                DepthFirstSearcher dfs = new DepthFirstSearcher(graph, w);
                List<int> v = dfs.Order;
            }
        }
    }
}
