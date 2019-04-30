using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyStack<string> myStack = new MyStack<string>();
            Node<string> node1 = new Node<string>("1: First Node");
            Node<string> node2 = new Node<string>("2: Second Node");
            Node<string> node3 = new Node<string>("3: Third Node");

            Console.WriteLine("Initial Queue:\n" +
                "==================");
            for (int i = 0; i < 3; i++)
            {
                myStack.Push(node1);
                myStack.Push(node2);
                myStack.Push(node3);

                //string val = myStack.Peek();
                //Console.WriteLine(val);
            }
            Console.WriteLine("==================");
            Console.ReadKey();

            Node<string> node4 = new Node<string>("4: New Fourth Node");

            Console.WriteLine("/n" +
                "Value to add: \"4: New Fourth Node\"" +
                "==================");

            myStack.Push(node4);
            Node<string> val = myStack.Peek();

            Console.WriteLine(val);
            Console.WriteLine("==================");
            Console.ReadKey();
        }
    }
}
