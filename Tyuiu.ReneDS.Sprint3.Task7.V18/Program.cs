using System;
using Tyuiu.ReneDS.Sprint3.Task7.V18.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task7.V18
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значения F(x) = (2*x - 3) / (cos(x) + x) + 5                   *");
            Console.WriteLine("* на отрезке [-5; 5] с шагом 1.                                            *");
            Console.WriteLine("* При делении на ноль записать 0.                                         *");
            Console.WriteLine("* Значения округлить до двух знаков и занести в массив.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("Шаг = 1");

            int len = (stopValue - startValue) + 1;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+------------+------------+");
            Console.WriteLine("|     X      |    f(x)    |");
            Console.WriteLine("+------------+------------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,10:d} | {1,10:F2} |",
                    startValue, valueArray[i]);

                startValue++;
            }

            Console.WriteLine("+------------+------------+");

            Console.ReadKey();
        }
    }
}
