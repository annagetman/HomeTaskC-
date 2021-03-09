using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
   public static class MyArray
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

        public static int GetReverceArray(ref int[] arr1)
        {
            int reverceArray = arr1[0];

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                reverceArray += arr1[i];
            }
            return reverceArray;
        }


        public static int CountOddElementsByArray(ref int[] arr1)
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


        //public static int SortArray(ref int[] arr1)
        //{
        //}

        /*      

        //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        //9. Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) 


        //            int[] arr9 = new int[15];
        //            Random random10 = new Random();

        //            for (int i = 0; i < arr9.Length; i++)
        //            {
        //                arr9[i] = random10.Next(10, 50);
        //                //Console.WriteLine(arr10[i]);
        //            }


        //            var len = arr9.Length;
        //            for (var i = 1; i < len; i++)
        //            {
        //                for (var j = 0; j < len - i; j++)
        //                {
        //                    if (array[j] > array[j + 1])
        //                    {
        //                        Swap(ref array[j], ref array[j + 1]);
        //                    }
        //                }
        //            }

        //            return array;
        //        }



        //        //10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))

                int[] arr10 = new int[15];
                Random random10 = new Random();

                    for(int i=0; i<arr10.Length; i++)
                    {
                        arr10[i] = random10.Next(10, 50);
                        //Console.WriteLine(arr10[i]);
                    }

            int tmp;
            int j;

                    for(int i=1; i<arr10.Length; i++)
                    {
                        j = i;
                        while(j>0 && arr10[j]>arr10[j - 1])
                        {
                            tmp = arr10[j];
                            arr10[j] = arr10[j - 1];
                            arr10[j - 1] = tmp;

                            j--;
                        }
                    }

                    for (int i = 0; i < arr10.Length; i++)
        {
            Console.WriteLine($"{arr10[i]}");
        }


        */

        //public static int SortArrayDescending(ref int[] arr1)
        //{

        //}





    }
}