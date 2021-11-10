using NUnit.Framework;
using DLinkedList;

namespace DLinkedListTests
{
    public class DoublyLinkedListTests
    {
        DoublyLinkedList testList = new DoublyLinkedList(new int[] { 3, 4, 5 });
        [SetUp]
        public void Setup()
        {

        }




        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[0] { }, 0)]
        [TestCase(new int[] { 1 }, 1)]


        public void GetLenghtTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.GetLength();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]

        public void ToArrayTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 1, 2, 3 }, 4)]
        [TestCase(new int[] { }, new int[] { 4 }, 4)]
        [TestCase(new int[] { 1 }, new int[] { 4, 1 }, 4)]

        public void AddFirstTest(int[] actualArray, int[] expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddFirst(val);
            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 3, 4, 5 })]

        public void AddFirstListTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddFirst(testList);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { }, new int[] { 4 }, 4)]
        [TestCase(new int[] { 1 }, new int[] { 1, 4 }, 4)]

        public void AddLast(int[] actualArray, int[] expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddLast(val);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 3, 4, 5 })]

        public void AddLastList(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddLast(testList);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4, 3 }, 2, 4)]
        [TestCase(new int[] { 1 }, new int[] { 4, 1 }, 0, 4)]

        public void AddAtTest(int[] actualArray, int[] expected, int idx, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddAt(idx, val);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 3 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { 3, 4, 5, 1 }, 0)]
        [TestCase(new int[] { }, new int[] { 3, 4, 5 }, 0)]

        public void AddAtListTest(int[] actualArray, int[] expected, int idx)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.AddAt(idx, testList);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { })]


        public void RemoveFirstTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.RemoveFirst();

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { })]


        public void RemoveLastTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.RemoveLast();

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, 1)]
        [TestCase(new int[] { 1 }, new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, 2)]


        public void RemoveAtTest(int[] actualArray, int[] expected, int idx)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.RemoveAt(idx);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3 }, 2)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, 3)]

        public void RemoveFirstMultipleTest(int[] actualArray, int[] expected, int n)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.RemoveFirstMultiple(n);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, 1, 1)]
        [TestCase(new int[] { 1 }, new int[] { }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3 }, 0, 2)]
        public void RemoveAtMultipleTest(int[] actualArray, int[] expected, int idx, int n)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.RemoveAtMultiple(idx, n);

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 0, 1)]
        [TestCase(new int[] { 1 }, -1, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 2, 3)]
        public void RemoveFirstValTest(int[] actualArray, int expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.RemoveFirst(val);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 2, 2, 3 }, 2, 2)]
        [TestCase(new int[] { 1 }, 0, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 1, 3)]
        public void RemoveAllTest(int[] actualArray, int expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.RemoveAll(val);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, true, 2)]
        [TestCase(new int[] { 1 }, false, 2)]
        [TestCase(new int[] { 1, 2, 3 }, true, 3)]
        public void ContainsTest(int[] actualArray, bool expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            bool actual = actualList.Contains(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 2)]
        [TestCase(new int[] { 1 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 2, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1, 4)]


        public void IndexOfTest(int[] actualArray, int expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.IndexOf(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 2, 3 }, 2)]
        public void GetFirstTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.GetFirst();

            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 2, 3 }, 3)]
        public void GetLastTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.GetLast();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3 }, 3, 2)]
        public void GetTest(int[] actualArray, int expected, int val)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.Get(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]


        public void ReversTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.Reverse();

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 3, 2, 1 }, 3)]

        public void MaxTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.Max();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 3, 2, 1 }, 1)]

        public void MinTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.Min();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 2, 3, 1 }, 1)]
        public void IndexOfMaxTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.IndexOfMax();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 2, 3, 1 }, 2)]
        public void IndexOfMinTest(int[] actualArray, int expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            int actual = actualList.IndexOfMin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 4, 2, 8 }, new int[] { 2, 4, 8})]
        [TestCase(new int[] {  1 }, new int[] { 1 })]
        public void SortTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.Sort();
            
            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1})]
        [TestCase(new int[] { 4, 2, 8 }, new int[] { 8, 4, 2 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void SortDescTest(int[] actualArray, int[] expected)
        {
            DoublyLinkedList actualList = new DoublyLinkedList(actualArray);

            actualList.SortDesc();

            int[] actual = actualList.ToArray();

            Assert.AreEqual(expected, actual);
        }


    }
}