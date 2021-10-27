using System;

namespace Lists

{
    public class LinkedList
    {
        private Node _head;
        public LinkedList()
        {
            _head = null;
        }
        public LinkedList(int val)
        {
            _head = new Node(val, null);
        }
        public LinkedList(int[] array)
        {
            _head = new Node(array[0], null);
            Node current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                current.Next = new Node(array[i], null);
                current = current.Next;
            }
        }
        public int GetLength()
        {
            Node current = _head;
            int lenght = 0;
            if (current != null)
            {
                while (current.Next != null)
                {
                    lenght++;
                    current = current.Next;
                }
                lenght++;
            }
           
            return lenght;
        }

        public int[] ToArray()
        {
            int[] array = new int[GetLength()];
            Node current = _head;
            if (current != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = current.Value;
                    current = current.Next;
                }
            }
            return array;
          
        }

        public void AddFirst(int val)
        {
            Node newHead = new Node(val, _head);
            _head = newHead; 
        }

        public void AddFirst(LinkedList list)
        {
            Node current = list.GetHead();
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = _head;
            _head = list.GetHead();

        }


        private Node GetHead()
        {
            return _head;
        }
    }
}
