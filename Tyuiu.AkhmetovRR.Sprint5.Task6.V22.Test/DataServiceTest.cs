namespace Tyuiu.AkhmetovRR.Sprint5.Task6.V22.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            int x = 5;
            double result = Math.Round(Math.Sin(2 / (3 * x)) + Math.Pow(x, 2), 3);
            double wait = 25;
            Assert.AreEqual(wait, result);
        }
    }
}