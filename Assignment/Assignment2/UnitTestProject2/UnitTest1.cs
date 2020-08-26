using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_methodMethod1()
        {
            Program ob = new Program();
            string name=ob.method("Wellcome friends!");
            string actual = "have nice day";
            Assert.AreEqual(actual, name);
        }
    }
}
