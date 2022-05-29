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
            var IntValue = accessMethod.MaxInt(500, 750, 200);
            var FloatValue = accessMethod.MaxFloat(23.567F, 100.218F, 654.574F);
            var StringValue = accessMethod.MaxString("Apple", "Peach", "Banana");
            Console.WriteLine("The Maximum Integer Value is: " + IntValue);
            Console.WriteLine("The Maximum Float Value is: " + FloatValue);
            Console.WriteLine("The Maximum String Value is: " + StringValue);

        }
    }
}