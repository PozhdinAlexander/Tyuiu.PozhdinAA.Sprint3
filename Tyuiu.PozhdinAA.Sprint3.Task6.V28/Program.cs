using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PozhdinAA.Sprint3.Task6.V28.Lib;

namespace Tyuiu.PozhdinAA.Sprint3.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Пождин А. А. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [13, 19]                                *");
            Console.WriteLine("* количество всех делителей меньше 7.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int start = 13;
            int stop = 19;


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало отрезка = {start}\nКонец отрезка = {stop}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumTheDivisors(start, stop));
            Console.ReadKey();
        }
    }
}