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
            binaryTree.Insert(56);
            binaryTree.Insert(83);
            binaryTree.Insert(2);
            binaryTree.Insert(13);

            binaryTree.IndexNodes();

            // Game game = new Game();
            // game.Run();
        }
    } 
}
