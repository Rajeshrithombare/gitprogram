using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
namespace Square_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            squ ob = new squ();
            int res = ob.Method(2);
            int actual = 4;
            int expeced = res;
            Assert.AreEqual(actual, expeced);


        }
    }
}
