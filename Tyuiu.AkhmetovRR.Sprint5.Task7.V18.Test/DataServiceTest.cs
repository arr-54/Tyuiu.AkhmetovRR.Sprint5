using Tyuiu.AkhmetovRR.Sprint5.Task7.V18.Lib;
namespace Tyuiu.AkhmetovRR.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\?????\AppData\Local\Temp\OutPutDataFileTask7V18.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}