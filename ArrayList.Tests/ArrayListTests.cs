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
                2 => new int[] { -3, 6, 32, 19, 22, 99},
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
                1 => new int[] {2, 1, 2, 8, 4 },
                2 => new int[] {-19, -3, 6, 32, 19, 22, 99 },
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
                2 => new ArrayList(arrayB) ,
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
            int[] arrayA = new int[] {  1, 2, 8, 4, 2 };
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
            int[] arrayB = new int[] { -3, 6, 32, 19, 89, 22, 99};

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
            int[] arrayB = new int[] { -3, 6, 32, 19, -2, 32, 43, 22, 99};

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
            int[] arrayB = new int[] { -3, 6, 32, 19, 22};

            ArrayList arrayList = key switch
            {
                1 => new ArrayList(arrayA),
                2 => new ArrayList(arrayB),
                _ => new ArrayList(),
            };
            return arrayList;

        }

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
        //public void RemoveLastTest(int key, int expectedKey)
        //{
        //    //arrange
        //    ArrayList actual = new ArrayList(GetTestArray(key));
        //    ArrayList expected = GetExpectedRemoveLast(expectedKey);
        //    //act
        //    actual.RemoveFirst();

        //    //assert
        //    Assert.AreEqual(expected.ToArray(), actual.ToArray());
        //}

    }
}