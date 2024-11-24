using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AkhmetovRR.Sprint5.Task5.V14.Lib;

namespace Tyuiu.AkhmetovRR.Sprint5.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V14.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}