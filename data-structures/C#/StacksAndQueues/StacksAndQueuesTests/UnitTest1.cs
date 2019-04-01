using StacksAndQueues.Classes;
using System;
using Xunit;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyStack()
        {
            MyStack<string> stack = new MyStack<string>();
            string blankTop = stack.Peek();

            Assert.Null(blankTop);
        }

        [Fact]
        public void CanPushOneNodeOnToStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");

            stack.Push(node1);
            string top = stack.Peek();

            Assert.Equal("One", top);
        }

        [Fact]
        public void CanPushMultipleNodesOnToStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            string top = stack.Peek();

            Assert.Equal("Three", top);
        }

        [Fact]
        public void CanPopTopNodeFromStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Pop();
            string top = stack.Peek();

            Assert.Equal("Two", top);
        }

        [Fact]
        public void CanRecoverDataFromPoppedNode()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Pop();
            string pop = stack.Pop();

            Assert.Equal("Two", pop);
        }

        [Fact]
        public void CanPopAllNodesFromStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            string top = stack.Peek();

            Assert.Null(top);
        }

        [Fact]
        public void CanCreateEmptyQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();

            string emptyFront = queue.Peek();

            Assert.Null(emptyFront);
        }

        //[Fact]
        public void CanEnqueOnToQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");

            queue.Enque(node1);
            string front = queue.Peek();

            Assert.Equal("One", front);
        }
    }
}
