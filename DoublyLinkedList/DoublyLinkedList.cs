using System;

namespace DLinkedList
{
    public class DoublyLinkedList : ILists
    {
        private DoublyLinkedListNode _head;
        private DoublyLinkedListNode _tail;

        public DoublyLinkedList()
        {
            _head = new DoublyLinkedListNode(0, null, null);
            _tail = _head;
        }

        public DoublyLinkedList(int val)
        {
            _head = new DoublyLinkedListNode(val, null, null);
            _tail = _head;
        }

        public DoublyLinkedList(int[] array)
        {
            if (array.Length > 0)
            {
                _head = new DoublyLinkedListNode(array[0], null, null);
                DoublyLinkedListNode current = _head;
                for (int i = 1; i < array.Length; i++)
                {
                    current.Next = new DoublyLinkedListNode(array[i], null, current);
                    current = current.Next;
                }
                _tail = current;
            }

        }

        public int GetLength()
        {
            int length = 0;
            DoublyLinkedListNode current = _head;
            if (current != null)
            {
                while (current != null)
                {
                    length++;
                    current = current.Next;
                }
            }

            return length;
        }

        public int[] ToArray()
        {
            DoublyLinkedListNode current = _head;
            int length = GetLength();
            int[] toArray = new int[length];
            if (current != null)
            {
                int i = 0;
                while (current != null)
                {
                    toArray[i] = current.Value;
                    current = current.Next;
                    i++;
                }
            }
            return toArray;
        }

        public void AddFirst(int val)
        {
            InsertNewNodeValue(val);
        }
        public void AddFirst(DoublyLinkedList list)
        {
            InsertNewNodeList(list);
        }

        public void AddLast(int val)
        {
            DoublyLinkedListNode current = _tail;
            if (current == null)
            {
                DoublyLinkedListNode newNode = new DoublyLinkedListNode(val, null, null);
                _head = newNode;
                _tail = _head;
            }
            else
            {
                DoublyLinkedListNode newNode = new DoublyLinkedListNode(val, null, current);
                current.Next = newNode;
                _tail = newNode;
            }

        }




        public void AddLast(DoublyLinkedList list)
        {
            int[] listArray = list.ToArray();
            DoublyLinkedList addList = new DoublyLinkedList(listArray);
            if (_head == null)
            {
                _head = addList._head;
                _tail = addList._tail;
            }
            else
            {
                _tail.Next = addList._head;
                _tail = addList._tail;
            }

        }

