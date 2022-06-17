namespace BinaryTree
{
    internal class Node<T> where T : IComparable
    {
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }
        public T? Data { get; private set; }
        public int Index { get; set; }

        public Node()
        {
            Left = null;
            Right = null;
            Data = default(T);
        }

        public void Add(T value)
        {
            if (Data == null || Data.CompareTo(default(T)) == 0 || value.CompareTo(Data) == 0)
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

                Left.Add(value);
                return;
            }

            if (value.CompareTo(Data) > 0)
            {
                if (Right == null)
                {
                    Right = new Node<T>();
                }

                Right.Add(value);
                return;
            }
        }

        // public void RemoveByValue(T value)
        // {
        //     if (value.CompareTo(Data) == 0)
        //     {
                
        //         return;
        //     }

        //     if (value.CompareTo(Data) < 0)
        //     {
        //         if (Left == null)
        //         {
        //             Left = new Node<T>();
        //         }

        //         Left.Data = value;
        //         return;
        //     }

        //     if (value.CompareTo(Data) > 0)
        //     {
        //         if (Right == null)
        //         {
        //             Right = new Node<T>();
        //         }

        //         Right.Data = value;
        //         return;
        //     }
        // }
    }
}
