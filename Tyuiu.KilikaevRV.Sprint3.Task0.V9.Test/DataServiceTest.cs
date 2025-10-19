namespace Tyuiu.KilikaevRV.Sprint3.Task0.V9.Test;
using global::Tyuiu.KilikaevRV.Sprint3.Task0.V9.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            double wait = 0.43;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }

