using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Impl
{
    /// <summary>
    /// реализация на основе листа связных списков.
    /// </summary>
    public class SparseMultiGraph : IGraph
    {
        private readonly bool directed;
        private readonly int V;
        private readonly List<AdjListItem> adj;
        private int edgesCount;

        public SparseMultiGraph(int v, bool directed)
        {
            this.V = v;
            edgesCount = 0;
            this.directed = directed;
            adj = new List<AdjListItem>(V);
            for (int i = 0; i < V; i++)
            {
                adj.Add(null);
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
            if (!Exists(edge))
            {
                edgesCount++;
                adj[v] = new AdjListItem() { Next = adj[v], W=w };
                if (!directed)
                {
                    adj[w] = new AdjListItem() { Next = adj[w], W = v };
                }
            }
        }

        public void Remove(Edge edge)
        {
            if (Exists(edge))
            {
                int v = edge.V;
                int w = edge.W;
                Remove(adj, v, w);
                Remove(adj, w, v);
                edgesCount--;
            }
        }

        private void Remove(List<AdjListItem> adj, int v, int w)
        {
            if (adj[v] == null)
            {
                return;
            }
            if (adj[v].W == w)
            {
                adj[v] = adj[v].Next;
                return;
            }
            AdjListItem itemToDeleteChild = adj[v];
            while (itemToDeleteChild.Next.W != w)
            {
                itemToDeleteChild = itemToDeleteChild.Next;
            }
            if (itemToDeleteChild != null)
            {
                itemToDeleteChild.Next = itemToDeleteChild.Next.Next;
            }
        }

        public int GetComponentsCount()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(int vertexA, int vertexB)
        {
            return Exists(new Edge() {V=vertexA, W=vertexB});
        }

        public IEnumerable<int> Adjacent(int v)
        {
            AdjListItem item = adj[v];
            while (item != null)
            {
                yield return item.W;
                item = item.Next;
            }
        }

        private bool Exists(Edge e)
        {
            AdjListItem item = adj[e.V];
            if (adj[e.V] == null)
            {
                return false;
            }
            while (item != null)
            {
                if (item.W == e.W)
                {
                    return true;
                }
                item = item.Next;
            }
            return false;
        }

        private class AdjListItem
        {
            public AdjListItem Next;

            public int W
            {
                get;
                set;
            }
        }

    }
}
