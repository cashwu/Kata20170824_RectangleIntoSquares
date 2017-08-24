using System;
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

        [TestMethod]
        public void input_3_5_should_return_3_2_1_1()
        {
            SqInRectShouldBe(new List<int> { 3, 2, 1, 1 }, 3, 5);
        }

        [TestMethod]
        public void input_20_14_should_return_3_2_1_1()
        {
            SqInRectShouldBe(new List<int> { 14, 6, 6, 2, 2, 2 }, 20, 14);
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

            var result = new List<int>();

            var baseLeng = int.MaxValue;

            while (baseLeng != 0)
            {
                baseLeng = Math.Min(lng, wdth);

                lng = lng - baseLeng == 0 ? baseLeng : lng - baseLeng;
                wdth = wdth - baseLeng == 0 ? baseLeng : wdth - baseLeng;

                result.Add(baseLeng);

                if (lng == wdth)
                {
                    result.Add(wdth);
                    break;
                }
            }

            return result;
        }
    }
}
