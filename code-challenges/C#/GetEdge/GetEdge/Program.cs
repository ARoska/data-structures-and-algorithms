using Graph.Classes;
using System;
using System.Collections.Generic;

namespace GetEdge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in a map and a path as an array of strings and determines if the array of strings can be visited in direct order in the map.  If successful, the total sum of all weights in the path is returned.  If there is no direct path from one position in the next returns null.
        /// </summary>
        /// <param name="map">Map to be traversed.</param>
        /// <param name="itinerary">Path of strings to attempt to traverse with.</param>
        /// <returns>Total of weights in path if successful, or null if unsuccessful.</returns>
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

                Dictionary<Node<string>, int> neighbors = map.AdjacencyList[current];
                totalCost += neighbors[next];
                current = next;
            }

            return totalCost;
        }
    }
}
