using System;

namespace LambdaExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Subtract Method: {Subtract(5, 2)}");

            Func<int, int, int> subtract = (a, b) => a - b;
            Console.WriteLine($"subtract Lambda: {subtract(5, 2)}");

            Console.ReadLine();
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
