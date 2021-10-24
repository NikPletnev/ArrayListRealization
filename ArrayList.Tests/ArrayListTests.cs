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

        public ArrayList GetTestListToTestAddFirst(int key)
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
            int[] arrayA = new int[] {  1, 2, 8, 4, 2, 3, 4, };
            int[] arrayB = new int[] {  -3, 6, 32, 19, 22, 99, -2, 32, 43, };

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





    }
}