using System;

namespace BinaryTree
{
    public class BinarySearchTree //: BinaryTree
    {
        Node root;
        public BinarySearchTree() 
        {
            root = null;
        }
        private Node Insert(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root.data)
                root.left = Insert(root.left, data);
            else if (data > root.data)
                root.right = Insert(root.right, data);

            return root;
        }
        public void Insert(int data)
        {
            root = Insert(root, data);
        }
        private void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data + " ");
                InOrder(root.right);
            }
        }
        public void InOrder()
        {
            InOrder(root);
        }
        private bool Search(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            else if (value < root.data)
            {
                return Search(root.left, value);
            }
            else if (value > root.data)
            {
                return Search(root.right, value);
            }
            else 
            {
                return true;
            }
        }
        public bool Search(int value)
        {
            return Search(root, value);
        }
    }
}