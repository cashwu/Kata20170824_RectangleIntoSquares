using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170824_RectangleIntoSquares
{
    [TestClass]
    public class RectangleIntoSquaresTests
    {
        [TestMethod]
        public void input_2_2_should_return_null()
        {
            SqInRectShouldBe(null, 2, 2);
        }

        [TestMethod]
        public void input_1_2_should_return_1_1()
        {
            SqInRectShouldBe(new List<int> { 1, 1 }, 1, 2);
        }

        [TestMethod]
        public void input_2_1_should_return_1_1()
        {
            SqInRectShouldBe(new List<int> { 1, 1 }, 2, 1);
        }

        [TestMethod]
        public void input_3_2_should_return_2_1_1()
        {
            SqInRectShouldBe(new List<int> { 2, 1, 1 }, 3, 2);
        }

        private static void SqInRectShouldBe(List<int> expected, int lng, int wdth)
        {
            var s = new SqInRect();
            var actual = s.sqInRect(lng, wdth);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class SqInRect
    {
        public List<int> sqInRect(int lng, int wdth)
        {
            if (lng == wdth)
            {
                return null;
            }

            var baseLeng = Math.Min(lng, wdth);
            var result = new List<int>();

            for (var i = baseLeng; i >= 1; i--)
            {
                result.Add(i);

                if (i == 1)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
