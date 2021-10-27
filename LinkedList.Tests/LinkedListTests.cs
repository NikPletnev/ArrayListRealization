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
            int[] array = new int[] { 3, 5, 12, 15, 32};
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
        [TestCase(2, new int[1] {5})]
        [TestCase(3, new int[5] {3, 5, 12, 15, 32})]

        public void ToArrayTest(int key, int[] expected)
        {
            LinkedList actualLinkedList = GetTestLinkedList(key);

            int[] actual = actualLinkedList.ToArray();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, new int[] { 6}, 6)]
        [TestCase(2, new int[] { 11 ,5 }, 11)]
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

    }
}