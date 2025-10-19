namespace Tyuiu.KilikaevRV.Sprint3.Task0.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;



public class DataService : ISprint3Task0V9

{
   
        public double GetSumSeries(double x)
        {
            double sum = 0;

            for (int i = 1; i <= 15; i++)
            {
                double denominator = 3 + Math.Pow(x, i);
                double term = Math.Pow(1 / denominator, i);
                sum += term;
            }

            return Math.Round(sum, 2); // Округляем до 2 знаков после запятой
        }
    


public double GetSumSeries(double value, int startValue, int stopValue)
    {
        throw new NotImplementedException();
    }
}

    
