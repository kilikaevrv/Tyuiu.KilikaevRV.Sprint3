using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KilikaevRV.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль
                if (x + 1.7 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    // Вычисление функции: F(x) = sin(x)/(x+1.7) - cos(x)*4x - 6
                    double numerator = Math.Sin(x);
                    double denominator = x + 1.7;
                    double firstTerm = numerator / denominator;
                    double secondTerm = Math.Cos(x) * 4 * x;
                    double result = firstTerm - secondTerm - 6;

                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}