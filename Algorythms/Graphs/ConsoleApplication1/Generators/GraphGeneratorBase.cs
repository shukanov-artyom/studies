using System;

namespace ConsoleApplication1.Generators
{
    public abstract class GraphGeneratorBase
    {
        private readonly int vertexes;
        private readonly bool dense;

        public GraphGeneratorBase(int vertexes, bool dense)
        {
            this.dense = dense;
            this.vertexes = vertexes;
        }

        protected int Vertexes
        {
            get
            {
                return vertexes;
            }
        }

        protected bool Dense
        {
            get
            {
                return dense;
            }
        }

        public abstract IGraph Fill(IGraph graph);
    }
}
