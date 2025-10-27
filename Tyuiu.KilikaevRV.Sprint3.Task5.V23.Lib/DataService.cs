using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyulu.KilikaevRV.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double xPowerK = Math.Pow(x, k);
                    double term = (xPowerK + 2) * Math.Cos(k);
                    totalSum += term;
                }
            }

            return Math.Round(totalSum, 3);
        }
    }
}