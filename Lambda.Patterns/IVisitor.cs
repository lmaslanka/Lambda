namespace Lambda.Patterns
{
    public interface IVisitor<T>
    {
        void Visit(T item);

        bool HasCompleted { get; }
    }
}
