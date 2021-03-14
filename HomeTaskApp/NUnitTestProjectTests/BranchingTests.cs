using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeTask;

namespace NUnitTestProjecTests
{
    public class BranchingTests
    {
        [TestCase(4, 2, 6)]
        [TestCase(8,3,11)]
        [TestCase(5,5,25)]
        [TestCase(2,4,-2)]
        public void CompareCount(int numA, int numB, int expected)
        {
            int actual = Branching.CompareCount(numA, numB);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 6, 1)]
        [TestCase(3,-4,4)]
        [TestCase(-2,-3,3)]
        public void DefineQuarter(int numX, int numY, int expected)
        {
            int actual = Branching.DefineQuarter(numX, numY);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 4, 1, new int[] { 1, 2, 4 })]
        [TestCase(5, 4, 6, new int[] { 4, 5, 6 })]
        [TestCase(3, 7, 5, new int[] { 3, 5, 7 })]
        public void OutputAscending(int numA, int numB, int numC, int[] expected)
        {
            int[] actual = Branching.OutputAscending(numA, numB, numC);
            Assert.AreEqual(expected, actual);
        }

       
        // [TestCase(2, 4, 0, new double[] { -2, 0 })]
        [TestCase(1, 0, 0, new double[] { 0 })]
         //[TestCase(5, 0, 3, new double[] { })]
        public void SolveQuadraticEquation(double numA, double numB, double numD, double[] expected)
        {
            double[] actual = Branching.SolveQuadraticEquation(numA, numB, numD);
            Assert.AreEqual(expected, actual);
        }

    }
}
