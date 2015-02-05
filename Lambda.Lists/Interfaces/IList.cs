namespace Lambda.Lists
{
    public interface IList<T> where T : new()
    {
        void Add(T item);
        T Remove(T item);
        T RemoveAt(int index);
        int IndexOf(T item);

        T this[int index] { get; }
        int Length { get; }
        int Count { get; }
        int Capacity { get; }
    }
}