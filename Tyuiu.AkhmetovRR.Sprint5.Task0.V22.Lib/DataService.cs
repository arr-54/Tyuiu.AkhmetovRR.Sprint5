﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhmetovRR.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double y = Math.Round((Math.Pow(1 - x, 2)) / (-3 * x), 3);
            File.WriteAllText(path, Convert.ToString(y));
            Console.WriteLine(y);
            return path;
        }
    }
}
