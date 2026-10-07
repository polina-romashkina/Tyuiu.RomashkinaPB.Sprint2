using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, ›, ‹=, >=, последовательность можно чередовать,
////но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(False, False, False, False, True, False), при а =175, b = 176, c = 414, d = 414

namespace Tyuiu.RomashkinaPB.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c > d);
            res[1] = (a > b) & (c == d);
            res[2] = (a + 20 < b) || (c < d);
            res[3] = (a < b) && (c - 20 >= d);
            res[4] = !res[0];
            res[5] = (a + 10 <= b) ^ (c < d);
            return res;
        }
    }
}
