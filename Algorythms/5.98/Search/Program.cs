using System;
using System.Collections.Generic;

namespace Search
{
    class Program
    {
        private static List<int> visits = new List<int>();

        private static IDictionary<int, LinkedList<int>> adjacencyLists =
                new Dictionary<int, LinkedList<int>>()
                {
                    {0, new LinkedList<int>(new List<int>(){2, 4, 6})},
                    {1, new LinkedList<int>(new List<int>(){1, 4, 3})},
                    {2, new LinkedList<int>(new List<int>(){2, 5, 0})},
                    {3, new LinkedList<int>(new List<int>(){3, 6, 1})},
                    {4, new LinkedList<int>(new List<int>(){4, 0, 1})},
                    {5, new LinkedList<int>(new List<int>(){5, 2})},
                    {6, new LinkedList<int>(new List<int>(){6, 0, 3})},
                };
        private static int[] visited = new int[adjacencyLists.Count];

        static void Main(string[] args)
        {
            //SearchStack();
            SearchRecurse(0);
        }

        private static void SearchStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            stack.Push(0);
            int element = 0;
            while (element != -1)
            {
                if (visited[element] != 1)
                {
                    VisitNode(element);
                    visited[element] = 1;
                }
                LinkedListNode<int> node = adjacencyLists[element].First;
                while (node != null)
                {
                    if (visited[node.Value] != 1)
                    {
                        stack.Push(node.Value);
                    }
                    node = node.Next;
                }
                element = stack.Pop();
            }
        }

        private static void VisitNode(int element)
        {
            // do smth
            visits.Add(element);
        }

        private static void SearchRecurse(int element)
        {
            VisitNode(element);
            visited[element] = 1;
            LinkedListNode<int> node;
            for (node = adjacencyLists[element].First; node != null; node = node.Next)
            {
                if (visited[node.Value] != 1)
                {
                    SearchRecurse(node.Value);
                }
            }
        }
    }
}
