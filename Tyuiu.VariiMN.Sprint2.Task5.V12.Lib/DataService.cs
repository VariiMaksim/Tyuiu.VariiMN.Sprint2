using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VariiMN.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int lastDay = n - 1;
            int lastMonth = m;
            int lastYear = g;
            int daysInMonth;
            switch (m)
            {
                case 1:  // Январь
                    daysInMonth = 31;
                    break;
                case 2:  // Февраль
                    daysInMonth = 29; 
                    break;
                case 3:  // Март
                    daysInMonth = 31;
                    break;
                case 4:  // Апрель
                    daysInMonth = 30;
                    break;
                case 5:  // Май
                    daysInMonth = 31;
                    break;
                case 6:  // Июнь
                    daysInMonth = 30;
                    break;
                case 7:  // Июль
                    daysInMonth = 31;
                    break;
                case 8:  // Август
                    daysInMonth = 31;
                    break;
                case 9:  // Сентябрь
                    daysInMonth = 30;
                    break;
                case 10: // Октябрь
                    daysInMonth = 31;
                    break;
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;
            }
            string formattedDay = lastDay.ToString("00");
            string formattedMonth = lastMonth.ToString("00");

            return $"{formattedDay}.{formattedMonth}.{lastYear}";

        }
    }
}
