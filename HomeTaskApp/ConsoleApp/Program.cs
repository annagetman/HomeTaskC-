using System;
using HomeTask;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            int var = Variables.SolveEquation(2, 6);
            Console.WriteLine(var);

            int numA = 2;
            int numB = 5;
            //int var2 = Variables.SwapVariables(ref numA, numB);
            //Console.WriteLine(var2);

            //int var3 = Variables.GetDivisionAndRemainder(2, 6);
            //Console.WriteLine(var3);

            //int numX = Variables.SolveLinearEquation(2, 6, 5);
            //Console.WriteLine(numX);

            int var5 = Variables.EquationStraightLine(2, 6, 5, 2);
            Console.WriteLine(var5);

            //int[] arr1= new int[5] { 5,4,8,7,5};
            //int ff=0;
            //int lll=0;
            //int num = Variables.SolveEquation(ref ff, lll);
            //Console.WriteLine(num);
            //int num1 = MyArray.GetMaxNumber(arr1);
            //Console.WriteLine(num1);
            //int num2 = Variables.SolveEquation(2, 6);
            //Console.WriteLine(num2);
            //int num3 = Variables.SolveEquation(2, 6);
            //Console.WriteLine(num3);

        }
    }
}
