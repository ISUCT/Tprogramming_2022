namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        Queue<Node<T>> nodeQueue;
        Node<T> Root { get; set; }
        public BinaryTree()
        {
            Root = new Node<T>();
            nodeQueue = new Queue<Node<T>>();
            nodeQueue.Enqueue(Root);
        }

        public void Insert(T value)
        {
            Root.Add(value);
        }

        public void IndexNodes()
        {
            int index = 1;
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                node.Index = index;
                System.Console.WriteLine(node.Index + " - " + node.Data);
                index++;
                if (node.Left != null)
                {
                    nodeQueue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    nodeQueue.Enqueue(node.Right);
                }
            }
        }

        public void Remove(T value)
        {
            
        }

        public void Remove(int Index)
        {
            
        }
    }
}