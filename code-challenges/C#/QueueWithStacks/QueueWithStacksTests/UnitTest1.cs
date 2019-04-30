using QueueWithStacks.Classes;
using StacksAndQueues.Classes;
using System;
using Xunit;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();

            Assert.Null(myPseudoQueue.Peek());
        }

        [Fact]
        public void CanEnqueueOneNodeToPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");

            myPseudoQueue.Enqueue(node1);

            Assert.Equal("One", myPseudoQueue.Peek().Value);
        }

        [Fact]
        public void CanEnqueueMultipleNodesToPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Enqueue(node2);
            myPseudoQueue.Enqueue(node3);

            Assert.Equal("Three", myPseudoQueue.Peek().Value);
        }

        [Fact]
        public void CanDequeueNodeFromPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Enqueue(node2);
            myPseudoQueue.Enqueue(node3);
            myPseudoQueue.Dequeue();

            Assert.Equal("Two", myPseudoQueue.Peek().Value);
        }

        [Fact]
        public void CanDequeueMultipleNodesFromPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Enqueue(node2);
            myPseudoQueue.Enqueue(node3);
            myPseudoQueue.Dequeue();
            myPseudoQueue.Dequeue();

            Assert.Equal("One", myPseudoQueue.Peek().Value);
        }

        [Fact]
        public void CanDequeueAllNodesFromPseudoQueue()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Enqueue(node2);
            myPseudoQueue.Enqueue(node3);
            myPseudoQueue.Dequeue();
            myPseudoQueue.Dequeue();
            myPseudoQueue.Dequeue();

            Assert.Null(myPseudoQueue.Peek());
        }

        [Fact]
        public void CanRecoverDataFromDequeuedNode()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");
            Node<string> node2 = new Node<string>("Two");
            Node<string> node3 = new Node<string>("Three");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Enqueue(node2);
            myPseudoQueue.Enqueue(node3);
            Node<string> recoveredData = myPseudoQueue.Dequeue();

            Assert.Equal("Three", recoveredData.Value);
        }

        [Fact]
        public void DequeueWhileQueueIsEmptyWillReturnNull()
        {
            MyPseudoQueue<string> myPseudoQueue = new MyPseudoQueue<string>();
            Node<string> node1 = new Node<string>("One");

            myPseudoQueue.Enqueue(node1);
            myPseudoQueue.Dequeue();
            Node<string> recoveredData = myPseudoQueue.Dequeue();

            Assert.Null(recoveredData);
        }
    }
}

