using System;

namespace HomeTask
{
    public static class Variables
    {

        public static int SolveEquation(int numA, int numB)
        {
            if ((numB - numA) == 0)
            {
                throw new DivideByZeroException("numB should not be equal to numA");
            }
            int res = (5 * numA + numB * numB) / (numB - numA);
            return res;
        }

        public static void SwapVariables(ref int numA, int numB)
        {
            int numC;
            numC = numA;
            numA = numB;
            numB = numC;
        }

        public static (int Division, int RemainderDivision) GetDivisionAndRemainder(int numA, int numB)
        {
            int Division = numB / numA;
            int RemainderDivision = numB % numA;
            return (Division, RemainderDivision);
        }

        public static double SolveLinearEquation(double numA, double numB, double numC)
        {
            double numX = (numC - numB) / numA;
            return numX;
        }

        public static (double k, double b) EquationStraightLine(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x1-x2=0");
            }
            double k = (y1 - y2) / (x1 - x2);
            double b = y2 - k * x2;
            return (k, b);
        }
    }
}
