using System;
using Tyuiu.KilikaevRV.Sprint3.Task7.V17.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кликаев Р. В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Кликаев Роман Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = sin(x)/(x+1.7) - cos(x)*4x - 6                                  *");
            Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1.                               *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.    *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                       *");
            Console.WriteLine("* Значения занести в массив!                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,5:d}     | {1,8:f2}  |", x, result[count]);
                count++;
            }
            Console.WriteLine("+----------+-----------+");

            Console.WriteLine();
            Console.WriteLine("Массив значений функции:");
            Console.Write("[");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.WriteLine("Проверка деления на ноль:");
            Console.WriteLine("При x = -1.7 было бы деление на ноль, но x принимает только целые значения");
            Console.WriteLine("Ближайшие целые значен