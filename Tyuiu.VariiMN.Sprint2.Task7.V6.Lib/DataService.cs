using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VariiMN.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x * x <= 4) && (y <= 0) && (x * x + y * y <= 4))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

    }
}
