using System;

namespace Study
{
    public class CyclicList
    {
        private ListElement<int> root = null;

        public void Add(ListElement<int> element, ListElement<int> parent)
        {
            if (root == null)
            {
                root = element;
                root.Next = root;
            }
            else
            {
                // вставляем между корнем и следующим
                ListElement<int> nextNext = parent.Next;
                parent.Next = element;
                element.Next = nextNext;
            }
        }

        public void DeleteChild(ListElement<int> parent)
        {
            if (parent.Next == parent)
            {
                parent = null;
            }
            else
            {
                parent.Next = parent.Next.Next;
            }
        }
    }

    public class ListElement<T>
    {
        public ListElement(T val)
        {
            Value = val;
        }

        public T Value
        {
            get;
            set;
        }

        public ListElement<T> Next
        {
            get;
            set;
        }
    }
}
