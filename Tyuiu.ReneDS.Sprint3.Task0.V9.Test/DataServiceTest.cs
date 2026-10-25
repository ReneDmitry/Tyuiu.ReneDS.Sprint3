using Tyuiu.ReneDS.Sprint3.Task0.V9.Lib;
using tyuiu.cources.programming.interfaces;
namespace Tyuiu.ReneDS.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            
            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.430;

            Assert.AreEqual(res, wait);
        }
    }
}
