namespace Tyuiu.KilikaevRV.Sprint3.Task0.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;



public class DataService : ISprint3Task0V9
{
   
        public double GetSumSeries(double value, int startValue, int stopValue)
    {
        double sum = 0;

        for (int i = startValue; i <= stopValue; i++)
        {
            double denominator = 3 + Math.Pow(value, i);
            double term = Math.Pow(1 / denominator, i);
            sum += term;
        }

        return Math.Round(sum, 2);
    }
}
    



    
