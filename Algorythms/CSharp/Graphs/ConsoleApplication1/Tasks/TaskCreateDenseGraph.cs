using System;
using ConsoleApplication1.Generators;

namespace ConsoleApplication1.Tasks
{
    public class TaskCreateDenseGraph : GraphProcessingTaskBase
    {
        public TaskCreateDenseGraph(int vertexes)
            : base(vertexes)
        {
        }

        protected override void ProcessInternal(IGraph graph)
        {
            var gen = new GraphGeneratorRandomEdges(Vertexes, true);
            gen.Fill(graph);
        }

        protected override void Prepare(IGraph graph)
        {
            // nothing
        }
    }
}
