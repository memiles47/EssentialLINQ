using System;

namespace LambdaExperiments
{
    class Program
    {
        static void Main()
        {
            //Using a method
            Console.WriteLine($"SimpleMath Method: {SimpleMath1(1, 2, 3)}");

            //Lambda
            Func<int, int, int, int> simpleMath2 = (a, b, c) => (a + b)/c;
            Console.WriteLine($"SimpleMath Lambda: {simpleMath2(1, 2, 3)}");

            Console.ReadLine();
        }

        static int SimpleMath1(int a, int b, int c)
        {
            return (a + b)/c;
        }
    }
}
