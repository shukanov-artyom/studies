using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Impl
{
    public class DenseGraph : IGraph
    {
        private int edgesCount;

        // используем листы для реализации матрицы
        private readonly List<List<bool>> adjMatrix = new List<List<bool>>();
        private readonly int V;
        private readonly bool digraph;

        public DenseGraph(int v, bool digraph)
        {
            V = v;
            this.digraph = digraph;
            for (int i = 0; i < V; i++)
            {
                adjMatrix.Add(new List<bool>(V));
                for (int j = 0; j < V; j++)
                {
                    adjMatrix[i].Add(false);
                }
            }
        }

        public int Vertexes
        {
            get
            {
                return V;
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
            int v = edge.V;
            int w = edge.W;
            if (!adjMatrix[v][w])
            {
                edgesCount++;
                adjMatrix[v][w] = true;
            }
            if (!digraph)
            {
                adjMatrix[w][v] = true;
            }
        }

        public void Remove(Edge edge)
        {
            int v = edge.V;
            int w = edge.W;
            if (adjMatrix[v][w])
            {
                adjMatrix[v][w] = false;
            }
            if (!digraph)
            {
                adjMatrix[w][v] = false;
            }
        }

        public int GetComponentsCount()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(int vertexA, int vertexB)
        {
            return adjMatrix[vertexA][vertexB];
        }

        public IEnumerable<int> Adjacent(int v)
        {
            List<bool> vector = adjMatrix[v];
            for (int i = 0; i < v; i++)
            {
                if (vector[i])
                {
                    yield return i;
                }
            }
        } 
    }
}
