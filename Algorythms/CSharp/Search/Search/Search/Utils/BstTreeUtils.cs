using System;
using System.Collections.Generic;

namespace Search.Utils
{
    public static class BstTreeUtils
    {
        public static int CalculateHeight(BstItem tree)
        {
            if (tree == null)
            {
                return -1;
            }
            int leftHeight = CalculateHeight(tree.Left);
            int rightHeight = CalculateHeight(tree.Right);
            return 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);
        }

        /// <summary>
        /// Поиск в бинарном дереве
        /// </summary>
        public static  Item SearchBst(BstItem tree, int key)
        {
            if (tree.Item.Key == key)
            {
                return tree.Item;
            }
            if (key < tree.Item.Key)
            {
                return SearchBst(tree.Left, key);
            }
            return SearchBst(tree.Right, key);
        }

        /// <summary>
        /// Поиск в бинарном дереве
        /// </summary>
        public static Item SearchBst(RbItem tree, int key)
        {
            if (tree.Item.Key == key)
            {
                return tree.Item;
            }
            if (key < tree.Item.Key)
            {
                return SearchBst(tree.Left, key);
            }
            return SearchBst(tree.Right, key);
        }

        /// <summary>
        /// Рекурсивный прямой обход.
        /// </summary>
        public static void DirectTraverseRecursive(BstItem node, Action<BstItem> visit)
        {
            if (node == null)
            {
                return;
            }
            visit(node);
            DirectTraverseRecursive(node.Left, visit);
            DirectTraverseRecursive(node.Right, visit);
        }

        /// <summary>
        /// Позволяет выбрать сортированный по возрастанию массив ключей
        /// </summary>
        public static void CrossTraverseRecursive(BstItem node, Action<BstItem> visit)
        {
            if (node == null)
            {
                return;
            }
            CrossTraverseRecursive(node.Left, visit);
            visit(node);
            CrossTraverseRecursive(node.Right, visit);
        }

        /// <summary>
        /// Нерекурсивный прямой обход.
        /// </summary>
        public static void DirectTraverseNonRecursive(BstItem node, Action<BstItem> visit)
        {
            Stack<BstItem> stack = new Stack<BstItem>();
            stack.Push(node);
            while (stack.Count != 0)
            {
                BstItem item = stack.Pop();
                visit(item);
                if (item.Left != null) stack.Push(item.Left);
                if (item.Right != null) stack.Push(item.Right);
            }
        }

        /// <summary>
        /// Обход по уровням, на каждом уровне сохраняем значение уровня для каждого элемента
        /// Посещая элемент, инкрементим общий счётчик на уровень этого элемента.
        /// </summary>
        public static int CalculateInternalPathLength(BstItem node)
        {
            int result = 0;
            Queue<LeveledBstItem> queue = new Queue<LeveledBstItem>();
            queue.Enqueue(new LeveledBstItem(node, 0));
            while (queue.Count != 0)
            {
                LeveledBstItem item = queue.Dequeue();
                result += item.Level;
                if (item.Item.Left != null) queue.
                    Enqueue(new LeveledBstItem(item.Item.Left, item.Level + 1));
                if (item.Item.Right != null) queue.
                    Enqueue(new LeveledBstItem(item.Item.Right, item.Level + 1));
            }
            return result;
        }

        /// <summary>
        /// Вставка в корень - рекурсивеая реализация
        /// </summary>
        public static void InsertIntoRoot(ref BstItem root, Item item)
        {
            if (root == null)
            {
                root = new BstItem(item);
                return;
            }
            if (item < root.Item)
            {
                InsertIntoRoot(ref root.Left, item);
                RotateRight(ref root);
            }
            else
            {
                InsertIntoRoot(ref root.Right, item);
                RotateLeft(ref root);
            }
        }

        /// <summary>
        /// Поворот направо.
        /// Узел становится правым дочерним узлом своего левого дочернего узла
        /// </summary>
        public static void RotateRight(ref BstItem a)
        {
            BstItem left = a.Left;
            a.Left = left.Right;
            left.Right = a;
            a = left;
        }

        /// <summary>
        /// Поворот узла вправо для красно-чёрного дерева.
        /// </summary>
        /// <param name="a"></param>
        public static void RotateRight(ref RbItem a)
        {
            RbItem left = a.Left;
            a.Left = left.Right;
            left.Right = a;
            a = left;
        }

        /// <summary>
        /// Поворот налево.
        /// Узел становится левым дочерним узлом своего правого дочернего узла
        /// </summary>
        public static void RotateLeft(ref BstItem a)
        {
            BstItem x = a.Right;
            a.Right = x.Left;
            x.Left = a;
            a = x;
        }

