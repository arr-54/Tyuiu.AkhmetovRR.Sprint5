using Tyuiu.AkhmetovRR.Sprint5.Task7.V18.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Ахметов Р.Р. | ИБКСб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                     *");
Console.WriteLine("* Задание #7                                                                  *");
Console.WriteLine("* Вариант #18                                                                 *");
Console.WriteLine("* Выполнила: Ахметов Роман Русланович | ИБКСб-24-1                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Заменить все буквы \"н\" на \"нн\".Полученный результат сохранить           *");
Console.WriteLine("* в файл OutPutDataFileTask7V18.txt.                                          *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
string res = ds.LoadDataAndSave(path);
Console.WriteLine("Результат находится в файле: " + res);



Console.ReadKey();