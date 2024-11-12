using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FabritsiusAO.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            DataService ds = new();
            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');
            double x = Convert.ToDouble(str);
            double F = ds.Calculate(x);
            return F;
        }
        public double Calculate(double x)
        {
            double F = Math.Round(Math.Sin(x) + (Math.Pow(x, 2) / 2), 3);
            return F;
        }
    }
}
