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
            Node<string> node1 = new Node<string>("Hi");


            myStack.Push(node1);

            string val = myStack.Peek();

            Console.WriteLine(val);
        }
    }
}
