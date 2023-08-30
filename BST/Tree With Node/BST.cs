using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_With_Node
{
    internal class BST
    {
        public Node root { get; set; }

        public void Add(int value)
        {
            Node newNode = new Node() { Value = value };
            if (root == null)
            {
                root = newNode;
                return;
            }
            Node tmpNode = root;
            while (true)
            {
                if (value < tmpNode.Value)
                {
                    if (tmpNode.Left == null)
                    {
                        tmpNode.Left = newNode;
                       
                        return;
                    }
                    tmpNode = tmpNode.Left;



                }
                if (value >= tmpNode.Value)
                {
                    if (tmpNode.Right == null)
                    {
                        tmpNode.Right = newNode;
                        return;
                    }
                    tmpNode = tmpNode.Right;
                }
            }

        }

        public void ScanInOrder() => ScanInOrder(root);

        public void ScanInOrder(Node node)
        {
            if (node == null) return;
            ScanInOrder(node.Left);
            Console.WriteLine(node.Value);
            ScanInOrder(node.Right);

        }

    }
}

