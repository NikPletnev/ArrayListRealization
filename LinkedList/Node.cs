using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Node
    {
        private int _value;
        private Node _next;

        public Node()
        {

        }
        public Node(int val, Node next)
        {
            Value = val;
            Next = next;
        }
        public int Value { get => _value; set => _value = value; }
        public Node Next { get => _next; set => _next = value; }
       
    }
}
