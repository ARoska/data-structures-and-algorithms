using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class MyBinaryTree<T> where T : IConvertible
    {
        public Node<T> Root { get; set; }

        public Node<T> Current { get; set; }

        public MyBinaryTree()
        {
            Root = null;
        }
    }
}
