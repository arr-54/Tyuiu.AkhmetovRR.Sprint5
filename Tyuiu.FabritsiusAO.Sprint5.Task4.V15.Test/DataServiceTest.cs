using Tyuiu.FabritsiusAO.Sprint5.Task4.V15.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double x = 3.54;
            double wait = 5.878;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}