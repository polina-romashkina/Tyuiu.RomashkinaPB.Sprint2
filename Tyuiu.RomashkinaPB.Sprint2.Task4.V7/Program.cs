using Tyuiu.RomashkinaPB.Sprint2.Task4.V7.Lib;

// [первый операнд - условие]?[второй операнд] : [третий операнд]
//здесь сразу три опернада. В зависимости от условия тернарная операция возвращает 
//второй или третий операнд: если условие равно true, то возвращает второй операнд;
//если условие равно false, тотретий.

// int x = 13;
// int y = 12;
// int z = x < y ? (x + y) : (x - y);
//Console.WriteLine(z) // 1


namespace Tyuiu.RomashkinaPB.Sprint2.Task4.V7;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт # 2                                                              *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованием тернарного операторов, где пользователь вводит           *");
        Console.WriteLine("* значение переменных x, y с клавиатуры.                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}
