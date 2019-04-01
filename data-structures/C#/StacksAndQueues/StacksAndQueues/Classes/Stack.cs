using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class MyStack<T> where T : class
    {
        public Node<T> Top { get; set; }

        public MyStack()
        {
            Top = new Node<T>(null);
        }

        public void Push(Node<T> node)
        {
            node.Next = Top;
            Top = node;
        }

        public T Pop()
        {
            T temp = Top.Value;
            Top = Top.Next;
            return temp;
        }

        public T Peek()
        {
            return Top.Value;
        }
    }
}
