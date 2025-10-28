using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyutu.KilikaevRV.Sprint3.Task6.V24.Lib;

namespace Tyutu.KilikaevRV.Sprint3.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;
            int wait = 41; // Ожидаемое количество всех делителей

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSingleNumber()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 17;
            int wait = 2; // У числа 17 два делителя: 1 и 17

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsForNumber24()
        {
            DataService ds = new DataService();

            int startValue = 24;
            int stopValue = 24;
            int wait = 8; // У числа 24 восемь делителей: 1, 2, 3, 4, 6, 8, 12, 24

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 26;
            int stopValue = 17; // Некорректный диапазон

            ds.GetSumTheDivisors(startValue, stopValue);
        }
    }
}