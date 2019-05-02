using Hashtable.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in two Hash Tables, and performs a Left Join on them.  All values from the first table are added to a list, followed by any values in the second table with a matching key.  If table two does not have a matching key, null is added after the first value.  The key and values are added in the following order: [key, value1, value2].
        /// </summary>
        /// <param name="tableOne">First Hash Table to join.</param>
        /// <param name="tableTwo">Second Hash Table to join.</param>
        /// <returns>List of keys and values.</returns>
        public static List<string> LeftJoin(MyHashTable tableOne, MyHashTable tableTwo)
        {
            List<string> resultList = new List<string>();

            if (tableOne == null)
            {
                return null;
            }

            foreach (var item in tableOne.Map)
            {
                if (item != null)
                {
                    resultList.Add(item.First.Value.Key);
                    resultList.Add(item.First.Value.Value);

                    if (tableTwo.Contains(item.First.Value.Key))
                    {
                        MyNode node = tableTwo.Get(item.First.Value.Key);
                        resultList.Add(node.Value);
                    }
                    else
                    {
                        resultList.Add(null);
                    }

                }
            }

            return resultList;
        }
    }
}
