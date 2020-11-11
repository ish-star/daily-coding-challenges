using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Tests
{
    [TestClass]
    public class MultiplyArrayUnitTests
    {
        IMultiplyArray _testClass;

        [TestInitialize]
        public void Initialize()
        {
            _testClass = new MultiplyArray();
        }

        [TestMethod]
        public void MultiplyNumbersInArrayAndReturnArray_LengthOfThreeArray()
        {
            var array = new[] { 3, 2, 1};

            var result = _testClass.MultiplyNumbersInArrayAndReturnArray(array);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(6, result[2]);
        }

        [TestMethod]
        public void MultiplyNumbersInArrayAndReturnArray_LengthOfFiveArray()
        {
            var array = new[] { 1, 2, 3, 4, 5 };

            var result = _testClass.MultiplyNumbersInArrayAndReturnArray(array);

            Assert.AreEqual(120, result[0]);
            Assert.AreEqual(60, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(24, result[4]);
        }
    }
}
