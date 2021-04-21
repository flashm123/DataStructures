using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public int Data
        {
            get;
            set;
        }

        public Node Left;
        public Node Right;
        
    }
}
