using System;
using System.Collections.Generic;
using DokRuTest.TestTasksSolutions;

namespace DokRuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            //Задание 4
            Console.WriteLine("Демонстрация работы 4 задания:");

            int numbetToSumDigits = GetIntImput();

            Console.WriteLine($"Рекурсивная сумма цифр: {Four.GetRecursiveDigitSum(numbetToSumDigits)}");

            Console.WriteLine();
            #endregion

            #region Task5
            //Задание 5
            Console.WriteLine("Демонстрация работы 5 задания:");
            Console.WriteLine("Сколько центов разложить на монеты?");

            int centAmaunt = GetIntImput();

            Dictionary<string, int> coins = Five.GetMinimalUSACoinsDictionary(centAmaunt);

            foreach (var coin in coins)
            {
                Console.WriteLine($"{coin.Key}: {coin.Value}");
            }

            Console.WriteLine();
            #endregion

            #region Task6
            // Задание 6
            Console.WriteLine("Демонстрация работы 6 задания:");

            int numberToReverseDigits = GetIntImput();
            
            Console.WriteLine($"Все цифры числа отсортированы в обратном порядке: {Six.GetMaxNumberFromDigits(numberToReverseDigits)}");

            Console.WriteLine();
            #endregion

            #region Task7
            //Задание 7
            Console.WriteLine("Демонстрация работы 7 задания:");

            Console.WriteLine("Укажите номер строки пирамиды для суммирования.");

            int piramidRowNumber = GetIntImput();

            Console.WriteLine($"Сумма строки: {Seven.GetPiramidRowSum(piramidRowNumber)}");

            Console.WriteLine();
            #endregion

            //Задание 8
            #region Task8
            Console.WriteLine("Демонстрация работы 8 задания:");
            Console.WriteLine($"Вот пять: {Eight.GiveFive()}");
            #endregion
            Console.ReadKey();
        }

        static private int GetIntImput()
        {
            bool isInputRight = false;

            int imput = 0;

            do
            {
                Console.WriteLine("Введите число:");
                string strImput = Console.ReadLine();
                try
                {
                    if(strImput.Contains("."))
                    {
                        int dotIndex = strImput.IndexOf(".");
                        strImput = strImput.Substring(0, dotIndex);
                    }
                    imput = Convert.ToInt32(strImput);
                    isInputRight = true;
                }
                catch
                {
                    Console.WriteLine("Число должно быть указано цифрами!");
                }
            } while (!isInputRight);

            return imput;
        }
    }
}
