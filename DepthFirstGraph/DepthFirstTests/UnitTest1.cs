using Graph.Classes;
using System;
using System.Collections.Generic;
using Xunit;
using static DepthFirstGraph.Program;

namespace DepthFirstTests
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnListOfPreOrderNodes()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(7);

            graph.AddDirectedEdge(nodeA, nodeB, 1);
            graph.AddDirectedEdge(nodeA, nodeC, 3);
            graph.AddDirectedEdge(nodeB, nodeD, 2);

            List<Node<int>> expectedList = new List<Node<int>> { nodeA, nodeB, nodeD, nodeC };

            List<Node<int>> actualList = DepthFirstPreOrder(graph, nodeA);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillReturnListOfPreOrderNodesWithoutDupes()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(7);

            graph.AddDirectedEdge(nodeA, nodeB, 1);
            graph.AddDirectedEdge(nodeA, nodeC, 3);
            graph.AddDirectedEdge(nodeB, nodeD, 2);
            graph.AddDirectedEdge(nodeD, nodeC, 55);

            List<Node<int>> expectedList = new List<Node<int>> { nodeA, nodeB, nodeD, nodeC };

            List<Node<int>> actualList = DepthFirstPreOrder(graph, nodeA);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillReturnNullIfRootIsNotInGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(7);

            graph.AddDirectedEdge(nodeA, nodeB, 1);
            graph.AddDirectedEdge(nodeA, nodeC, 3);

            Assert.Null(DepthFirstPreOrder(graph, nodeD));
        }
    }
}
