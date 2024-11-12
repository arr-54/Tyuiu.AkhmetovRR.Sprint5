using Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculateValid()
        {
            DataService ds = new();
            int x = 0;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}