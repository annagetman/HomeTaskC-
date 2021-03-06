using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    public static class Branching
    {
        public static int CompareCount(int numA, int numB)
        {

            int res = 0;
            if (numA == numB)
            {

                res = numA * numB;
            }
            else
               if (numA > numB)
            {
                res = numA + numB;
            }
            else
            {
                res = numA - numB;
            }
            return res;
        }

        public static int DefineQuarter(int numX, int numY)
        {
            int res = 0; ;
            if (numY < 0 && numX < 0)
            {
                res = 3;
            }
            if (numX > 0 && numY > 0)
            {
                res = 1;
            }
            if (numY > 0 && numX < 0)
            {
                res = 2;
            }
            if (numX > 0 && numY < 0)
            {
                res = 4;
            }
            return res;
        }

        public static int[] OutputAscending(int numA, int numB, int numC)
        {
            if (numA < numB && numB < numC)
            {
                return new int[] {
                    numA, numB, numC //ABC
                };
            }
            else if (numA < numC && numC < numB)
                {
                    return new int[] {
                numA, numC, numB
                }; //ACB
                }
                else if (numB < numA && numA < numC)
                {
                    return new int[] {
                    numB, numA, numC}; //BAC
                }
                else if (numB < numC && numC < numA)
                {
                    return new int[] {
                        numB, numC, numA }; //BCA
                }
                else if (numC < numA && numA < numB)
                {
                    return new int[] { numC, numA, numB }; //CAB
                }
                else //if (numC < numB && numB < numA)
                {
                    return new int[] { numC, numB, numA }; //CBA
                }
            }


        public static double[] SolveQuadraticEquation(double numA, double numB, double numD)
            {
                if (numA == 0)
                {
                    throw new ArgumentException("A should not be equal to zero");
                }
                double[] array = null;
                if (numD > 0)
                {
                    double x1 = ((-numD + Math.Sqrt(numD)) / 2 * numA);
                    double x2 = ((-numD - Math.Sqrt(numD)) / 2 * numA);
                    array = new double[2] { x1, x2 };
                }
                else if (numD == 0)
                {
                    double x = ((-numD + Math.Sqrt(numD)) / 2 * numA);
                    array = new double[1] { x };
                }
                else
                {
                    array = new double[0] { };
                }
                return array;
            }

        public static string PrintUppercaseEntry(int num)
            {
                int numtwise = 0;
                string res = String.Empty;

                int remainder = numtwise % 10;
                int ten = numtwise / 10;

                string doubleNum = string.Empty;

                if (numtwise > 20)
                {
                    if (numtwise == 11)
                    {
                        doubleNum = "одинадцать ";
                    }
                    if (numtwise == 12)
                    {
                        doubleNum = "двенадцать ";
                    }
                    if (numtwise == 13)
                    {
                        doubleNum = "тринадцать ";
                    }
                    if (numtwise == 14)
                    {
                        doubleNum = "четирнадцать ";
                    }
                    if (numtwise == 15)
                    {
                        doubleNum = "пятнадцать ";
                    }
                    if (numtwise == 16)
                    {
                        doubleNum = "шестнадцать ";
                    }
                    if (numtwise == 17)
                    {
                        doubleNum = "семьнадцать ";
                    }
                    if (numtwise == 18)
                    {
                        doubleNum = "восемьнадцать ";
                    }
                    if (numtwise == 19)
                    {
                        doubleNum = "девятнадцать ";
                    }
                }
                else

                    res = doubleNum;

                string tenStr = string.Empty;

                if (ten == 10)
                {
                    tenStr = "десять ";
                }
                if (ten == 2)
                {
                    tenStr = "Двадцать ";
                }
                if (ten == 3)
                {
                    tenStr = "тридцать ";
                }
                if (ten == 4)
                {
                    tenStr = "сорок ";
                }
                if (ten == 5)
                {
                    tenStr = "пятдесят ";
                }
                if (ten == 6)
                {
                    tenStr = "шестдесят ";
                }
                if (ten == 7)
                {
                    tenStr = "семьдесят ";
                }
                if (ten == 8)
                {
                    tenStr = "восемьдесят ";
                }
                if (ten == 9)
                {
                    tenStr = "девяносто ";
                }
                string oddStr = string.Empty;
                if (remainder == 1)
                {
                    oddStr = "один ";
                }
                if (remainder == 2)
                {
                    oddStr = "два ";
                }
                if (remainder == 3)
                {
                    oddStr = "три ";
                }
                if (remainder == 4)
                {
                    oddStr = "четыре ";
                }
                if (remainder == 5)
                {
                    oddStr = "пять ";
                }
                if (remainder == 6)
                {
                    oddStr = "шесть ";
                }
                if (remainder == 7)
                {
                    oddStr = "семь ";
                }
                if (remainder == 8)
                {
                    oddStr = "восемь ";
                }
                if (remainder == 9)
                {
                    oddStr = "девять ";
                }
                res = $"{tenStr} {oddStr}";
                return res;
            }


        }
    }

    
