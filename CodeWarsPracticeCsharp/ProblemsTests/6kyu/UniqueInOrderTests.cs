using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Problems;

namespace ProblemsTest
{
    [TestFixture]
    public class UniqueInOrderTests
    {
        [TestCase]
        public void EmptyTest()
        {
            Assert.AreEqual("", _002_UniqueInOrder.UniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", _002_UniqueInOrder.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}
