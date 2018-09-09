using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                                (0)
                   5(1)                     8(2)
              2(3)     6(4)        9(5)       7(6)

             */

            Tree tree = new Tree();

            tree.AddNode(0, Direction.Left, new Node(1, 5));
            tree.AddNode(0, Direction.Right, new Node(2, 8));

            tree.AddNode(1, Direction.Left, new Node(3, 2));
            tree.AddNode(1, Direction.Right, new Node(4, 6));

            tree.AddNode(2, Direction.Left, new Node(5, 9));
            tree.AddNode(2, Direction.Right, new Node(6, 7));


            tree.DeleteNode(2);

            //tree.PreorderTraversal();
            //tree.InorderTraversal();
            tree.PostorderTraversal();

            Console.ReadLine();
        }
    }
}
