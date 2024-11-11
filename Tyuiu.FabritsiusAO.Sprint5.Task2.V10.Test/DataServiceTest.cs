using System.IO;
using Tyuiu.FabritsiusAO.Sprint5.Task2.V10.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedArrayValid()
        {
            DataService ds = new();
            int[,] Array = { { 1, 1, 1, }, { -1, -1, -1 }, { 0, 0, 0 } };
            int[,] ArrayWait = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            int[,] ArrayRes = ds.CalculateArray(Array);
            CollectionAssert.AreEqual(ArrayWait, ArrayRes);
        }
    }
}