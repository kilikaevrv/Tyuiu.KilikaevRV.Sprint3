using System;
using Tyuiu.KilikaevRV.Sprint3.Task1.V14.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double t = 0.7;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение t = {t}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(t, startValue, stopValue);
            Console.WriteLine($"Сумма ряда S = {result}");

            Console.ReadKey();
        }
    }
}