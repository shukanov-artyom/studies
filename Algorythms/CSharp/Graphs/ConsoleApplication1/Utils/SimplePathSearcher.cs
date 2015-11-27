using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Utils
{
    public class SimplePathSearcher
    {
        private readonly IGraph graph;
        private readonly HashSet<int> visited = 
            new HashSet<int>();
        private readonly List<int> path = new List<int>();

        public SimplePathSearcher(IGraph graph)
        {
            this.graph = graph;
        }

        public int[] Search(int v, int w)
        {
            if (SearchRec(w, v))
            {
                return path.ToArray();
            }
            return new List<int>().ToArray();
        }

        private bool SearchRec(int v, int w)
        {
            if (v == w)
            {
                return true;
            }
            visited.Add(v);
            foreach (int i in graph.Adjacent(v))
            {
                if (!visited.Contains(i))
                {
                    if (SearchRec(i, w))
                    {
                        path.Add(i);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
