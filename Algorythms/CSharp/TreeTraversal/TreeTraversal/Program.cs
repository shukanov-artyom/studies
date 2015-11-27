using System;
using System.Collections.Generic;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // form tree
            Node a = new Node()
            {
                Name = "A"
            };
            a.Left = new Node()
            {
                Name = "B"
            };
            a.Right = new Node()
            {
                Name = "C"
            };

            ProcessReverse(a);
            //ProcessDirect(a);
            //ProcessByLevels(a);

            Console.Read();
        }

        public static void ProcessDirect(Node a)
        {
            if (a != null)
            {
                Visit(a);
                ProcessDirect(a.Left);
                ProcessDirect(a.Right);
            }
        }

        public static void ProcessReverse(Node a)
        {
            if (a != null)
            {
                ProcessDirect(a.Left);
                ProcessDirect(a.Right);
                Visit(a);
            }
        }

        public static void ProcessCross(Node a)
        {
            if (a != null)
            {
                ProcessDirect(a.Left);
                Visit(a);
                ProcessDirect(a.Right);
            }
        }

        public static void ProcessByLevels(Node a)
        {
            Queue<Node> q = new Queue<Node>();
            if (a != null)
            {
                q.Enqueue(a);
                while (q.Count != 0)
                {
                    Node n = q.Dequeue();
                    Visit(n);
                    if (n.Left != null)
                    {
                        q.Enqueue(n.Left);
                    }
                    if (n.Right != null)
                    {
                        q.Enqueue(n.Right);
                    }
                }
            }
        }

        public static void Visit(Node n)
        {
            Console.WriteLine(n.Name);
        }
    }

    public class Node
    {
        public string Name;

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
