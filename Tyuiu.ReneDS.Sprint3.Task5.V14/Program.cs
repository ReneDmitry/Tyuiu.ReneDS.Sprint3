using System;
using Tyuiu.ReneDS.Sprint3.Task5.V14.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task5.V14
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму выражения sin(x) + 2 / k.                       *");
            Console.WriteLine("* Внешний цикл: i от 1 до 3. Внутренний цикл: k от 1 до 14.               *");
            Console.WriteLine("* Значение x = 5.                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            Console.WriteLine("X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда i = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда i = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда k = " + startValue2);
            Console.WriteLine("Конец шага первой суммы ряда k = " + stopValue2);

            double res;
            res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);

            Console.ReadLine();
        }
    }
}