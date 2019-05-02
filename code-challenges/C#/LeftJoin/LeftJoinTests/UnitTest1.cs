using Hashtable.Classes;
using System;
using Xunit;
using LeftJoin;
using System.Collections.Generic;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void WillMergeTwoTables()
        {
            MyHashTable tableOne = new MyHashTable();
            MyHashTable tableTwo = new MyHashTable();

            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");

            tableTwo.Add("fond", "averse");
            tableTwo.Add("wrath", "delight");

            string[] expected = new string[] { "fond", "enamored", "averse", "wrath", "anger", "delight" };

            List<string> resultList = LeftJoin.Program.LeftJoin(tableOne, tableTwo);
            string[] result = resultList.ToArray();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WillMergeTwoTablesLeavingBehindValuesInTableTwoThatHaveNoMatchInTableOne()
        {
            MyHashTable tableOne = new MyHashTable();
            MyHashTable tableTwo = new MyHashTable();

            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");

            tableTwo.Add("fond", "averse");
            tableTwo.Add("wrath", "delight");
            tableTwo.Add("negative", "positive");

            string[] expected = new string[] { "fond", "enamored", "averse", "wrath", "anger", "delight" };

            List<string> resultList = LeftJoin.Program.LeftJoin(tableOne, tableTwo);
            string[] result = resultList.ToArray();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WillMergeTwoTablesAddingNullIfNoMatchInTableTwo()
        {
            MyHashTable tableOne = new MyHashTable();
            MyHashTable tableTwo = new MyHashTable();

            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");

            tableTwo.Add("fond", "averse");
            tableTwo.Add("negative", "positive");

            string[] expected = new string[] { "fond", "enamored", "averse", "wrath", "anger", null };

            List<string> resultList = LeftJoin.Program.LeftJoin(tableOne, tableTwo);
            string[] result = resultList.ToArray();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WillReturnEmptyArrayIfNoValuesInTableOne()
        {
            MyHashTable tableOne = new MyHashTable();
            MyHashTable tableTwo = new MyHashTable();

            tableTwo.Add("fond", "averse");
            tableTwo.Add("negative", "positive");

            string[] expected = new string[0];

            List<string> resultList = LeftJoin.Program.LeftJoin(tableOne, tableTwo);
            string[] result = resultList.ToArray();

            Assert.Equal(expected, result);
        }
    }
}
