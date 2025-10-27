using System;
using Tyulu.KilikaevRV.Sprint3.Task5.V23.Lib;

namespace Tyulu.KilikaevRV.Sprint3.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Килияев Р.В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Килияев Роман Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда по формуле:       *");
            Console.WriteLine("* y = ∑_{i=1}^3 ∑_{k=1}^10 (x^k + 2) * cos(k) при x = 2                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 2                                                                   *");
            Console.WriteLine("* i = 1..3                                                                *");
            Console.WriteLine("* k = 1..10                                                               *");
            Console.WriteLine("***************************************************************************");

            // Вычисление
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;  // начало диапазона i
            int startValue2 = 1;  // начало диапазона k  
            int stopValue1 = 3;   // конец диапазона i
            int stopValue2 = 10;  // конец диапазона k

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Сумма сумм ряда: {result,10:F3}                                        *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}