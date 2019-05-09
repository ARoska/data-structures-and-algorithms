using Graph.Classes;
using System;
using System.Collections.Generic;

namespace DepthFirstGraph
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Node<int>> DepthFirstPreOrder(MyGraph<int> graph, Node<int> root)
        {
            List<Node<int>> list = new List<Node<int>>();
            Traverse(graph, root, list);
            return list;
        }

        public static List<Node<int>> Traverse(MyGraph<int> graph, Node<int> root, List<Node<int>> list)
        {
            if (!graph.AdjacencyList.ContainsKey(root))
            {
                return null;
            }

            if (root.Visited == false)
            {
                root.Visited = true;
                list.Add(root);
            }

            foreach (var node in graph.AdjacencyList[root])
            {
                if (node.Key.Visited == false)
                {
                    Traverse(graph, node.Key, list);
                }
            }

            return list;
        }
    }
}
