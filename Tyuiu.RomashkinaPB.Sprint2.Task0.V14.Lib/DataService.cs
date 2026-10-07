using tyuiu.cources.programming.interfaces.Sprint2;

//ЗАДАНИЕ
//Написать программу из операций сравнения ( ==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арефметических выражений, которая ведет логическую последовательность(массив):
//(True, False, True, False, True, False), при x = 1075, y = 754

namespace Tyuiu.RomashkinaPB.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 321 == y;
            res[1] = x - 321 != y;
            res[2] = x - 1000 < y;
            res[3] = x - 999 > y; 
            res[4] = x - 555 <= y;
            res[5] = x - 666 >= y;

            return res;
        }
    }
}
