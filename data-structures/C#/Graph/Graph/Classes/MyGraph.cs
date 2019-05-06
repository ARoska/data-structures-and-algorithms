using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class MyGraph<T>
    {
        public Dictionary<Node<T>, List<Edge<T>>> AdjacencyList { get; set; }
        private int _size = 0;

        public MyGraph()
        {
            AdjacencyList = new Dictionary<Node<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Adds a new Node with the given value to the Graph.
        /// </summary>
        /// <param name="value">Value for Node to contain.</param>
        /// <returns>New Node created in Graph.</returns>
        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>(value);

            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;

            return node;
        }

        /// <summary>
        /// Adds a Directed Edge from one Node to Another.  Weight is applied to the Edge.
        /// </summary>
        /// <param name="nodeA">Node to start Edge at.</param>
        /// <param name="nodeB">Node to point Edge towards.</param>
        /// <param name="weight">Weight to apply to Edge.</param>
        public void AddDirectedEdge(Node<T> nodeA, Node<T> nodeB, int weight)
        {
            AdjacencyList[nodeA].Add(new Edge<T>(nodeB, weight));
        }

        /// <summary>
        /// Adds an Undirected Edge to two Nodes.  Weight is applied to the Edge.
        /// </summary>
        /// <param name="nodeA">First Node to connect with Edge.</param>
        /// <param name="nodeB">Second Node to connect with Edge.</param>
        /// <param name="weight">Weight to apply to Edge.</param>
        public void AddUndirectedEdge(Node<T> nodeA, Node<T> nodeB, int weight)
        {
            AddDirectedEdge(nodeA, nodeB, weight);
            AddDirectedEdge(nodeB, nodeA, weight);
        }

        /// <summary>
        /// Returns a List of all Nodes in the Graph.
        /// </summary>
        /// <returns>List of all Nodes.</returns>
        public List<Node<T>> GetNodes()
        {
            if (AdjacencyList.Count < 1)
            {
                return null;
            }

            List<Node<T>> nodes = new List<Node<T>>();

            foreach (var node in AdjacencyList)
            {
                nodes.Add(node.Key);
            }

            return nodes;
        }

        /// <summary>
        /// Takes in a Node in the Graph and returns all adjacent Nodes along with the weights of their Edges.
        /// </summary>
        /// <param name="node">Node to get neighbors of.</param>
        /// <returns>List of all Edges and their weights.</returns>
        public List<Edge<T>> GetNeighbors(Node<T> node)
        {
            if (AdjacencyList.Count < 1 || AdjacencyList[node] == null)
            {
                return null;
            }

            List<Edge<T>> neighbors = new List<Edge<T>>();

            foreach (var neighbor in AdjacencyList[node])
            {
                neighbors.Add(neighbor);
            }

            return neighbors;
        }

        /// <summary>
        /// Returns the current size of the Graph.
        /// </summary>
        /// <returns>Current size of Graph.</returns>
        public int Size()
        {
            return _size;
        }
    }
}
