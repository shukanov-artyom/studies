using System;

namespace ConsoleApplication1
{
    public struct Edge
    {
        public Edge()
        {
            V = W = -1;
        }

        public Edge(int v, int w)
        {
            V = v;
            W = w;
        }

        public int V { get; set; }

        public int W { get; set; }

        public override bool Equals(object obj)
        {
            Edge e = (Edge)obj;
            return e.V == V && e.W == W;
        }
    }
}
