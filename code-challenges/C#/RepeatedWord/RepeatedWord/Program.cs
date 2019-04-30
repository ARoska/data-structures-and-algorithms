using Hashtable.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstInput = "Once upon a time, there was a princess who...";

            Console.WriteLine($"Long string to parse: \"{firstInput}\"");

            string firstReturn = RepeatedWord(firstInput);

            Console.WriteLine("\n" +
                $"The first word to repeat is: {firstReturn}");

            string secondInput = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness...";

            Console.WriteLine("\n" +
                "===========================\n" +
                "\n" +
                $"Long string to parse: \"{secondInput}\"");

            string secondReturn = RepeatedWord(secondInput);

            Console.WriteLine("\n" +
                $"The first word to repeat is: {secondReturn}");
        }

        /// <summary>
        /// Takes in a long string and uses a HashTable to determine the first repeated word in the string.  If no repeated words are found returns null.
        /// </summary>
        /// <param name="longString">String to parse.</param>
        /// <returns>First repeated word in longString, or null if none found.</returns>
        public static string RepeatedWord(string longString)
        {
            string[] words = longString.Split(" ");

            if (words.Length > 1)
            {
                MyHashTable hashTable = new MyHashTable();

                for (int i = 0; i < words.Length; i++)
                {
                    if (hashTable.Contains(words[i].ToLower()))
                    {
                        return words[i];
                    }

                    hashTable.Add(words[i].ToLower(), "");
                }
            }

            return null;
        }
    }
}
