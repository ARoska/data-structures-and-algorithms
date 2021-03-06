﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class MyGraph<T>
    {
        public Dictionary<Node<T>, Neighbors> AdjacencyList { get; set; }
        private int _size = 0;

        public MyGraph()
        {
            AdjacencyList = new Dictionary<Node<T>, Dictionary<Node<T>, int>>();
        }

        /// <summary>
        /// Adds a new Node with the given value to the Graph.
        /// </summary>
        /// <param name="value">Value for Node to contain.</param>
        /// <returns>New Node created in Graph.</returns>
        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>(value);

            AdjacencyList.Add(node, new Dictionary<Node<T>, int>());
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
            AdjacencyList[nodeA].Add(nodeB, weight);
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
                Edge<T> edge = new Edge<T>(neighbor.Key, neighbor.Value);
                neighbors.Add(edge);
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

        /// <summary>
        /// Traverses the Graph with a breadth-first traversal, adding each Node to a List in the order they are accessed.  Nodes are only added once.
        /// </summary>
        /// <param name="root">Node to start traversal at.</param>
        /// <returns>List of all Nodes accessed from root.</returns>
        public List<Node<T>> BreadthFist(Node<T> root)
        {
            if (!AdjacencyList.ContainsKey(root))
            {
                return null;
            }

            List<Node<T>> nodes = new List<Node<T>>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            root.Visited = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> front = queue.Dequeue();
                nodes.Add(front);

                foreach (var child in AdjacencyList[front])
                {
                    if (!child.Key.Visited)
                    {
                        child.Key.Visited = true;
                        queue.Enqueue(child.Key);
                    }
                }
            }

            return nodes;
        }

        /// <summary>
        /// Takes in a staring point Node and an ending point Node and determines if there is a path from start to end.
        /// </summary>
        /// <param name="startNode">Node to start at.</param>
        /// <param name="endNode">Node to end at.</param>
        /// <returns>True if path from start to end exists.</returns>
        public bool PathBetween(Node<T> startNode, Node<T> endNode)
        {
            List<Node<T>> path = BreadthFist(startNode);

            if (path.Contains(endNode))
            {
                return true;
            }

            return false;
        }
    }
}
