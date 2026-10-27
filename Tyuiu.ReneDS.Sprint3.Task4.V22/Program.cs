using System;
using Tyuiu.ReneDS.Sprint3.Task4.V22.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task4.V22
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операторы break и continue в циклах                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке от -5 до 5 вычислить значения функции                        *");
            Console.WriteLine("* y = x / (sin(x) - x).                                                   *");
            Console.WriteLine("* При x = 0 пропустить значение. Полученные значения перемножить.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начальное значение X = " + startValue);
            Console.WriteLine("Конечное значение X = " + stopValue);

            double res;
            res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение значений = " + res);

            Console.ReadLine();
        }
    }
}