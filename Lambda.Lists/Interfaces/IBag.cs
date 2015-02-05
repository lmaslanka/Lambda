namespace Lambda.Lists
{
    using System.Collections.Generic;

    public interface IBag<T> : IEnumerable<T>
    {
        void Add(T item);

        bool IsEmpty { get; }
        int Size { get; }
    }
}
