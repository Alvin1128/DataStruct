using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    interface ITree
    {
        Node Search(int index);
        bool AddNode(int index, Direction direction, Node node);
        void DeleteNode(int index);
        void PreorderTraversal();
        void InorderTraversal();
        void PostorderTraversal();
    }
}
