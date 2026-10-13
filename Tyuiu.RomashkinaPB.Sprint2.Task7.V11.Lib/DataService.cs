using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomashkinaPB.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((y >= x)) || (x <= 0 && y <= 0)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
