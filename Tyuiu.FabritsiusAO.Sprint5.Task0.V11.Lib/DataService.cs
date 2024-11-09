using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.FabritsiusAO.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Round((4 - Math.Pow(x, 3)) / Math.Pow(x, 2), 3);
            File.WriteAllText(path,Convert.ToString(y));
            return path;
        }
    }
}
