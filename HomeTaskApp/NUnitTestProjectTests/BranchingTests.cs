using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeTask;

namespace NUnitTestProjecTests
{
    public class BranchingTests
    {
        [TestCase(3, 4, 245)]
        //[TestCase(5,3,9)]
        //[TestCase(5,3,9)]
        public void CompareCount(int numA, int numB, int expected)
        {
            int actual = Branching.CompareCount(numA, numB);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 4, 245)]
        //[TestCase(5,3,9)]
        //[TestCase(5,3,9)]
        public void DefineQuarter(int numX, int numY, int expected)
        {
            int actual = Branching.DefineQuarter(numX, numY);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(3, 4, 245)]
        ////[TestCase(5,3,9)]
        ////[TestCase(5,3,9)]
        //public void PrintUppercaseEntry(int numtwise, int expected)
        //{
        //    int actual = Branching.PrintUppercaseEntry(numtwise);
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(2, 4, 0, new double[] { -2, 0 })]
        //[TestCase(1, 0, 0, new double[] { 0 })]
        //[TestCase(5, 0, 3, new double[] { })]
        //public void GetQuadraticEquationSolvingWhenABCShouldSolvQuadraticEquation(double a, double b, double c, double[] expected)
        //{
        //    double[] actual = Branching.SolveQuadraticEquation(a, b, c);
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
