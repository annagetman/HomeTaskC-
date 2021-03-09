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
                res =3;
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

        public static (int numA, int numB, int numC) OutputAscending(int numA, int numB, int numC)
        {
            if (numA < numB && numB < numC)
            {
                return (numA, numB, numC); //ABC
            }
            else if (numA < numC && numC < numB)
            {
                return (numA, numC, numB); //ACB
            }
            else if (numB < numA && numA < numC)
            {
                return (numB, numA, numC); //BAC
            }
            else if (numB < numC && numC < numA)
            {
                return (numB, numC, numA); //BCA
            }
            else if (numC < numA && numA < numB)
            {
                return (numC, numA, numB); //CAB
            }
            else //if (numC < numB && numB < numA)
            {
                return (numC, numB, numA); //CBA
            }
        }

        //public static (string res, double D, double x1, double x2) SolveQuadraticEquation(int numA, int numB, int numC)
        //{
        //    double D = Math.Sqrt((numB * numB) - (4 * numA * numC)); // D = b2 − 4ac.
        //    string res = String.Empty;
        //    if (D == 0) // один корень
        //    {
        //        //Console.WriteLine("D=0 -один корень:");
        //        double x = -numB / (2 * numA);
        //      res = $"x = {0}-один корень";
        //        return res;
        //    }
        //    else if (D > 0) //будет 2 корня
        //    {
        //        double x1, x2;
        //        x1 = (-numB + D) / (2 * numA);
        //        x2 = (-numB - D) / (2 * numA);
        //        //res = $"D={0}, x1={x1}, x2={x2}";
        //        return x1, x2;
        //    }
        //    else
        //    {
        //        res = "D<0 - корней нет";
        //       return res; //корней нет
        //    }
        //}

        
        public static string PrintUppercaseEntry(int numtwise)
        {
            numtwise = Convert.ToInt32(Console.ReadLine());
            string res = String.Empty;

            int remainder = numtwise % 10;
            int ten = numtwise / 10;

            string doubleNum = string.Empty;

            if (numtwise > 10 && numtwise > 20)
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

            res=doubleNum;

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
