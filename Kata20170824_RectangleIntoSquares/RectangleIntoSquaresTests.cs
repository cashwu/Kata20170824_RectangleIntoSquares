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
            return null;
        }
    }
}
