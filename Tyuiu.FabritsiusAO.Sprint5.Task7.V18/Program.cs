using Tyuiu.FabritsiusAO.Sprint5.Task7.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #5 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V18.txt (файл взять из      *");
        Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\*");
        Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.       *");
        Console.WriteLine("* Заменить все буквы \"н\" на \"нн\".Полученный результат сохранить       *");
        Console.WriteLine("* в файл OutPutDataFileTask7V18.txt.                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
        string savefile = Path.GetTempFileName();
        Console.WriteLine("Файл вход: " + savefile);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine("Файл выход: " + res);
        Console.ReadLine();
    }
}