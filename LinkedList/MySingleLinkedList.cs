using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MySingleLinkedList<T>
    {
        private Node<T> head;
        public int Count { get; set; }

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

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> prevNode = this.GetNodeByIndex(this.Count - 1);
                prevNode.Next = newNode;
            }
            this.Count++;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > this.Count)
                throw new ArgumentOutOfRangeException("index", "索引超出范围");

            Node<T> newNode = new Node<T>(value);

            if (index == 0)
            {
                if (head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }
            else
            {
                Node<T> prevNode = this.GetNodeByIndex(index - 1);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }

            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.Count - 1)
                throw new ArgumentOutOfRangeException("index", "索引超出范围");

            if (index == 0)
            {
                if (head == null)
                {
                    return;
                }
                else
                {
                    head = head.Next;
                }
            }
            else
            {
                Node<T> deleteNode = this.GetNodeByIndex(index);
                Node<T> prevNode = this.GetNodeByIndex(index - 1);
                prevNode.Next = deleteNode.Next;
                deleteNode = null;
            }
            this.Count--;
        }


        public Node<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index > this.Count - 1)
                throw new ArgumentOutOfRangeException("index", "索引超出范围");

            if (index == 0)
                return this.head;

            Node<T> result = null;
            int count = 0;
            Node<T> currNode = head;
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
