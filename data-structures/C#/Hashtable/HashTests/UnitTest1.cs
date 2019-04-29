using System;
using Xunit;
using Hashtable.Classes;

namespace HashTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddKeyValuePairToHashTable()
        {
            MyHashTable hashTable = new MyHashTable();
            MyNode expectedNode = new MyNode("test", "test");

            hashTable.Add("test", "test");
            MyNode resultNode = hashTable.Get("test");

            Assert.Equal(resultNode.Key, expectedNode.Key);
            Assert.Equal(resultNode.Value, expectedNode.Value);
        }
    }
}
