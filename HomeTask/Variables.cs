using System;

namespace HomeTask
{
    public static class Variables
    {

        public static int SolveEquation(int numA, int numB)
        {
            int res = (5 * numA + numB * numB) / (numB - numA);
            return res;
        }
     
            public static void  SwapVariables(ref int numA, ref int numB)
        {
            int numC;
            numC = numA;
            numA = numB;
            numB = numC;
        }

        public static void GetDivisionAndRemainder(ref int numA, ref int numB)
        {
            int Division = numB % numA;
            int RemainderDivision = numB/numA;
        }

        public static double SolveLinearEquation(double numA, double numB, double numC)
        {
            double numX = (numC - numB) / numA;
            return numX;
        }
       
        public static void EquationStraightLine(ref int x1, ref int y1, ref int x2, ref int y2)
        {
            double k, b, y;
            k = (y1 - y2) / (x1 - x2);
            b = y2 - k* x2;
        }
    }
}
