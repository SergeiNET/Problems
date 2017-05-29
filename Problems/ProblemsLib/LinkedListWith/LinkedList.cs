using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LinkedListWith
{
    public class LinkedList<T> : ICollection<T>
    {
        private LinkedListNode<T> Head { get; set; }
        private LinkedListNode<T> Tail { get; set; }

        public int Count { private set; get; }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = Tail = new LinkedListNode<T> { Data = item };
            } else
            {
                Tail.Next = new LinkedListNode<T> { Data = item };
                Tail = Tail.Next;
            }

            Count++;
        }

        public void AddToHead(T item)
        {
            if (Head == null)
            {
                Head = Tail = new LinkedListNode<T> { Data = item };
            }
            else
            {
                var newHead = new LinkedListNode<T> { Data = item };
                newHead.Next = Head;
                Head = newHead;
            }

            Count++;
        }

        public void Clear()
        {
            Head = Tail = null;
        }

        public bool Contains(T item)
        {
            foreach (var val in this)
            {
                if (val.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            do
            {
                yield return current.Data;
                current = current.Next;
            }
            while (current != null);
        }

        public bool Remove(T item)
        {
            var node = FindParentNode(item);
            if (node != null)
            {

                var nodeToRemove = node.Next;
                if (nodeToRemove == Tail)
                {
                    Tail = node;
                }
                node.Next = nodeToRemove.Next;
                Count--;
                return true;
            } else
            {
                if (node == Head)
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private LinkedListNode<T> FindNodeOrNull(T val)
        {
            LinkedListNode<T> current = Head;
            do
            {
                if (current.Data.Equals(val))
                {
                    return current;
                }

                current = current.Next;
            }
            while (current != null);

            return null;
        }

        private LinkedListNode<T> FindNodeByIndex(int index)
        {
            int currentIndex = 0;
            LinkedListNode<T> current = Head;
            do
            {
                if (index == currentIndex)
                {
                    return current;
                }

                currentIndex++;
                current = current.Next;
            }
            while (current != null);

            return null;
        }

        public T GetNFromTheEnd(int n)
        {
            int currentIndex = 0;
            LinkedListNode<T> current = Head;
            do
            {
                if (n == Count - 1 - currentIndex)
                {
                    return current.Data;
                }

                currentIndex++;
                current = current.Next;
            }
            while (current != null);
            return default(T);
        }
        private LinkedListNode<T> FindParentNode(T val)
        {
            if (val == null) { throw new ArgumentNullException("val can't be null"); }
            LinkedListNode<T> current = Head;
            do
            {
                if (current.Next != null && val.Equals(current.Next.Data))
                {
                    return current;
                }

                current = current.Next;
            }
            while (current != null);

            return null;
        }

        public T this[int i]
        {
            get {
                if(i >= Count || i < 0)
                {
                    throw new IndexOutOfRangeException("Max index can be:" + (Count - 1));
                }
                return FindNodeByIndex(i).Data;
            }
            set {
                if (i >= Count || i < 0)
                {
                    throw new IndexOutOfRangeException("Max index can be:" + (Count - 1));
                }
                FindNodeByIndex(i).Data = value;
            }
        }
    }

    public class LinkedListNode<T>
    {
        public T Data;
        public LinkedListNode<T> Next;
    }
}
