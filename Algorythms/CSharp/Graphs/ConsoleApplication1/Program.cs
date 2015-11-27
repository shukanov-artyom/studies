using System;
using System.Collections.Generic;
using ConsoleApplication1.Impl;
using ConsoleApplication1.Tasks;

namespace ConsoleApplication1
{
    public static class Program
    {
        private const int v = 100;

        public static void Main(string[] args)
        {
            Console.WriteLine("Performing tests for {0} vertexes base count", v);
            var tasks = new List<IGraphProcessingTask>()
                        {
                            new TaskCreateDenseGraph(v),
                            new TaskCreateSparseGraph(v),
                            new TaskSearch(v),
                            new TaskDetermineVertexesDegrees(v),
                            new TaskFindSimplePath(v),
                            new TaskDfs(v)
                        };

            foreach (IGraphProcessingTask task in tasks)
            {
                var graphs = new List<IGraph>()
                                  {
                                      new TrivialGraph(v),
                                      new DenseGraph(v, false),
                                      new SparseMultiGraph(v, false),
                                      new SparseGraphList(v, false),
                                      new DictionaryGraph(v, false)
                                  };
                foreach (IGraph graph in graphs)
                {
                    task.Process(graph);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
