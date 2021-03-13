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
            int res = (5 * (numA + numB) *(numA+numB)) / (numB - numA);
            return res;
        }


        public static void SwapVariables(ref int numA, ref int numB)
        {
            int numC;
            numC = numA;
            numA = numB;
            numB = numC;
        }


        public static int[] GetDivisionAndRemainder(int numA, int numB)
        {
            int division = numB / numA;
            int remainderDivision = numB % numA;
            return new int[] { 
                division, remainderDivision 
            };
        }


        public static double SolveLinearEquation(double numA, double numB, double numC)
        {
            double numX = (numC - numB) / numA;
            return numX;
        }


        public static double[] EquationStraightLine2(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x1-x2=0");
            }
            double k = (y1 - y2) / (x1 - x2);
            double b = y2 - k * x2;
            return new double[] {
                k, b
            };
        }




    }
}
