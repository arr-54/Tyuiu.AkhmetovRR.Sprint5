using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhmetovRR.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double k = 0;
            if (File.Exists(path))
            {
                double res = 1;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Парсинг строки с учетом культуры
                        double x = double.Parse(line, CultureInfo.InvariantCulture);
                        if (x % 3 == 0 && x > k && (Convert.ToInt32(x) == Convert.ToDouble(x)))
                        {
                            k = x;
                        }
                    }
                }
                for (int i = 1; i <= k; i++)
                    res *= i;

                return Math.Round(res, 3);
            }
            else
            {
                Console.WriteLine("Ошибка");
                return 1;
            }
        }
    }
}
