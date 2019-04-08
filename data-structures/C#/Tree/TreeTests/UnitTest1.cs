using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateEmptyTree()
        {
            MyBinaryTree<int> myTree = new MyBinaryTree<int>();

            Assert.Null(myTree.Root);
        }

        [Fact]
        public void CanCreateTreeWithOneRoot()
        {
            Node<string> node = new Node<string>("root");
            MyBinaryTree<string> tree = new MyBinaryTree<string>();

            tree.Root = node;

            Assert.Equal("root", tree.Root.Value);
        }

        [Fact]
        public void CanAddLeftChild()
        {
            Node<string> node1 = new Node<string>("root");
            Node<string> node2 = new Node<string>("left");
            MyBinaryTree<string> tree = new MyBinaryTree<string>();

            tree.Root = node1;
            tree.Root.LChild = node2;

            Assert.Equal("left", tree.Root.LChild.Value);
        }

        [Fact]
        public void CanAddRightChild()
        {
            Node<string> node1 = new Node<string>("root");
            Node<string> node2 = new Node<string>("right");
            MyBinaryTree<string> tree = new MyBinaryTree<string>();

            tree.Root = node1;
            tree.Root.RChild = node2;

            Assert.Equal("right", tree.Root.RChild.Value);
        }

        [Fact]
        public void CanCreateEmptySearchTree()
        {
            MyBinarySearchTree myTree = new MyBinarySearchTree();

            Assert.Null(myTree.Root);
        }

        [Fact]
        public void CanRetrieveDataFromPreOrder()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            tree.Root = node1;
            tree.Root.LChild = node2;
            tree.Root.RChild = node3;
            tree.Root.LChild.LChild = node4;
            tree.Root.LChild.RChild = node5;
            tree.Root.RChild.LChild = node6;

            List<int> input = new List<int>();
            List<int> expected = new List<int> { 1, 2, 4, 5, 3, 6 };

            Assert.Equal(expected, tree.PreOrder(node1, input));
        }

        //[Fact]
        public void CanRetrieveDataFromInOrder()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            tree.Root = node1;
            tree.Root.LChild = node2;
            tree.Root.RChild = node3;
            tree.Root.LChild.LChild = node4;
            tree.Root.LChild.RChild = node5;
            tree.Root.RChild.LChild = node6;

            List<int> input = new List<int>();
            List<int> expected = new List<int> { 4, 2, 5, 1, 3, 6 };

            Assert.Equal(expected, tree.InOrder(node1, input));
        }

        [Fact]
        public void CanRetrieveDataFromPostOrder()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            tree.Root = node1;
            tree.Root.LChild = node2;
            tree.Root.RChild = node3;
            tree.Root.LChild.LChild = node4;
            tree.Root.LChild.RChild = node5;
            tree.Root.RChild.LChild = node6;

            List<int> input = new List<int>();
            List<int> expected = new List<int> { 4, 5, 2, 6, 3, 1 };

            Assert.Equal(expected, tree.PostOrder(node1, input));
        }


    }
}
