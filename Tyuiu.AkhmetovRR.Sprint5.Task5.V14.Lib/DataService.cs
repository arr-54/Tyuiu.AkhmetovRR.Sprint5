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
                string fileContent = File.ReadAllText(path);
                var elements = fileContent.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    string trimmedElement = element.Trim();

                    if (!string.IsNullOrEmpty(trimmedElement) && double.TryParse(trimmedElement, out double number))
                    {
                        number = Math.Round(number, 3); // Округляем до 3 знаков
                        numbers.Add(number);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
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
            return number;
        }
    }
}
