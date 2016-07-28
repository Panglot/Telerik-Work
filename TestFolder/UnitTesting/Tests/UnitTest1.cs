using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student ivan = new Student("Ivan");
            Assert.AreEqual("Ivan", ivan.Name);
        }

        [TestMethod]
        [Timeout(29)]
        public void Test2()
        {
            Person kiro = new Person("Kiro");
            kiro.Age = 23;
            for (int i = 0; i < 10000000; i++)
            {

            }
            Assert.AreEqual(23, kiro.Age);
        }
    }
}
