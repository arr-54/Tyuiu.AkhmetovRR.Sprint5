using Tyuiu.FabritsiusAO.Sprint5.Task0.V11.Lib;
using System.IO;
namespace Tyuiu.FabritsiusAO.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new();
            string path = @"C:\Various Programms\Visual studio repos\Tyuiu.FabritsiusAO.Sprint5\Tyuiu.FabritsiusAO.Sprint5.Task0.V11\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileinfo = new(path);
            bool FileExists = fileinfo.Exists;
            Assert.IsTrue(FileExists);
        }
    }
}