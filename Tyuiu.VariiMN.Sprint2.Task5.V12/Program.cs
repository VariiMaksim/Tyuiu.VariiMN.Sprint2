using Tyuiu.VariiMN.Sprint2.Task5.V12.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                             *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:        *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год является високосным.     *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите год (g):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}