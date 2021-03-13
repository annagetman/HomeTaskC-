using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    public static class DoubleCycle
    {
        //Найти минимальный элемент массива
        //Найти максимальный элемент массива
        //Найти индекс минимального элемента массива
        //Найти индекс максимального элемента массива
        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        //Отразите массив относительно его главной диагонали

        public static int FindMaxNamberOfArrayElement(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }


        public static int FindMinNamberOfArrayElement(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }


        public static int FindMaxIndexOfArrayElement(int[,] array)
        {
            int max = array[0, 0];
            for(int i = 1; i<array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j]) {
                        max = array[i, j];
                            }
                }
            }
            return max;
        }


        public static int FindMinIndexOfArrayElement(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }




        public static int FindNumberOfArrayElementsThatAreLargerAllTheirNeighbors(int[,] array)
        {
            int counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i <= 0 || array[i - 1, j] < array[i, j])
                        && (i >= array.GetLength(0) - 1 || array[i + 1, j] < array[i, j])
                        && (j <= 0 || array[i, j - 1] < array[i, j])
                        && (j >= array.GetLength(1) - 1 || array[i, j + 1] < array[i, j]))
                    {

                        counter++;
                    }
                }
            }
            return counter;
        }
        



    }
}
