using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Tyuiu.RomashkinaPB.Sprint2.Task1.V4.Lib;

namespace Tyuiu.RomashkinaPB.Sprint2.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;
            bool[] res = new bool[6]; 
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, false , true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
