using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public virtual SinglyLinkedListNode<T> Next { get; set; }
        public SinglyLinkedListNode()
        {

        }
        public SinglyLinkedListNode(T item)
        {
            Value = item;
        }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
