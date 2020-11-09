using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Tests
{
    [TestClass]
    public class ArrayToAddTests
    {
        [TestMethod]
        public void DoesArrayContainTwoNumbersThatEqualk_True()
        {
            var array = new[] { 10, 15, 3, 7 };

            var result = ArrayToAdd.DoesArrayContainTwoNumbersThatEqualk(17, array);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesArrayContainTwoNumbersThatEqualk_False()
        {
            var array = new[] { 10, 15, 3, 6 };

            var result = ArrayToAdd.DoesArrayContainTwoNumbersThatEqualk(17, array);

            Assert.IsFalse(result);
        }
    }
}
