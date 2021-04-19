using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 0, 7, 9, -10, 139, -1, 0 };

            Reverse(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Reverses array
        /// </summary>
        /// <param name="array">The array to reverse</param>
        static void Reverse(int[] array)
        {
            var middle = array.Length / 2;
            var temp = 0;

            for (int i = 0; i <= middle; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
    }
}
