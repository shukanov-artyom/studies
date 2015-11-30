using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Impl
{
    public class SparseGraphList : IGraph
    {
        private readonly int V;
        private readonly bool digraph;

        private int vertexesCount;
        private int edgesCount;

        // используем списки для динамического выделения памяти.
        private List<List<int>> adjLists;

        public SparseGraphList(int V, bool digraph)
        {
            this.V = V;
            this.digraph = digraph;
            adjLists = new List<List<int>>(V);
            for (int i = 0; i < V; i++)
            {
                adjLists.Add(new List<int>());
            }
        }

        public int Vertexes
        {
            get
            {
                return adjLists.Count;
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
            if (adjLists[v].Contains(w))
            {
                return;
            }
            adjLists[v].Add(w);
            if (!digraph)
            {
                adjLists[w].Add(v);
            }
            edgesCount++;
        }

        public void Remove(Edge edge)
        {
            int v = edge.V;
            int w = edge.W;
            if (!adjLists[v].Contains(w))
            {
                return;
            }
            adjLists[v].Remove(w);
            if (!digraph)
            {
                adjLists[w].Remove(v);
            }
            edgesCount--;
        }

        public int GetComponentsCount()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(int vertexA, int vertexB)
        {
            return adjLists[vertexA].Contains(vertexB);
        }

        public IEnumerable<int> Adjacent(int v)
        {
            if (adjLists[v] == null)
            {
                return new List<int>();
            }
            return adjLists[v];
        }
    }
}
