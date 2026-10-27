using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ReneDS.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string res = "";

            foreach (char symbol in value)
            {
                if (char.IsDigit(symbol))
                {
                    res = res + item;
                }
                else
                {
                    res = res + symbol;
                }
            }

            return res;
        }
    }
}
