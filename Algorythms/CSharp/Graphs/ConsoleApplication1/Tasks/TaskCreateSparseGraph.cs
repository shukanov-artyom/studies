using System;
using ConsoleApplication1.Generators;

namespace ConsoleApplication1.Tasks
{
    public class TaskCreateSparseGraph : GraphProcessingTaskBase
    {
        public TaskCreateSparseGraph(int vertexes) :
            base(vertexes)
        {
        }

        protected override void Prepare(IGraph graph)
        {
            // nothing
        }

        protected override void ProcessInternal(IGraph graph)
        {
            var gen = new GraphGeneratorRandomEdges(Vertexes, false);
            gen.Fill(graph);
        }
    }
}
