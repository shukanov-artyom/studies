using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Utils
{
    /// <summary>
    /// Реализация поиска в глубину на графе.
    /// </summary>
    internal class DepthFirstSearcher
    {
        private readonly IGraph g;
        private readonly List<int> order; 

        private int counter = 0;

        public DepthFirstSearcher(IGraph g, int v = 0)
        {
            this.g = g;
            order = new List<int>(g.Vertexes);
            for (int i=0; i<g.Vertexes; i++)
            {
                order.Add(-1);
            }
            SearchC(v);
        }

        public List<int> Order
        {
            get
            {
                return order;
            }
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }

        private void SearchC(int v)
        {
            order[v] = counter++;
            foreach (int adj in g.Adjacent(v))
            {
                if (order[adj] == -1)
                {
                    SearchC(adj);
                }
            }
        }
    }
}
