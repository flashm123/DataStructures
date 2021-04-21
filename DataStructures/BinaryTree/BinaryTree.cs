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

        public void Insert(ref Node node, int data)
        {
            if (node == null)
            {
                var itemToAdd = new Node(data);
                node = itemToAdd;
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
