using System;
using Xunit;
using Hashtable.Classes;

namespace HashTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanHashValueToKey()
        {
            MyHashTable hashTable = new MyHashTable();

            int hashKey = hashTable.Hash("test");

            Assert.InRange(hashKey, 0, 1024);
        }

        [Fact]
        public void CanAddKeyValuePairToHashTable()
        {
            MyHashTable hashTable = new MyHashTable();

            hashTable.Add("test", "test");
            MyNode resultNode = hashTable.Get("test");

            Assert.Equal("test", resultNode.Key);
            Assert.Equal("test", resultNode.Value);
        }

        [Fact]
        public void CanGetValueFromHashTable()
        {
            MyHashTable hashTable = new MyHashTable();

            hashTable.Add("test", "test");
            MyNode resultNode = hashTable.Get("test");

            Assert.Equal("test", resultNode.Value);
        }

        [Fact]
        public void IfKeyDoesNotExistReturnsNull()
        {
            MyHashTable hashTable = new MyHashTable();

            Assert.Null(hashTable.Get("test"));
        }

        [Fact]
        public void CanAddMultipleValuesWithSameKeyToHashTable()
        {
            MyHashTable hashTable = new MyHashTable();

            hashTable.Add("test", "testOne");
            hashTable.Add("test", "testTwo");
            MyNode resultNode = hashTable.Get("test");

            Assert.Equal("test", resultNode.Key);
            Assert.Equal("testTwo", resultNode.Value);
        }

    }
}
