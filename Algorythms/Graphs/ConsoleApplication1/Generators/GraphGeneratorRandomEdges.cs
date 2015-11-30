using System;

namespace ConsoleApplication1.Generators
{
    public class GraphGeneratorRandomEdges : GraphGeneratorBase
    {
        private readonly Random r;

        public GraphGeneratorRandomEdges(int vertexes, bool dense) :
            base(vertexes, dense)
        {
            r = new Random(DateTime.Now.Millisecond);
        }

        public override IGraph Fill(IGraph graph)
        {
            if (graph == null)
            {
                throw new ArgumentNullException("graph");
            }
            for (int i = 0; i < GetEdgesCount(); i++)
            {
                graph.Insert(GenerateRandomEdge());
            }
            return graph;
        }

        private Edge GenerateRandomEdge()
        {
            int V;
            int W;
            do
            {
                V = r.Next(Vertexes);
                W = r.Next(Vertexes);
            } while (V == W);
            return new Edge(V, W);
        }

        private int GetEdgesCount()
        {
            if (Dense)
            {
                return (int)(0.8 * Vertexes*(Vertexes - 1)/2);
            }
            return (int)(0.8*Vertexes);
        }
    }
}
