using System;
using System.Collections.Generic;
using System.Linq;
using DokRuTest.Helpers;
using System.Text;
using System.Threading.Tasks;

namespace DokRuTest.TestTasksSolutions
{
    //Напишите функцию, которая в качестве аргумента принимает натуральное число n и возвращает сумму цифр этого числа.
    //Если это значение имеет более одной цифры, продолжайте уменьшать его таким образом, пока не будет получено одноразрядное число.
    //Это применимо только к натуральным числам.

    static public class Four
    {
        static public int GetRecursiveDigitSum(int number)
        {
            if (number <=0)
            {
                return 0;
            }

            if (IsSinglDigit(number))
            {
                return number;
            }

            int[] digitArray = ArrayHelper.GetDigitArrayFromInt(number);

            number = digitArray.Sum();

            return GetRecursiveDigitSum(number);
        }

        

        static private bool IsSinglDigit(int number)
        {
            if (number == 0)
            {
                return true;
            }

            int modulo = number / 10;

            if (modulo == 0)
            {
                return true;
            }

            return false;
        }
    }
}
