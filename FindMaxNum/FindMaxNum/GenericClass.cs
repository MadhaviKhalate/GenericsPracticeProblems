using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericClass<T> where T : IComparable
    {
        public T[] value;
        public GenericClass(T[] value)
        {
            this.value = value;
        }
        public static T[] sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public static T findMaximum(params T[] value)
        {
            var sorted_values = sort(value);
            return sorted_values[value.Length - 1];
        }
        public T ReturnMax()
        {
            var Result = GenericClass<T>.findMaximum(this.value);
            return Result;
        }
        public void printMax()
        {
            var max = findMaximum(this.value);
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}
