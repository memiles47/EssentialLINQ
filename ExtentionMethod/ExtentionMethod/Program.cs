using System;

namespace ExtentionMethod
{
    internal class Program
    {
        private static void Main()
        {
            ShowTest("co");
            ShowTest("WA");
            ShowTest("AW");
            ShowTest("AL");
            ShowTest("NV");
            ShowTest("NM");
            ShowTest("Mi");

            Console.ReadLine();
        }

        public static void ShowTest(string state)
        {
            Console.WriteLine($"You entered: {state}, It is a state: {SpecialString.IsState(state)}");
        }
    }
}
