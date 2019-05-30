using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonLetterCounterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoCommonLetterTest()
        {
           int result= CommonLetterCounter.CommonLetterCalculator.CommonLetterCount("gökhan","flower");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void FullCommonLetterTest()
        {
            int result = CommonLetterCounter.CommonLetterCalculator.CommonLetterCount("flower", "flower");
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void SomeLettersCommonTest()
        {
            int result = CommonLetterCounter.CommonLetterCalculator.CommonLetterCount("gökhan", "metehannn");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void NegativeTest()
        {
            int result = CommonLetterCounter.CommonLetterCalculator.CommonLetterCount("mgökhan", "metehannn");
            Assert.AreNotEqual(3, result);
        }
    }
}
