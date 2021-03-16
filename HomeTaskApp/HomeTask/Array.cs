using HomeTask;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    public static class Array
    {
        public static int GetMaxNumber(int[] arr1)
        {
            int max = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            return max;
        }

        public static int GetMinNumber(int[] arr1)
        {
            int min = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            return min;
        }

        public static int GetMinIndex(int[] arr1)
        {
            int minIndex = 0;
            int min = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int GetMaxIndex(int[] arr1)
        {
            int maxIndex = 0;
            int max = 100;
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int GetSumOddElementByArray(int[] arr1)
        {
            int sumOddIndexArr = 0;

            for (int i = 0; i < arr1.Length; ++i)
            {
                if (i % 2 != 0)
                {
                    sumOddIndexArr += i;
                }

            }
            return sumOddIndexArr;
        }

        public static int GetReverceArray(int[] arr1)
        {
            int reverceArray = arr1[0];

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                reverceArray += arr1[i];
            }
            return reverceArray;
        }

        public static int CountOddElementsByArray(int[] arr1)
        {
            int reverceArray = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 != 0)
                {
                    reverceArray = arr1[i];
                }
            }
            return reverceArray;
        }

        public static int[] SortArrayDescending(int[] arr1)
        {
            int[] arr9 = new int[15];
            Random random10 = new Random();

            for (int i = 0; i < arr9.Length; i++)
            {
                arr9[i] = random10.Next(10, 50);
            }

            int len = arr9.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        Swap(ref arr9[j], ref arr1[j + 1]);
                    }
                }
            }
            return arr9;
        }

        private static void Swap(ref int v1, ref int v2)
        {
            throw new NotImplementedException();
        }

        //public static int[] SortArrayDescending(int[] arr1)
        //{
        //    int[] arr10 = new int[15];
        //    Random random10 = new Random();

        //    for (int i = 0; i < arr10.Length; i++)
        //    {
        //        arr10[i] = random10.Next(10, 50);
        //    }

        //    int tamp;
        //    int j;

        //    for (int i = 1; i < arr10.Length; i++)
        //    {
        //        j = i;
        //        while (j > 0 && arr10[j] > arr10[j - 1])
        //        {
        //            tamp = arr10[j];
        //            arr10[j] = arr10[j - 1];
        //            arr10[j - 1] = tamp;
        //            j--;
        //        }
        //    }

        //    for (int i = 0; i < arr10.Length; i++)
        //    {
        //        arr10[i++] = arr10[i];
        //    }
        //    return arr10;
        //}  


    }
}