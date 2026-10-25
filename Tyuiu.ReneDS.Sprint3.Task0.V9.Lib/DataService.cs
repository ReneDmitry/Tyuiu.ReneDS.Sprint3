// Вычисляем сумму ряда с помощью цикла for.
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReneDS.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + Math.Pow(1 / (3 + Math.Pow(value, i)), i);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
