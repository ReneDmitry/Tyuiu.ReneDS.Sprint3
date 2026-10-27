using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReneDS.Sprint3.Task6.V14.Lib
{


    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int j = 6; j <= x; j++)
                {
                    if (x % j == 0)
                    {
                        sum++;
                    }
                }
            }

            return sum;
        }

        }
    }
