﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLinkedList
{
    interface ILists
    {
        int GetLength();
        int[] ToArray();
        void AddFirst(int val);
        void AddFirst(DoublyLinkedList list);
        void AddLast(int val);
        void AddLast(DoublyLinkedList list);
        void AddAt(int idx, int val);
        void AddAt(int idx, DoublyLinkedList list);
        void Set(int idx, int val);
        void RemoveFirst();
        void RemoveLast();
        void RemoveAt(int idx);
        void RemoveFirstMultiple(int n);
        void RemoveLastMultiple(int n);
        void RemoveAtMultiple(int idx, int n);
        int RemoveFirst(int val);
        int RemoveAll(int val);
        bool Contains(int val);
        int IndexOf(int val);
        int GetFirst();
        int GetLast();
        int Get(int idx);
        void Reverse();
        int Max();
        int Min();
        int IndexOfMax();
        int IndexOfMin();
        void Sort();
        void SortDesc();
    }
}
