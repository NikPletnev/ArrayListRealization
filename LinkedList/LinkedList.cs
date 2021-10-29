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
            int idx = -1;
            int count = 0;
            Node current = _head;
            if (_head.Next == null && _head.Value == val)
            {
                RemoveFirst();
                idx = count;
            }
            else
            {
                while (current != null)
                {
                    if (current.Value == val)
                    {
                        idx = count;
                        break;
                    }
                    current = current.Next;
                    count++;
                }
                if (idx != -1)
                {
                    RemoveAt(idx);
                }
            }
            return idx;
        }

        public int RemoveAll(int val)
        {

            int idx = 0;
            int count = 0;
            int returnNumberDeleted = 0;
            Node current = _head;
            if (_head.Next == null && _head.Value == val)
            {
                RemoveFirst();
                returnNumberDeleted++;
            }
            else
            {
                while (current != null)
                {
                    if (current.Value == val)
                    {
                        idx = count;
                        RemoveAt(idx);
                        current = _head;
                        count = 0;
                        returnNumberDeleted++;
                        continue;
                    }
                    current = current.Next;
                    count++;
                }

            }

            return returnNumberDeleted;
        }



        public bool Contains(int val)
        {
            Node current = _head;
            bool contains = false;
            for (int i = 0; i < GetLength(); i++)
            {
                if (current.Value == val)
                {
                    contains = true;
                    break;
                }
                current = current.Next;
            }
            return contains;
        }

        public int IndexOf(int val)
        {
            Node current = _head;
            int idx = -1;
            for (int i = 0; i < GetLength(); i++)
            {
                if (current.Value == val)
                {
                    idx = i;
                    break;
                }
                current = current.Next;
            }
            return idx;
        }

        public int GetFirst()
        {
            if (_head != null)
            {
                return _head.Value;
            }
            else
            {
                throw new Exception("List has no elements");
            }
        }

        public int GetLast()
        {
            if (_head != null)
            {
                Node current = _head;
                while (current.Next !=null)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            else
            {
                throw new Exception("List has no elements");
            }
        }

        public int Get(int idx)
        {
            if (_head != null)
            {
                Node current = _head;
                int len = GetLength();
                for (int i = 0; i < idx; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            else
            {
                throw new Exception("List has no elements");
            }
        }

        public void Reverse()
        {
            Node current = _head;
            LinkedList reversedList = new LinkedList();
            while (GetLength() != 0)
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
               
                reversedList.AddLast(current.Value);
                current = _head;
                RemoveLast();
            }
            _head = reversedList.GetHead();
        }


        public int Max()
        {
            if (_head != null)
            {
                Node current = _head;
                int max = _head.Value;
                while (current != null)
                {
                    if (current.Value > max)
                    {
                        max = current.Value;
                    }
                    current = current.Next;
                }
                return max;
            }
            else
            {
                throw new Exception("List has no elements");
            }
        }

        public int Min()
        {
            if (_head != null)
            {
                Node current = _head;
                int min = _head.Value;
                while (current != null)
                {
                    if (current.Value < min)
                    {
                        min = current.Value;
                    }
                    current = current.Next;
                }
                return min;
            }
            else
            {
                throw new Exception("List has no elements");
            }
            
        }


        public int IndexOfMax()
        {
            if (_head != null)
            {
                Node current = _head;
                int max = _head.Value;
                int idx = 0;
                int count = 0;
                while (current != null)
                {
                    
                    if (current.Value > max)
                    {
                        max = current.Value;
                        idx = count;
                    }
                    current = current.Next;
                    count++;
                }
                return idx;
            }
            else
            {
                throw new Exception("List has no elements");
            }
        }

        public int IndexOfMin()
        {
            if (_head != null)
            {
                Node current = _head;
                int min = _head.Value;
                int idx = 0;
                int count = 0;
                while (current != null)
                {
                    if (current.Value < min)
                    {
                        min = current.Value;
                        idx = count;
                    }
                    current = current.Next;
                    count++;
                }
                return idx;
            }
            else
            {
                throw new Exception("List has no elements");
            }

        }


        public void Sort()
        {
            Node outCurrent = _head;
            Node innerCurrent = _head;
            int tmp;

            while (outCurrent.Next != null)
            {
                innerCurrent = outCurrent.Next;
                while (innerCurrent != null)
                {
                    if (outCurrent.Value > innerCurrent.Value)
                    {
                        tmp = innerCurrent.Value;
                        innerCurrent.Value = outCurrent.Value;
                        outCurrent.Value = tmp;
                    }
                    innerCurrent = innerCurrent.Next;
                }
                outCurrent = outCurrent.Next;
            }        

        }

        public void SortDesc()
        {
            Node outCurrent = _head;
            Node innerCurrent = _head;
            int tmp;

            while (outCurrent.Next != null)
            {
                innerCurrent = outCurrent.Next;
                while (innerCurrent != null)
                {
                    if (outCurrent.Value < innerCurrent.Value)
                    {
                        tmp = innerCurrent.Value;
                        innerCurrent.Value = outCurrent.Value;
                        outCurrent.Value = tmp;
                    }
                    innerCurrent = innerCurrent.Next;
                }
                outCurrent = outCurrent.Next;
            }

        }



        private Node GetHead()
        {
            return _head;
        }
    }
}
