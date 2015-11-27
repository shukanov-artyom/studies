using System;

namespace ConsoleApplication1.Generators
{
    public class GraphGeneratorRandom : GraphGeneratorBase
    {
        public GraphGeneratorRandom(int vertexes, bool dense) :
            base(vertexes, dense)
        {
        }

        public override IGraph Fill(IGraph graph)
        {
            throw new NotImplementedException();
        }
    }
}
