using Tyuiu.VariiMN.Sprint2.Task2.V10.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task2.V10
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
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения              *");
            Console.WriteLine("* с клавиатуры и вычисляет находится                                     *");
            Console.WriteLine("* ли точка с координатами X,Y в заштрихованной области.                  *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            if (res)
            {
                Console.WriteLine("Точка есть в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точки нет в заштрихованной области");
            }


            Console.ReadKey();
        }
    }
}