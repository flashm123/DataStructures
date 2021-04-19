using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        
        public T Data
        {
            get;
            set;
        }

        public Node<T> Next
        {
            get;
            set;
        }
    }
}
