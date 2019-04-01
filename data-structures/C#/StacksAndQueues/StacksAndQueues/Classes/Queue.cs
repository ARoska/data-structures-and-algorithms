using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class MyQueue<T> where T : class
    {
        public Node<T> Back { get; set; }
        public Node<T> Front { get; set; }

        public MyQueue()
        {
            Front = new Node<T>(null);
            Back = Front;
        }

        public void Enque(Node<T> node)
        {
            Back.Next = node;
            Back = node;
        }

        public T Deque()
        {
            T temp = Front.Value;
            Front = Front.Next;
            return temp;
        }

        public T Peek()
        {
            return Front.Value;
        }
    }
}
