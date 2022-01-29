using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokRuTest.TestTasksSolutions
{
    //  Напишите функцию, которая принимает количество американской валюты центы(cents) и возвращает словарь / хэш,
    //  который показывает наименьшее количество монет, используемых для создания этой суммы.
    //  Рассматриваются только номиналы монет:
    //  Pennies(1¢),
    //  Nickels(5¢),
    //  Dimes(10¢) and
    //  Quarters(25¢).
    //  Поэтому возвращаемый словарь должен содержать ровно 4 пары ключ / значение.
    static public class Five
    {

        static public Dictionary<string, int> GetMinimalCoinsDictionary(double number)
        {

            int coinCount = Convert.ToInt32(Math.Floor(number));

            Dictionary<string, int> coins = new Dictionary<string, int>
            {
                {"Pennies", 0},
                {"Nickels", 0},
                {"Dimes", 0},
                {"Quarters", 0}
            };

            if (number <=0)
            {
                return coins;
            }

            int[] coinArray = GetCoinArray(coinCount);

            coins["Pennies"] = coinArray[3];
            coins["Nickels"] = coinArray[2];
            coins["Dimes"] = coinArray[1];
            coins["Quarters"] = coinArray[0];

            return coins;
        }

        static private int[] GetCoinArray(int number)
        {
            int[] coinArray= new int[] {0,0,0,0};

            if (number <=0)
            {
                return coinArray;
            }

            int[] coinDenominationArray = new int[] { 25, 10, 5, 1 };

            for (int i = 0; i < coinDenominationArray.Length; i++)
            {
                coinArray[i] = number / coinDenominationArray[i];
                number = number - coinArray[i] * coinDenominationArray[i];
            }

            return coinArray;
        }
    }
}
