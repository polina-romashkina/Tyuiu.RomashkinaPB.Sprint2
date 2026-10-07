using Tyuiu.RomashkinaPB.Sprint2.Task0.V14.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCompareOperation()
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
