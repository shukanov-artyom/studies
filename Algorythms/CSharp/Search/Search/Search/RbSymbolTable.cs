using System;
using Search.Utils;

namespace Search
{
    public class RbSymbolTable : ISymbolTable
    {
        private RbItem root;

        private static bool IsRed(RbItem item)
        {
            return item != null && item.IsRed;
        }

        /// <summary>
        /// Рекурсивная вставка в красно-чёрное дерево.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="item"></param>
        /// <param name="sw">Если на предыдущем уровне вставка была влево, то False, если в правое дерево, то True.</param>
        private static void Insert(ref RbItem root, Item item, bool sw)
        {
            if (root == null)
            {
                // если дерево пустое то вставляем новый чёрный элемент (не часть 3- или 4-элемента)
                root = new RbItem(item);
                return;
            }
            // разбиваем на рекурсивном спуске, если это 4-узел
            if (IsRed(root.Left) && IsRed(root.Right))
            {
                // перекрашиваем
                root.Left.IsRed = false;
                root.Right.IsRed = false;
                root.IsRed = true;
            }
            // рекурсивная вставка в правое или в левое поддерево
            if (item < root.Item)
            {
                // вставляем в левое поддерево
                Insert(ref root.Left, item, false);
                // ротации на подъёме
                if (root.IsRed && root.Left.IsRed && sw) // две однонаправленные последовательные красные ссылки
                {
                    BstTreeUtils.RotateRight(ref root);
                }
                if (root.Left.IsRed && root.Left.Left.IsRed) // две однонаправленные последовательные красные ссылки уровнем ниже
                {
                    BstTreeUtils.RotateRight(ref root);
                    root.IsRed = false;
                    root.Right.IsRed = true;
                }
            }
            else
            {
                // вставляем в правое поддерево
                Insert(ref root.Right, item, true);
                // ротации на подъёме
                if (root.IsRed && root.Right.IsRed && !sw)
                {
                    BstTreeUtils.RotateLeft(ref root);
                }
                if (root.Right.IsRed && root.Right.Right.IsRed)
                {
                    BstTreeUtils.RotateLeft(ref root);
                    root.IsRed = false;
                    root.Left.IsRed = true; // сделали нормальный 4-узел
                }
            }
        }

        public void Insert(Item item)
        {
            Insert(ref root, item, false);
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
            throw new NotImplementedException();
        }

        public Item Select(int key)
        {
            throw new NotImplementedException();
        }
    }
}
