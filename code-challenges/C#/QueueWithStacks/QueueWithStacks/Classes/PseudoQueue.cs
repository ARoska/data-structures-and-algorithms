using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T> where T : class
    {
        public MyStack<T> StackOne { get; set; }

        public PseudoQueue()
        {
            StackOne = new MyStack<T>();
        }

        public void Enqueue(Node<T> node)
        {
            MyStack<T> StackTwo = new MyStack<T>;

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            StackOne.Push(node);

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }
        }

        public T Dequeue()
        {
            T returnTemp;
            MyStack<T> StackTwo = new MyStack<T>;

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            returnTemp = StackTwo.Pop();

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }

            return returnTemp;
        }

        public T Peek()
        {
            T returnTemp;
            MyStack<T> StackTwo = new MyStack<T>;

            while (StackOne.Top != null)
            {
                T temp = StackOne.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackTwo.Push(tempNode);
            }

            returnTemp = StackTwo.Peek();

            while (StackTwo.Top != null)
            {
                T temp = StackTwo.Pop();
                Node<T> tempNode = new Node<T>(temp);
                StackOne.Push(tempNode);
            }

            return returnTemp;
        }
    }
}
