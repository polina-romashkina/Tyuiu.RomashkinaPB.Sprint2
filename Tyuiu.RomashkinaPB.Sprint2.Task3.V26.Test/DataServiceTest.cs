using Tyuiu.RomashkinaPB.Sprint2.Task3.V26.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondotion1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondotion2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondotion3()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = 2803.626;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondotion4()
        {
            DataService ds = new DataService();
            double x = -31;
            double res = ds.Calculate(x);
            double wait = -247.968;
            Assert.AreEqual(wait, res);
        }
    }
}
