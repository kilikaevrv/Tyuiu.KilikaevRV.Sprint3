using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KilikaevRV.Sprint3.Task4.V22.Lib
{
    public class DataService : ISprint3Task4V22
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                double sinValue = Math.Sin(x);
                double denominator = sinValue - x;

                if (Math.Abs(denominator) < 1e-10)
                    continue;

                double functionValue = x / denominator;
                product *= functionValue;
            }

            return Math.Round(product, 3);
        }
    }
}