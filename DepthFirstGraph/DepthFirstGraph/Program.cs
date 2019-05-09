using Graph.Classes;
using System;
using System.Collections.Generic;

namespace DepthFirstGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Node<string>> DepthFirstPreOrder(MyGraph<string> graph, Node<string> root, List<Node<string>> list)
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
                    DepthFirstPreOrder(graph, node, list);
                }
            }

            return list;
        }
    }
}
