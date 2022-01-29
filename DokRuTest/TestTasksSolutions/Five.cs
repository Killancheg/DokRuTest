using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DokRuTest.MoneyNominals;

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

        static public Dictionary<string, int> GetMinimalUSACoinsDictionary(double number)
        {
            Dictionary<string, int> coins = new Dictionary<string, int>();

            List<Nominal> usaCoins = CreateNomimalListUSA();

            foreach (var usaCoin in usaCoins)
            {
                coins.Add(usaCoin.Name + "s", 0);
            }

            if (number <=0)
            {
                return coins;
            }

            number = Math.Floor(number);

            foreach (var usaCoin in usaCoins)
            {
                coins[usaCoin.Name + "s"] = Convert.ToInt32(usaCoin.CountCoinsInAmaunt(number));
                number -= usaCoin.CountCoinsInAmaunt(number) * usaCoin.Value;
            }

            return coins;
        }

        static public List<Nominal> CreateNomimalListUSA()
        {
            List<Nominal> usaCoins = new List<Nominal>();

            usaCoins.Add(new MoneyNominals.USA.Quarter());
            usaCoins.Add(new MoneyNominals.USA.Dime());
            usaCoins.Add(new MoneyNominals.USA.Nickel());
            usaCoins.Add(new MoneyNominals.USA.Pennie());

            return usaCoins;
        }

        
    }
}
