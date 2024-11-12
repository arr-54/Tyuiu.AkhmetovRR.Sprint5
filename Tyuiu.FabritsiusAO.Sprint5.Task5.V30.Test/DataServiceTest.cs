using Tyuiu.FabritsiusAO.Sprint5.Task5.V30.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool FE = fileInfo.Exists;
            Assert.IsTrue(FE);
        }
    }
}