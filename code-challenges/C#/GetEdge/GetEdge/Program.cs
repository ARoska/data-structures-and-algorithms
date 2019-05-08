using Graph.Classes;
using System;

namespace GetEdge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int? GetEdge(MyGraph<string> map, string[] itinerary)
        {
            int totalCost = 0;
            Node<string> current = new Node<string>(itinerary[0]);
            if (!map.AdjacencyList.ContainsKey(current))
            {
                return null;
            }

            for (int i = 0; i < itinerary.Length - 1; i++)
            {
                Node<string> next = new Node<string>(itinerary[i + 1]);
                if (!map.AdjacencyList.ContainsKey(next))
                {
                    return null;
                }

                foreach (var edge in map.AdjacencyList[current])
                {
                    if (edge.Node == next)
                    {
                        totalCost += edge.Weight;
                    }
                }
            }

            return totalCost;
        }
    }
}
