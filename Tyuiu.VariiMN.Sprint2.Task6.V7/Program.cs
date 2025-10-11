using Tyuiu.VariiMN.Sprint2.Task6.V7.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task6.V7
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
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.  *");
            Console.WriteLine("* Условие: С начала 1990 года по некоторый день прошло n месяцев         *");
            Console.WriteLine("* и 2 дня. Определить название месяца (январь, февраль и т. п.)          *");
            Console.WriteLine("* этого дня.                                                             *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startYear = 1990;
            Console.WriteLine("Введите количество полных месяцев, прошедших с начала 1990 года:");
            int n = Convert.ToInt32(Console.ReadLine());

            string monthName = ds.FindMonthName(startYear, n);
            

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine($"Текущий месяц: {monthName}");

            Console.ReadKey();
        }
    }
}