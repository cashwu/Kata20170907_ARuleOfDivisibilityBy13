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

        [TestMethod]
        public void input_1234567_should_return_87()
        {
            ThirteenShouldBe(87, 1234567);
        }

        [TestMethod]
        public void input_85299258_should_return_31()
        {
            ThirteenShouldBe(31, 85299258);
        }

        [TestMethod]
        public void input_1111111111_should_return_71()
        {
            ThirteenShouldBe(71, 1111111111);
        }

        [TestMethod]
        public void input_987654321_should_return_30()
        {
            ThirteenShouldBe(30, 987654321);
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
            long prevNum;
            var currentNum = n;
            do
            {
                prevNum = currentNum;
                currentNum = DivisionsThirtNumber(prevNum);

            } while (prevNum != currentNum);

            return currentNum;
        }

        private long DivisionsThirtNumber(long number)
        {
            return (long)number.ToString().Reverse().Select((a, i) => char.GetNumericValue(a) * divisionsNum[i % 6]).Sum();
        }
    }
}
