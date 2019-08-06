using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    class BinarySearchTree
    {
        public BinaryTree Tree { get; set; }

        public BinarySearchTree(BinaryTree tree)
        {
            Tree = tree;
        }

        public void Add(Node node)
        {
            Node root = Tree.Root;

            if(root == null)
            {
                Tree.Root = node;
            }
            else
            {
                Node last = root;
                
                while(root != null)
                {
                    last = root;

                    if((int) node.Value > (int) root.Value)
                    {
                        root = root.Right;
                    }
                    else if((int) node.Value < (int)root.Value)
                    {
                        root = root.Left;
                    }

                }
                if((int) node.Value > (int)last.Value)
                {
                    last.Right = node;
                }
                else
                {
                    last.Left = node;
                }
            }
        }

        public Node FindNode(int value)
        {
            Node root = Tree.Root;

            while(root != null)
            {
                if(value == (int)root.Value)
                {
                    return root;
                }
                if(value < (int)root.Value)
                {
                    root = root.Left;
                }
                else
                {
                    root = root.Right;
                }
            }
            return null;
        }
    }
}
