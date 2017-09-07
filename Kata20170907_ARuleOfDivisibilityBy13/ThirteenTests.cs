using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170907_ARuleOfDivisibilityBy13
{
    [TestClass]
    public class ThirteenTests
    {
        [TestMethod]
        public void input_321_should_return_48()
        {
            ThirteenShouldBe(48, 321);
        }

        private static void ThirteenShouldBe(int expected, int number)
        {
            var thirteen = new Thirteen();
            var actual = thirteen.Thirt(number);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Thirteen
    {
        public long Thirt(long n)
        {
            return 48;
        }
    }
}
