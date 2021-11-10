using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLinkedList
{
    class DoublyLinkedListNode
    {
        private int _value;
        private DoublyLinkedListNode _next;
        private DoublyLinkedListNode _perv;
        public DoublyLinkedListNode()
        {

        }
        public DoublyLinkedListNode(int val, DoublyLinkedListNode next, DoublyLinkedListNode perv)
        {
            Value = val;
            Next = next;
            Perv = perv;
        }
        public int Value  { get => _value; set => _value = value;}
        public DoublyLinkedListNode Next { get => _next; set => _next = value; }
        public DoublyLinkedListNode Perv { get => _perv; set => _perv = value; }
    }
}
