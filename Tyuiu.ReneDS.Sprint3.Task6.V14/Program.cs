using Tyuiu.ReneDS.Sprint3.Task6.V14.Lib;

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
            Console.WriteLine("* Найти количество всех делителей больше 5                                *");
            Console.WriteLine("* принадлежащих отрезку [7, 16]                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            int startValue = 7;
            int stopValue = 16;

            Console.WriteLine(" Начало отрезка = " + startValue);
            Console.WriteLine(" Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Количество всех делителей больше 5 = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();



        }
    }

}