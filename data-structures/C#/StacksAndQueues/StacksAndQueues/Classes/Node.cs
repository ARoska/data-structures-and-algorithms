using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T> where T : IConvertible
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }
        public int Timestamp{ get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
