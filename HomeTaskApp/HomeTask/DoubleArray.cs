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
    }
}
