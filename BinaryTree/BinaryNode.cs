namespace BinaryTree
{
    internal class Node<T> where T : IComparable
    {
        Node<T> Left { get; set; }
        Node<T> Right { get; set; }
        public T Data { get; private set; }
        public int Index;

        public void Add(T value)
        {
            if (Data == null || value.CompareTo(Data) == 0)
            {
                Data = value;
                return;
            }

            if (value.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = new Node<T>();
                }

                Left.Data = value;
                return;
            }

            if (value.CompareTo(Data) > 0)
            {
                if (Right == null)
                {
                    Right = new Node<T>();
                }

                Right.Data = value;
                return;
            }
        }

        public void IndexNode()
        {
            if (Left != null)
            {
                Left.IndexNode();
            }

            if (Right != null)
            {
                Right.IndexNode();
            }
        }
    }
}
