using HomeTask;
using NUnit.Framework;
//using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjecTests
{
    public class ArrayTests
    {


         [TestCase(3,335)]

        public static void GetMaxNumber(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);
            int actual = Array.GetMaxNumber(array);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 0)]

        public static void GetMinNumber(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);

            int actual = Array.GetMinNumber(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 0)]

        public static void GetMinIndex(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);

            int actual = Array.GetMinIndex(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 0)]

        public static void GetMaxIndex(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);

            int actual = Array.GetMaxIndex(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 0)]

        public static void GetSumOddElementByArray(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);

            int actual = Array.GetSumOddElementByArray(array);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 0)]

        public static void GetReverceArray(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);

            int actual = Array.GetReverceArray(array);
            Assert.AreEqual(expected, actual);
        }














        public class ArrayMock
        {
            public static int[] GetMock(int num)
            {
                int[] result = new int[0];
                switch (num)
                {
                    case 0:
                        result = new int[] { };
                        break;

                    case 1:
                        result = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        break;

                    case 2:
                        result = new int[] { 34, 5, 69, 127, 2, 101, 22, 16, 73, 44 };
                        break;

                    case 3:
                        result = new int[] { 0, 32, 13, 56, 1, 335, 6, 41, 8 };
                        break;

                    case 4:
                        result = new int[] { 16, 92, 3, 36, 23 };
                        break;
                }
                return result;
            }

        }





    }

}

