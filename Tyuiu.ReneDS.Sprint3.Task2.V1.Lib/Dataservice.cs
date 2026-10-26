using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReneDS.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;

            do
            {
                sumSeries = sumSeries + Math.Sin(startValue) * Math.Pow(1.0 / 2, 2);

                startValue++;
            }
            while (startValue <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}
