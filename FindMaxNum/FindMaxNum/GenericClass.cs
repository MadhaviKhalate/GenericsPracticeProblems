using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericClass
    {
        public T FindMax<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0
                || firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0
                || firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0
                || secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0
                || secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}
