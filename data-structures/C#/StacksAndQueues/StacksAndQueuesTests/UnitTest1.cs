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
            Node<string> blankTop = stack.Peek();

            Assert.Null(blankTop);
        }

        [Fact]
        public void CanPushOneNodeOnToStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Node<string> node1 = new Node<string>("One");

            stack.Push(node1);
            Node<string> top = stack.Peek();

            Assert.Equal("One", top.Value);
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
            Node<string> top = stack.Peek();

            Assert.Equal("Three", top.Value);
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
            Node<string> top = stack.Peek();

            Assert.Equal("Two", top.Value);
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
            Node<string> pop = stack.Pop();

            Assert.Equal("Two", pop.Value);
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
            Node<string> top = stack.Peek();

            Assert.Null(top);
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();

            Node<string> emptyFront = queue.Peek();

            Assert.Null(emptyFront);
        }

        [Fact]
        public void CanEnqueOnToQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");

            queue.Enqueue(node1);
            Node<string> front = queue.Peek();

            Assert.Equal("One", front.Value);
        }

        [Fact]
        public void CanEnqueMultipleNodes()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal("Three", queue.Rear.Value);
        }

        [Fact]
        public void CanEnqueAndDequeueMultipleNodes()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Dequeue();
            queue.Dequeue();
            Node<string> front = queue.Peek();

            Assert.Equal("Three", front.Value);
        }

        [Fact]
        public void CanRecoverDataFromDequeuedNode()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Dequeue();
            Node<string> dequeue = queue.Dequeue();

            Assert.Equal("Two", dequeue.Value);
        }

        [Fact]
        public void CanDequeueAllNodes()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.Null(queue.Peek());
        }
    }
}
