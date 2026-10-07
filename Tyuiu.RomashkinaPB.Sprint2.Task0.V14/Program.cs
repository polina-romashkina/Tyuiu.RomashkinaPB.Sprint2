using Tyuiu.RomashkinaPB.Sprint2.Task0.V14.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task0.V14

//ТЕОРИЯ
//Операции сравнения (==, !=, <, >, <= , >=)

//Операция ==
//Сравнивает два операнда на равенство.
//Если они равны, то операция возвращает true, если не равны, то возвращает false:
//int a = 11;
//int b = 5;
//bool c = a == b;         //false

//Операция !=
//Сравнивает два операнда и возвращает true, если они не равны, и false, если они равны.
//int a = 10;
//int b = 3;
//bool c = a != b;       // true
//bool d = a != 10;      // false

//Операция < 
//Операция "меньше чем". Возращает true, если первый операнд меньше второго,
//и false, если первый опперанд больше второго.
//int a = 11;
//int b = 5
//bool c = a < b;        //false

//Операция >=
//Операция "больше или равно". Сравнивает два операнда и возвращает true,
//если первый операнд больше или равен второму. Иначе возвращает false.
//int a = 10;
//int b = 3;
//bool c = a >= b;      //true
//bool c = a >= 15;     //false
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1075;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.Title = "Спринт #2 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 2                                                              *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнения ( ==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
            Console.WriteLine("* и арефметических выражений, которая ведет логическую последовательность *");
            Console.WriteLine("* (массив): (True, False, True, False, True, False), при x = 1075, y= 754 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
