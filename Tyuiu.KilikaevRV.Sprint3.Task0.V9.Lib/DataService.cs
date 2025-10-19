namespace Tyuiu.KilikaevRV.Sprint3.Task0.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;



public class DataService : ISprint3Task0V9
{
    public double GetSumSeries(double x)
    {
        double sum = 0;

        // Цикл for от i=1 до i=15
        for (int i = 1; i <= 15; i++)
        {
            double term = Math.Pow(1.0 / (3 + Math.Pow(x, i)), i);
            sum += term;
        }

        return Math.Round(sum, 3); // Округляем до 3 знаков после запятой
    }

    public double GetSumSeries(double value, int startValue, int stopValue)
    {
        throw new NotImplementedException();
    }
}

    
