using System;
using Tyuiu.ReneDS.Sprint3.Task0.V9.Lib;

namespace Tyuiu.ReneDS.Sprint3.Task0.V9
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ренье Д. С. | АСОиУБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ренье Дмитрий Сергеевич | АСОиУБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл for, вычислить сумму ряда                                *");
            Console.WriteLine("* S = сумма (1 / (3 + x^i))^i для i от 1 до 15 при x = 0.5.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            // Исходные данные из условия задания.
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Начальное значение i = " + startValue);
            Console.WriteLine("Конечное значение i = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadLine();
        }
    }
}