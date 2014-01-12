using System;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void TestMethod1()
        {
            var integer1 = "23";
            var integer2 = "23";
            Assert.That(integer1.Equals(integer2));
        }
    }
}
