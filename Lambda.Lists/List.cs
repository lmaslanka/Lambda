namespace Lambda.Lists
{
    using System;

    public class List<T> where T : IComparable<T>, new()
    {
        public void Add(T item)
        {
            if (this.list.Length <= count)
            {
                var temp = new T[this.list.Length * 2];
                Buffer.BlockCopy(this.list, 0, temp, 0, this.list.Length * sizeof(int));
                this.list = temp;
            }

            this.list[count++] = item;
        }

        public T Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            return this.RemoveAt(this.IndexOf(item));
        }

        public T RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if ((uint)index >= (uint)count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.list[index];
            this.count--;

            if (index < count)
            {
                int intSize = sizeof(int);
                Buffer.BlockCopy(this.list, (index + 1) * intSize , this.list, index * intSize, (count - index) * intSize);
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
