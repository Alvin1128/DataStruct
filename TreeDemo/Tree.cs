using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    public class Tree : ITree
    {
        public Node RootNode { get; set; }
        public Tree()
        {
            RootNode = new Node(0, 0);
        }
        ~Tree()
        {

        }

        public Node Search(int nodeIndex)
        {
            var tempNode = new Node();

            if (nodeIndex == RootNode.NodeIndex) {
                return RootNode;
            }


            if (RootNode.LeftChild != null)
            {
                if (RootNode.LeftChild.NodeIndex == nodeIndex)
                {
                    return RootNode.LeftChild;
                }
                else
                {
                    tempNode = RootNode.LeftChild.Search(nodeIndex);
                    if (tempNode != null)
                    {
                        return tempNode;
                    }
                }
            }

            if (RootNode.RightChild != null)
            {
                if (RootNode.RightChild.NodeIndex == nodeIndex)
                {
                    return RootNode.RightChild;
                }
                else
                {
                    tempNode = RootNode.RightChild.Search(nodeIndex);
                    if (tempNode != null)
                    {
                        return tempNode;
                    }
                }
            }
            return null;
        }

        public bool AddNode(int nodeIndex, Direction direction, Node node)
        {
            var targetNode = this.Search(nodeIndex);

            if (targetNode == null) return false;

            var newNode = new Node(node.NodeIndex, node.Data, node.LeftChild, node.RightChild, targetNode);

            if (direction == Direction.Left)
            {
                targetNode.LeftChild = newNode;
            }
            else if (direction == Direction.Right)
            {
                targetNode.RightChild = newNode;
            }

            return true;
        }

        public void DeleteNode(int nodeIndex)
        {
            var targetNode = this.Search(nodeIndex);

            if (targetNode.LeftChild != null)
            {
                targetNode.LeftChild.DeleteNode();
            }
            if (targetNode.RightChild != null)
            {
                targetNode.RightChild.DeleteNode();
            }
            var parentNode = targetNode.ParentNode;
            if (parentNode.LeftChild != null)
            {
                if (parentNode.LeftChild.NodeIndex == targetNode.NodeIndex)
                {
                    parentNode.LeftChild = null;
                }
            }

            if (parentNode.RightChild != null)
            {
                if (parentNode.RightChild.NodeIndex == targetNode.NodeIndex)
                {
                    parentNode.RightChild = null;
                }
            }

        }

        /// <summary>
        /// 根，左，右
        /// </summary>
        public void PreorderTraversal()
        {

            Console.WriteLine(RootNode.ToString());

            if (RootNode.LeftChild != null)
            {
                RootNode.LeftChild.PreorderTraversal();
            }

            if (RootNode.RightChild != null)
            {
                RootNode.RightChild.PreorderTraversal();
            }

            Console.WriteLine("================");

        }
        /// <summary>
        /// 左，根，右
        /// </summary>
        public void InorderTraversal()
        {
            if (RootNode.LeftChild != null)
            {
                RootNode.LeftChild.InorderTraversal();
            }

            Console.WriteLine(RootNode.ToString());

            if (RootNode.RightChild != null)
            {
                RootNode.RightChild.InorderTraversal();
            }
            Console.WriteLine("================");
        }

        /// <summary>
        /// 左，右，根
        /// </summary>
        public void PostorderTraversal()
        {
            if (RootNode.LeftChild != null)
            {
                RootNode.LeftChild.PostorderTraversal();
            }
            
            if (RootNode.RightChild != null)
            {
                RootNode.RightChild.PostorderTraversal();
            }

            Console.WriteLine(RootNode.ToString());
            Console.WriteLine("================");
        }
    }


    public enum Direction
    {
        Left,
        Right
    }
}

