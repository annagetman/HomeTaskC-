using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    public static class Cycle
    {
        public static int SquareNumber(int numA, int numB)
        {
            for (int i = 1; i < numB; i++)
            {
                numA *= numB;
            }
            return numA;
        }

        public static int[] DisplayNumbersThatDivisibleBynumA(int numA)
        {
            int[] array = new int[1000 / numA];
            int j = 0;

            if (numA != 0 && numA <= 1000)
            {
                for (int i = numA; i <= 1000; i += numA)
                {
                    array[j] = i;
                    ++j;
                }
            }
            return array;
        }

        public static int FindPositiveNumbers(int numA)
        {
            int res = 0; 
            for (int i = 1; i <= numA; i++)
            {
                if (numA > 0 && i * i < numA)
                {
                    res++;
                }
            }
            return res;

        }

        public static int PrintGreatestDivisor(int numA)
        {
            int res = 1;

            for (int i = numA/2; i>=1; i-- )
            {
                if (numA % i == 0)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }


        public static int PrintNumbersDivisibleBy7(int numA, int numB)
        {
            int sum = 0;

            if (numA < numB)
            {
                for (int i = 1; i < numB; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;

                    }
                }
                return sum;
            }

            else if (numA > numB)
            {
                for (int i = 1; i < numA; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;

                    }
                }
                return sum;
            }
            else
            {
                throw new Exception("a=b");
            }
        }


        public static int PrintNumbersfibonacci(int numN)
        {
            string res = string.Empty;
            if (numN > 48 || numN <= 0)
            {
                throw new Exception("Error, very large number!");
            }

            int a = 1;
            int b = 1;
            int Nfib;


            for (int i = 1; i < numN; i++)
            {
                Nfib = a;
                a = b;
                b += Nfib;
            }
            return b;

        }


        public static double FindDivisorEuclidAlgorithm(double numA, double numB)
        {
            double res;
            {
                while (numA != numB)
                {
                    if (numA > numB)
                    {
                        double evclid = numA;
                        numA = numB;
                        numB = evclid;
                    }
                    numB = numB - numA;
                }
                res = numA;
            }
            return res;
        }

        public static int FindPositiveInteger(int y)
        {
            int left = 0;
            int right = y;
            int middle = right;

            while (y != middle * middle * middle)
            {
                if ((middle * middle * middle) > y)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
            }
            return middle;
        }

        public static string FindNumberOddDigitsOfThisNumber(string numN)
        {
            string res = string.Empty;
            for (int i = 0; i < numN.Length; i++)
            {
                if (numN[i] % 2 != 0)
                {
                    res += numN[i];

                }
            }
            return res;
        }


        public static string PrintNumberPalindrome(string mirrorNum)
        {
            string res = string.Empty;
            for (int i = mirrorNum.Length - 1; i > -1; --i)
            {
                res += mirrorNum[i];
            }
            return res;
        }


        public static int PrintNumbersSumOfEvenDigitsIsGreaterThanSumOfTheOddOnes(int numN11)
        {
            int res = 0;
            int sumEven;
            int sumOdd;
            int nextN = 0;
            for (int i = 1; i <= numN11; i++)
            {
                sumEven = 0;
                sumOdd = 0;
                nextN = i;
                while (nextN > 0)
                {
                    var currentDigit = (nextN % 10);
                    if (currentDigit % 2 == 0)
                    {
                        sumEven += currentDigit;
                    }
                    else
                    {
                        sumOdd += currentDigit;
                    }
                    nextN /= 10;
                }
                if (sumEven > sumOdd)
                {
                    res = i;
                }
            }
            return res;
        }



    }
}




