using Microsoft.Testing.Platform.Extensions.Messages;
using Tyuiu.ReneDS.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}
