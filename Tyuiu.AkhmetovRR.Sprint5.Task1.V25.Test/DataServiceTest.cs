using Tyuiu.AkhmetovRR.Sprint5.Task1.V25.Lib;

namespace Tyuiu.AkhmetovRR.Sprint5.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_Test()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string filePath = dataService.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(filePath)); 
            string[] lines = File.ReadAllLines(filePath);
            Assert.AreEqual(12, lines.Length);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
