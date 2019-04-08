using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static MyBinaryTree<object> FuzzBuzz(MyBinaryTree<object> tree)
        {
            PreOrderMod(tree.Root);
            return tree;
        }

        public static void PreOrderMod(Node<object> root)
        {
            if (root != null)
            {
                int value = (int)root.Value;
                if ((value % 3 == 0) && (value % 5 == 0))
                {
                    root.Value = "FizzBuzz";
                }
                if (value % 3 == 0)
                {
                    root.Value = "Fizz";
                }
                if (value % 5 == 0)
                {
                    root.Value = "Buzz";
                }

                if (root.LChild != null)
                {
                    PreOrderMod(root.LChild);
                }
                if (root.RChild != null)
                {
                    PreOrderMod(root.RChild);
                }
            }
        }

    }
}
