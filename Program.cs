using System;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(3);
            bst.Insert(2);
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(7);
            bst.Insert(5);
            bst.Insert(4);
            bst.Insert(8);
            bst.Insert(0);

            //bst.InOrder();
            
            Console.WriteLine(bst.Search(10));

        }
    }
}
