﻿using Tyuiu.VariiMN.Sprint2.Task0.V5.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task0.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                               *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)        *");
            Console.WriteLine("* последовательность операций не должна нарушаться)                      *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую послед(массив)   *");
            Console.WriteLine("* (False, True, True, True, False, True), при x = 105, y = 223         *");

            int x = 105;
            int y = 223;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}