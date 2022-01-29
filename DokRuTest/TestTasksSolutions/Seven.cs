using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokRuTest.TestTasksSolutions
{
//  Дана пирамида чисел:
//               1
//            3     5
//         7     9    11
//     13    15    17    19
//  21    23    25    27    29
//  ...
//
//  Напишите функцию, которая вычисляет сумму строки этого треугольника из переданного в функцию индекса строки(начиная с индекса 1).

    static public class Seven
    {
        public static int GetPiramidRowSum(int rowNumber)
        {
            if (rowNumber<=0)
            {
                return 0;
            }

            int memberInRowPosition = GetFirstMemberInRowPosition(rowNumber);

            int piramidRowSum = 0;

            for (int i = 0;i< rowNumber;i++)
            {
                piramidRowSum += CalculatePiramidMemberOnPosition(memberInRowPosition);
                memberInRowPosition++;
            }

            return piramidRowSum;
        }


        private static int GetFirstMemberInRowPosition(int rowNumber)
        {
            int firstMemberInRowPosition = 1;

            for(int i =0;i<=rowNumber-1;i++)
            {
                firstMemberInRowPosition += i;
            }

            return firstMemberInRowPosition;
        }

        private static int CalculatePiramidMemberOnPosition(int rowPosition)
        {
            int piramidMember = 1 + 2 * (rowPosition - 1);
            return piramidMember;
        }
    }
}
