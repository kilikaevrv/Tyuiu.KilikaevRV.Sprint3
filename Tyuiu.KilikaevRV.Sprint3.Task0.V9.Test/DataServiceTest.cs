namespace Tyuiu.KilikaevRV.Sprint3.Task0.V9.Test;
using Tyuiu.KilikaevRV.Sprint3.Task0.V9.Lib;


    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double wait = 0.43;
            double res = ds.GetSumSeries(x);
            Assert.AreEqual(wait, res);
        }
    }


