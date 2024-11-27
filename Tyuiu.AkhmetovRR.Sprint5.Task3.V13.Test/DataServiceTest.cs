namespace Tyuiu.AkhmetovRR.Sprint5.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void testics()
        {
            string path = Path.Combine("C:", "Users", "user", "Appdata", "Local", "Temp", "OutPutFileTask3.bin");

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}