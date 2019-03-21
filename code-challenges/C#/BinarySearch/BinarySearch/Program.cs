using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunChallenge();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("There was an error.  The application will now close.");
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }

        static void RunChallenge()
        {
            Console.WriteLine("Please input an array length:");
            string arrayLengthInput = Console.ReadLine();
            int arrayLength = Convert.ToInt32(arrayLengthInput);
            int[] sortedArray = new int[arrayLength];

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine($"Please input number {i + 1} of {sortedArray.Length}");
                string arrayValueInput = Console.ReadLine();
                int arrayValue = Convert.ToInt32(arrayValueInput);
                sortedArray[i] = arrayValue;
            }
            Array.Sort(sortedArray);

            Console.WriteLine("Please input a number to search for:");
            string searchKeyInput = Console.ReadLine();
            int searchKey = Convert.ToInt32(searchKeyInput);

            Console.WriteLine($"The index of your search key is: {BinarySearch(sortedArray, searchKey)}");
            Console.ReadKey();
        }

        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] == searchKey)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
