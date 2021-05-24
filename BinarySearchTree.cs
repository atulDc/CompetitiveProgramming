using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
    class Node
    {
        public int rootKey;
        public Node left;
        public Node right;
        public Node() { }
        public Node(int rootKey)
        {
            this.rootKey = rootKey;
            this.left = null;
            this.right = null;
        }
    }
    class BinarySearchTree
    {
        public Node root;
        BinarySearchTree()
        {
            root = null;
        }
        public void insertElement(int element)
        {
            root = insertInTree(root,element);
        }



        public Node insertInTree(Node root, int element)
        {
            if (root == null)
            {
                root = new Node(element);
                return root;
            }
            else if(root.rootKey > element)
            {
                 root.left = insertInTree(root.left, element);
            }
            else
            {
                 root.right = insertInTree(root.right, element);
            }
            return root;
        }

        public void preOrder()
        {
            preOrderTraverse(root);
        }
        public void preOrderTraverse(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.rootKey);
            preOrderTraverse(root.left);
            preOrderTraverse(root.right);
        }

        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine("Enter number of elements...");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i<n)
            {
                Console.WriteLine("Insert {0} element: ", i);
                int element = Convert.ToInt32(Console.ReadLine());
                bst.insertElement(element);
                i++;
            }
            Console.WriteLine("Traverse");
            bst.preOrder();
            Console.ReadKey();
        }
    }
}
