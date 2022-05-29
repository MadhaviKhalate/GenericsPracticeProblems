using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericClass<T> where T : IComparable
    {
        public T[] data;
        public GenericClass(T[] data)
        {
            this.data = data;
        }
        public static T[] sort(T[] data)
        {
            Array.Sort(data);
            return data;
        }
        public static T MaxValue(params T[] data)
        {
            var sortedData = sort(data);
            return sortedData[data.Length - 1];
        }
        public T printMax()
        {
            var Result = GenericClass<T>.MaxValue(this.data);
            return Result;
        }
    }
}
