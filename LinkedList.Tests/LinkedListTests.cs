using NUnit.Framework;
using Lists;

namespace LinkedListTests
{
    public class LinkedListsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        public LinkedList GetTestLinkedList(int key)
        {
            int[] array = new int[] { 3, 5, 12, 15, 32 };

            LinkedList returnLinkedList = key switch
            {
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(array),
                _ => new LinkedList()
            };
            return returnLinkedList;
        }

        public LinkedList GetTestLinkedLustToAdd()
        {
            int[] array = new int[] { 1, 2, 3 };
            LinkedList returnLinkedList = new LinkedList(array);
            return returnLinkedList;
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 5)]


        public void GetLenghtTest(int key, int expected)
        {
            LinkedList actualLinkedList = GetTestLinkedList(key);

            int actual = actualLinkedList.GetLength();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[0])]
        [TestCase(2, new int[1] { 5 })]
        [TestCase(3, new int[5] { 3, 5, 12, 15, 32 })]

        public void ToArrayTest(int key, int[] expected)
        {
            LinkedList actualLinkedList = GetTestLinkedList(key);

            int[] actual = actualLinkedList.ToArray();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, new int[] { 6 }, 6)]
        [TestCase(2, new int[] { 11, 5 }, 11)]
        [TestCase(3, new int[] { 56, 3, 5, 12, 15, 32 }, 56)]


        public void AddFirstTest(int key, int[] expected, int val)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.AddFirst(val);

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(1, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 3, 5 })]
        [TestCase(3, new int[] { 1, 2, 3, 3, 5, 12, 15, 32 })]


        public void AddFirstListTest(int key, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);
            LinkedList listToAdd = GetTestLinkedLustToAdd();

            actual.AddFirst(listToAdd);

            Assert.AreEqual(expected, actual.ToArray());
        }


        [TestCase(1, 5, new int[] { 5 })]
        [TestCase(2, 6, new int[] { 5, 6 })]
        [TestCase(3, 9, new int[] { 3, 5, 12, 15, 32, 9 })]


        public void AddLastTest(int key, int val, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.AddLast(val);

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(1, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 5, 1, 2, 3 })]
        [TestCase(3, new int[] { 3, 5, 12, 15, 32, 1, 2, 3 })]


        public void AddLastTestList(int key, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);
            LinkedList listToAdd = GetTestLinkedLustToAdd();

            actual.AddLast(listToAdd);

            Assert.AreEqual(expected, actual.ToArray());

        }

        [TestCase(2, 0, 6, new int[] { 6, 5 })]
        [TestCase(3, 2, 67, new int[] { 3, 5, 67, 12, 15, 32 })]


        public void AddAtTest(int key, int idx, int val, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.AddAt(idx, val);

            Assert.AreEqual(expected, actual.ToArray());
        }


        [TestCase(2, 0, new int[] { 1, 2, 3, 5 })]
        [TestCase(3, 2, new int[] { 3, 5, 1, 2, 3, 12, 15, 32 })]

        public void AddAtTestList(int key, int idx, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);
            LinkedList listToAdd = GetTestLinkedLustToAdd();

            actual.AddAt(idx, listToAdd);

            Assert.AreEqual(expected, actual.ToArray());

        }

        [TestCase(2, 0, 90, new int[] { 90 })]
        [TestCase(3, 3, 42, new int[] { 3, 5, 12, 42, 32 })]


        public void SetTest(int key, int idx, int val, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.Set(idx, val);

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(2, new int[0])]
        [TestCase(3, new int[] { 5, 12, 15, 32 })]

        public void RemoveFirstTest(int key, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(2, new int[0])]
        [TestCase(3, new int[] { 3, 5, 12, 15 })]
        public void RemoveLastTest(int key, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveLast();

            Assert.AreEqual(expected, actual.ToArray());

        }


        [TestCase(2, 0, new int[0])]
        [TestCase(3, 3, new int[] { 3, 5, 12, 32 })]
        [TestCase(3, 4, new int[] { 3, 5, 12, 15 })]

        public void RemoveAtTest(int key, int idx, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveAt(idx);

            Assert.AreEqual(expected, actual.ToArray());

        }

        [TestCase(2, 1, new int[0])]
        [TestCase(3, 3, new int[] { 15, 32 })]
        [TestCase(3, 5, new int[0])]

        public void RemoveFirstMultipleTest(int key, int n, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveFirstMultiple(n);

            Assert.AreEqual(expected, actual.ToArray());

        }

        [TestCase(2, 1, new int[0])]
        [TestCase(3, 2, new int[] { 3, 5, 12 })]
        [TestCase(3, 5, new int[0])]
        public void RemoveLasttMultipleTest(int key, int n, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveLastMultiple(n);

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(2, 0, 1, new int[0])]
        [TestCase(3, 2, 2, new int[] { 3, 5, 32 })]
        [TestCase(3, 0, 5, new int[0])]

        public void RemoveAtMultipleTest(int key, int idx, int n, int[] expected)
        {
            LinkedList actual = GetTestLinkedList(key);

            actual.RemoveAtMultiple(idx, n);

            Assert.AreEqual(expected, actual.ToArray());
        }

        [TestCase(2, 5, 0)]
        [TestCase(2, 2, -1)]
        [TestCase(3, 15, 3)]
        [TestCase(3, 32, 4)]


        public void RemoveFirstTestVal(int key, int val, int expected)
        {
            LinkedList actualList = GetTestLinkedList(key);

            int actual = actualList.RemoveFirst(val);

            Assert.AreEqual(expected, actual);
        }

    }
}