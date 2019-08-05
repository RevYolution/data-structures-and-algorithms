using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    class Node
    {
        /// <summary>
        /// Gets/sets left node of a tree
        /// </summary>
        public Node Left { get; set; }

        /// <summary>
        /// Gets/set right node of a tree
        /// </summary>
        public Node Right { get; set; }

        /// <summary>
        /// Gets/sets the value of a tree object
        /// </summary>
        public Object Value { get; set; }

        public Node(Object value)
        {
            Value = value;
        }
    }
}
