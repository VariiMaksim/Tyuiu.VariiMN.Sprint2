using Tyuiu.VariiMN.Sprint2.Task4.V28.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 14.062;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.787;
            Assert.AreEqual(wait, res);
        }
    }
}
