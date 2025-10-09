using Tyuiu.VariiMN.Sprint2.Task4.V28.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task4.V28
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* написать программу, которая вычисляет требуемое значение c             *");
            Console.WriteLine("* использованием тернарного оператора, ввод x,y, если                    *");
            Console.WriteLine("* z = x < y * 2 - 10 ? (1 + y+2/x^2)^x : 2x^2 - cos(y)^2 + 12 / y^2 -    *");
            Console.WriteLine("* - sin(x)^2 + 9. Ответ округлить до трёх знаков                         *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y); 

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine("Значение функции = " + res);



            Console.ReadKey();
        }
    }
}