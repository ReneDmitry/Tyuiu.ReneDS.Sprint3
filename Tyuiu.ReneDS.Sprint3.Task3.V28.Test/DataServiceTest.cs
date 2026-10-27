using Tyuiu.ReneDS.Sprint3.Task3.V28.Lib;
using tyuiu.cources.programming.interfaces;
namespace Tyuiu.ReneDS.Sprint3.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "f35hyt t4j 3gkg45";
            char item = 'r';

            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "frrhyt trj rgkgrr";

            Assert.AreEqual(wait, res);


        }
    }
}
