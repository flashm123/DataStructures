using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            var linkedList = new LinkedList<string>("a", "b", "c", "d", "e", "f", "g", "h");

            // linkedList.Remove("c");
            // linkedList.Remove("g");

            linkedList.Reverse();

            foreach (var item in linkedList.GetNodes())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
