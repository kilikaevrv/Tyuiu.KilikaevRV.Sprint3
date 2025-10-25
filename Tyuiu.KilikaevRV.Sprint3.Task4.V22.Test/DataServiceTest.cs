using System;

namespace Tyuiu.KilikaevRV.Sprint3.Task4.V22.Lib
{
    public class DataService : ISprint3Task4V22
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                // Вычисляем sin(x) и знаменатель
                double sinX = Math.Sin(x);
                double denominator = sinX - x;

                // Проверяем, не слишком ли мал знаменатель
                if (Math.Abs(denominator) < 0.0000001)
                    continue;

                // Вычисляем значение функции
                double value = (double)x / denominator;
                product *= value;

                // Для отладки можно вывести промежуточные значения
                // Console.WriteLine($"x={x}, sin(x)={sinX:F6}, denominator={denominator:F6}, value={value:F6}, product={product:F6}");
            }

            return Math.Round(product, 3);
        }
    }

    public interface ISprint3Task4V22
    {
    }
}