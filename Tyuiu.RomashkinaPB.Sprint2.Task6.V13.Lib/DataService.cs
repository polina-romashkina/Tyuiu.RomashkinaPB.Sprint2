using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomashkinaPB.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29,
                _ => throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}")
            };

            return n switch
            {
                _ when n < daysInMonth => $"{n + 1}.{m}.{g}",
                _ when m < 12 => $"01.{m + 1}.{g}",
                _ => $"01.01.{g + 1}"
            };
        }
    }
}
