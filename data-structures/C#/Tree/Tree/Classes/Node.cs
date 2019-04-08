using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class Node<T> where T : IConvertible
    {
        public T Value { get; set; }
        public Node<T> LChild { get; set; }
        public Node<T> RChild { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
