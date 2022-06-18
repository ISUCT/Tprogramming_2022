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
        }

        public void Insert(T value)
        {
            Root.Add(value);
        }

        public void IndexNodes()
        {
            nodeQueue.Enqueue(Root);
            int index = 1;
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();

                node.Index = index;
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

        public void ShowNodes()
        {
            nodeQueue.Enqueue(Root);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                System.Console.WriteLine(node.Index + " - " + node.Data);
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

        public void GetByIndex(int index)
        {
            var node = Root.GetNode(index);
            if (node != null)
            {
                System.Console.WriteLine($"Found {node.Data}");
                return;
            }

            System.Console.WriteLine("Node with this index not found");
        }

        public void Remove(T value)
        {

        }

        public void Remove(int Index)
        {

        }
    }
}