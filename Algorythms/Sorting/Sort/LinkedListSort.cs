using System;
using System.Collections.Generic;

namespace Sort
{
    public class LinkedListSort
    {
        public void Sort()
        {
            LinkedList<double> list = GenerateList();
            SelectionSort(list);
        }

        private void SelectionSort(LinkedList<double> list)
        {
            LinkedList<double> result = new LinkedList<double>();
            while (list.First != null)
            {
                LinkedListNode<double> preMaxItem = FindPreMinItem(list);
                result.AddLast(preMaxItem != null ? preMaxItem.Next.Value : list.First.Value);
                list.Remove(preMaxItem != null ? preMaxItem.Next : list.First);
            }
            ElementsSwap(result.First);
        }

        private LinkedListNode<double> FindPreMinItem(LinkedList<double> list)
        {
            LinkedListNode<double> result = null;
            LinkedListNode<double> item = list.First;
            while (item.Next != null)
            {
                if ((result == null && item.Next.Value < list.First.Value) ||
                    result != null && item.Next.Value < result.Next.Value)
                {
                    result = item;
                }
                item = item.Next;
            }
            return result;
        }

        private LinkedList<double> GenerateList()
        {
            LinkedList<double> result = new LinkedList<double>();
            result.AddFirst(22.7);
            result.AddFirst(2.3);
            result.AddFirst(11.1);
            result.AddFirst(2.0);
            result.AddFirst(1.9);
            result.AddFirst(12.1);
            result.AddFirst(1.1);
            return result;
        }

        private static void ElementsSwap(LinkedListNode<double> prePairElement)
        {
            LinkedList<double> list = prePairElement.List;

            // 1
            LinkedListNode<double> node = prePairElement;
            LinkedListNode<double> node2 = node.Next;
            list.Remove(node.Next.Next);
            node.List.AddAfter(node, node.Next.Next);

            // 2 
            node = node.Next;
            list.Remove(node2);
            node.List.AddAfter(node, node2);

            // 3
            list.Remove(node.Next);
            node2.List.AddAfter(node2, node.Next);
        }
    }
}
