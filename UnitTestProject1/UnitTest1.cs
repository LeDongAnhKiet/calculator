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
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
     @".\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = (TestContext.DataRow[2].ToString()).Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
