using Tyuiu.RomashkinaPB.Sprint2.Task6.V13.Lib;

// Конструкция switch мы ее можем сократить и получить результат непосредственно из конструкции switch:
// int DoOperation( int op, int a, int b)
//{
//     int result = op switch
//      {
//           1 => a + b,
//           2 => a - b,
//           3 => a * b,
//             _ => 0
//      };
//    return result
//}

namespace Tyuiu.RomashkinaPB.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 2                                                              *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму оператора      *");
            Console.WriteLine("* switch, вычисляет требуемое значение и возвращает результат            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);
            if ((n < 1) || (n > 31) || (m < 1) || (m > 12))
            {
                res = "ВВедено неверное значение";
            }
            else
            {
                res = "Дата следующего дня: " + ds.FindDateOfNextDay(g, m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
