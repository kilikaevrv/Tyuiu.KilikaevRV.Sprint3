using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint3.Task7.V17.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Правильные значения, пересчитанные вручную
            double[] wait = {
                -0.62,   // x = -5
                -16.79,  // x = -4
                -17.77,  // x = -3 (исправлено!)
                -6.30,   // x = -2 (исправлено!)
                -5.04,   // x = -1 (исправлено!)
                -6.00,   // x = 0
                -7.85,   // x = 1 (исправлено!)
                -2.43,   // x = 2 (исправлено!)
                5.91,    // x = 3 (исправлено!)
                4.33,    // x = 4 (исправлено!)
                -11.82   // x = 5 (исправлено!)
            };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMassFunctionForXEqualsMinus3()
        {
            DataService ds = new DataService();

            int startValue = -3;
            int stopValue = -3;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Проверим вычисление для x = -3
            double expected = -17.77;

            Assert.AreEqual(expected, result[0], 0.01); // Допуск 0.01 из-за округления
        }

        [TestMethod]
        public void ValidGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { -6.00 };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = -5; // Некорректный диапазон

            ds.GetMassFunction(startValue, stopValue);
        }
    }
}