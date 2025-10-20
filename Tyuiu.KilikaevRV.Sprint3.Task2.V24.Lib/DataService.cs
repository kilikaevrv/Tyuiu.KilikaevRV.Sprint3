using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KilikaevRV.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            double cosA = Math.Cos(value); // Вычисляем cos(a) один раз
            int k = startValue;

            do
            {
                multiplySeries *= (Math.Pow(value, k) + 4) * cosA;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}