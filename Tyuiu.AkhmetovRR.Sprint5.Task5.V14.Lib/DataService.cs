using System.Globalization;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhmetovRR.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            List<double> data = ReadFile(path);
            int? max3 = FindLoad(data);
            if (max3 != null)
            {
                return max3.Value;
            }
            else
            {
                throw new Exception("в файле не найдено целых чисел");
            }
        }
        public List<double> ReadFile(string path)
        {
            var numbers = new List<double>();
            try
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    string tline = line.Trim();
                    if (!string.IsNullOrEmpty(tline))
                    {
                        if (double.TryParse(tline, out double number))
                        {
                            number = Math.Round(number, 3);
                            numbers.Add(number);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return numbers;
        }
        public int? FindLoad(List<double> numbers)
        {
            int? num = null;
            foreach (var number in numbers)
            {
                if (number % 1 == 0)
                {
                    int intnum = (int)number;
                    if (number % 3 == 0)
                    {
                        if (num == null || intnum > num)
                        {
                            num = intnum;
                        }
                    }
                }

            }
            return num;
        }
        public BigInteger CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Ошибка");
            }
            BigInteger result = 1;
            for (int i = 2; i <= number; i++) 
            {
                result *= i;
            }
            return result;
        }
    }
}
