using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DokRuTest.Helpers;

namespace DokRuTest.TestTasksSolutions
{
    static public class Six
    {
        //Напишите функцию, которая может принимать любое неотрицательное целое число в
        //качестве аргумента и возвращать его вместе с цифрами в порядке убывания.
        //Переставьте цифры так, чтобы на выходе создать максимально возможное число.

        static public int GetMaxNumberFromDigits(int number)
        {
            if (number <=0)
            {
                return 0;
            }

            int[] digitArray = ArrayHelper.GetDigitArrayFromInt(number);

            Array.Sort(digitArray);
            Array.Reverse(digitArray);

            int newNumber = ArrayHelper.GetNumberFromIntArray(digitArray);

            return newNumber;
        }
    }
}
