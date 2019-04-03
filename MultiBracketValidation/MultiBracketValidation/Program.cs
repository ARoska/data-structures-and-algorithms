using StacksAndQueues.Classes;
using System;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool MultiBracketValidation(string str)
        {
            MyStack<char> myStack = new MyStack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '[' || str[i] == '(')
                {
                    Node<char> node = new Node<char>(str[i]);
                    myStack.Push(node);
                }
                if (str[i] == '}' || str[i] == ']' || str[i] == ')')
                {
                    char character = str[i];
                    switch (character)
                    {
                        case '}':
                            if (Compare(character, myStack) == false)
                            {
                                return false;
                            }
                            break;

                        case ']':
                            if (Compare(character, myStack) == false)
                            {
                                return false;
                            }
                            break;

                        case ')':
                            if (Compare(character, myStack) == false)
                            {
                                return false;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            return true;
        }

        public bool Compare(char character, MyStack<char> myStack)
        {
            Node<char> node = myStack.Peek();
            char top = node.Value;

            if (top == character)
            {
                return true;
            }

            return false;
        }
    }
}
