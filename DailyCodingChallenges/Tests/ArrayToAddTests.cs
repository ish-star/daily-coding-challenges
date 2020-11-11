using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Tests
{
    [TestClass]
    public class ArrayToAddTests
    {
        IArrayToAdd _testClass;

        [TestInitialize]
        public void Initialize()
        {
            _testClass = new ArrayToAdd();
        }

        [TestMethod]
        public void DoesArrayContainTwoNumbersThatEqualk_True()
        {
            var array = new[] { 10, 15, 3, 7 };

            var result = _testClass.DoesArrayContainTwoNumbersThatEqualk(17, array);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesArrayContainTwoNumbersThatEqualk_False()
        {
            var array = new[] { 10, 15, 3, 6 };

            var result = _testClass.DoesArrayContainTwoNumbersThatEqualk(17, array);

            Assert.IsFalse(result);
        }
    }
}
