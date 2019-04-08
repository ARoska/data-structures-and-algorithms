using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> LChild { get; set; }
        public Node<T> RChild { get; set; }

        public Node()
        {

        }

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> lChild, Node<T> rChild)
        {
            Value = value;
            LChild = lChild;
            RChild = rChild;
        }
    }
}
