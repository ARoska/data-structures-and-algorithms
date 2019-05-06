using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Edge<T>
    {
        public int Weight { get; set; }
        public Node<T> Node { get; set; }

        public Edge(Node<T> node, int weight)
        {
            Node = node;
            Weight = weight;
        }
    }
}
