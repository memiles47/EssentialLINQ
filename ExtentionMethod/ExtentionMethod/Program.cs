using System;

//Added the Methods namespace for the extention methods
using Methods;

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
            //Calling the regular method
            //Console.WriteLine($"You entered: {state}, It is a state: {SpecialString.IsState(state)}");

            //Calling the extention string method shorter and easier to read
            Console.WriteLine($"You entered: {state}, It is a state: {state.IsState()}");
        }
    }
}
