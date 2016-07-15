using System;

namespace LambdaExamples
{
    internal class Program
    {
        private static void Main()
        {
            #region Subtract Method
            Console.WriteLine($"Subtract Method: {Subtract(5, 2)}");

            Func<int, int, int> subtract = (a, b) => a - b;
            Console.WriteLine($"subtract Lambda: {subtract(5, 2)}\n");
            #endregion
            #region Multiply Method
            Console.WriteLine($"Multiply Method: {Multiply(5)}");

            Func<int, int> multiply = a => a * 5;
            Console.WriteLine($"Multiply Lambda: {multiply(5)}\n");
            #endregion

            Console.ReadLine();
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a)
        {
            return a*5;
        }
    }
}
