using Tyuiu.RomashkinaPB.Sprint2.Task5.V13.Lib;

// Switch (выражение)
//     {
//         case значение1:
//            код, выполняемый если выражение имеет значение1
//         break;
//         case значение2:
//            код, выполняемый если выражение имеет значение2
//         break;
//         //.............
//         case значениеN:
//            код. выполняемый если выражение имеет значениеN
//         break;
//         default;
//            код, выполняеиый если выражение не имеет ни одно из указанных значений
//         break;



namespace Tyuiu.RomashkinaPB.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 2                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

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