        /// <summary>
        /// Поворот налево  в красно-чёрном дереве.
        /// Узел становится левым дочерним узлом своего правого дочернего узла
        /// </summary>
        public static void RotateLeft(ref RbItem a)
        {
            RbItem x = a.Right;
            a.Right = x.Left;
            x.Left = a;
            a = x;
        }

        /// <summary>
        /// Сосчитать узлы в дереве
        /// </summary>
        public static int GetNodesCount(BstItem root) 
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + GetNodesCount(root.Left) + GetNodesCount(root.Right);
        }

        /// <summary>
        /// Сосчитать узлы в красно-чёрном дереве
        /// </summary>
        public static int GetNodesCount(RbItem root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + GetNodesCount(root.Left) + GetNodesCount(root.Right);
        }

        /// <summary>
        /// Рекурсивная выборка.
        /// Возвращается k-й наименьший элемент.
        /// </summary>
        public static Item SelectRecursive(BstItem tree, int k)
        {
            if (tree == null)
            {
                return null;
            }
            int t = GetNodesCount(tree.Left);
            if (t > k)
            {
                SelectRecursive(tree.Left, k);
            }
            else if (t < k)
            {
                SelectRecursive(tree.Right, k - t - 1);
            }
            return tree.Item;
        }

        /// <summary>
        /// Нерекурсивная выборка.
        /// Возвращается k-й наименьший элемент.
        /// </summary>
        public static Item SelectNonRecursive(BstItem tree, int k)
        {
            if (tree == null)
            {
                return null;
            }
            int k1 = k;
            BstItem item = tree;
            int c;
            while ((c = GetNodesCount(item.Left)) != k1)
            {
                if (c > k1)
                {
                    item = item.Left;
                }
                else if (c < k1)
                {
                    k1 = k1 - c - 1;
                    item = item.Right;
                }
            }
            return item.Item;
        }

        /// <summary>
        /// Разбиение BST-дерева.
        /// k-й наименьший элемент попадёт в корень.
        /// </summary>
        public static void PartitionRecursive(ref BstItem tree, int k)
        {
            // сколько у нас в левом поддереве?
            int t = tree.Left == null ? 0 : GetNodesCount(tree.Left);
            if (t > k) // новый корень - в левом поддереве
            {
                PartitionRecursive(ref tree.Left, k);
                RotateRight(ref tree);
            }
            else if (t < k) // новый корень - в правом поддереве
            {
                PartitionRecursive(ref tree.Right, k-t-1);
                RotateLeft(ref tree);
            }
            // иначе - разбиение уже изначально было верным
        }

        /// <summary>
        /// Удаляем из бинарного дерева корень.
        /// </summary>
        /// <param name="tree"></param>
        public static void RemoveRoot(ref BstItem tree)
        {
            tree = Join(ref tree.Left, ref tree.Right);
        }

        /// <summary>
        /// Удаляем из бинарного дерева элемент с заданным ключом.
        /// </summary>
        public static void RemoveRecursive(ref BstItem tree, int key)
        {
            if (tree == null)
            {
                return; // не нашли такого элемента
            }
            if (key < tree.Item.Key) // ищем в левом деревк
            {
                RemoveRecursive(ref tree.Left, key);
            }
            if (key > tree.Item.Key) // ищем в правом дереве
            {
                RemoveRecursive(ref tree.Right, key);
            }
            if (key == tree.Item.Key) // нашли, удаляем, объединяя левое и правое поддеревья
            {
                tree = Join(ref tree.Left, ref tree.Right);
            }
        }

        /// <summary>
        /// Удаление из красно-чёрного дерева.
        /// </summary>
        public static void Remove(ref RbItem tree, int key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Объединение двух бинарных деревьев.
        /// </summary>
        public static BstItem Join(ref BstItem left, ref BstItem right)
        {
            if (right == null)
            {
                return left;
            }
            PartitionRecursive(ref right, 0);
            right.Left = left;
            return right;
        }

        public static bool DigitBit(int key, int bitNumber)
        {
            return ((key >> (32 - bitNumber - 1)) & 1) == 1;

            /*int bitsShift = 32 - bitNumber - 1;
            int mask = 1;
            int shifted = key >> bitsShift;
            int masked = shifted & mask;
            return masked == 1;*/
        }

        private class LeveledBstItem
        {
            public LeveledBstItem(BstItem node, int level)
            {
                Item = node;
                Level = level;
            }

            public BstItem Item { get; set; }

            public int Level { get; set; }
        }
    }
}
