using Tyuiu.AkhmetovRR.Sprint5.Task6.V22.Lib;
namespace Tyuiu.AkhmetovRR.Sprint5.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ахметов Роман Русланович | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Ахметов Роман Русланович | ИБКСб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask6V22.txt (файл взять из архива с*");
            Console.WriteLine(@"*согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор символьных данных. Найти количест*");
            Console.WriteLine("*тво удвоенных букв мм в заданной строке.                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}