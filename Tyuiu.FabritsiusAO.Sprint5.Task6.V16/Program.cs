using Tyuiu.FabritsiusAO.Sprint5.Task6.V16.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V16.txt (файл взять из      *");
        Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную                 *");
        Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
        Console.WriteLine("* символьных данных.Найти количество английских слов в заданной строке.   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask6V16.txt";
        Console.WriteLine("Файл: "+path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}