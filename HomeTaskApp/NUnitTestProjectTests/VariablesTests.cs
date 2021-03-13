using HomeTask;
using NUnit.Framework;

namespace NUnitTestProjecTests
{
    public class VariablesTests
    {

        [TestCase(3, 4, 245)]
        //[TestCase(5,3,9)]
        //[TestCase(5,3,9)]
        public void SolveEquation(int numA, int numB, int expected)
        {
            int actual = Variables.SolveEquation(numA, numB);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 4, 4, 3)]
        [TestCase(5, 3, 3, 5)]
        [TestCase(6, 1, 1, 6)]
        public void SwapVariables(int numA, int numB, int expectedA, int expectedB)
        {
            Variables.SwapVariables(ref numA, ref numB);
            int actualA = numA;
            int actualB = numB;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }




        [TestCase(4, 2, new int[] { 0, 2 })]
        [TestCase(16, 4, new int[] { 0, 4 })]
        [TestCase(9, 3, new int[] { 0, 3 })]
        [TestCase(20, 2, new int[] { 0, 2 })]
        [TestCase(24, 6, new int[] { 0, 6 })]
      

        public void GetDivisionAndRemainder(int numA, int numB, int[] expected)
        {

            int[] actual = Variables.GetDivisionAndRemainder(numA, numB);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 4, 8, 2)]
        [TestCase(4, 2, 10, 2)]
        [TestCase(3, 3, 33, 10)]
        public void SolveLinearEquation(double numA, double numB, double numC, int expected)
        {
            double actual = Variables.SolveLinearEquation(numA, numB, numC);
            Assert.AreEqual(expected, actual);
        }


      //  [TestCase(4, 16, 2, 8, new int[] { 4, 0 })]
        //[TestCase(8, 4, new int[] { 0, 2 })]


        public void EquationStraightLine(int x1, int y1, int x2, int y2, double[] expected)
        {


            double[] actual = Variables.EquationStraightLine(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);

        }

    }
}