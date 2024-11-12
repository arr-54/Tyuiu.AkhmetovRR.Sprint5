using Tyuiu.FabritsiusAO.Sprint5.Task7.V18.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            FileInfo FI = new(path);
            bool FE = FI.Exists;
            Assert.IsTrue(FE);
        }
    }
}