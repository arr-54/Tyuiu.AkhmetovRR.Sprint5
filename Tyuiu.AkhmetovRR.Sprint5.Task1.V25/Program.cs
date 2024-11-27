using Tyuiu.AkhmetovRR.Sprint5.Task1.V25.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #5 | Выполнил: Ахметов Р.Р. | ИБКСб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #5                                                            *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл              *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил Ахметов Роман Русланович | ИБКСб-24-1                       *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* На картинке                                                          *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Функция                                                              *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int startValue = -5;
int stopValue = 5;

string filePath = dataService.SaveToFileTextData(startValue, stopValue);

Console.WriteLine($"\nРезультаты сохранены в файл: {filePath}");
Console.WriteLine("************************************************************************");
Console.ReadLine();