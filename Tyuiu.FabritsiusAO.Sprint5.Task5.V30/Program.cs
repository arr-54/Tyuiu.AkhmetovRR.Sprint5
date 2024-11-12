using Tyuiu.FabritsiusAO.Sprint5.Task5.V30.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V30.txt (файл взять         *");
        Console.WriteLine("* из архива согласно вашему варианту. \r\n\r\nСоздать папку в ручную      *");
        Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть              *");
        Console.WriteLine("* набор значений. Найти максимальное целое число в файле,                 *");
        Console.WriteLine("* которое является простым числом.Полученный результат вывести на консоль.*");
        Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.\r\n\r\n *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
        Console.WriteLine("Файл: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadLine();
    }
}