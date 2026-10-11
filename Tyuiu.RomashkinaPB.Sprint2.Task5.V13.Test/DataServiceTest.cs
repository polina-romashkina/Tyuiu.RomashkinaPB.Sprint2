using Tyuiu.RomashkinaPB.Sprint2.Task5.V13.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDate_NextDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 15;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2024-01-16";
            Assert.AreEqual(wait, res);
            

        }

        [TestMethod]
        public void ValidFindDate_EndOfMonth()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2024-02-01";
            Assert.AreEqual(wait, res);


        }

        [TestMethod]
        public void ValidFindDate_EndOfYear()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2025-01-01";
            Assert.AreEqual(wait, res);


        }



    }
}
