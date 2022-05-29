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

            int[] IntArr = { 30, 20, 60, 49, 50, 93, 10};
            GenericClass<int> maxInt = new GenericClass<int>(IntArr);
            maxInt.printMax();

            double[] FloatArr = { 11.67, 50.23, 30.21, 45.79, 34.50};
            GenericClass<double> maxDouble = new GenericClass<double>(FloatArr);
            maxDouble.printMax();

            string[] StrArr = { "Apple", "Peach", "Banana", "Oragne", "Guava" };
            GenericClass<string> maxStr = new GenericClass<string>(StrArr);
            maxStr.printMax();
        }
    }
}