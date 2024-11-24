using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.AkhmetovRR.Sprint5.Task5.V14.Lib;
using System.Numerics;
namespace Tyuiu.AkhmetovRR.Sprint5.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Ахметов Р.Р. | ИБКСб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                     *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнил:  Ахметов Роман Русланович | ИБКСб-24-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая находит факториал наибольшего числа в файле,     *");
            Console.WriteLine("* кратного 3.                                                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string path = @"C:\Users\COMP GOD\Desktop\DataSprint5\InPutDataFileTask5V14.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double LoadNumber = ds.LoadFromDataFile(path);
            int number = (int)LoadNumber;
            BigInteger factorial = ds.CalculateFactorial(number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}