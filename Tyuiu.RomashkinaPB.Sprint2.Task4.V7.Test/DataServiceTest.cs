using Tyuiu.RomashkinaPB.Sprint2.Task4.V7.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.061;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5.5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 183.415;
            Assert.AreEqual(wait,res);
        }
    }
}
