using System;
using Xunit;
using Graph.Classes;
using System.Collections.Generic;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToTheGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> expectedNode = new Node<int>(5);

            Node<int> actualNode = graph.AddNode(5);
            
            Assert.Equal(expectedNode.Value, actualNode.Value);
        }

        [Fact]
        public void CanAddEdgeToGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Edge<int> expectedEdge = new Edge<int>(nodeB, 7);

            graph.AddDirectedEdge(nodeA, nodeB, 7);
            List<Edge<int>> edges = graph.GetNeighbors(nodeA);
            
            Assert.Equal(expectedEdge.Node.Value, edges[0].Node.Value);
            Assert.Equal(expectedEdge.Weight, edges[0].Weight);
        }

        [Fact]
        public void CollectionOfAllNodesCanBeRetrieve()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(99);
            List<Node<int>> expectedNodes = new List<Node<int>> { nodeA, nodeB, nodeC, nodeD };

            List<Node<int>> actualNodes = graph.GetNodes();

            Assert.Equal(expectedNodes, actualNodes);
        }

        [Fact]
        public void CanRetrieveListOfEdges()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);

            Edge<int> edgeA = new Edge<int>(nodeB, 2);
            Edge<int> edgeB = new Edge<int>(nodeC, 5);
            List<Edge<int>> expectedEdges = new List<Edge<int>> { edgeA, edgeB };

            graph.AddDirectedEdge(nodeA, nodeB, 2);
            graph.AddDirectedEdge(nodeA, nodeC, 5);

            List<Edge<int>> actualEdges = graph.GetNeighbors(nodeA);

            Assert.Equal(expectedEdges[0].Node.Value, actualEdges[0].Node.Value);
            Assert.Equal(expectedEdges[0].Weight, actualEdges[0].Weight);
            Assert.Equal(expectedEdges[1].Node.Value, actualEdges[1].Node.Value);
            Assert.Equal(expectedEdges[1].Weight, actualEdges[1].Weight);
        }

        [Fact]
        public void ProperSizeIsReturned()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(99);

            Assert.Equal(4, graph.Size());
        }

        [Fact]
        public void GraphWithOnlyOneNodeAndOneEdgeCanBeRetrieved()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = graph.AddNode(5);

            List<Node<int>> expectedNodes = new List<Node<int>>() { nodeA };

            graph.AddDirectedEdge(nodeA, nodeA, 5);

            List<Node<int>> actualNodes = graph.GetNodes();

            Assert.Equal(expectedNodes, actualNodes);
        }

        [Fact]
        public void ReturnsNullIfGraphEmpty()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Assert.Null(graph.GetNodes());
        }

        [Fact]
        public void CanBreadthFirstTraverseGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(7);

            graph.AddDirectedEdge(nodeA, nodeB, 1);
            graph.AddDirectedEdge(nodeA, nodeC, 3);
            graph.AddDirectedEdge(nodeC, nodeD, 2);

            List<Node<int>> expectedList = new List<Node<int>>() { nodeA, nodeB, nodeC, nodeD };

            List<Node<int>> actualList = graph.BreadthFist(nodeA);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillOnlyAddEachNodeOnceInBreadthFirstTraversal()
        {
            MyGraph<int> graph = new MyGraph<int>();

            Node<int> nodeA = graph.AddNode(5);
            Node<int> nodeB = graph.AddNode(10);
            Node<int> nodeC = graph.AddNode(1);
            Node<int> nodeD = graph.AddNode(7);

            graph.AddDirectedEdge(nodeA, nodeB, 1);
            graph.AddDirectedEdge(nodeA, nodeC, 3);
            graph.AddDirectedEdge(nodeA, nodeD, 10);
            graph.AddDirectedEdge(nodeC, nodeB, 645);
            graph.AddDirectedEdge(nodeC, nodeD, 2);

            List<Node<int>> expectedList = new List<Node<int>>() { nodeA, nodeB, nodeC, nodeD };

            List<Node<int>> actualList = graph.BreadthFist(nodeA);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillReturnSingleNodeGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = graph.AddNode(5);

            List<Node<int>> expectedList = new List<Node<int>>() { nodeA };

            List<Node<int>> actualList = graph.BreadthFist(nodeA);

            Assert.Equal(expectedList, actualList);
        }

        [Fact]
        public void WillReturnNullIfNodeNotInGraph()
        {
            MyGraph<int> graph = new MyGraph<int>();
            Node<int> nodeA = new Node<int>(50);

            Assert.Null(graph.BreadthFist(nodeA));
        }
    }
}