        public void AddAt(int idx, int val)
        {
            if (idx >= 0 && idx < GetLength())
            {
                InsertNewNodeValue(val, idx);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void AddAt(int idx, DoublyLinkedList list)
        {
            if ((idx == 0 && idx == GetLength()) || idx >= 0 && idx < GetLength())
            {
                InsertNewNodeList(list, idx);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Set(int idx, int val)
        {
            if (idx >= 0 && idx < GetLength())
            {
                DoublyLinkedListNode current = _head;
                for (int i = 0; i < idx; i++)
                {
                    current = current.Next;
                }
                current.Value = val;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveFirst()
        {
            if (_head != null)
            {
                _head = _head.Next;
            }
        }

        public void RemoveLast()
        {
            if (_tail != null)
            {
                _tail = _tail.Perv;
                if (_tail != null)
                {
                    _tail.Next = null;
                }
                else
                {
                    _head = null;
                }
            }
        }

        public void RemoveAt(int idx)
        {
            if (idx < 0 && idx > GetLength())
            {
                throw new IndexOutOfRangeException();
            }
            DoublyLinkedListNode current = _head;
            if (idx == 0)
            {
                RemoveFirst();
            }
            else
            {
                for (int i = 0; i < idx - 1; i++)
                {
                    current = current.Next;
                }
                if (current != null)
                {
                    current.Next = current.Next.Next;
                    if (current.Next != null)
                    {
                        current.Next.Perv = current;
                    }
                }
                else
                {
                    RemoveLast();
                }
            }

        }

        public void RemoveFirstMultiple(int n)
        {
            if (n > GetLength())
            {
                throw new IndexOutOfRangeException();
            }
            DoublyLinkedListNode current = _head;
            for (int i = 0; i < n; i++)
            {
                current = current.Next;
            }
            _head = current;
        }

        public void RemoveLastMultiple(int n)
        {
            if (n > GetLength())
            {
                throw new IndexOutOfRangeException();
            }
            DoublyLinkedListNode current = _head;
            for (int i = 0; i < n; i++)
            {
                current = current.Next;
            }
            _head = current;
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            if (idx < 0 && idx > GetLength() && idx + n + 1 > GetLength())
            {
                throw new IndexOutOfRangeException();
            }
            DoublyLinkedListNode current = _head;
            if (idx == 0)
            {
                RemoveFirstMultiple(n);
            }
            else
            {
                for (int i = 0; i < idx - 1; i++)
                {
                    current = current.Next;
                }
                if (current != null)
                {
                    DoublyLinkedListNode newCurrent = current;
                    for (int i = 0; i < n; i++)
                    {
                        newCurrent = newCurrent.Next;
                    }
                    current.Next = newCurrent.Next;
                    if (newCurrent.Next != null)
                    {
                        newCurrent.Perv = current;
                    }
                }
                else
                {
                    RemoveLast();
                }
            }
        }

        public int RemoveFirst(int val)
        {
            DoublyLinkedListNode current = _head;
            int count = 0;
            while (current != null)
            {

                if (val == current.Value)
                {
                    if (count == 0)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        current.Perv.Next = current.Next;
                        if (current.Next != null)
                        {
                            current.Next.Perv = current.Perv;
                        }
                    }

                    return count;
                }
                count++;
                current = current.Next;
            }
            return -1;
        }

        public int RemoveAll(int val)
        {
            DoublyLinkedListNode current = _head;
            int count = 0;
            int n = 0;
            while (current != null)
            {
                if (current.Value == val)
                {
                    n++;
                    if (count == 0)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        current.Perv.Next = current.Next;
                        if (current.Next != null)
                        {
                            current.Next.Perv = current.Perv;
                        }
                    }
                    current = _head;
                    count = 0;
                    continue;
                }
                count++;
                current = current.Next;
            }
            return n;
        }

        public bool Contains(int val)
        {
            DoublyLinkedListNode current = _head;
            bool contains = false;
            while (current != null)
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
            DoublyLinkedListNode current = _head;
            int index = 0;
            while (current != null)
            {
                if (current.Value == val)
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public int GetFirst()
        {
            if (_head != null)
            {
                return _head.Value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public int GetLast()
        {
            if (_tail != null)
            {
                return _tail.Value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public int Get(int idx)
        {
            if (idx >= 0)
            {
                DoublyLinkedListNode current = _head;
                for (int i = 0; i < idx; i++)
                {
                    current = current.Next;
                    if (current == null)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                return current.Value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void Reverse()
        {
            DoublyLinkedListNode headCurrent = _head;
            DoublyLinkedListNode tailCurrent = _tail;

            while (headCurrent != tailCurrent )
            {
                Swap(headCurrent, tailCurrent);
                headCurrent = headCurrent.Next;
                tailCurrent = tailCurrent.Perv;
                if (headCurrent.Perv == tailCurrent)
                {
                    break;
                }
            } 
            
        }

        public int Max()
        {
            DoublyLinkedListNode current = _head;
            if (_head != null)
            {
                int max = _head.Value;
                while (current != null)
                {
                    if (max < current.Value)
                    {
                        max = current.Value;
                    }
                    current = current.Next;
                }
                return max;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        public int Min()
        {
            DoublyLinkedListNode current = _head;
            if (_head != null)
            {
                int min = _head.Value;
                while (current != null)
                {
                    if (min > current.Value)
                    {
                        min = current.Value;
                    }
                    current = current.Next;
                }
                return min;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOfMax()
        {
            DoublyLinkedListNode current = _head;
            if (_head != null)
            {
                int max = _head.Value;
                int index = 0;
                int indexMax = 0; 
                while (current != null)
                {
                    if (max < current.Value)
                    {
                        max = current.Value;
                        indexMax = index;
                    }
                    index++;
                    current = current.Next;
                }
                return indexMax;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOfMin()
        {
            DoublyLinkedListNode current = _head;
            if (_head != null)
            {
                int min = _head.Value;
                int index = 0;
                int indexMin = 0;
                while (current != null)
                {
                    if (min > current.Value)
                    {
                        min = current.Value;
                        indexMin = index;
                    }
                    index++;
                    current = current.Next;
                }
                return indexMin;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Sort()
        {
            DoublyLinkedListNode firstCurrent = _head;
            DoublyLinkedListNode secondCurrent;

            while (firstCurrent.Next != null)
            {
                secondCurrent = firstCurrent;
                while (secondCurrent !=null)
                {
                    if (firstCurrent.Value > secondCurrent.Value)
                    {
                        Swap(firstCurrent, secondCurrent);
                    }
                    secondCurrent = secondCurrent.Next;
                }
                firstCurrent = firstCurrent.Next;
            }
        }

        public void SortDesc()
        {
            DoublyLinkedListNode firstCurrent = _head;
            DoublyLinkedListNode secondCurrent;

            while (firstCurrent.Next != null)
            {
                secondCurrent = firstCurrent;
                while (secondCurrent != null)
                {
                    if (firstCurrent.Value < secondCurrent.Value)
                    {
                        Swap(firstCurrent, secondCurrent);
                    }
                    secondCurrent = secondCurrent.Next;
                }
                firstCurrent = firstCurrent.Next;
            }
        }

        private void InsertNewNodeValue(int val = 0, int n = 0)
        {
            DoublyLinkedListNode current = _head;
            if (current == null)
            {
                _head = new DoublyLinkedListNode(val, null, null);
                _tail = _head;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    current = current.Next;
                }
                if (n < 1)
                {
                    DoublyLinkedListNode newHead = new DoublyLinkedListNode(val, null, null);
                    current.Perv = newHead;
                    newHead.Next = current;
                    _head = newHead;
                }
                else
                {
                    DoublyLinkedListNode insertNode = new DoublyLinkedListNode(val, current, current.Perv);
                    current.Perv.Next = insertNode;
                    current.Perv = insertNode;
                }
            }

        }

        private void InsertNewNodeList(DoublyLinkedList list, int n = 0)
        {
            DoublyLinkedListNode current = _head;
            int[] array = list.ToArray();
            if (current == null)
            {
                if (array.Length > 0)
                {
                    _head = new DoublyLinkedListNode(array[0], null, null);
                    current = _head;
                    for (int i = 1; i < array.Length; i++)
                    {
                        current.Next = new DoublyLinkedListNode(array[i], null, current);
                        current = current.Next;
                    }
                    _tail = current;
                }
            }
            else
            {
                DoublyLinkedList addList = new DoublyLinkedList(array);
                if (n>0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        current = current.Next;
                    }
                    addList._tail.Next = current;
                    addList._head.Perv = current.Perv;
                    current.Perv.Next = addList._head;

                }
                else
                {
                    current.Perv = addList._tail.Next;
                    addList._tail.Next = current;
                    _head = addList._head;
                }

            }

        }
        private void Swap(DoublyLinkedListNode A, DoublyLinkedListNode B)
        {
            int  buffer = A.Value;
            A.Value = B.Value;
            B.Value = buffer;
        }
    }
}
