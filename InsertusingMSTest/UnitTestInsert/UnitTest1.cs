using InsertusingMSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestInsert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearch()
        {
            LinkedList list = new LinkedList();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }
        [TestMethod]
        public void TestInsert()
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Insert(3, 40);
            Assert.IsTrue(list.Search(40));
        }
    }
    }

