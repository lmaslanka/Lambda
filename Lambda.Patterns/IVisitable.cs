namespace Lambda.Patterns
{
    public interface IVisitable<T>
    {
        void Accept(IVisitor<T> visitor);
    }
}
