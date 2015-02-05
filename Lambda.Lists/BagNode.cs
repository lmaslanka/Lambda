namespace Lambda.Lists
{
    public class BagNode<T>
    {
        public BagNode(T data)
        {
            this.Data = data;
        }

        public BagNode<T> Next { get; set; }
        public T Data { get; set; }
    }
}
