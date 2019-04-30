using StacksAndQueues.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are these bracket sets balanced?:\n" +
                "1. {}\n" +
                "2. [}\n" +
                "3. (()}\n" +
                "4. [[]]\n" +
                "5. ({[]})\n" +
                "6. ]({})[\n" +
                "7. []{}()[]\n" +
                "8. [HELLO WORLD!]\n" +
                "9. (hello world...]\n" +
                "10. Hello World\n" +
                "=================\n" +
                $"1. {MultibracketValidation("{}")}\n" +
                $"2. {MultibracketValidation("[}")}\n" +
                $"3. {MultibracketValidation("(()}")}\n" +
                $"4. {MultibracketValidation("[[]]")}\n" +
                $"5. {MultibracketValidation("({[]})")}\n" +
                $"6. {MultibracketValidation("]({})[")}\n" +
                $"7. {MultibracketValidation("[]{}()[]")}\n" +
                $"8. {MultibracketValidation("[HELLO WORLD!]")}\n" +
                $"9. {MultibracketValidation("(hello world...]")}\n" +
                $"10. {MultibracketValidation("Hello World")}");

        }

        /// <summary>
        /// Takes in a string and checks if any Brackets *()* or *[]* or *{}* are balanced.
        /// Uses a Stack for all Opening Brackets and a Helper Method to check Closing Brackets against the Stack.
        /// </summary>
        /// <param name="str">Any string to check.</param>
        /// <returns>True if Brackets are balanced.</returns>
        public static bool MultibracketValidation(string str)
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
                            if (Compare('{', myStack) == false)
                            {
                                return false;
                            }
                            break;

                        case ']':
                            if (Compare('[', myStack) == false)
                            {
                                return false;
                            }
                            break;

                        case ')':
                            if (Compare('(', myStack) == false)
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

        /// <summary>
        /// Helper Method used to compare the top of the Stack against a given Closing Bracket.
        /// </summary>
        /// <param name="character">The Closing Bracket to compare.</param>
        /// <param name="myStack">The current Stack of Opening Brackets</param>
        /// <returns>True if Closing Bracket matches top of Stack.</returns>
        public static bool Compare(char character, MyStack<char> myStack)
        {
            if (myStack.Peek() == null)
            {
                return false;
            }

            Node<char> node = myStack.Peek();
            char top = node.Value;

            if (top == character)
            {
                myStack.Pop();
                return true;
            }

            return false;
        }
    }
}
