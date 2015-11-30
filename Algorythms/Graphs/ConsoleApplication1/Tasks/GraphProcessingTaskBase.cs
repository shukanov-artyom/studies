using System;

namespace ConsoleApplication1.Tasks
{
    public abstract class GraphProcessingTaskBase : IGraphProcessingTask
    {
        private readonly int vertexes;

        protected GraphProcessingTaskBase(int vertexes)
        {
            this.vertexes = vertexes;
        }

        protected int Vertexes
        {
            get
            {
                return vertexes;
            }
        }

        public void Process(IGraph graph)
        {
            Prepare(graph);
            using (new Measure(graph, this))
            {
                ProcessInternal(graph);
            }
        }

        protected abstract void Prepare(IGraph graph);

        protected abstract void ProcessInternal(IGraph graph);
    }
}