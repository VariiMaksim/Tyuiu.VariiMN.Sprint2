using Tyuiu.VariiMN.Sprint2.Task2.V10.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
