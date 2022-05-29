using System;
using System.Collections.Generic;

namespace GenericsProgram
{
    public class program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Running generics program using generic class");

            FindMaximum<int> integerValue = new FindMaximum<int>(500, 200, 900);
            Console.WriteLine("The Maximum Integer Value is: " + integerValue.CheckMax());
            FindMaximum<float> floatValue = new FindMaximum<float>(20.374F, 40.652F, 80.764F);
            Console.WriteLine("The Maximum Float Value is: " + floatValue.CheckMax());
            FindMaximum<string> stringValue = new FindMaximum<string>("Apple", "Peach", "Bananna");
            Console.WriteLine("The Maximum String Value is: " + stringValue.CheckMax());

        }
    }
}