using HomeTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjecTests
{
    class CycleTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(4,3,36)]
        [TestCase(5,4,320)]
        public void SquareNumber(int numA, int numB, int expected)
        {
            int actual = Cycle.SquareNumber(numA, numB);
            Assert.AreEqual(expected, actual);
        }


        // [TestCase(200, new int[] {  })]
        //[TestCase(500, new int[] {  })]
        //[TestCase(700 new int[] { 0, 2 })]
        //public void DisplayNumbersThatDivisibleBynumA(int numA, int[] expected)
        //{
        //    int[] actual = Cycle.DisplayNumbersThatDivisibleBynumA(numA);
        //    Assert.AreEqual(expected, actual);
        //}

        

        [TestCase(12,6,  6)]
        [TestCase(25, 15, 5)]
        [TestCase(36, 74, 2)]

        public void FindDivisorEuclidAlgorithm(double numA, double numB, double expected)
        {
            double actual = Cycle.FindDivisorEuclidAlgorithm(numA, numB);
            Assert.AreEqual(expected, actual);
        }




        [TestCase(343, 7)]
        [TestCase(125, 5)]
        [TestCase(27, 3)]

        public void FindPositiveInteger(int y, int expected)
        {
            int actual = Cycle.FindPositiveInteger(y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("125", "15")]
        [TestCase("7895", "795")]
        [TestCase("123", "13")]
        public void FindNumberOddDigitsOfThisNumber(string numA, string expected)
        {
            string actual = Cycle.FindNumberOddDigitsOfThisNumber(numA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("123", "321")]
        [TestCase("258", "852")]
        [TestCase("45", "54")]
        public void PrintNumberPalindrome(string numA, string expected)
        {
            string actual = Cycle.PrintNumberPalindrome(numA);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(33, 28)]
        [TestCase(123, 122)]
        [TestCase(45, 44)]
        public void PrintNumbersSumOfEvenDigitsIsGreaterThanSumOfTheOddOnes(int numA, int expected)
        {
            int actual = Cycle.PrintNumbersSumOfEvenDigitsIsGreaterThanSumOfTheOddOnes(numA);
            Assert.AreEqual(expected, actual);
        }

    }
}
