using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_5634_should_return_57()
        {
            ThirteenShouldBe(57, 5634);
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
        private readonly int[] divisionsNum = { 1, 10, 9, 12, 3, 4 };

        public long Thirt(long n)
        {
            var r = DivisionsThirtNumber(n);

            var r1 = DivisionsThirtNumber(r);

            return r1;
        }

        private long DivisionsThirtNumber(long number)
        {
            return (long)number.ToString().Reverse().Select((a, i) => char.GetNumericValue(a) * divisionsNum[i]).Sum();
        }
    }
}
