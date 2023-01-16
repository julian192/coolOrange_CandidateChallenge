using coolOrange_CandidateChallenge;
using Array = coolOrange_CandidateChallenge.Array;

namespace ChallangeTest
{
    [TestFixture]
    public class ArrayTest
    {
        [Test]
        public void TestFindMaxValue()
        {
            int[] testArray = {1, 2, 5, 3, 7, 9, 10, 0, 2, 7};
            Assert.AreEqual(10, Array.FindMaxValue(testArray, 0, 10));
            Assert.AreEqual(5, Array.FindMaxValue(testArray, 0, 3));
            Assert.AreEqual(7, Array.FindMaxValue(testArray, 8, 10));
        }

        [Test]
        public void TestFindMinPosition()
        {
            int[] testArray = { 1, 2, 5, 3, 7, 9, 10, 0, 2, 7 };
            Assert.AreEqual(7, Array.FindMinPosition(testArray, 0, 10));
            Assert.AreEqual(0, Array.FindMinPosition(testArray, 0, 4));
            Assert.AreEqual(1, Array.FindMinPosition(testArray, 1, 1));
        }

        [Test]
        public void TestSwap()
        {
            int[] testArray = { 1, 2, 5, 3, 7, 9, 10, 0, 2, 7 };
            Array.Swap(testArray, 2, 9);
            Assert.AreEqual(7, testArray[2]);
            Assert.AreEqual(5, testArray[9]);
        }

        [Test]
        public void TestShiftByOne()
        {
            int[] testArray = { 1, 2, 5, 3, 7, 9, 10, 0, 2, 7 };
            Array.ShiftLeftByOne(testArray, 0, 5);
            int[] afterShift = { 2, 5, 3, 7, 1, 9, 10, 0, 2, 7};
            CollectionAssert.AreEqual(afterShift, testArray);
        }

        [Test]
        public void TestCreateRandomArray()
        {
            int[] testArray = Array.CreateRandomArray(10, 0, 20);
            int min = 20;
            int max = 0;
            for(int i = 0; i  < testArray.Length; i++ )
            {
                if (testArray[i] > max)
                    max = testArray[i];
                if (testArray[i] < min)
                    min = testArray[i];
            }
            Assert.AreEqual(10, testArray.Length);
            Assert.GreaterOrEqual(20, max);
            Assert.LessOrEqual(0, min);
        }

        [Test]
        public void TestCreateRandomMatrix()
        {
            int[,] testArray = Array.CreateRandomMatrix(5, 5, 0, 20);
            int min = 20;
            int max = 0;
            for(int i = 0; i < testArray.GetLength(0); i++)
            {
                for(int j = 0; j < testArray.GetLength(1); j++)
                {
                    if (testArray[i, j] > max)
                        max = testArray[i, j];
                    if (testArray[i, j] < min)
                        min = testArray[i, j];
                }
            }
            Assert.AreEqual(5, testArray.GetLength(0));
            Assert.AreEqual(5, testArray.GetLength(1));
            Assert.GreaterOrEqual(20, max);
            Assert.LessOrEqual(0, min);
        }

        [Test]
        public void TestCopyArray()
        {
            int[] testArray = { 1, 2, 5, 3, 7, 9, 10, 0, 2, 7 };
            int[,] result = Array.CopyArray(testArray);
            for(int i = 0; i < result.GetLength(0); i++)
            {
                Assert.AreEqual(result[i, 0], result[i, 1]);
            }
        }

        [Test]
        public void TestFindInSortedArray()
        {
            int[] testArray = {0, 1, 2, 2, 3, 5, 7, 7, 9, 10};
            Assert.AreEqual(0, Array.FindInSortedArrary(testArray, 0));
            Assert.AreEqual(5, Array.FindInSortedArrary(testArray, 5));
            Assert.AreEqual(9, Array.FindInSortedArrary(testArray, 10));
        }
    }
}
