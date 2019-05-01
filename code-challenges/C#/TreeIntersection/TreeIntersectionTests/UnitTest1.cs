using System;
using Xunit;
using TreeIntersection;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnListOfSharedValues()
        {
            MyBinarySearchTree treeOne = new MyBinarySearchTree();
            MyBinarySearchTree treeTwo = new MyBinarySearchTree();

            Node<int> nodeOne1 = new Node<int>(10);
            Node<int> nodeOne2 = new Node<int>(20);
            Node<int> nodeOne3 = new Node<int>(30);
            Node<int> nodeOne4 = new Node<int>(45);
            Node<int> nodeOne5 = new Node<int>(50);
            Node<int> nodeOne6 = new Node<int>(5);
            Node<int> nodeOne7 = new Node<int>(8);
            Node<int> nodeOne8 = new Node<int>(7);
            Node<int> nodeOne9 = new Node<int>(6);

            Node<int> nodeTwo1 = new Node<int>(10);
            Node<int> nodeTwo2 = new Node<int>(18);
            Node<int> nodeTwo3 = new Node<int>(30);
            Node<int> nodeTwo4 = new Node<int>(40);
            Node<int> nodeTwo5 = new Node<int>(50);
            Node<int> nodeTwo6 = new Node<int>(9);
            Node<int> nodeTwo7 = new Node<int>(8);
            Node<int> nodeTwo8 = new Node<int>(7);
            Node<int> nodeTwo9 = new Node<int>(1);

            treeOne.Add(nodeOne1);
            treeOne.Add(nodeOne2);
            treeOne.Add(nodeOne3);
            treeOne.Add(nodeOne4);
            treeOne.Add(nodeOne5);
            treeOne.Add(nodeOne6);
            treeOne.Add(nodeOne7);
            treeOne.Add(nodeOne8);
            treeOne.Add(nodeOne9);

            treeTwo.Add(nodeTwo1);
            treeTwo.Add(nodeTwo2);
            treeTwo.Add(nodeTwo3);
            treeTwo.Add(nodeTwo4);
            treeTwo.Add(nodeTwo5);
            treeTwo.Add(nodeTwo6);
            treeTwo.Add(nodeTwo7);
            treeTwo.Add(nodeTwo8);
            treeTwo.Add(nodeTwo9);

            int[] expectedArr = new int[] { 10, 8, 30, 7, 50 };

            List<int> resultList = TreeIntersection.Program.TreeIntersection(treeOne, treeTwo);
            int[] resultArr = resultList.ToArray();

            Assert.Equal(expectedArr, resultArr);
        }

        [Fact]
        public void WillReturnNullIfNoSharedValues()
        {
            MyBinarySearchTree treeOne = new MyBinarySearchTree();
            MyBinarySearchTree treeTwo = new MyBinarySearchTree();

            Node<int> nodeOne1 = new Node<int>(10);
            Node<int> nodeOne2 = new Node<int>(20);
            Node<int> nodeOne3 = new Node<int>(30);
            Node<int> nodeOne4 = new Node<int>(45);
            Node<int> nodeOne5 = new Node<int>(50);
            Node<int> nodeOne6 = new Node<int>(5);
            Node<int> nodeOne7 = new Node<int>(8);
            Node<int> nodeOne8 = new Node<int>(7);
            Node<int> nodeOne9 = new Node<int>(6);

            Node<int> nodeTwo1 = new Node<int>(1000);
            Node<int> nodeTwo2 = new Node<int>(1800);
            Node<int> nodeTwo3 = new Node<int>(3000);
            Node<int> nodeTwo4 = new Node<int>(4000);
            Node<int> nodeTwo5 = new Node<int>(5000);
            Node<int> nodeTwo6 = new Node<int>(900);
            Node<int> nodeTwo7 = new Node<int>(800);
            Node<int> nodeTwo8 = new Node<int>(700);
            Node<int> nodeTwo9 = new Node<int>(100);

            treeOne.Add(nodeOne1);
            treeOne.Add(nodeOne2);
            treeOne.Add(nodeOne3);
            treeOne.Add(nodeOne4);
            treeOne.Add(nodeOne5);
            treeOne.Add(nodeOne6);
            treeOne.Add(nodeOne7);
            treeOne.Add(nodeOne8);
            treeOne.Add(nodeOne9);

            treeTwo.Add(nodeTwo1);
            treeTwo.Add(nodeTwo2);
            treeTwo.Add(nodeTwo3);
            treeTwo.Add(nodeTwo4);
            treeTwo.Add(nodeTwo5);
            treeTwo.Add(nodeTwo6);
            treeTwo.Add(nodeTwo7);
            treeTwo.Add(nodeTwo8);
            treeTwo.Add(nodeTwo9);

            Assert.Null(TreeIntersection.Program.TreeIntersection(treeOne, treeTwo));
        }

        [Fact]
        public void WillReturnNullIfOneTreeEmpty()
        {
            MyBinarySearchTree treeOne = new MyBinarySearchTree();
            MyBinarySearchTree treeTwo = new MyBinarySearchTree();

            Node<int> nodeOne1 = new Node<int>(10);
            Node<int> nodeOne2 = new Node<int>(20);
            Node<int> nodeOne3 = new Node<int>(30);
            Node<int> nodeOne4 = new Node<int>(45);
            Node<int> nodeOne5 = new Node<int>(50);
            Node<int> nodeOne6 = new Node<int>(5);
            Node<int> nodeOne7 = new Node<int>(8);
            Node<int> nodeOne8 = new Node<int>(7);
            Node<int> nodeOne9 = new Node<int>(6);

            treeOne.Add(nodeOne1);
            treeOne.Add(nodeOne2);
            treeOne.Add(nodeOne3);
            treeOne.Add(nodeOne4);
            treeOne.Add(nodeOne5);
            treeOne.Add(nodeOne6);
            treeOne.Add(nodeOne7);
            treeOne.Add(nodeOne8);
            treeOne.Add(nodeOne9);

            Assert.Null(TreeIntersection.Program.TreeIntersection(treeOne, treeTwo));
        }
    }
}
