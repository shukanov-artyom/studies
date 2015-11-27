using System;
using ConsoleApplication1.Generators;
using ConsoleApplication1.Utils;

namespace ConsoleApplication1.Tasks
{
    internal class TaskDetermineVertexesDegrees : GraphProcessingTaskBase
    {
        public TaskDetermineVertexesDegrees(int vertexes) : 
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
                GraphUtils.GetDegree(graph, i);
            }
        }
    }
}
