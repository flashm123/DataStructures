using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class BinaryTree
    {
        public Node root;
        
        public BinaryTree()
        {
        }

        public BinaryTree(params int[] nodes)
        {
            foreach (var node in nodes)
            {
                Insert(ref root, node);
            }
        }

        /// <summary>
        /// Insert the node to the Binary Tree
        /// </summary>
        /// <param name="node">Node to check with the input data</param>
        /// <param name="data">Data to insert</param>
        public void Insert(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else
            {
                if (data < node.Data)
                {
                    Insert(ref node.Left, data);
                }
                else if (data >= node.Data)
                {
                    Insert(ref node.Right, data);
                }
            }
        }
    }
}
