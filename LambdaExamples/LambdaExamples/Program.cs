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
            Console.WriteLine($"multiply Lambda: {multiply(5)}\n");
            #endregion

            #region Display Method
            Display("Michael Miles");

            Action<string> display = a => Console.WriteLine($"display Lambda: {a}");
            display("Michael Miles\n");

            #endregion

            #region DisplayWarning Method
            DisplayWarning();

            Action displayWarning = () => Console.WriteLine("displayWarning Lambda: Warning\n");
            displayWarning();
            #endregion

            #region SimpleMath Method
            Console.WriteLine($"SimpleMath Method: {SimpleMath(1, 3, 3)}");

            Func<int, int, int, decimal> simpleMath = (a, b, c) => (a + b) / c;
            Console.WriteLine($"simpleMath Lambda: {simpleMath(1, 2, 3)}\n");
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

        public static void Display(string value)
        {
            Console.WriteLine($"Display Method: {value}");
        }

        public static void DisplayWarning()
        {
            Console.WriteLine("DisplayWarning Method: Warning");
        }

        public static decimal SimpleMath(int a, int b, int c)
        {
            return (a + b)/c;
        }
    }
}
