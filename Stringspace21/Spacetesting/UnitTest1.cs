using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stringspace21;
namespace Spacetesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_mymethodMethod1()
        {
            Program ob = new Program();
            int n = ob.mymethod("my name is rashi");
            int actual = 3;
           int expected = n;
            Assert.AreEqual(actual,expected);
        }
    }
}
