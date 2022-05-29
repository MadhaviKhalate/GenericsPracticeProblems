using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class FindMaximum<T> where T : IComparable
    {
        private T firstValue, secondValue, thirdValue;

        public FindMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T CheckMax()
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
