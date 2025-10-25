using System;
using Tyuiu.KilikaevRV.Sprint3.Task4.V22.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");
            Console.WriteLine($"Функция: y = x / (sin(x) - x)");
            Console.WriteLine($"При x = 0 значение пропускается");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"Произведение значений функции = {result}");

            Console.ReadKey();
        }
    }
}