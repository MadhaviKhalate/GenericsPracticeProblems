using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class GenericClass
    {
        public int MaxInt(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
        public float MaxFloat(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
        public string MaxString(string firstStr, string secondStr, string thirdStr)
        {
            if (firstStr.CompareTo(secondStr) > 0 && firstStr.CompareTo(thirdStr) > 0)
            {
                return firstStr;
            }
            else if (secondStr.CompareTo(firstStr) > 0 && secondStr.CompareTo(thirdStr) > 0)
            {
                return secondStr;
            }
            else
            {
                return thirdStr;
            }
        }
    }
}
