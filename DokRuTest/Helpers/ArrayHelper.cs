using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokRuTest.Helpers
{
    static public class ArrayHelper
    {
        static public int[] GetDigitArrayFromInt(int number)
        {
            var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

            return digitArray;
        }

        static public int GetNumberFromIntArray(int[] array)
        {
            int number = 0;

            if (array == null)
            {
                return number;
            }

            string strNumber = string.Concat(array).Replace("-", "");

            number = int.Parse(strNumber);

            return number;
        }
    }
}
