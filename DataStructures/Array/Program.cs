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
            int[] source;

            source = GetInputArray(out source);

            // Reverse(numbers);

            Console.WriteLine("Sum is {0}", Sum(source));

            /*
             * foreach (var number in source)
            {
                Console.Write(number + " ");
            }
             * */
            Console.ReadKey();
        }

        /// <summary>
        /// Input array fron console
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        static int[] GetInputArray(out int[] source)
        {
            Console.WriteLine("Please input the array length");

            try
            {
                int length = int.Parse(Console.ReadLine());

                source = new int[length];

                Console.WriteLine("Please input the array");

                for (int i = 0; i < length; i++)
                {
                    source[i] = int.Parse(Console.ReadLine());
                }
            }
            finally
            {
            }

            return source;
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

        /// <summary>
        /// Summarizes array
        /// </summary>
        /// <param name="array"></param>
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
