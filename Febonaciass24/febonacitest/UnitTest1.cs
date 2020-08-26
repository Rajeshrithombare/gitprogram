using Microsoft.VisualStudio.TestTools.UnitTesting;
using Febonaciass24;
namespace febonacitest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_mymethodMethod1()
        {
            Program obj = new Program();
            int a =obj.mymethod(5);
            int d= 0;
            Assert.AreEqual(a,d);
        }
    }
}
