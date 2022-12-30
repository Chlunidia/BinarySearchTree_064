using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*A node class consist of three things, the information, reference to the right child, and reference to the left child*/

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void insert(string element) /*Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null)/*Check if the node to be inserted already inserted or not*/
            {
                Console.WriteLine("Duplicate word not allowed");
                return;
            }
            else /*If the specified node is not present*/
            {
                tmp = new Node(element, null, null); /*Create a node*/
                if (parent == null) /*If the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /*This function searches the currentNode of the specified Node as well as the currentNode of it's parent*/
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.Write(ptr.info + " ");
                inorder(ptr.rightchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }       
        static void Main(string[] args)
        {
        }
    }
}
