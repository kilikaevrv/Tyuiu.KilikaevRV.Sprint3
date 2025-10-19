using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint3.Task1.V14.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.422;

            Assert.AreEqual(wait, res);
        }
    }
}