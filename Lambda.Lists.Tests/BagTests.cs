// ReSharper disable InconsistentNaming

namespace Lambda.Lists.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BagTests
    {
        private const int TestItem1 = 10;
        private const int TestItem2 = 20;
        private const int TestItem3 = 30;
        private const int TestItem4 = 40;
        private const int TestItem5 = 50;

        private IBag<int> testBag;

        [TestInitialize()]
        public void Initialize()
        {
            this.testBag = new Bag<int>();
        }

        [TestMethod]
        public void New_CreateNewBag_NewEmptyBagCreated()
        {
            const int expectedInitialSize = 0;

            Assert.AreEqual(expectedInitialSize, this.testBag.Size);
        }

        [TestMethod]
        public void IsEmpty_CreateNewBag_NewEmptyBagCreated()
        {
            Assert.IsTrue(this.testBag.IsEmpty);
        }

        [TestMethod]
        public void Add_AddFiveItems_FiveItemsAdded()
        {
            const int expectedBagSize = 5;

            this.testBag.Add(TestItem1);
            this.testBag.Add(TestItem2);
            this.testBag.Add(TestItem3);
            this.testBag.Add(TestItem4);
            this.testBag.Add(TestItem5);

            Assert.AreEqual(expectedBagSize, this.testBag.Size);
        }

        [TestMethod]
        public void Iterator_AddFiveItems_LoopThroughAllItems()
        {
            var testItems = new System.Collections.Generic.List<int> { TestItem1, TestItem2, TestItem3, TestItem4, TestItem5 };
            var testItemFalags = new bool[testItems.Count];

            this.testBag.Add(TestItem1);
            this.testBag.Add(TestItem2);
            this.testBag.Add(TestItem3);
            this.testBag.Add(TestItem4);
            this.testBag.Add(TestItem5);

            foreach (var item in this.testBag)
            {
                testItemFalags[testItems.IndexOf(item)] = true;
            }

            Assert.IsFalse(testItemFalags.Contains(false));
        }
    }
}
