using System;
using Tyuiu.KilikaevRV.Sprint3.Task2.V24.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double a = 0.25;
            int startValue = 1;
            int stopValue = 8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение a = {a}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(a, startValue, stopValue);
            Console.WriteLine($"Произведение ряда p = {result}");

            Console.ReadKey();
        }
    }
}