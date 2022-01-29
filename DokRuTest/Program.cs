using System;
using DokRuTest.TestTasksSolutions;

namespace DokRuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            Console.WriteLine("Демонстрация работы 4 задания:");

            int numbetToSumDigits = GetIntImput();

            Console.WriteLine($"Рекурсивная сумма цифр: {Four.GetRecursiveDigitSum(numbetToSumDigits)}");

            Console.WriteLine();

            //Задание 7
            Console.WriteLine("Демонстрация работы 7 задания:");


            
            Console.WriteLine("Укажите номер строки пирамиды для суммирования.");

            int piramidRowNumber = GetIntImput();

            Console.WriteLine($"Сумма строки: {Seven.GetPiramidRowSum(piramidRowNumber)}");

            Console.WriteLine();

            //Задание 8
            Console.WriteLine("Демонстрация работы 8 задания:");
            Console.WriteLine($"Вот пять: {Eight.GiveFive()}");

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
