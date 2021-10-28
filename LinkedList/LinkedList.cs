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

        public void AddLast(int val)
        {
            Node newLastNode = new Node(val, null);
            if (_head == null)
            {
                _head = newLastNode;
            }
            else
            {
                Node current = GetHead();
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newLastNode;
            }
            
        }


        public void AddLast(LinkedList list)
        {
            if (_head == null)
            {
                _head = list.GetHead();
            }
            else
            {
                Node current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = list.GetHead();
            }
        }

        public void AddAt(int idx, int val)
        {
            if (idx+1 > GetLength() || idx < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() == 1)
            {
                AddFirst(val);
            }
            else
            {
                int count = 0;
                Node current = _head;
                Node tmpNode = new Node();

                while (count != idx - 1)
                {
                    current = current.Next;
                    count++;
                }

                tmpNode = current.Next;
                Node newNode = new Node(val, tmpNode);
                current.Next = newNode;
            }
        }

        public void AddAt(int idx, LinkedList list)
        {
            if (idx + 1 > GetLength() || idx < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() == 1)
            {
                AddFirst(list);
            }
            else
            {
                int count = 0;
                Node currentMain = _head;
                Node current = list.GetHead();
                Node tmpNode = new Node();

                while (count != idx - 1)
                {
                    currentMain = currentMain.Next;
                    count++;
                }

                tmpNode = currentMain.Next;
                currentMain.Next = list.GetHead();
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = tmpNode;
            }
        }


        public void Set(int idx, int val)
        {

            if (idx + 1 > GetLength() || idx < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = _head;
            int count = 0;
            while (count != idx)
            {
                current = current.Next;
                count++;
            }

            current.Value = val;
           
        }

        public void RemoveFirst()
        {
            if (GetLength() == 0)
            {
                throw new IndexOutOfRangeException();
            }
            _head = _head.Next;
        }

        public void RemoveLast()
        {
            if (GetLength() == 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (GetLength() == 1)
            {
                _head = null;
            }
            else
            {
                Node current = _head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
           
        }

        public void RemoveAt(int idx)
        {
            if (idx + 1 > GetLength() || idx < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() == 1)
            {
                RemoveFirst();
            }
            else
            {
                Node current = _head;
                int count = 0;
                while (count != idx - 1)
                {
                    count++;
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
        }


        public void RemoveFirstMultiple(int n)
        {
            if (n  > GetLength() || n < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() == 1 && n == 1)
            {
                RemoveFirst();
            }
            else
            {
                Node current = _head;
                for (int i = 0; i < n; i++)
                {
                    current = current.Next;
                }
                _head = current;
            }

        }


        public void RemoveLastMultiple(int n)
        {
            if (n > GetLength() || n < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() ==  n )
            {
                _head = null;
            }
            else
            {
                int newLength = GetLength() - n;
                Node current = _head;
                for (int i = 0; i < newLength - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx + 1 > GetLength() || idx < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (GetLength() == n)
            {
                _head = null;
            }
            else
            {
                Node current = _head;
                int count = 0;
                while (count != idx - 1)
                {
                    count++;
                    current = current.Next;
                }

                Node newNext = current;
                for (int i = 0; i <= n; i++)
                {
                    newNext = newNext.Next;
                }
                current.Next = newNext;
            }
        }

        public int RemoveFirst(int val)
        {
          
        }

        public void RemoveAllTest(int val)
        {

        }



        private Node GetHead()
        {
            return _head;
        }
    }
}
