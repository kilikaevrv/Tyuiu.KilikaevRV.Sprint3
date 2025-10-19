namespace Tyuiu.KilikaevRV.Sprint3.Task1.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = (Math.Pow(value, k) + 1.0 / (k + 1)) * Math.Cos(value);
                sumSeries += term;
                k++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
