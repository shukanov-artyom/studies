using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Impl
{
    public class DictionaryGraph : IGraph
    {
        private readonly IDictionary<int, bool> adj =
            new Dictionary<int, bool>();
        private readonly HashSet<int> vertexes = 
            new HashSet<int>(); 

        private int edgesCount;
        private bool digraph;
        private int V;

        public DictionaryGraph(int V, bool digraph)
        {
            this.digraph = digraph;
            this.V = V;
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
            vertexes.Add(edge.V);
            vertexes.Add(edge.W);
            int hash = Hash(edge);
            if (adj.ContainsKey(hash) && adj[hash])
            {
                return;
            }
            adj[hash] = true;
        }

        public void Remove(Edge edge)
        {
            adj[Hash(edge)] = false;
        }

        public int GetComponentsCount()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected(int vertexA, int vertexB)
        {
            int hash = Hash(new Edge(vertexA, vertexB));
            if (!adj.ContainsKey(hash))
            {
                return false;
            }
            return adj[hash];
        }

        public IEnumerable<int> Adjacent(int v)
        {
            for (int i = 0; i < V; i++)
            {
                if (IsConnected(v, i))
                {
                    yield return i;
                }
            }
        }

        private int Hash(Edge e)
        {
            if (e.V == e.W)
            {
                return e.V*e.V + e.W;
            }
            if (!digraph)
            {
                int v = e.V > e.W ? e.V : e.W;
                int w = e.V > e.W ? e.W : e.V;
                return v * v + w;
            }
            return e.V * e.V + e.W;
        }
    }
}
