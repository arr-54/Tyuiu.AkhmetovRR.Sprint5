using Tyuiu.FabritsiusAO.Sprint5.Task6.V16.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}