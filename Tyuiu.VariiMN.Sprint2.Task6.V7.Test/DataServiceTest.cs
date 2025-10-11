using Tyuiu.VariiMN.Sprint2.Task6.V7.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string res = ds.FindMonthName(1990, 22);
            Assert.AreEqual("ноябрь", res);
        }
    }
}
