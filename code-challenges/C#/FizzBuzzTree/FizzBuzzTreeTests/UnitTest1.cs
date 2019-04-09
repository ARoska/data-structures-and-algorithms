using Tree.Classes;
using static FizzBuzzTree.Program;
using System;
using Xunit;
using System.Collections.Generic;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCorrectlyFizzBuzzTree()
        {
            Node<object> node1 = new Node<object>(5);
            Node<object> node2 = new Node<object>(10);
            Node<object> node3 = new Node<object>(15);
            Node<object> node4 = new Node<object>(2);
            Node<object> node5 = new Node<object>(3);
            Node<object> node6 = new Node<object>(21);
            Node<object> node7 = new Node<object>(7);
            MyBinaryTree<object> tree = new MyBinaryTree<object>();
            MyBinaryTree<object> resultsTree = new MyBinaryTree<object>();
            List<object> list = new List<object>();

            tree.Root = node1;
            tree.Root.LChild = node2;
            tree.Root.RChild = node3;
            tree.Root.LChild.LChild = node4;
            tree.Root.LChild.RChild = node5;
            tree.Root.RChild.LChild = node6;
            tree.Root.RChild.RChild = node7;

            resultsTree = FizzBuzz(tree);

            List<object> expectedList = new List<object>() { "Buzz", "Buzz", 2, "Fizz", "FizzBuzz", "Fizz", 7 };
            List<object> actualList = resultsTree.PreOrder(resultsTree.Root, list);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void CanFizzBuzzTreeWithNonInts()
        {
            Node<object> node1 = new Node<object>("nope");
            Node<object> node2 = new Node<object>(10);
            Node<object> node3 = new Node<object>(15);
            Node<object> node4 = new Node<object>(2);
            Node<object> node5 = new Node<object>(3);
            Node<object> node6 = new Node<object>(21);
            Node<object> node7 = new Node<object>(7);
            MyBinaryTree<object> tree = new MyBinaryTree<object>();
            MyBinaryTree<object> resultsTree = new MyBinaryTree<object>();
            List<object> list = new List<object>();

            tree.Root = node1;
            tree.Root.LChild = node2;
            tree.Root.RChild = node3;
            tree.Root.LChild.LChild = node4;
            tree.Root.LChild.RChild = node5;
            tree.Root.RChild.LChild = node6;
            tree.Root.RChild.RChild = node7;

            resultsTree = FizzBuzz(tree);

            List<object> expectedList = new List<object>() { "nope", "Buzz", 2, "Fizz", "FizzBuzz", "Fizz", 7 };
            List<object> actualList = resultsTree.PreOrder(resultsTree.Root, list);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillReturnNullWhenNoNodesInTree()
        {
            MyBinaryTree<object> tree = new MyBinaryTree<object>();

            Assert.Null(FizzBuzz(tree));
        }
    }
}
