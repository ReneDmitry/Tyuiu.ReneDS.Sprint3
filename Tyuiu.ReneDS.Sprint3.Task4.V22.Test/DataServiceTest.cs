using Microsoft.Testing.Platform.Extensions.Messages;
using Tyuiu.ReneDS.Sprint3.Task4.V22.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 73.346;
            Assert.AreEqual(wait, res);
        }
    }
}
