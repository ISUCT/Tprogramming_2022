using BinaryTree;

namespace RpgSaga
{
    public class Program
    {
        public static void Main()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Insert(5);
            binaryTree.Insert(8);
            binaryTree.Insert(4);
            binaryTree.Insert(56);
            binaryTree.Insert(2);
            binaryTree.Insert(13);
            binaryTree.Insert(14);

            binaryTree.IndexNodes();
            binaryTree.ShowNodes();
            binaryTree.GetByIndex(8);
            binaryTree.GetByIndex(7);
            binaryTree.EditByIndex(7, 59);
        }
    } 
}
