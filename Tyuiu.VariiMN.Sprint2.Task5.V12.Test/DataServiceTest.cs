using Tyuiu.VariiMN.Sprint2.Task5.V12.Lib;

namespace Tyuiu.VariiMN.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            string res = ds.FindDateOfPreviousDay(2022, 10, 14);
            Assert.AreEqual("13.10.2022", res);
        }
    }
}
