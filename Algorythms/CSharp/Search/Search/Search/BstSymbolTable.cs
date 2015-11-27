using System;
using System.Collections.Generic;
using Search.Utils;

namespace Search
{
    public class BstSymbolTable : ISymbolTable
    {
        private BstItem root;
        private int count = 0;

        public void Insert(Item item)
        {
            InsertBstRecursive(ref root, item);
            ++count;
            //InsertBstNonRecursive(ref root, item);
        }

        public int Count()
        {
            return BstTreeUtils.GetNodesCount(root);
        }

        public Item Search(int key)
        {
            return BstTreeUtils.SearchBst(root, key);
        }

        public void Remove(Item item)
        {
            --count;
            BstTreeUtils.RemoveRecursive(ref root, item.Key);
        }

        public Item Select(int k)
        {
            return BstTreeUtils.SelectRecursive(root, k);
        }

        public void TreeAnalysis()
        {
            int height = BstTreeUtils.CalculateHeight(root);
            Console.WriteLine("BST tree height: {0}", height);
            int ipl = BstTreeUtils.CalculateInternalPathLength(root);
            Console.WriteLine("BST internal path length: {0}", ipl);
            Console.WriteLine("BST average path length: {0}", ipl / count);
            BstTreeUtils.CrossTraverseRecursive(root, item => Console.Write("{0},", item.Item.Key));
            Console.WriteLine("Nodes count: {0}", BstTreeUtils.GetNodesCount(root));
        }

        private void InsertBstNonRecursive(ref BstItem tree, Item item)
        {
            if (tree == null)
            {
                tree = new BstItem(item);
            }
            BstItem p = tree;
            for (BstItem q = p; q != null; p = q == null ? p : q)
            {
                q = item < p.Item ? p.Left : p.Right;
            } // нашли парент 
            if (item < p.Item)
            {
                p.Left = new BstItem(item);
            }
            else
            {
                p.Right = new BstItem(item);
            }
        }

        private void InsertBstRecursive(ref BstItem tree, Item item)
        {
            if (tree == null)
            {
                tree = new BstItem(item)
                       {
                           Left = null,
                           Right = null
                       };
            }
            else
            {
                if (tree.Item > item)
                {
                    InsertBstRecursive(ref tree.Left, item);
                }
                else
                {
                    InsertBstRecursive(ref tree.Right, item);
                }
            }
        }

        public void InsertIntoRoot(Item item)
        {
            BstTreeUtils.InsertIntoRoot(ref root, item);
            ++count;
        }
    }
}
