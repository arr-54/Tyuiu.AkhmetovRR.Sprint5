using Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        int x = 2;
        Console.Title = "Спринт #5 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 2, результат сохранить    *");
        Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.               *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение x: " + x);
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.ReadLine();
    }
}