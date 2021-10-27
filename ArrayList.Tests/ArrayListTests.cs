using NUnit.Framework;
using Lists;
namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public int[] GetTestArray(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 1, 2, 8, 4 },
                2 => new int[] { -3, 6, 32, 19, 22, 99 },
                _ => new int[] { },
            };
            return array;
        }

        public int[] GetTestArraySecond(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 8, 8, 8, 4 },
                2 => new int[] { -3, 6, 6, 19, 6, 99 },
                _ => new int[] { },
            };
            return array;
        }
        public int[] GetTestArrayToTestListToArray(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 1, 2, 8, 4 },
                2 => new int[] { -3, 6, 32, 19, 22, 99 },
                _ => new int[] { },
            };
            return array;
        }

        public int[] GetExpectedArrayToTestAddFirst(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 2, 1, 2, 8, 4 },
                2 => new int[] { -19, -3, 6, 32, 19, 22, 99 },
                _ => new int[] { },
            };
            return array;
        }

        public ArrayList GetListToAdd(int key)
        {
            int[] arrayA = new int[] { 2, 3, 4 };
            int[] arrayB = new int[] { -2, 32, 43 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }
        public ArrayList GetExpectedListToTestAddFirst(int key)
        {
            int[] arrayA = new int[] { 2, 3, 4, 1, 2, 8, 4 };
            int[] arrayB = new int[] { -2, 32, 43, -3, 6, 32, 19, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedListToTestAddLastVal(int key)
        {
            int[] arrayA = new int[] { 1, 2, 8, 4, 2 };
            int[] arrayB = new int[] { -3, 6, 32, 19, 22, 99, -19 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetTestListToTestAddList(int key)
        {
            int[] arrayA = new int[] { 2, 3, 4 };
            int[] arrayB = new int[] { -2, 32, 43 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }
        public ArrayList GetExpectedListToTestAddLastList(int key)
        {
            int[] arrayA = new int[] { 1, 2, 8, 4, 2, 3, 4 };
            int[] arrayB = new int[] { -3, 6, 32, 19, 22, 99, -2, 32, 43 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }


        public ArrayList GetExpectedForAddAtTest(int key)
        {

            int[] arrayA = new int[] { 1, 2, 54, 8, 4 };
            int[] arrayB = new int[] { -3, 6, 32, 19, 89, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedForAddAtTestList(int key)
        {

            int[] arrayA = new int[] { 1, 2, 2, 3, 4, 8, 4 };
            int[] arrayB = new int[] { -3, 6, 32, 19, -2, 32, 43, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }


        public ArrayList GetExpectedForSetTest(int key)
        {
            int[] arrayA = new int[] { 1, 2, 10, 4 };
            int[] arrayB = new int[] { -3, 6, 32, 19, 90, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedRemoveFirst(int key)
        {

            int[] arrayA = new int[] { 2, 8, 4 };
            int[] arrayB = new int[] { 6, 32, 19, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;

        }

        public ArrayList GetExpectedRemoveLast(int key)
        {

            int[] arrayA = new int[] { 1, 2, 8 };
            int[] arrayB = new int[] { -3, 6, 32, 19, 22 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;

        }

        public ArrayList GetExpectedRemoveMultiplyFirst(int key)
        {
            int[] arrayA = new int[] { 8, 4 };
            int[] arrayB = new int[] { 19, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedRemoveMultiplyLast(int key)
        {
            int[] arrayA = new int[] { 1, 2 };
            int[] arrayB = new int[] { -3, 6, 32 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedRemoveMultiplyAt(int key)
        {
            int[] arrayA = new int[] { 1, 4 };
            int[] arrayB = new int[] { -3, 6, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedRemoveFirstVal(int key)
        {
            int[] arrayA = new int[] { 1, 2, 4 };
            int[] arrayB = new int[] { -3, 6, 32, 22, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedRemoveAll(int key)
        {
            int[] arrayA = new int[] { 4 };
            int[] arrayB = new int[] { -3, 19, 99 };

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }


        public ArrayList GetExpectedReverse(int key)
        {
            int[] arrayA = new int[] { 4, 8, 2, 1 };
            int[] arrayB = new int[] { 99, 22, 19, 32, 6, -3 };
            //-3, 6, 32, 19, 22, 99
            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedSort(int key)
        {
            int[] arrayA = new int[] { 1, 2, 4, 8 };
            int[] arrayB = new int[] { -3, 6, 19, 22, 32, 99};
            //-3, 6, 32, 19, 22, 99
            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }

        public ArrayList GetExpectedSortDesc(int key)
        {
            int[] arrayA = new int[] { 8, 4, 2, 1 };
            int[] arrayB = new int[] {99, 32,  22, 19, 6, -3 };
            //-3, 6, 32, 19, 22, 99
            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;
        }


        //----------------------------------Test metods---------------------------------

        [TestCase(1, 4)]
        [TestCase(2, 6)]


        public void GetLenghtTest(int key, int expected)
        {

            //arrange
            ArrayList arrayList = new ArrayList(GetTestArray(key));


            //act
            int actual = arrayList.GetLenght();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]


        public void ToArrayTest(int key, int expectedKey)
        {
            //arrange
            ArrayList arrayList = new ArrayList(GetTestArray(key));

            //act
            int[] actual = arrayList.ToArray();
            int[] expected = GetTestArrayToTestListToArray(expectedKey);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2)]
        [TestCase(2, 2, -19)]

        public void AddFirstTestVal(int key, int expectedKey, int addNumber)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            int[] expectedArray = GetExpectedArrayToTestAddFirst(expectedKey);
            ArrayList expected = new ArrayList(expectedArray);
            //act
            actual.AddFirst(addNumber);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        public void AddFirstTestList(int key, int expectedKey, int keyForAddList)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedListToTestAddFirst(expectedKey);
            ArrayList addList = GetTestListToTestAddList(keyForAddList);

            //act
            actual.AddFirst(addList);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 2)]
        [TestCase(2, 2, -19)]
        public void AddLastTestVal(int key, int expectedKey, int addNumber)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedListToTestAddLastVal(expectedKey);
            //act
            actual.AddLast(addNumber);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        public void AddLastTestList(int key, int expectedKey, int keyForAddList)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedListToTestAddLastList(expectedKey);
            ArrayList addList = GetTestListToTestAddList(keyForAddList);
            //act
            actual.AddLast(addList);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 2, 54)]
        [TestCase(2, 2, 4, 89)]

        public void AddAtTest(int key, int expectedKey, int idx, int val)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedForAddAtTest(expectedKey);

            //act
            actual.AddAt(idx, val);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
        [TestCase(1, 1, 2, 1)]
        [TestCase(2, 2, 4, 2)]
        public void AddAtTestList(int key, int expectedKey, int idx, int keyToAddList)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedForAddAtTestList(expectedKey);
            ArrayList addList = GetListToAdd(keyToAddList);
            //act
            actual.AddAt(idx, addList);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 2, 10)]
        [TestCase(2, 2, 4, 90)]

        public void SetTest(int key, int expectedKey, int idx, int val)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedForSetTest(expectedKey);
            //act
            actual.Set(idx, val);


            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]

        public void RemoveFirstTest(int key, int expectedKey)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveFirst(expectedKey);
            //act
            actual.RemoveFirst();

            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void RemoveLastTest(int key, int expectedKey)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveLast(expectedKey);
            //act
            actual.RemoveLast();

            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 3)]

        public void RemoveFirstMultipleTest(int key, int expectedKey, int n)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveMultiplyFirst(expectedKey);
            //act
            actual.RemoveFirstMultiple(n);

            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 3)]
        public void RemoveLastMultipleTest(int key, int expectedKey, int n)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveMultiplyLast(expectedKey);
            //act
            actual.RemoveLastMultiple(n);

            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 1, 2)]
        [TestCase(2, 2, 2, 3)]

        public void RemoveAtMultipleTest(int key, int expectedKey, int idx, int n)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveMultiplyAt(expectedKey);
            //act
            actual.RemoveAtMultiple(idx, n);

            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 8)]
        [TestCase(2, 2, 19)]

        public void RemoveFirstTest(int key, int expectedKey, int val)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedRemoveFirstVal(expectedKey);
            //act
            actual.RemoveFirst(val);
            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 1, 8)]
        [TestCase(2, 2, 6)]

        public void RemoveAllTest(int key, int expectedKey, int val)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArraySecond(key));
            ArrayList expected = GetExpectedRemoveAll(expectedKey);
            //act
            actual.RemoveAll(val);
            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }


        [TestCase(1, true, 8)]
        [TestCase(2, false, 0)]

        public void ContainsTest(int key, bool expected, int val)
        {
            //arrange
            ArrayList actualArraayList = new ArrayList(GetTestArray(key));

            //act
            bool actual = actualArraayList.Contains(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1, 2)]
        [TestCase(2, 3, 19)]
        public void IndexOfTest(int key, int expected, int val)
        {
            //arrange
            ArrayList actualArraayList = new ArrayList(GetTestArray(key));

            //act
            int actual = actualArraayList.IndexOf(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, -3)]
        public void GetFirstTest(int key, int expected)
        {
            //arrange
            ArrayList actualArraayList = new ArrayList(GetTestArray(key));

            //act
            int actual = actualArraayList.GetFirst();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 99)]
        public void GetLstTest(int key, int expected)
        {
            //arrange
            ArrayList actualArraayList = new ArrayList(GetTestArray(key));

            //act
            int actual = actualArraayList.GetLast();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(2, 32, 2)]
        public void GetTest(int key, int expected, int val)
        {
            //arrange
            ArrayList actualArraayList = new ArrayList(GetTestArray(key));

            //act
            int actual = actualArraayList.Get(val);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]


        public void ReverseTest(int key, int expectedKey)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedReverse(expectedKey);

            //act
            actual.Reverse();
            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestCase(1, 8)]
        [TestCase(2, 99)]

        public void MaxTest(int key, int expected)
        {
            //arrange
            ArrayList actualArrayList = new ArrayList(GetTestArray(key));


            //act
            int actual = actualArrayList.Max();
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1)]
        [TestCase(2, -3)]

        public void MinTest(int key, int expected)
        {
            //arrange
            ArrayList actualArrayList = new ArrayList(GetTestArray(key));


            //act
            int actual = actualArrayList.Min();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 5)]

        public void IndexOfMaxTest(int key, int expected)
        {
            //arrange
            ArrayList actualArrayList = new ArrayList(GetTestArray(key));


            //act
            int actual = actualArrayList.IndexOfMax();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(2, 0)]

        public void IndexOfMinTest(int key, int expected)
        {
            //arrange
            ArrayList actualArrayList = new ArrayList(GetTestArray(key));


            //act
            int actual = actualArrayList.IndexOfMin();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]


        public void SortTest(int key, int expectedKey)
        {
            //arrange
            ArrayList actual= new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedSort(expectedKey);

            //act
            actual.Sort();
            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }


        public void SortDeskTest(int key, int expectedKey)
        {
            //arrange
            ArrayList actual = new ArrayList(GetTestArray(key));
            ArrayList expected = GetExpectedSortDesc(expectedKey);

            //act
            actual.SortDesc();
            //assert
            Assert.AreEqual(expected.ToArray(), actual.ToArray());
        }
    }
}