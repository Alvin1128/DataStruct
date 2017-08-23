using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DbNode<T>
    {
        public DbNode<T> Prev { get; set; }
        public T Item { get; set; }
        public DbNode<T> Next { get; set; }

        public DbNode(T item)
        {
            this.Item = item;
        }
    }
}
