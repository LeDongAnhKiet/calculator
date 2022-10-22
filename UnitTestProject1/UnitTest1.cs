using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestCong()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestTru()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestNhan()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestChia()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void TestDivBy0()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
