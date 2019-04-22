using System;

namespace Sorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Basic sorting method that traverses an array and sorts smaller values back towards the front.
        /// </summary>
        /// <param name="arr">Int Array to sort.</param>
        /// <returns>Sorted int Array.</returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }

            return arr;
        }
    }
}
