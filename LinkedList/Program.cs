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
            TestSingleLinkedList();

            Console.ReadLine();
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
