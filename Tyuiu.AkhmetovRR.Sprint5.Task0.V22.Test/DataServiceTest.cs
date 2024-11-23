using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AkhmetovRR.Sprint5.Task0.V22.Lib;

namespace Tyuiu.AkhmetovRR.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            string wait = File.ReadAllText(path);
            string result = (Math.Round((Math.Pow(1 - 3, 2)) / (-3 * 3), 3)).ToString();
            Assert.AreEqual(result, wait);
        }
    }
}