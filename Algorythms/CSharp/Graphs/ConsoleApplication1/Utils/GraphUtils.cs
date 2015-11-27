using System;

namespace ConsoleApplication1.Utils
{
    public static class GraphUtils
    {
        /// <summary>
        /// Определение степени вершины неориентированного графа
        /// </summary>
        public static int GetDegree(IGraph graph, int vertex)
        {
            int result = 0;
            for (int i = 0; i < graph.Vertexes; i++)
            {
                if (graph.IsConnected(i, vertex))
                {
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// Поиск простого пути.
        /// </summary>
        public static int[] SimplePath(IGraph g, int v, int w)
        {
            if (v == w)
            {
                return new int[0];
            }
            var s = new SimplePathSearcher(g);
            return s.Search(v, w);
        }
    }
}
