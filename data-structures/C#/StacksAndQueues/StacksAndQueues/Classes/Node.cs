using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T> where T : IConvertible
    {
        public Node<T> Next { get; set; }

        public T Value { get; set; }
        public int Timestamp { get; set; }
        public string Name { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, int timestamp)
        {
            Value = value;
            Timestamp = timestamp;
        }

        public Node(T value, int timestamp, string name)
        {
            Value = value;
            Timestamp = timestamp;
            Name = name;
        }
    }
}
