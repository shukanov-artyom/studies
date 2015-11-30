using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Impl
{
    /// <summary>
    /// Реализация на основе списка рёбер графа. 
    /// Неориентированный.
    /// </summary>
    public class TrivialGraph : IGraph
    {
        private int vertexesCount;
        private int edgesCount;
        private List<Edge> edges = new List<Edge>();

        private readonly int v;

        public TrivialGraph(int v)
        {
            this.v = v;
        }

        public int Vertexes
        {
            get
            {
                return v;
            }
        }

        public int Edges
        {
            get
            {
                return edgesCount;
            }
        }

        public void Insert(Edge edge)
        {
            if (!Exists(edge))
            {
                edges.Add(edge);
                edgesCount++;
            }
        }

        public void Remove(Edge edge)
        {
            if (Exists(edge))
            {
                edges.Remove(edge);
                edgesCount--;
            }
        }

        public int GetComponentsCount()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(int vertexA, int vertexB)
        {
            foreach (Edge edge in edges)
            {
                if ((edge.V == vertexA && edge.W == vertexB) || 
                    (edge.V == vertexB && edge.W == vertexA))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<int> Adjacent(int v)
        {
            foreach (Edge edge in edges)
            {
                if (edge.V == v)
                {
                    yield return edge.W;
                }
            }
        }

        private bool Exists(Edge e)
        {
            foreach (Edge edge in edges)
            {
                if (e.V == edge.V && e.W == edge.W)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
