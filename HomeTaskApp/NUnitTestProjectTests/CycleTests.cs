using HomeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjecTests
{
    class CycleTests
    {
        [TestCase(3, 4, 245)]
        //[TestCase(5,3,9)]
        //[TestCase(5,3,9)]
        public void SquareNumber(int numA, int numB, int expected)
        {
            int actual = Cycle.SquareNumber(numA, numB);
            Assert.AreEqual(expected, actual);
        }
    }
}
