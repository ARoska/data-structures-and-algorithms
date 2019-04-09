using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static MyBinaryTree<object> FizzBuzz(MyBinaryTree<object> tree)
        {
            if (tree.Root != null)
            {
                PreOrderMod(tree.Root);
                return tree; 
            }

            return null;
        }

        public static void PreOrderMod(Node<object> root)
        {
            if (root != null)
            {
                int value = 0;
                try
                {
                    value = (int)root.Value;
                }
                catch (Exception)
                {
                    value = -1;
                }

                if (value % 3 == 0)
                {
                    root.Value = "Fizz";
                }
                if (value % 5 == 0)
                {
                    root.Value = "Buzz";
                }
                if ((value % 3 == 0) && (value % 5 == 0))
                {
                    root.Value = "FizzBuzz";
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
