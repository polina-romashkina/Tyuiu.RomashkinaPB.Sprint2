using Tyuiu.RomashkinaPB.Sprint2.Task7.V11.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = -0.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
