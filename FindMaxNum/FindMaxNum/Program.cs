using System;
using System.Collections.Generic;

namespace GenericsProgram
{
    public class program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Running Generics Program");

            GenericClass accessMethod = new GenericClass();
            var forInt = accessMethod.MaxInt(500, 750, 200);
            Console.WriteLine("The Maximum Integer Value is: " + forInt);
        }
    }
}