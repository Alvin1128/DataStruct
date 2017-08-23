using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyDoubleLinkedList<T>
    {
        public int Count { get; private set; }
        private DbNode<T> head;

        public T this[int index]
        {
            get
            {
                return this.GetNodeByIndex(index).Item;
            }
            set
            {
                this.GetNodeByIndex(index).Item = value;
            }
        }

        public void AddAfter(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DbNode<T> lastNode = this.GetNodeByIndex(this.Count - 1);
                lastNode.Next = newNode;
                newNode.Prev = lastNode;
            }
            Count++;
        }

        public void AddBefore(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DbNode<T> lastNode = this.GetNodeByIndex(this.Count - 1);

                if (lastNode == head)
                {
                    newNode.Next = lastNode;
                    lastNode.Prev = newNode;
                    head = newNode;
                }
                else
                {
                    newNode.Next = lastNode;
                    newNode.Prev = lastNode.Prev;

                    newNode.Prev.Next = newNode;
                    lastNode.Prev = newNode;
                }
            }
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.Count - 1)
                throw new ArgumentOutOfRangeException("index", "索引超出范围");

            DbNode<T> deleteNode = this.GetNodeByIndex(index);

            DbNode<T> prevNode = deleteNode.Prev;
            DbNode<T> nextNode = deleteNode.Next;


            prevNode.Next = nextNode;
            nextNode.Prev = prevNode;

            Count--;
        }

        public DbNode<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index > this.Count - 1)
                throw new ArgumentOutOfRangeException("index", "索引超出范围");

            if (index == 0)
                return this.head;

            DbNode<T> result = null;
            int count = 0;
            DbNode<T> currNode = head;
            for (int i = 0; i < this.Count; i++)
            {
                count++;
                currNode = currNode.Next;
                if (count == index)
                {
                    result = currNode;
                    break;
                }
            }

            return result;
        }

    }
}
