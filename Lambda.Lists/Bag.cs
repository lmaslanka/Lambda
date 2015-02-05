namespace Lambda.Lists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Bag<T> : IBag<T>, IEnumerable<T> where T : new()
    {
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            var temp = new BagNode<T>(item);
            temp.Next = root;
            root = temp;
            size++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = root;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty { get { return this.root == null; } }
        public int Size { get { return size; } }
        
        private BagNode<T> root;
        private int size;
    }
}
