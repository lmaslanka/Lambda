namespace Lambda.Lists.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void NewListOfSizeZeroIsCreated()
        {
            const int ExpectedListSize = 0;
            List<int> testList = new List<int>();

            Assert.AreEqual(ExpectedListSize, testList.Length);
        }

        [TestMethod]
        public void AddTwoItemsListSizeIsTwo()
        {
            const int ExpectedListSize = 2;
            List<int> testList = new List<int>();

            testList.Add(1001);
            testList.Add(1002);

            Assert.AreEqual(ExpectedListSize, testList.Length);
        }

        [TestMethod]
        public void AddTwoItemsAccessTwoItemsFromList()
        {
            const int TestItemOne = 1001;
            const int TestItemTwo = 1002;
            List<int> testList = new List<int>();

            testList.Add(TestItemOne);
            testList.Add(TestItemTwo);

            Assert.AreEqual(TestItemOne, testList[0]);
            Assert.AreEqual(TestItemTwo, testList[1]);
        }

        [TestMethod]
        public void AddTwoItemsRemoveFirstItemFromList()
        {
            const int TestItemOne = 1001;
            const int TestItemTwo = 1002;

            List<int> testList = new List<int>();

            testList.Add(TestItemOne);
            testList.Add(TestItemTwo);

            int item = testList.RemoveAt(0);

            Assert.AreEqual(TestItemOne, item);
            Assert.AreEqual(1, testList.Length);
        }

        [TestMethod]
        public void AddThreeItemsRemoveSecondItemFromList()
        {
            const int TestItemOne = 1001;
            const int TestItemTwo = 1002;
            const int TestItemThree = 1003;

            List<int> testList = new List<int>();

            testList.Add(TestItemOne);
            testList.Add(TestItemTwo);
            testList.Add(TestItemThree);

            int item = testList.RemoveAt(1);

            Assert.AreEqual(TestItemTwo, item);
            Assert.AreEqual(2, testList.Length);
        }

        [TestMethod]
        public void AddThreeItemsRemoveLastItemFromList()
        {
            const int TestItemOne = 1001;
            const int TestItemTwo = 1002;
            const int TestItemThree = 1003;

            List<int> testList = new List<int>();

            testList.Add(TestItemOne);
            testList.Add(TestItemTwo);
            testList.Add(TestItemThree);

            int item = testList.RemoveAt(2);

            Assert.AreEqual(TestItemThree, item);
            Assert.AreEqual(2, testList.Length);
        }

        [TestMethod]
        public void AddTwoItemsRemoveSpecificItemFromList()
        {
            const int TestItemOne = 1001;
            const int TestItemTwo = 1002;

            List<int> testList = new List<int>();

            testList.Add(TestItemOne);
            testList.Add(TestItemTwo);

            int item = testList.Remove(TestItemOne);

            Assert.AreEqual(TestItemOne, item);
            Assert.AreEqual(1, testList.Length);
        }
    }
}
