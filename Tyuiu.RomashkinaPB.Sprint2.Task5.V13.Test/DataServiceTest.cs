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
            string wait = "16.01.2024";
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
            string wait = "01.102.2024";
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
            string wait = "01.01.2025";
            Assert.AreEqual(wait, res);


        }



    }
}
