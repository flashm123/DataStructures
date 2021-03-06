using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LinkedList
{
    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
        }

        public LinkedList(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Insert(elements[i]);
            }
        }

        /// <summary>
        /// Insert element to the linked list
        /// </summary>
        /// <param name="data">Item to add</param>
        public void Insert(T data)
        {
            var itemToAdd = new Node<T>(data);

            if (head == null)
            {
                head = itemToAdd;
            }
            else
            {
                tail.Next = itemToAdd;
            }

            tail = itemToAdd;
        }


        /// <summary>
        /// Remove element from the linked list
        /// </summary>
        /// <param name="data">Item to remove</param>
        public void Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous == null)
                    {
                        head = current.Next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    else
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = null;
                        }
                    }
                }

                previous = current;
                current = current.Next;
            }
        }

        /// <summary>
        /// Reverse the linked list
        /// </summary>
        public void Reverse()
        {
            Swap(head);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="current"></param>
        private void Swap(Node<T> current)
        {
            Node<T> previous;

            if (current != tail)
            {
                previous = current;
                current = current.Next;
                Swap(current);
                tail.Next = previous;
                tail = previous;
            }
            else
            {
                head.Next = null;
                head = tail;
            }
        }

        /// <summary>
        /// Iterator pattern
        /// </summary>
        /// <returns></returns>
        public IEnumerable GetNodes()
        {
            var current = head;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }
    }
}
