using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSingleLinkedList();
            TestDoubleLinkedList();

            LinkedList<int> linkedList = new LinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            //LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            //LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            linkedList.AddFirst(node1);
            //linkedList.AddFirst(node2);
            //linkedList.AddFirst(node3);

            Console.ReadLine();
        }

        public static void TestDoubleLinkedList()
        {
            MyDoubleLinkedList<int> linkedList = new MyDoubleLinkedList<int>();

            DbNode<int> node1 = new DbNode<int>(1);
            DbNode<int> node2 = new DbNode<int>(2);
            DbNode<int> node3 = new DbNode<int>(3);
            linkedList.AddBefore(1);
            linkedList.AddBefore(2);
            linkedList.AddBefore(3);
            linkedList.AddBefore(4);
            linkedList.AddAfter(5);

            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }

            Console.WriteLine("Remove at 1");
            linkedList.RemoveAt(0);

            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }


        }

        public static void TestSingleLinkedList()
        {
            MySingleLinkedList<int> linkedList = new MySingleLinkedList<int>();

            Console.WriteLine("Add 3 item");
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }

            Console.WriteLine("Insert index:0 value:10");
            linkedList.Insert(0, 10);
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }


            Console.WriteLine("RemoveAt 0");
            linkedList.RemoveAt(0);

            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(linkedList[i]);
            }


        }
    }
}
