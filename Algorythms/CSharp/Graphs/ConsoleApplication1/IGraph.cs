using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public interface IGraph
    {
        int Vertexes { get; }

        int Edges { get; }

        void Insert(Edge edge);

        void Remove(Edge edge);

        int GetComponentsCount();

        bool IsConnected(int vertexA, int vertexB);

        IEnumerable<int> Adjacent(int v);
    }
}
