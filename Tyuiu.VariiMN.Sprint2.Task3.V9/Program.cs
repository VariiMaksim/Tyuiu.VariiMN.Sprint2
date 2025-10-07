using Tyuiu.VariiMN.Sprint2.Task3.V9.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task3.V9
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
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение               *");
            Console.WriteLine("* функции Y с использованием вложенных оператор if-else,                 *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.            *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.            *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Значение функции = " + res);



            Console.ReadKey();
        }
    }
}