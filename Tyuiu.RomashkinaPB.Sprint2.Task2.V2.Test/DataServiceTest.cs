using Tyuiu.RomashkinaPB.Sprint2.Task2.V2.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedAre()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
