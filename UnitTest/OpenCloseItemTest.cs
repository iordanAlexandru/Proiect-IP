using NUnit.Framework;
using System;
using Proiect_Ip;

namespace UnitTest
{
    public class OpenCloseItemTest
    {

        private OpenCloseItem openCloseItem1;
        private OpenCloseItem openCloseItem2;
        private string ITEM_1_NAME = "item1";
        private const string ITEM_2_NAME = "item2";


        [SetUp]
        public void Setup()
        {
            openCloseItem1 = new OpenCloseItem(ITEM_1_NAME);
            openCloseItem2 = new OpenCloseItem(ITEM_2_NAME);
        }

        [Test]
        public void TestOpenCloseItemOpenMethod()
        {
            Assert.AreEqual("S-a deschis " + ITEM_1_NAME, openCloseItem1.open());
        }

        [Test]
        public void TestOpenCloseItemCloseMethod()
        {
            Assert.AreEqual("S-a inchis " + ITEM_1_NAME, openCloseItem1.close());
        }

        [Test]
        public void TestOpenCloseItemOpenMethodDoesntHaveSameOutput()
        {
            Assert.AreNotEqual(openCloseItem1.open(), openCloseItem2.open());
        }

        [Test]
        public void TestOpenCloseItemCloseMethodDoesntHaveSameOutput()
        {
            Assert.AreNotEqual(openCloseItem1.close(), openCloseItem2.close());
        }
    }
}