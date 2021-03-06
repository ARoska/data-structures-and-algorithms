﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class MyHashTable
    {
        public LinkedList<MyNode>[] Map { get; set; }

        /// <summary>
        /// Generates a predefined HashTable with 1024 positions.
        /// </summary>
        public MyHashTable()
        {
            Map = new LinkedList<MyNode>[1024];
        }

        /// <summary>
        /// Generates a HashTable with the given number of positions.
        /// </summary>
        /// <param name="length">Number of positions.</param>
        public MyHashTable(int length)
        {
            Map = new LinkedList<MyNode>[length];
        }

        /// <summary>
        /// Takes in a Key string and converts it into a Hash Key integer.
        /// </summary>
        /// <param name="key">Key string.</param>
        /// <returns>Hash Key.</returns>
        public int Hash(string key)
        {
            int hash = 0;
            char[] charArr = key.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                hash += charArr[i];
            }

            return (hash * 599) % Map.Length;
        }

        /// <summary>
        /// Takes in a Key string and a Value string.  Adds the Key:Value pair to the HashTable at the position determined by the Hash algorythm.  If a collision occures the new Key:Value pair is added at the front of the bucket.
        /// </summary>
        /// <param name="key">Key string to be hashed.</param>
        /// <param name="value">Values string to be added to HashTable.</param>
        public void Add(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] == null)
            {
                Map[hashKey] = new LinkedList<MyNode>();
            }

            Map[hashKey].AddFirst(new MyNode(key, value));
        }

        /// <summary>
        /// Takes in a Key string and a Value string and removes that pair from the HashTable, if present.
        /// </summary>
        /// <param name="key">Key string to be searched for.</param>
        /// <param name="value">Value string to be searched for.</param>
        public void Remove(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                foreach (var item in Map[hashKey])
                {
                    if (item.Key == key && item.Value == value)
                    {
                        Map[hashKey].Remove(item);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Takes in a Key string and returns the Key:Value pair from the HashTable as dermined by the Hash algorythm.  In the event that there is a collision in the HashTable, the first pair is returned.
        /// </summary>
        /// <param name="key">Key string.</param>
        /// <returns>Node containing Key:Value pair.</returns>
        public MyNode Get(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                foreach (var item in Map[hashKey])
                {
                    if (item.Key == key)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Takes in a Key string and returns a list of all Key:Value pairs from the HashTable as dermined by the Hash algorythm.
        /// </summary>
        /// <param name="key">Key string.</param>
        /// <returns>List containing all Key:Value pairs at hash.</returns>
        public LinkedList<MyNode> GetBucket(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                return Map[hashKey];
            }

            return null;
        }

        /// <summary>
        /// Takes in a Key string and returns true if that string exists in the HashTable.
        /// </summary>
        /// <param name="key">Key string.</param>
        /// <returns>True if Key exists in HashTable.</returns>
        public bool Contains(string key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                foreach (var item in Map[hashKey])
                {
                    if (item.Key == key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Takes in a Key:Value pair and returns true if that pair exists in the HashTable.
        /// </summary>
        /// <param name="key">Key string to search for.</param>
        /// <param name="value">Value string to search for.</param>
        /// <returns>True if Key:Value pair exists in HashTable.</returns>
        public bool ContainsUnique(string key, string value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                foreach (var item in Map[hashKey])
                {
                    if (item.Key == key && item.Value == value)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
