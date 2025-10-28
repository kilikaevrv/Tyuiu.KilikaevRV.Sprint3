using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyutu.KilikaevRV.Sprint3.Task6.V24.Lib
{
    public class DataService : ISprint3Task6V24
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            int totalDivisors = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                // Для каждого числа находим количество делителей
                int divisorsCount = 0;

                // Проверяем все числа от 1 до самого числа
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalDivisors += divisorsCount;
            }

            return totalDivisors;
        }
    }
}