namespace Lambda.Lists
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IList<T>, IEnumerable<T> where T : new()
    {
        public void Add(T item)
        {
            if (this.list.Length <= count)
            {
                var temp = new T[this.list.Length * 2];
                Array.Copy(this.list, 0, temp, 0, this.list.Length);
                this.list = temp;
            }

            this.list[count++] = item;
        }

        public T Remove(T item)
        {
            return this.RemoveAt(this.IndexOf(item));
        }

        public T RemoveAt(int index)
        {
            if ((uint)index >= (uint)count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.list[index];
            this.count--;

            if (index < count)
            {
                Array.Copy(this.list, index + 1, this.list, index, count - index);
            }
            
            return item;
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(this.list, item, 0, count);
        }

        public T this[int index]
        {
            get
            {
                if ((uint)index >= (uint)this.list.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.list[index];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List()
        {
            this.list = new T[1];
        }

        public int Length { get { return this.count; } }
        public int Count { get { return this.count; } }
        public int Capacity { get { return this.list.Length; } }

        private T[] list;
        private int count = 0;
    }
}
