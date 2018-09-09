using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    public class Node
    {
        public Node()
        {

        }
        public Node(int nodeIndex, int data)
        {
            NodeIndex = nodeIndex;
            Data = data;
            LeftChild = null;
            RightChild = null;
            ParentNode = null;
        }


        public Node(int nodeIndex, int data, Node leftChild, Node rightChild, Node parentNode)
        {
            NodeIndex = nodeIndex;
            Data = data;
            LeftChild = leftChild;
            RightChild = rightChild;
            ParentNode = parentNode;
        }
        public override string ToString()
        {
            return $"nodeIndex:{this.NodeIndex} data:{this.Data.ToString()}";
        }

        public int NodeIndex { get; set; }
        public int Data { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node ParentNode { get; set; }

        internal Node Search(int nodeIndex)
        {
            var tempNode = new Node();
            if (this.NodeIndex == nodeIndex)
                return this;

            if (this.LeftChild != null)
            {
                if (this.LeftChild.NodeIndex == nodeIndex)
                    return this.LeftChild;
                else
                {
                    tempNode = this.LeftChild.Search(nodeIndex);
                    if (tempNode != null)
                    {
                        return tempNode;
                    }
                }
            }

            if (this.RightChild != null)
            {
                if (this.RightChild.NodeIndex == nodeIndex)
                    return this.RightChild;
                else
                {
                    tempNode = this.RightChild.Search(nodeIndex);
                    if (tempNode != null)
                    {
                        return tempNode;
                    }
                }
            }

            return null;
        }

        internal void DeleteNode()
        {
            if (this.LeftChild != null)
            {
                this.LeftChild.DeleteNode();
            }
            else if (this.RightChild != null)
            {
                this.RightChild.DeleteNode();
            }

            var parentNode = this.ParentNode;
            if (parentNode.LeftChild != null)
            {
                if (parentNode.LeftChild.NodeIndex == this.NodeIndex)
                {
                    parentNode.LeftChild = null;
                }
            }
            else if (parentNode.RightChild != null)
            {
                if (parentNode.RightChild.NodeIndex == this.NodeIndex)
                {
                    parentNode.RightChild = null;
                }
            }
        }

        internal void PreorderTraversal()
        {

            Console.WriteLine(this.ToString());

            if (this.LeftChild != null)
            {
                this.LeftChild.PreorderTraversal();
            }

            if (this.RightChild != null)
            {
                this.RightChild.PreorderTraversal();
            }

        }

        internal void InorderTraversal()
        {
            if (this.LeftChild != null)
            {
                this.LeftChild.InorderTraversal();
            }

            Console.WriteLine(this.ToString());

            if (this.RightChild != null)
            {
                this.RightChild.InorderTraversal();
            }
        }

        internal void PostorderTraversal()
        {
            if (this.LeftChild != null)
            {
                this.LeftChild.InorderTraversal();
            }
            if (this.RightChild != null)
            {
                this.RightChild.InorderTraversal();
            }

            Console.WriteLine(this.ToString());
        }
    }
}
