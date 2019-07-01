using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        public static List<Node> PreOrder(Node root, List<Node> nodeArray = null)
        {
            if(root == null)
            {
                return null;
            }
            if(nodeArray == null)
            {
                return new List<Node>();
            }

            nodeArray.Add(root);

            if(root.Left != null) 
            {
                PreOrder(root.Left, nodeArray);
            }
            if(root.Right != null)
            {
                PreOrder(root.Right, nodeArray);
            }

            return nodeArray;
        }

        public static List<Node> InOrder(Node root, List<Node> nodeArray = null)
        {
            if(root == null)
            {
                return null;
            }

            if(nodeArray == null)
            {
                nodeArray = new List<Node>();
            }

            if(root.Left != null)
            {
                InOrder(root.Left, nodeArray);
            }

            nodeArray.Add(root);

            if(root.Right != null)
            {
                InOrder(root.Right, nodeArray);
            }

            return nodeArray;
        }

        public static List<Node> PostOrder(Node root, List<Node> nodeArray = null)
        {
            if(root == null)
            {
                return null;
            }

            if(nodeArray == null)
            {
                nodeArray = new List<Node>();
            }

            if(root.Left != null)
            {
                PostOrder(root.Left, nodeArray);
            }

            if(root.Right != null)
            {
                PostOrder(root.Right, nodeArray);
            }

            nodeArray.Add(root);
            return nodeArray;
        }

    }
}
