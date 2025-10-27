using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyulu.KilikaevRV.Sprint3.Task5.V23.Lib;

namespace Tyulu.KilikaevRV.Sprint3.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Правильное ожидаемое значение: -3653.506
            double expected = -3653.506;

            Assert.AreEqual(expected, result, 0.001, "Неправильная сумма для x=2, i=1..3, k=1..10");
        }

        [TestMethod]
        public void ValidGetSumSumSeriesWithSingleK()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 1;
            int stopValue2 = 1;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Для x=2, i=1, k=1: (2^1 + 2)1 = (2+2)*0.5403 = 2.1612
            double expected = 2.161;

            Assert.AreEqual(expected, result, 0.001, "Неправильная сумма для одиночного элемента");
        }
    }
}