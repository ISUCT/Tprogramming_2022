namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        Node<T> Root { get; set; }
        public BinaryTree()
        {
            Root = new Node<T>(); 
        }

        public void Insert(T value)
        {
            Root.Add(value);
        }

        public void IndexNodes()
        {
            return;
        }
    }
}