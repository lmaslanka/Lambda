// ReSharper disable InconsistentNaming

namespace Lambda.Lists.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class ListTests
    {
        private const int TestItemOne = 1001;
        private const int TestItemTwo = 1002;
        private const int TestItemThree = 1003;

        private IList<int> testList;
        private IList<Object> testNullableTypeList;
        
        [TestInitialize()]
        public void Initialize()
        {
            this.testList = new List<int>();
            this.testNullableTypeList = new List<Object>();
        }
        
        [TestMethod]
        public void New_CreateNewListOfSizeZero_ListIsCreated()
        {
            const int ExpectedListSize = 0;

            Assert.AreEqual(ExpectedListSize, this.testList.Length);
        }

        [TestMethod]
        public void Add_AddTwoItems_ListSizeIsTwo()
        {
            const int ExpectedListSize = 2;

            this.testList.Add(1001);
            this.testList.Add(1002);

            Assert.AreEqual(ExpectedListSize, this.testList.Length);
        }

        [TestMethod]
        public void Indexer_AddTwoItems_AccessTwoItemsFromList()
        {
            this.testList.Add(TestItemOne);
            this.testList.Add(TestItemTwo);

            Assert.AreEqual(TestItemOne, this.testList[0]);
            Assert.AreEqual(TestItemTwo, this.testList[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Cannot access index less than zero.")]
        public void Indexer_AccessItemBelowLowerBound_InvalidArgumentException()
        {
            const int indexBelowLowerBound = -1;
            this.testList.Add(TestItemOne);

            Assert.AreEqual(TestItemOne, this.testList[indexBelowLowerBound]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Cannot access index greater than number of items in the list.")]
        public void Indexer_AccessItemAboveUpperBound_InvalidArgumentException()
        {
            const int indexAboveUpperBound = 10;
            this.testList.Add(TestItemOne);

            Assert.AreEqual(TestItemOne, this.testList[indexAboveUpperBound]);
        }

        [TestMethod]
        public void RemoveAt_AddTwoItems_RemoveFirstItemFromList()
        {
            this.testList.Add(TestItemOne);
            this.testList.Add(TestItemTwo);

            int item = this.testList.RemoveAt(0);

            Assert.AreEqual(TestItemOne, item);
            Assert.AreEqual(1, this.testList.Length);
        }

        [TestMethod]
        public void RemoveAt_AddThreeItems_RemoveSecondItemFromList()
        {
            this.testList.Add(TestItemOne);
            this.testList.Add(TestItemTwo);
            this.testList.Add(TestItemThree);

            int item = this.testList.RemoveAt(1);

            Assert.AreEqual(TestItemTwo, item);
            Assert.AreEqual(2, this.testList.Length);
        }

        [TestMethod]
        public void RemoveAt_AddThreeItems_RemoveLastItemFromList()
        {
            this.testList.Add(TestItemOne);
            this.testList.Add(TestItemTwo);
            this.testList.Add(TestItemThree);

            int item = this.testList.RemoveAt(2);

            Assert.AreEqual(TestItemThree, item);
            Assert.AreEqual(2, this.testList.Length);
        }

        [TestMethod]
        public void Remove_RemoveNullItem_NullItemRemoved()
        {
            const int expectedNumberOfItemsAfterRemove = 1;
            object nullItemToRemove = null;
            
            this.testNullableTypeList.Add(null);
            this.testNullableTypeList.Add(null);

            object item = this.testNullableTypeList.Remove(nullItemToRemove);

            Assert.AreEqual(expectedNumberOfItemsAfterRemove, testNullableTypeList.Count);
        }

        [TestMethod]
        public void Remove_AddTwoItems_RemoveSpecificItemFromList()
        {
            this.testList.Add(TestItemOne);
            this.testList.Add(TestItemTwo);

            int item = this.testList.Remove(TestItemOne);

            Assert.AreEqual(TestItemOne, item);
            Assert.AreEqual(1, this.testList.Length);
        }
    }
}
