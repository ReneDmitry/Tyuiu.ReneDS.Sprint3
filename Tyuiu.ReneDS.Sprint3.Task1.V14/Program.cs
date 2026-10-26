using System;
using Tyuiu.ReneDS.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task1.V14
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл while, вычислить сумму ряда                               *");
            Console.WriteLine("* S = сумма (t^k + 1 / (k + 1)) * cos(t)                                   *");
            Console.WriteLine("* для k от 1 до 14 при t = 0.7.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("T = " + value);
            Console.WriteLine("Начальное значение k = " + startValue);
            Console.WriteLine("Конечное значение k = " + stopValue);

            double res;
            res = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);

            Console.ReadLine();
        }
    }
}
