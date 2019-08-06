using System;
using Trees.Classes;

namespace BinaryTreeHeight
{
    class Program
    {
        public static int GetHeight(BinaryTree tree)
        {
            if (tree == null)
            {
                throw new ArgumentNullException();
            }
                return GetHeight(tree.Root, 0);
        }

        private static int GetHeight(Node root, int height)
        {
            if (root == null)
            {
                return height;
            }

            int leftHeight = GetHeight(root.Left, height + 1);
            int rightHeight = GetHeight(root.Right, height + 1);

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


}
