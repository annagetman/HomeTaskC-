using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Найти минимальный элемент массива
            //2.Найти максимальный элемент массива
            //3.Найти индекс минимального элемента массива
            //4.Найти индекс максимального элемента массива
            /*
            int[] arr1 = new int[5] { 8, 2, 3, 4, 9 };
            int max = 0;
            int min = 100;
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                    maxIndex = i;
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"max-{max} maxIndex -{maxIndex} -min {min} minIndex-{minIndex} ");

            Console.ReadKey();



            //5. Посчитать сумму элементов массива с нечетными индексами

            int[] arr5 = new int[6] { 8, 2, 3, 6, 3, 5 };
            int sumOddIndexArr5 = 0;

            for (int i = 0; i < arr5.Length; ++i)
            {
                if (i % 2 != 0)
                {

                    //Console.WriteLine(i);
                    sumOddIndexArr5 += i;
                }

            }
            Console.WriteLine($"sumOddIndexArr5-{sumOddIndexArr5}");
            Console.ReadKey();


            //6. Сделать реверс массива (массив в обратном направлении)


            int[] arr6 = new int[4] { 1, 2, 3, 4 };

            for (int i = arr6.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr6[i]);
            }

            Console.ReadKey();

            //    7.Посчитать количество нечетных элементов массива

            int[] arr7 = new int[6] { 1, 2, 3, 4, 7, 3 };

            for (int i = 0; i < arr7.Length; i++)
            {
                if (arr7[i] % 2 != 0)
                {
                    Console.WriteLine(arr7[i]);
                }
            }

            Console.ReadKey();


            */



            //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            //9. Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert)) 


            int[] arr9 = new int[15];
            Random random10 = new Random();

            for (int i = 0; i < arr9.Length; i++)
            {
                arr9[i] = random10.Next(10, 50);
                //Console.WriteLine(arr10[i]);
            }


            var len = arr9.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }



        //10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))

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
                while(j>0 && arr10[j]>arr10[j-1])
                {
                    tmp = arr10[j];
                    arr10[j] = arr10[j - 1];
                    arr10[j - 1] = tmp;

                    j--;
                }
            }

            for(int i =0; i<arr10.Length; i++)
            {
                Console.WriteLine($"{arr10[i]}");
            }







        }
    }
}