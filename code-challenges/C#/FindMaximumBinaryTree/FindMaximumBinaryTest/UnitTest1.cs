using System;
using static FindMaximumBinaryTree.Program;
using Tree.Classes;
using Xunit;

namespace FindMaximumBinaryTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindLargestNumberInIntTree()
        {
            Node<object> node1 = new Node<object>(1);
            Node<object> node2 = new Node<object>(2);
            Node<object> node3 = new Node<object>(3);
            Node<object> node4 = new Node<object>(4);
            Node<object> node5 = new Node<object>(5);
            Node<object> node6 = new Node<object>(6);
            MyBinaryTree<object> tree = new MyBinaryTree<object>();

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);

            int? returnValue = FindMaximumValue(tree);

            Assert.Equal(6, returnValue);
        }

        [Fact]
        public void CanFindLargestNumberInMixedTree()
        {
            Node<object> node1 = new Node<object>(1);
            Node<object> node2 = new Node<object>("yellow");
            Node<object> node3 = new Node<object>(3);
            Node<object> node4 = new Node<object>(4);
            Node<object> node5 = new Node<object>(5);
            Node<object> node6 = new Node<object>("blue");
            MyBinaryTree<object> tree = new MyBinaryTree<object>();

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);

            int? returnValue = FindMaximumValue(tree);

            Assert.Equal(5, returnValue);
        }

        [Fact]
        public void ReturnsNullIfNoIntsTree()
        {
            Node<object> node1 = new Node<object>("one");
            Node<object> node2 = new Node<object>("two");
            Node<object> node3 = new Node<object>("three");
            Node<object> node4 = new Node<object>("four");
            Node<object> node5 = new Node<object>("five");
            Node<object> node6 = new Node<object>("six");
            MyBinaryTree<object> tree = new MyBinaryTree<object>();

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);

            int? returnValue = FindMaximumValue(tree);

            Assert.Null(returnValue);
        }
    }
}
