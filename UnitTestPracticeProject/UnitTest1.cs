using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeUnitTesting;


namespace UnitTestPracticeProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            var ob = new SimpleCalc();
            int result = ob.addFun(2, 3);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethodMul()
        {
            var ob = new SimpleCalc();
            int result = ob.mulFun(5, 8);
            Assert.AreEqual(40, result);
        }
        [TestMethod]
        public void TestMethodSub()
        {
            var ob = new SimpleCalc();
            int result = ob.subFun(8, 5);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethodDiv()
        {
            var ob = new SimpleCalc();
            int result = ob.divFun(5, 2);
            Assert.AreEqual(2, result);
        }
    }
}
