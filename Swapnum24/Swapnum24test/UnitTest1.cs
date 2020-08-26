using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swapnum24;
namespace Swapnum24test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program ob = new Program();
            int n1 =  4;
            int b1 = ob.mymethod(7);
            int actual = b1;
            int n2 = 7;
            int b2 = ob.mymethod2(4);
            int expected = b2;
            Assert.AreEqual(actual, expected);

        }
    }
}
