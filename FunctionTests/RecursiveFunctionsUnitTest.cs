using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionTests
{
    [TestClass]
    public class RecursiveFunctionsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(362880, Functions.Recursive.factorial(9));
            Assert.AreEqual(362880, Functions.Recursive.factorial_tr(9));
            Assert.AreEqual(362880, Functions.Recursive.factorial_it(9));

            Assert.AreEqual(7.257415615307994e+306, Functions.Recursive.factorial(170));
            Assert.AreEqual(7.257415615308004e+306, Functions.Recursive.factorial_tr(170));
            Assert.AreEqual(7.257415615308004e+306, Functions.Recursive.factorial_it(170));
        }
    }
}